using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Budget {
    public partial class Form1 : Form {
        const char SEPARATOR = ';';
        protected String path;
        protected BindingList<Entree> entryList;
        protected decimal solde;

        public Form1() {
            InitializeComponent();
            entryList = new BindingList<Entree>();
            entreeBindingSource = new BindingSource(entryList, null);
            entreeGridView.DataSource = entreeBindingSource;
            entreeGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            entreeGridView.EnableHeadersVisualStyles = false;

            solde = 0;

            monthPicker.DataSource = new BindingSource(
                System.Globalization.DateTimeFormatInfo.CurrentInfo.MonthNames
                .Where(m => m != String.Empty)
                .Select((m, i) => new { Name = m, Index = i })
                .ToDictionary(x => x.Index, x => x.Name), null);
            monthPicker.DisplayMember = "Value";
            monthPicker.ValueMember = "Key";

            changeStateOfAll(false);
        }

        private void raisonInput_MouseDoubleClick(object sender, EventArgs e) {
            raisonInput.Text = "";
            raisonInput.ForeColor = Color.Black;
        }

        private void raisonInput_Enter(object sender, EventArgs e) {
            raisonInput_MouseDoubleClick(sender, e);
        }

        private void montantInput_MouseDoubleClick(object sender, EventArgs e) {
            montantInput.Text = "";
            montantInput.ForeColor = Color.Black;
        }

        private void montantInput_Enter(object sender, EventArgs e) {
            montantInput_MouseDoubleClick(sender, e);
        }

        private void envoyerButton_Click(object sender, EventArgs e) {
            decimal montantValue;
            if (!raisonInput.Text.Equals("") && decimal.TryParse(montantInput.Text.Replace('.', ','), out montantValue) && dateInput.Value != null) {
                errorLabel.Text = "";
                
                Entree tempEntree = new Entree(DateTime.Parse(dateInput.Value.ToString("yyyy-MM-dd")), 
                    raisonInput.Text, decimal.Parse(montantInput.Text.Replace('.', ',')));
                entryList.Add(tempEntree);

                raisonInput.Text = "";
                montantInput.Text = "";

                if (tempEntree.Montant < 0)
                    entreeGridView[2, entreeGridView.Rows.GetLastRow(DataGridViewElementStates.None)].Style.BackColor = Color.PaleVioletRed;
                else
                    entreeGridView[2, entreeGridView.Rows.GetLastRow(DataGridViewElementStates.None)].Style.BackColor = Color.DarkSeaGreen;

                dateInput.Focus();
                calculateStats();
            } else {
                errorLabel.Text = "Veuillez entrer des informations valides.";
            }
        }

        private void searchInput_Click(object sender, EventArgs e) {
            if (openFile.ShowDialog() == DialogResult.OK) {
                errorLoadingLabel.Text = "";
                path = openFile.FileName;

                loadData();
            } else {
                errorLoadingLabel.Text = "Veuillez entrer un fichier valide.";

                changeStateOfAll(false);
            }
        }

        private void loadData() {
            if (File.Exists(path)) {
                fileInput.Text = path;

                String[] lines = File.ReadAllLines(path);
                int i = 0;

                foreach (string line in File.ReadAllLines(path)) {
                    String[] splitLine = line.Split(SEPARATOR);
                    Entree tempEntree = new Entree(DateTime.Parse(splitLine[0]), splitLine[1], decimal.Parse(splitLine[2]));

                    entryList.Add(tempEntree);
                    if ((decimal) entreeGridView[2, i].Value < 0)
                        entreeGridView[2, i].Style.BackColor = Color.PaleVioletRed;
                    else
                        entreeGridView[2, i].Style.BackColor = Color.DarkSeaGreen;
                    i++;
                }

                searchInput.Enabled = false;
                changeStateOfAll(true);
                calculateStats();
            }
        }

        private void monthPicker_SelectedIndexChanged(object sender, EventArgs e) {
            calculateStats();
        }

        // Doublon
        private void anneePicker_SelectedIndexChanged(object sender, EventArgs e) {
            calculateStats();
        }

        private void calculateStats() {
            if (entryList.Count > 0) {
                //entryList = new BindingList<Entree>(entryList.OrderBy(x => x.Date).ToList());
                //entryList.ResetBindings(); // Ne fonctionne pas
                // Soit trouver un moyen de sort et d'afficher, soit insérer au bon endroit sur le coup

                solde = 0;
                
                List<decimal> depenses = new List<decimal>();

                entreeGridView.FirstDisplayedScrollingRowIndex = entreeGridView.Rows.GetLastRow(DataGridViewElementStates.None);

                foreach (Entree entry in entryList) {
                    solde += entry.Montant;

                    if (entry.Montant < 0)
                        depenses.Add(entry.Montant);
                }

                //variationMensuelleShow;
                //variationAnnuelleShow;
                //depenseMoyenneMensuelleShow;
                depenseMoyenneShow.Text = (depenses.Sum() / depenses.Count).ToString("C2").Replace("(", "").Replace(")", ""); // Je ne sais pas pourquoi ça ajoute des parenthèses
                sommeActuelleShow.Text = solde.ToString("C2");
            }
        }

        private void changeStateOfAll(bool state) {
            dateInput.Enabled = state;
            raisonInput.Enabled = state;
            montantInput.Enabled = state;
            envoyerButton.Enabled = state;
            monthPicker.Enabled = state;
            anneePicker.Enabled = state;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            if (path != "") {
                List<string> contenu = new List<string>();

                foreach (Entree entry in entryList)
                    contenu.Add(entry.EntreeToStringOutput());

                File.WriteAllLines(path, contenu.ToArray());
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            PCFGHelper pcfgHelper = new PCFGHelper();
            if ((path = pcfgHelper.AppPath) != null)
                loadData();
        }

        private void montantInput_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == ((char)Keys.Enter)) {
                envoyerButton_Click(sender, e);
                
                e.Handled = true;
            }
        }
    }
}
