using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class OrdenUsR : UserControl
    {
        private UserControl current = null;
        public OrdenUsR()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
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
            current =new OrdenCre();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
                        tableLayoutPanel1.Controls.Clear();
                        current =new OrdenCrear();
                        tableLayoutPanel1.Controls.Add(current, 0, 0);
                        tableLayoutPanel1.SetColumnSpan(current, 5);
                        tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Clear();
            current =new OrdenEl();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }
    }
}