using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Regular : UserControl
    {
        
        private UserControl current = null;
        public Regular()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Clear();
            current = new Inicial();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void btnDire_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Clear();
            current = new Direcciones();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Clear();
            current = new OrdenUsR();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }
    }
}