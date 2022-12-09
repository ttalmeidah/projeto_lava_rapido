using LavaRapido.Apresentacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavaRapido
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "" || textSenha.Text == "")
            {
                MessageBox.Show("Preencha o Usuário e Senha");
                return;
            }


            FrmMenu menu = new FrmMenu();
            //this.Hide(); ocultar
            Limpar();
            menu.ShowDialog();

        }

        //Limpar campo usuário e senha
        private void Limpar()
        {
            textUsuario.Text = "";
            textSenha.Text = "";
            textUsuario.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }
    }
}
