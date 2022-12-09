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
    public partial class Serviços : Form
    {
        public Serviços()
        {
            InitializeComponent();
        }

        private void agendamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.ShowDialog();
        }
    }
}
