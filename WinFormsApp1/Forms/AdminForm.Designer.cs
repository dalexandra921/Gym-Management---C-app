namespace WinFormsApp1
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControl tabControl1;
            tabPage1 = new TabPage();
            btnModificaSala = new Button();
            btnStergeZona = new Button();
            dgvZone = new DataGridView();
            btnModificaZona = new Button();
            btnStergeSala = new Button();
            btnAdaugaZona = new Button();
            btnAdaugaSala = new Button();
            dgvSali = new DataGridView();
            tabPage2 = new TabPage();
            btnStergeAbonament = new Button();
            btnModificaAbonament = new Button();
            btnAdaugaAbonament = new Button();
            dgvAbonamente = new DataGridView();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            dgvClase = new DataGridView();
            cmbAntrenori = new ComboBox();
            btnAdaugaClasa = new Button();
            btnModificaClasa = new Button();
            btnStergeClasa = new Button();
            tabControl1 = new TabControl();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvZone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSali).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAbonamente).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClase).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(699, 583);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "Săli și Zone";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnModificaSala);
            tabPage1.Controls.Add(btnStergeZona);
            tabPage1.Controls.Add(dgvZone);
            tabPage1.Controls.Add(btnModificaZona);
            tabPage1.Controls.Add(btnStergeSala);
            tabPage1.Controls.Add(btnAdaugaZona);
            tabPage1.Controls.Add(btnAdaugaSala);
            tabPage1.Controls.Add(dgvSali);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(691, 550);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Săli și Zone";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnModificaSala
            // 
            btnModificaSala.Location = new Point(519, 95);
            btnModificaSala.Name = "btnModificaSala";
            btnModificaSala.Size = new Size(120, 49);
            btnModificaSala.TabIndex = 2;
            btnModificaSala.Text = "Modifică sală";
            btnModificaSala.UseVisualStyleBackColor = true;
            btnModificaSala.Click += btnModificaSala_Click;
            // 
            // btnStergeZona
            // 
            btnStergeZona.Location = new Point(458, 449);
            btnStergeZona.Name = "btnStergeZona";
            btnStergeZona.Size = new Size(103, 49);
            btnStergeZona.TabIndex = 6;
            btnStergeZona.Text = "Șterge zonă";
            btnStergeZona.UseVisualStyleBackColor = true;
            btnStergeZona.Click += btnStergeZona_Click;
            // 
            // dgvZone
            // 
            dgvZone.AllowUserToAddRows = false;
            dgvZone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZone.Location = new Point(15, 285);
            dgvZone.Name = "dgvZone";
            dgvZone.RowHeadersWidth = 51;
            dgvZone.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZone.Size = new Size(320, 246);
            dgvZone.TabIndex = 4;
            // 
            // btnModificaZona
            // 
            btnModificaZona.Location = new Point(519, 361);
            btnModificaZona.Name = "btnModificaZona";
            btnModificaZona.Size = new Size(120, 49);
            btnModificaZona.TabIndex = 5;
            btnModificaZona.Text = "Modifică zonă";
            btnModificaZona.UseVisualStyleBackColor = true;
            btnModificaZona.Click += btnModificaSala_Click;
            // 
            // btnStergeSala
            // 
            btnStergeSala.Location = new Point(458, 168);
            btnStergeSala.Name = "btnStergeSala";
            btnStergeSala.Size = new Size(103, 49);
            btnStergeSala.TabIndex = 3;
            btnStergeSala.Text = "Șterge sală";
            btnStergeSala.UseVisualStyleBackColor = true;
            btnStergeSala.Click += btnStergeSala_Click;
            // 
            // btnAdaugaZona
            // 
            btnAdaugaZona.Location = new Point(381, 361);
            btnAdaugaZona.Name = "btnAdaugaZona";
            btnAdaugaZona.Size = new Size(110, 49);
            btnAdaugaZona.TabIndex = 4;
            btnAdaugaZona.Text = "Adaugă zonă";
            btnAdaugaZona.UseVisualStyleBackColor = true;
            btnAdaugaZona.Click += btnAdaugaZona_Click;
            // 
            // btnAdaugaSala
            // 
            btnAdaugaSala.Location = new Point(381, 95);
            btnAdaugaSala.Name = "btnAdaugaSala";
            btnAdaugaSala.Size = new Size(110, 49);
            btnAdaugaSala.TabIndex = 1;
            btnAdaugaSala.Text = "Adaugă sală";
            btnAdaugaSala.UseVisualStyleBackColor = true;
            btnAdaugaSala.Click += btnAdaugaSala_Click;
            // 
            // dgvSali
            // 
            dgvSali.AllowUserToAddRows = false;
            dgvSali.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSali.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSali.Location = new Point(15, 18);
            dgvSali.Name = "dgvSali";
            dgvSali.ReadOnly = true;
            dgvSali.RowHeadersWidth = 51;
            dgvSali.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSali.Size = new Size(320, 246);
            dgvSali.TabIndex = 0;
            dgvSali.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnStergeAbonament);
            tabPage2.Controls.Add(btnModificaAbonament);
            tabPage2.Controls.Add(btnAdaugaAbonament);
            tabPage2.Controls.Add(dgvAbonamente);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(691, 550);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Abonamente";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStergeAbonament
            // 
            btnStergeAbonament.Location = new Point(544, 421);
            btnStergeAbonament.Name = "btnStergeAbonament";
            btnStergeAbonament.Size = new Size(105, 53);
            btnStergeAbonament.TabIndex = 3;
            btnStergeAbonament.Text = "Șterge abonament";
            btnStergeAbonament.UseVisualStyleBackColor = true;
            // 
            // btnModificaAbonament
            // 
            btnModificaAbonament.Location = new Point(544, 256);
            btnModificaAbonament.Name = "btnModificaAbonament";
            btnModificaAbonament.Size = new Size(105, 51);
            btnModificaAbonament.TabIndex = 2;
            btnModificaAbonament.Text = "Modifică abonament";
            btnModificaAbonament.UseVisualStyleBackColor = true;
            // 
            // btnAdaugaAbonament
            // 
            btnAdaugaAbonament.Location = new Point(544, 117);
            btnAdaugaAbonament.Name = "btnAdaugaAbonament";
            btnAdaugaAbonament.Size = new Size(105, 51);
            btnAdaugaAbonament.TabIndex = 1;
            btnAdaugaAbonament.Text = "Adaugă abonament";
            btnAdaugaAbonament.UseVisualStyleBackColor = true;
            // 
            // dgvAbonamente
            // 
            dgvAbonamente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAbonamente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAbonamente.Location = new Point(17, 19);
            dgvAbonamente.MultiSelect = false;
            dgvAbonamente.Name = "dgvAbonamente";
            dgvAbonamente.ReadOnly = true;
            dgvAbonamente.RowHeadersWidth = 51;
            dgvAbonamente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAbonamente.Size = new Size(494, 510);
            dgvAbonamente.TabIndex = 0;
            dgvAbonamente.CellContentClick += dgvAbonamente_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnStergeClasa);
            tabPage3.Controls.Add(btnModificaClasa);
            tabPage3.Controls.Add(btnAdaugaClasa);
            tabPage3.Controls.Add(cmbAntrenori);
            tabPage3.Controls.Add(dgvClase);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(691, 550);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Clase și Antrenori";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(691, 550);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Monitorizare activitate";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvClase
            // 
            dgvClase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClase.Location = new Point(19, 21);
            dgvClase.Name = "dgvClase";
            dgvClase.ReadOnly = true;
            dgvClase.RowHeadersWidth = 51;
            dgvClase.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClase.Size = new Size(321, 247);
            dgvClase.TabIndex = 0;
            dgvClase.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // cmbAntrenori
            // 
            cmbAntrenori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAntrenori.FormattingEnabled = true;
            cmbAntrenori.Location = new Point(19, 301);
            cmbAntrenori.Name = "cmbAntrenori";
            cmbAntrenori.Size = new Size(321, 28);
            cmbAntrenori.TabIndex = 1;
            // 
            // btnAdaugaClasa
            // 
            btnAdaugaClasa.Location = new Point(474, 21);
            btnAdaugaClasa.Name = "btnAdaugaClasa";
            btnAdaugaClasa.Size = new Size(94, 48);
            btnAdaugaClasa.TabIndex = 2;
            btnAdaugaClasa.Text = "Adaugă clasă";
            btnAdaugaClasa.UseVisualStyleBackColor = true;
            // 
            // btnModificaClasa
            // 
            btnModificaClasa.Location = new Point(474, 116);
            btnModificaClasa.Name = "btnModificaClasa";
            btnModificaClasa.Size = new Size(94, 55);
            btnModificaClasa.TabIndex = 3;
            btnModificaClasa.Text = "Modifică clasă";
            btnModificaClasa.UseVisualStyleBackColor = true;
            // 
            // btnStergeClasa
            // 
            btnStergeClasa.Location = new Point(474, 218);
            btnStergeClasa.Name = "btnStergeClasa";
            btnStergeClasa.Size = new Size(94, 50);
            btnStergeClasa.TabIndex = 4;
            btnStergeClasa.Text = "Șterge clasă";
            btnStergeClasa.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 622);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvZone).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSali).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAbonamente).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClase).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dgvSali;
        private Button btnAdaugaSala;
        private Button btnStergeSala;
        private Button btnModificaSala;
        private DataGridView dgvZone;
        private Button btnStergeZona;
        private Button btnModificaZona;
        private Button btnAdaugaZona;
        private Button btnStergeAbonament;
        private Button btnModificaAbonament;
        private Button btnAdaugaAbonament;
        private DataGridView dgvAbonamente;
        private DataGridView dgvClase;
        private Button btnStergeClasa;
        private Button btnModificaClasa;
        private Button btnAdaugaClasa;
        private ComboBox cmbAntrenori;
    }
}