using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Usuario : UserControl
    {
        private UserControl current = null;
        public Usuario()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Clear();
            current =new Inicial();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }
    private void btnCrear_Click(object sender, EventArgs e)
    {
        tableLayoutPanel1.Controls.Remove(current);
        tableLayoutPanel1.Controls.Clear();
        current = new CrearUs();
        tableLayoutPanel1.Controls.Add(current, 0, 0);
        tableLayoutPanel1.SetColumnSpan(current, 5);
        tableLayoutPanel1.SetRowSpan(current, 5);
    }

    private void btnElim_Click(object sender, EventArgs e)
    {
        tableLayoutPanel1.Controls.Remove(current);
        tableLayoutPanel1.Controls.Clear();
        current = new BorrarUs();
        tableLayoutPanel1.Controls.Add(current, 0, 0);
        tableLayoutPanel1.SetColumnSpan(current, 5);
        tableLayoutPanel1.SetRowSpan(current, 5);
    }

    private void btnVer_Click(object sender, EventArgs e)
    {
        tableLayoutPanel1.Controls.Remove(current);
        tableLayoutPanel1.Controls.Clear();
        current = new VerUs();
        tableLayoutPanel1.Controls.Add(current, 0, 0);
        tableLayoutPanel1.SetColumnSpan(current, 5);
        tableLayoutPanel1.SetRowSpan(current, 5);
    }
    }
}