using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Login : UserControl
    {
        private UserControl current = null;
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Clear();
            current = new Inicial();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }


        private void txtLogin_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("")||txtContra.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar campos vacios");
            }
            else
            {
               
                var user = ConnectionDB.ExecuteQuery($"SELECT username FROM APPUSER");
                var list = new List<string>();
                
                foreach (DataRow dr in user.Rows)
                {
                 list.Add(dr[0].ToString());
                }
                
                var password = ConnectionDB.ExecuteQuery($"SELECT password FROM APPUSER");
                var listpassword = new List<string>();
                
                foreach (DataRow dr in password.Rows)
                {
                 listpassword.Add(dr[0].ToString());
                }
                
                foreach (var text in list)
                {
                    if (txtNombre.Text.Equals(text))
                    {
                        foreach (var pass in listpassword)
                        {
                            var isAdmin = "";
                            var tipo = ConnectionDB.ExecuteQuery(
                                $"SELECT usertype FROM appuser WHERE username='{txtNombre.Text}' ");
                            
                            foreach (DataRow dr in tipo.Rows)
                            { 
                                isAdmin = dr[0].ToString();
                            }
                            if (txtContra.Text.Equals(pass))
                            {
                                if (Convert.ToBoolean(isAdmin))
                                {
                                    tableLayoutPanel1.Controls.Remove(current);
                                    tableLayoutPanel1.Controls.Clear();
                                    current = new Admin();
                                    tableLayoutPanel1.Controls.Add(current, 0, 0);
                                    tableLayoutPanel1.SetColumnSpan(current, 5);
                                    tableLayoutPanel1.SetRowSpan(current, 5);
                                    break;
                                }
                                else
                                {
                                    tableLayoutPanel1.Controls.Remove(current);
                                    tableLayoutPanel1.Controls.Clear();
                                    current = new Regular();
                                    tableLayoutPanel1.Controls.Add(current, 0, 0);
                                    tableLayoutPanel1.SetColumnSpan(current, 5);
                                    tableLayoutPanel1.SetRowSpan(current, 5);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}