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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;   
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {

        }

        private void logofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serviços serviços = new Serviços();
            serviços.ShowDialog();
        }

        private void agendamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.ShowDialog();
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();  
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            Serviços serviços = new Serviços();
            serviços.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.ShowDialog();

     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.ShowDialog();
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            Localização localização = new Localização();
            localização.ShowDialog();

        }
    }
}
