using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (openFileDialog1.ShowDialog() == DialogResult.Ok)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.Load();
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
