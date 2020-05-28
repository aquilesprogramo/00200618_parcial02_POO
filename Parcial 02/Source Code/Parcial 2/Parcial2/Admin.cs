using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Admin : UserControl
    {
        private UserControl current = null;
        public Admin()
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
        
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Clear();
            current = new Usuario();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Clear();
            current = new Products();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void btnNegocio_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
                        tableLayoutPanel1.Controls.Clear();
                        current = new Negocio();
                        tableLayoutPanel1.Controls.Add(current, 0, 0);
                        tableLayoutPanel1.SetColumnSpan(current, 5);
                        tableLayoutPanel1.SetRowSpan(current, 5);
        }
    private void btnOrdenes_Click(object sender, EventArgs e)
{
    tableLayoutPanel1.Controls.Remove(current);
    tableLayoutPanel1.Controls.Clear();
    current =new OrdenUsA();
    tableLayoutPanel1.Controls.Add(current, 0, 0);
    tableLayoutPanel1.SetColumnSpan(current, 5);
    tableLayoutPanel1.SetRowSpan(current, 5);
}
    
    }
}