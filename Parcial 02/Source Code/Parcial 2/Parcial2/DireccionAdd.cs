using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class DireccionAdd : UserControl
    {
        private UserControl current = null;
        public DireccionAdd()
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

        private void btnAgre_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("")||txtDire.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar campos vacios");
            }
            else
            {
                var user = ConnectionDB.ExecuteQuery($"SELECT iduser FROM appuser WHERE username = " +
                                                     $"'{txtUser.Text}'");
                var cosa = "";
                            foreach (DataRow dr in user.Rows)
                            {
                                cosa = dr[0].ToString();

                            }
                ConnectionDB.ExecuteNonQuery($"INSERT INTO address (iduser, address) VALUES " +
                    $"('{Convert.ToInt32(cosa)}', '{txtDire.Text}')");
                MessageBox.Show("Se ha agregado la direccion");
            }
        }
    }
}