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
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "" || textEmail.Text == "" || textTelefone.Text == "" || textModelo.Text == "" || comboServico.Text == "")

            {
                MessageBox.Show("Preencha os campos obrigatórios");
                return;
            }  

                MessageBox.Show("Agendamento Confirmado!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Localização localização = new Localização();
            localização.ShowDialog();
        }
    }
}
