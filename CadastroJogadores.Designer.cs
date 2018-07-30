namespace DanD
{
    partial class CadastroJogadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroJogadores));
            this.nomeDoJogadorLabel = new System.Windows.Forms.Label();
            this.nomeDoPersonagem = new System.Windows.Forms.Label();
            this.classeDoPersonagem = new System.Windows.Forms.Label();
            this.nomeDoJogadorTextBox = new System.Windows.Forms.TextBox();
            this.nomeDoPersonagemTextBox = new System.Windows.Forms.TextBox();
            this.classesComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeDoJogadorLabel
            // 
            this.nomeDoJogadorLabel.AutoSize = true;
            this.nomeDoJogadorLabel.Location = new System.Drawing.Point(12, 9);
            this.nomeDoJogadorLabel.Name = "nomeDoJogadorLabel";
            this.nomeDoJogadorLabel.Size = new System.Drawing.Size(94, 13);
            this.nomeDoJogadorLabel.TabIndex = 0;
            this.nomeDoJogadorLabel.Text = "Nome do Jogador:";
            // 
            // nomeDoPersonagem
            // 
            this.nomeDoPersonagem.AutoSize = true;
            this.nomeDoPersonagem.Location = new System.Drawing.Point(12, 35);
            this.nomeDoPersonagem.Name = "nomeDoPersonagem";
            this.nomeDoPersonagem.Size = new System.Drawing.Size(115, 13);
            this.nomeDoPersonagem.TabIndex = 1;
            this.nomeDoPersonagem.Text = "Nome do Personagem:";
            // 
            // classeDoPersonagem
            // 
            this.classeDoPersonagem.AutoSize = true;
            this.classeDoPersonagem.Location = new System.Drawing.Point(12, 61);
            this.classeDoPersonagem.Name = "classeDoPersonagem";
            this.classeDoPersonagem.Size = new System.Drawing.Size(118, 13);
            this.classeDoPersonagem.TabIndex = 2;
            this.classeDoPersonagem.Text = "Classe do Personagem:";
            // 
            // nomeDoJogadorTextBox
            // 
            this.nomeDoJogadorTextBox.Location = new System.Drawing.Point(112, 6);
            this.nomeDoJogadorTextBox.Name = "nomeDoJogadorTextBox";
            this.nomeDoJogadorTextBox.Size = new System.Drawing.Size(165, 20);
            this.nomeDoJogadorTextBox.TabIndex = 3;
            // 
            // nomeDoPersonagemTextBox
            // 
            this.nomeDoPersonagemTextBox.Location = new System.Drawing.Point(133, 32);
            this.nomeDoPersonagemTextBox.Name = "nomeDoPersonagemTextBox";
            this.nomeDoPersonagemTextBox.Size = new System.Drawing.Size(144, 20);
            this.nomeDoPersonagemTextBox.TabIndex = 4;
            // 
            // classesComboBox
            // 
            this.classesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classesComboBox.FormattingEnabled = true;
            this.classesComboBox.Items.AddRange(new object[] {
            "Bárbaro",
            "Bardo",
            "Bruxo",
            "Clérigo",
            "Druida",
            "Feiticeiro",
            "Guerreiro",
            "Ladino",
            "Mago",
            "Monge",
            "Paladino",
            "Patrulheiro"});
            this.classesComboBox.Location = new System.Drawing.Point(133, 58);
            this.classesComboBox.Name = "classesComboBox";
            this.classesComboBox.Size = new System.Drawing.Size(144, 21);
            this.classesComboBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 117);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.classesComboBox);
            this.Controls.Add(this.nomeDoPersonagemTextBox);
            this.Controls.Add(this.nomeDoJogadorTextBox);
            this.Controls.Add(this.classeDoPersonagem);
            this.Controls.Add(this.nomeDoPersonagem);
            this.Controls.Add(this.nomeDoJogadorLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 155);
            this.MinimumSize = new System.Drawing.Size(305, 155);
            this.Name = "CadastroJogadores";
            this.Text = "Cadastro de Jogadores";
            this.Load += new System.EventHandler(this.CadastroJogadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeDoJogadorLabel;
        private System.Windows.Forms.Label nomeDoPersonagem;
        private System.Windows.Forms.Label classeDoPersonagem;
        private System.Windows.Forms.TextBox nomeDoJogadorTextBox;
        private System.Windows.Forms.TextBox nomeDoPersonagemTextBox;
        private System.Windows.Forms.ComboBox classesComboBox;
        private System.Windows.Forms.Button button1;
    }
}