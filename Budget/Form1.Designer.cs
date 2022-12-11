namespace Budget {
    partial class Form1 {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.anneePicker = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monthPicker = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.sommeActuelleShow = new System.Windows.Forms.TextBox();
            this.depenseMoyenneShow = new System.Windows.Forms.TextBox();
            this.depenseMoyenneMensuelleShow = new System.Windows.Forms.TextBox();
            this.variationAnnuelleShow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.variationMensuelleShow = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.raisonInput = new System.Windows.Forms.TextBox();
            this.montantInput = new System.Windows.Forms.TextBox();
            this.envoyerButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.fileInput = new System.Windows.Forms.TextBox();
            this.searchInput = new System.Windows.Forms.Button();
            this.errorLoadingLabel = new System.Windows.Forms.Label();
            this.entreeGridView = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raisonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entreeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entreeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.entreeGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.19608F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1034, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(520, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(511, 680);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 220);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Variation mensuelle";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 16);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(499, 201);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chart2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 220);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Variation annuelle";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 16);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(499, 201);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 455);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(505, 222);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Statistiques";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.anneePicker);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.monthPicker);
            this.groupBox6.Location = new System.Drawing.Point(6, 160);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(491, 56);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Paramètres";
            // 
            // anneePicker
            // 
            this.anneePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.anneePicker.Enabled = false;
            this.anneePicker.FormattingEnabled = true;
            this.anneePicker.Location = new System.Drawing.Point(267, 29);
            this.anneePicker.Name = "anneePicker";
            this.anneePicker.Size = new System.Drawing.Size(106, 21);
            this.anneePicker.TabIndex = 14;
            this.anneePicker.SelectedIndexChanged += new System.EventHandler(this.anneePicker_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Année";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mois";
            // 
            // monthPicker
            // 
            this.monthPicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.monthPicker.FormattingEnabled = true;
            this.monthPicker.Location = new System.Drawing.Point(379, 29);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.Size = new System.Drawing.Size(106, 21);
            this.monthPicker.TabIndex = 11;
            this.monthPicker.SelectedIndexChanged += new System.EventHandler(this.monthPicker_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.sommeActuelleShow, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.depenseMoyenneShow, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.depenseMoyenneMensuelleShow, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.variationAnnuelleShow, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.variationMensuelleShow, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(499, 138);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // sommeActuelleShow
            // 
            this.sommeActuelleShow.Enabled = false;
            this.sommeActuelleShow.HideSelection = false;
            this.sommeActuelleShow.Location = new System.Drawing.Point(253, 113);
            this.sommeActuelleShow.Name = "sommeActuelleShow";
            this.sommeActuelleShow.ReadOnly = true;
            this.sommeActuelleShow.Size = new System.Drawing.Size(241, 20);
            this.sommeActuelleShow.TabIndex = 10;
            // 
            // depenseMoyenneShow
            // 
            this.depenseMoyenneShow.Enabled = false;
            this.depenseMoyenneShow.HideSelection = false;
            this.depenseMoyenneShow.Location = new System.Drawing.Point(253, 86);
            this.depenseMoyenneShow.Name = "depenseMoyenneShow";
            this.depenseMoyenneShow.ReadOnly = true;
            this.depenseMoyenneShow.Size = new System.Drawing.Size(241, 20);
            this.depenseMoyenneShow.TabIndex = 9;
            // 
            // depenseMoyenneMensuelleShow
            // 
            this.depenseMoyenneMensuelleShow.Enabled = false;
            this.depenseMoyenneMensuelleShow.HideSelection = false;
            this.depenseMoyenneMensuelleShow.Location = new System.Drawing.Point(253, 59);
            this.depenseMoyenneMensuelleShow.Name = "depenseMoyenneMensuelleShow";
            this.depenseMoyenneMensuelleShow.ReadOnly = true;
            this.depenseMoyenneMensuelleShow.Size = new System.Drawing.Size(241, 20);
            this.depenseMoyenneMensuelleShow.TabIndex = 8;
            // 
            // variationAnnuelleShow
            // 
            this.variationAnnuelleShow.Enabled = false;
            this.variationAnnuelleShow.HideSelection = false;
            this.variationAnnuelleShow.Location = new System.Drawing.Point(253, 32);
            this.variationAnnuelleShow.Name = "variationAnnuelleShow";
            this.variationAnnuelleShow.ReadOnly = true;
            this.variationAnnuelleShow.Size = new System.Drawing.Size(241, 20);
            this.variationAnnuelleShow.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Variation mensuelle :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Variation annuelle :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dépense moyenne mensuelle :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dépense moyenne :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Somme actuelle :";
            // 
            // variationMensuelleShow
            // 
            this.variationMensuelleShow.Enabled = false;
            this.variationMensuelleShow.HideSelection = false;
            this.variationMensuelleShow.Location = new System.Drawing.Point(253, 5);
            this.variationMensuelleShow.Name = "variationMensuelleShow";
            this.variationMensuelleShow.ReadOnly = true;
            this.variationMensuelleShow.Size = new System.Drawing.Size(241, 20);
            this.variationMensuelleShow.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 689);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout de données";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dateInput);
            this.flowLayoutPanel2.Controls.Add(this.raisonInput);
            this.flowLayoutPanel2.Controls.Add(this.montantInput);
            this.flowLayoutPanel2.Controls.Add(this.envoyerButton);
            this.flowLayoutPanel2.Controls.Add(this.errorLabel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(505, 50);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(3, 3);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(117, 20);
            this.dateInput.TabIndex = 0;
            // 
            // raisonInput
            // 
            this.raisonInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.raisonInput.Location = new System.Drawing.Point(126, 3);
            this.raisonInput.Name = "raisonInput";
            this.raisonInput.Size = new System.Drawing.Size(179, 20);
            this.raisonInput.TabIndex = 1;
            this.raisonInput.Text = "Raison";
            this.raisonInput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.raisonInput_MouseDoubleClick);
            // 
            // montantInput
            // 
            this.montantInput.AcceptsReturn = true;
            this.montantInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.montantInput.Location = new System.Drawing.Point(311, 3);
            this.montantInput.Name = "montantInput";
            this.montantInput.Size = new System.Drawing.Size(104, 20);
            this.montantInput.TabIndex = 2;
            this.montantInput.Text = "Montant";
            this.montantInput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.montantInput_MouseDoubleClick);
            // 
            // envoyerButton
            // 
            this.envoyerButton.Location = new System.Drawing.Point(421, 3);
            this.envoyerButton.Name = "envoyerButton";
            this.envoyerButton.Size = new System.Drawing.Size(78, 23);
            this.envoyerButton.TabIndex = 3;
            this.envoyerButton.Text = "Envoyer";
            this.envoyerButton.UseVisualStyleBackColor = true;
            this.envoyerButton.Click += new System.EventHandler(this.envoyerButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(3, 29);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel3);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(520, 689);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(511, 69);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fichier";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.fileInput);
            this.flowLayoutPanel3.Controls.Add(this.searchInput);
            this.flowLayoutPanel3.Controls.Add(this.errorLoadingLabel);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(505, 50);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // fileInput
            // 
            this.fileInput.Enabled = false;
            this.fileInput.Location = new System.Drawing.Point(3, 3);
            this.fileInput.Name = "fileInput";
            this.fileInput.ReadOnly = true;
            this.fileInput.Size = new System.Drawing.Size(415, 20);
            this.fileInput.TabIndex = 0;
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(424, 3);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(75, 23);
            this.searchInput.TabIndex = 1;
            this.searchInput.Text = "Ouvrir";
            this.searchInput.UseVisualStyleBackColor = true;
            this.searchInput.Click += new System.EventHandler(this.searchInput_Click);
            // 
            // errorLoadingLabel
            // 
            this.errorLoadingLabel.AutoSize = true;
            this.errorLoadingLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLoadingLabel.Location = new System.Drawing.Point(3, 29);
            this.errorLoadingLabel.Name = "errorLoadingLabel";
            this.errorLoadingLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLoadingLabel.TabIndex = 2;
            // 
            // entreeGridView
            // 
            this.entreeGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.entreeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.entreeGridView.AutoGenerateColumns = false;
            this.entreeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.entreeGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.entreeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entreeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.raisonDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn});
            this.entreeGridView.DataSource = this.entreeBindingSource;
            this.entreeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entreeGridView.Location = new System.Drawing.Point(3, 3);
            this.entreeGridView.Name = "entreeGridView";
            this.entreeGridView.Size = new System.Drawing.Size(511, 680);
            this.entreeGridView.TabIndex = 6;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // raisonDataGridViewTextBoxColumn
            // 
            this.raisonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.raisonDataGridViewTextBoxColumn.DataPropertyName = "Raison";
            this.raisonDataGridViewTextBoxColumn.HeaderText = "Raison";
            this.raisonDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.raisonDataGridViewTextBoxColumn.Name = "raisonDataGridViewTextBoxColumn";
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "Montant";
            this.montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            // 
            // entreeBindingSource
            // 
            this.entreeBindingSource.DataSource = typeof(Budget.Entree);
            // 
            // openFile
            // 
            this.openFile.Filter = "CSV Files (*.csv)|*.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1050, 800);
            this.MinimumSize = new System.Drawing.Size(1050, 800);
            this.Name = "Form1";
            this.Text = "Budget v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entreeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entreeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.TextBox raisonInput;
        private System.Windows.Forms.TextBox montantInput;
        private System.Windows.Forms.Button envoyerButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox fileInput;
        private System.Windows.Forms.Button searchInput;
        private System.Windows.Forms.Label errorLoadingLabel;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView entreeGridView;
        private System.Windows.Forms.BindingSource entreeBindingSource;
        private System.Windows.Forms.TextBox sommeActuelleShow;
        private System.Windows.Forms.TextBox depenseMoyenneShow;
        private System.Windows.Forms.TextBox depenseMoyenneMensuelleShow;
        private System.Windows.Forms.TextBox variationAnnuelleShow;
        private System.Windows.Forms.TextBox variationMensuelleShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raisonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox monthPicker;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox anneePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

