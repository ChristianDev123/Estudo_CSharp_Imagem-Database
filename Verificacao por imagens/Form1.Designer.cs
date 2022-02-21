
namespace Verificacao_por_imagens
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LinkCadastre_se = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuario_textbox = new System.Windows.Forms.TextBox();
            this.avisos_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(320, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verificação por Imagem";
            // 
            // LinkCadastre_se
            // 
            this.LinkCadastre_se.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.LinkCadastre_se.AutoSize = true;
            this.LinkCadastre_se.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LinkCadastre_se.LinkColor = System.Drawing.Color.Gold;
            this.LinkCadastre_se.Location = new System.Drawing.Point(236, 222);
            this.LinkCadastre_se.Name = "LinkCadastre_se";
            this.LinkCadastre_se.Size = new System.Drawing.Size(140, 31);
            this.LinkCadastre_se.TabIndex = 1;
            this.LinkCadastre_se.TabStop = true;
            this.LinkCadastre_se.Text = "Cadastre-se";
            this.LinkCadastre_se.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCadastre_se_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Verificacao_por_imagens.Properties.Resources.Imagem_user_default;
            this.pictureBox1.Location = new System.Drawing.Point(339, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // usuario_textbox
            // 
            this.usuario_textbox.Location = new System.Drawing.Point(242, 180);
            this.usuario_textbox.Name = "usuario_textbox";
            this.usuario_textbox.Size = new System.Drawing.Size(404, 39);
            this.usuario_textbox.TabIndex = 4;
            // 
            // avisos_textbox
            // 
            this.avisos_textbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.avisos_textbox.Location = new System.Drawing.Point(761, 604);
            this.avisos_textbox.Multiline = true;
            this.avisos_textbox.Name = "avisos_textbox";
            this.avisos_textbox.ReadOnly = true;
            this.avisos_textbox.Size = new System.Drawing.Size(131, 65);
            this.avisos_textbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(236, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuário cadastrado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(225, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Imagem cadastrada:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(904, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.avisos_textbox);
            this.Controls.Add(this.usuario_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LinkCadastre_se);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkCadastre_se;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usuario_textbox;
        private System.Windows.Forms.TextBox avisos_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

