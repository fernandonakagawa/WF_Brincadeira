using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            int qtd = tbNome.Text.Trim().Length;
            MessageBox.Show($"O nome {tbNome.Text.Trim()} tem tamanho {qtd}");
        }

        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrar.Checked)
            {
                tbNome.PasswordChar = (char)0;
            }
            else
            {
                tbNome.PasswordChar = '*';
            }
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            lbContador.Text = tbNome.Text.Trim().Length.ToString();
        }
    }
}
