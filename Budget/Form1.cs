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

            solde = 0;

            dateInput.Enabled = false;
            raisonInput.Enabled = false;
            montantInput.Enabled = false;
            envoyerButton.Enabled = false;
            // set base path;
        }

        private void raisonInput_MouseDoubleClick(object sender, EventArgs e) {
            raisonInput.Text = "";
            raisonInput.ForeColor = Color.Black;
        }

        private void montantInput_MouseDoubleClick(object sender, EventArgs e) {
            montantInput.Text = "";
            montantInput.ForeColor = Color.Black;
        }

        private void envoyerButton_Click(object sender, EventArgs e) {
            decimal montantValue;
            if (!raisonInput.Text.Equals("") && decimal.TryParse(montantInput.Text.Replace('.', ','), out montantValue) && dateInput.Value != null) {
                errorLabel.Text = "";

            } else {
                errorLabel.Text = "Veuillez entrer des informations valides.";
            }
        }

        private void searchInput_Click(object sender, EventArgs e) {
            if (openFile.ShowDialog() == DialogResult.OK) {
                errorLoadingLabel.Text = "";
                path = openFile.FileName;
                fileInput.Text = path;

                searchInput.Enabled = false;

                dateInput.Enabled = true;
                raisonInput.Enabled = true;
                montantInput.Enabled = true;
                envoyerButton.Enabled = true;

                loadData();
            } else {
                errorLoadingLabel.Text = "Veuillez entrer un fichier valide.";

                dateInput.Enabled = false;
                raisonInput.Enabled = false;
                montantInput.Enabled = false;
                envoyerButton.Enabled = false;
            }
        }

        private void loadData() {
            if (File.Exists(path)) {
                String[] lines = File.ReadAllLines(path);

                foreach (string line in File.ReadAllLines(path)) {
                    String[] splitLine = line.Split(SEPARATOR);
                    Entree tempEntree = new Entree(DateTime.Parse(splitLine[1]), splitLine[2], decimal.Parse(splitLine[3]));

                    entryList.Add(tempEntree);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            if (path != null) {
                List<string> contenu = new List<string>();

                for (int i = 0; i < entryList.Count; i++) {
                    Entree entreeTemp = entryList[i];

                    contenu.Add(i.ToString() + ";" +
                        entreeTemp.Date.ToString("yyyy-MM-dd") + ";" +
                        entreeTemp.Raison + ";" +
                        entreeTemp.Montant.ToString("0.00"));
                }

                File.WriteAllLines(path, contenu.ToArray());
            }
        }
    }

    public class Entree {
        public DateTime Date { get; set; }
        public String Raison { get; set; }
        public decimal Montant { get; set; }

        public Entree(DateTime _date, String _raison, decimal _montant) {
            this.Date = _date;
            this.Raison = _raison;
            this.Montant = _montant;
        }

        public string[] EntreeToString() {
            string[] row = {
                Date.ToString("yyyy-MM-dd"),
                Raison,
                Montant.ToString()
            };

            return row;
        }
    }
}
