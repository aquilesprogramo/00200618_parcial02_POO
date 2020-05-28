using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Pass : UserControl
    {
        private UserControl current = null;

        public Pass()
        {
            InitializeComponent();
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

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (txtUsua.Text.Equals("") || txtContra.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar campos vacios");
            }
            else
            {
                ConnectionDB.ExecuteNonQuery($"UPDATE appuser SET password = " +
                                             $"'{txtContra.Text}' " +
                                             $"WHERE username='{txtUsua.Text}' ");
                MessageBox.Show("Se ha cambiado el password");


            }
        }
    }
}