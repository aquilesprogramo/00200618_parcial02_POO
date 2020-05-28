using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class NegocioAdd : UserControl
    {
        private UserControl current = null;
        public NegocioAdd()
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

        private void btnAgre_Click(object sender, EventArgs e)
        {
            if (txtName.Equals("") || txtDescrip.Equals(""))
            {
                MessageBox.Show("No se puede dejar vacio el campo");
            }
            else
            {
                ConnectionDB.ExecuteNonQuery($"INSERT INTO business(name,description) " +
                                             $"VALUES ('{txtName.Text}','{txtDescrip.Text}') ");
                MessageBox.Show("Se ha agregado");
            }
        }
    }
}