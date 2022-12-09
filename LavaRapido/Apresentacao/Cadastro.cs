using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavaRapido.Apresentacao
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSALVAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro realizado com sucesso");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.ShowDialog();

            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.ShowDialog();

            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Localização localização = new Localização();
            localização.ShowDialog();

            Close();
        }
    }
}
