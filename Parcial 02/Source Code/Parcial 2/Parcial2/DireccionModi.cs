using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class DireccionModi : UserControl
    {
        private UserControl current = null;
        public DireccionModi()
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

        private void DireccionModi_Load(object sender, EventArgs e)
        {
            var num = ConnectionDB.ExecuteQuery("SELECT address FROM address");
                        var numList = new List<string>();
                       
                   
                        foreach (DataRow dr in num.Rows)
                        {
                            numList.Add(dr[0].ToString());
                        }
                        comboBox1.DataSource = numList;
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals(""))
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
                            
                            ConnectionDB.ExecuteNonQuery($"UPDATE address SET address = '{txtNueva.Text}' "+
                                        $"WHERE address = '{comboBox1.SelectedItem.ToString()}' AND iduser ='{cosa}'");
                           
                            
                            
                            
            
                        }
        }
    }
}