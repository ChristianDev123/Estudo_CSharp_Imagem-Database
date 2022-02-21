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
    public partial class Form_cadastro : Form
    {
        Thread ligacao_pagina;
        public Form_cadastro()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Close();
            ligacao_pagina = new Thread(gerencia_paginas.form_login);
            ligacao_pagina.SetApartmentState(ApartmentState.STA);
            ligacao_pagina.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.Load();
            }
        }
    }
}
