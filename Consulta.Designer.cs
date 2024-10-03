namespace WinFormsApp1
{
    partial class Consulta
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
            components = new System.ComponentModel.Container();
            txtSintomas = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripComboBox1 = new ToolStripComboBox();
            lblId = new Label();
            lblNome = new Label();
            lblanimal = new Label();
            lblRaca = new Label();
            lblDataNascimento = new Label();
            lblPeso = new Label();
            lblTelefone = new Label();
            label1 = new Label();
            dataconsulta = new DateTimePicker();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            data = new ColumnHeader();
            sintomas = new ColumnHeader();
            lstHistorico = new ListView();
            btnCancelarConsulta = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(9, 109);
            txtSintomas.Multiline = true;
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(349, 153);
            txtSintomas.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(182, 31);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11F);
            lblId.ForeColor = Color.Cornsilk;
            lblId.Location = new Point(3, 21);
            lblId.Name = "lblId";
            lblId.Size = new Size(50, 20);
            lblId.TabIndex = 1;
            lblId.Text = "label1";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11F);
            lblNome.ForeColor = Color.Cornsilk;
            lblNome.Location = new Point(74, 21);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 2;
            lblNome.Text = "label1";
            // 
            // lblanimal
            // 
            lblanimal.AutoSize = true;
            lblanimal.Font = new Font("Segoe UI", 11F);
            lblanimal.ForeColor = Color.Cornsilk;
            lblanimal.Location = new Point(209, 22);
            lblanimal.Name = "lblanimal";
            lblanimal.Size = new Size(50, 20);
            lblanimal.TabIndex = 3;
            lblanimal.Text = "label1";
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.Font = new Font("Segoe UI", 11F);
            lblRaca.ForeColor = Color.Cornsilk;
            lblRaca.Location = new Point(308, 22);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(50, 20);
            lblRaca.TabIndex = 4;
            lblRaca.Text = "label1";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI", 11F);
            lblDataNascimento.Location = new Point(417, 21);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(50, 20);
            lblDataNascimento.TabIndex = 5;
            lblDataNascimento.Text = "label1";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 11F);
            lblPeso.Location = new Point(544, 21);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(50, 20);
            lblPeso.TabIndex = 6;
            lblPeso.Text = "label2";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 11F);
            lblTelefone.Location = new Point(696, 21);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(50, 20);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(7, 29);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 8;
            label1.Text = "Descreva os sintomas";
            // 
            // dataconsulta
            // 
            dataconsulta.Location = new Point(434, 109);
            dataconsulta.Name = "dataconsulta";
            dataconsulta.Size = new Size(255, 23);
            dataconsulta.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(434, 86);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 10;
            label2.Text = "Marque sua consulta";
            // 
            // button1
            // 
            button1.Location = new Point(650, 401);
            button1.Name = "button1";
            button1.Size = new Size(124, 37);
            button1.TabIndex = 11;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(7, 35);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 13;
            label3.Text = "Consultas Marcadas";
            // 
            // lstHistorico
            // 
            lstHistorico.Columns.AddRange(new ColumnHeader[] { data, sintomas });
            lstHistorico.Location = new Point(5, 306);
            lstHistorico.Name = "lstHistorico";
            lstHistorico.Size = new Size(353, 136);
            lstHistorico.TabIndex = 12;
            lstHistorico.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancelarConsulta
            // 
            btnCancelarConsulta.Location = new Point(650, 339);
            btnCancelarConsulta.Name = "btnCancelarConsulta";
            btnCancelarConsulta.Size = new Size(124, 37);
            btnCancelarConsulta.TabIndex = 15;
            btnCancelarConsulta.Text = "Cancelar";
            btnCancelarConsulta.UseVisualStyleBackColor = true;
            btnCancelarConsulta.Click += btnCancelarConsulta_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(2, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 59);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Location = new Point(2, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 20);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(2, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 58);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Location = new Point(357, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(30, 393);
            panel4.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.BackColor = Color.CornflowerBlue;
            panel5.Location = new Point(-3, 57);
            panel5.Name = "panel5";
            panel5.Size = new Size(15, 393);
            panel5.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.BackColor = Color.CornflowerBlue;
            panel6.Controls.Add(lblId);
            panel6.Controls.Add(lblNome);
            panel6.Controls.Add(lblanimal);
            panel6.Controls.Add(lblRaca);
            panel6.Location = new Point(-3, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(390, 63);
            panel6.TabIndex = 19;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSintomas);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCancelarConsulta);
            Controls.Add(lstHistorico);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataconsulta);
            Controls.Add(lblTelefone);
            Controls.Add(lblPeso);
            Controls.Add(lblDataNascimento);
            Name = "Consulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta";
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSintomas;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private Label lblId;
        private Label lblNome;
        private Label lblanimal;
        private Label lblRaca;
        private Label lblDataNascimento;
        private Label lblPeso;
        private Label lblTelefone;
        private Label label1;
        private DateTimePicker dataconsulta;
        private Label label2;
        private Button button1;
        private Label label3;
        private ColumnHeader data;
        private ColumnHeader sintomas;
        private ListView lstHistorico;
        private Button btnCancelarConsulta;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}