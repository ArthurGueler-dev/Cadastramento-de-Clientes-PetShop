namespace WinFormsApp1
{
    partial class cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNome = new TextBox();
            txtTipoAnimal = new TextBox();
            txtRaça = new TextBox();
            txtDataNascimento = new TextBox();
            txtPeso = new TextBox();
            button1 = new Button();
            label7 = new Label();
            txtTelefone = new TextBox();
            lst_contatos = new ListView();
            label4 = new Label();
            txtBuscar = new TextBox();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 182);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 288);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo do Animal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(300, 182);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Raça";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(300, 412);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 4;
            label5.Text = "Data de Nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.CornflowerBlue;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(302, 288);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 5;
            label6.Text = "Peso";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 205);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(224, 23);
            txtNome.TabIndex = 6;
            // 
            // txtTipoAnimal
            // 
            txtTipoAnimal.Location = new Point(12, 311);
            txtTipoAnimal.Name = "txtTipoAnimal";
            txtTipoAnimal.Size = new Size(224, 23);
            txtTipoAnimal.TabIndex = 7;
            // 
            // txtRaça
            // 
            txtRaça.Location = new Point(302, 205);
            txtRaça.Name = "txtRaça";
            txtRaça.Size = new Size(224, 23);
            txtRaça.TabIndex = 8;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(302, 435);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(224, 23);
            txtDataNascimento.TabIndex = 10;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(302, 311);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(224, 23);
            txtPeso.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(197, 551);
            button1.Name = "button1";
            button1.Size = new Size(106, 34);
            button1.TabIndex = 12;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 412);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 13;
            label7.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 435);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(224, 23);
            txtTelefone.TabIndex = 14;
            // 
            // lst_contatos
            // 
            lst_contatos.BackColor = SystemColors.Window;
            lst_contatos.ForeColor = SystemColors.WindowText;
            lst_contatos.Location = new Point(579, 163);
            lst_contatos.Name = "lst_contatos";
            lst_contatos.Size = new Size(772, 440);
            lst_contatos.TabIndex = 15;
            lst_contatos.UseCompatibleStateImageBehavior = false;
            lst_contatos.SelectedIndexChanged += lst_contatos_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(579, 94);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 16;
            label4.Text = "Buscar ";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(579, 118);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(367, 23);
            txtBuscar.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(1015, 116);
            button2.Name = "button2";
            button2.Size = new Size(100, 24);
            button2.TabIndex = 18;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtDataNascimento);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtRaça);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtTipoAnimal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 660);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Location = new Point(1382, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 660);
            panel2.TabIndex = 15;
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1588, 653);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(lst_contatos);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "cadastro";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            TransparencyKey = Color.Snow;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtNome;
        private TextBox txtTipoAnimal;
        private TextBox txtRaça;
        private TextBox txtDataNascimento;
        private TextBox txtPeso;
        private Button button1;
        private Label label7;
        private TextBox txtTelefone;
        private ListView lst_contatos;
        private Label label4;
        private TextBox txtBuscar;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
    }
}
