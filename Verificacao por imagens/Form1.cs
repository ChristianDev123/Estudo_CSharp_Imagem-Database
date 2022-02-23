using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificacao_por_imagens
{   
    public partial class Login : Form
    {
        Thread ligacao_paginas;
        public Login()
        {
            InitializeComponent();
        }

        private void LinkCadastre_se_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ligacao_paginas = new Thread(gerencia_paginas.form_cadastro);
            ligacao_paginas.SetApartmentState(ApartmentState.STA);
            ligacao_paginas.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.Load();
            }
            // Rotina para puxar imagens do banco de dados:
            //pictureBox1.Image = Image.FromStream((MemoryStream)query.select_imagens_mysql("imagem_nome","lilo-stitch-amigurumi-colecionavel.jpg"));
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            // Rotina pra verificação da imagem através do usuario apresentado
            FileStream imagem = new FileStream(pictureBox1.ImageLocation, FileMode.Open, FileAccess.Read);
            byte[] imagem_byte;
            BinaryReader leitor_binario = new BinaryReader(imagem);
            imagem_byte = leitor_binario.ReadBytes((int)imagem.Length);
            var imagem_banco =(MemoryStream)query.select_imagens_mysql("usuario_login", usuario_textbox.Text);
            if (imagem_byte.Length == imagem_banco.Length)
            {
                MessageBox.Show("é a mesma imagem!");
            }
        }
    }
    public class gerencia_paginas
    {
        public static void form_cadastro()
        {
            Application.Run(new Form_cadastro());
        }
        public static void form_login()
        {
            Application.Run(new Login());
        }
    }
}
