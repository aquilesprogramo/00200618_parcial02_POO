using System;
using System.Windows.Forms;

namespace Parcial2
{

    public partial class Negocio : UserControl
    {
        private UserControl current = null;
        public Negocio()
        {
            InitializeComponent();
        }

        private void btnAgre_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Clear();
            current = new NegocioAdd();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Clear();
            current = new Inicial();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
                        tableLayoutPanel1.Controls.Clear();
                        current = new NegocioElim();
                        tableLayoutPanel1.Controls.Add(current, 0, 0);
                        tableLayoutPanel1.SetColumnSpan(current, 5);
                        tableLayoutPanel1.SetRowSpan(current, 5);
        }
    }
}