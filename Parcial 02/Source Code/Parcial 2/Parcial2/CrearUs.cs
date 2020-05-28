using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class CrearUs : UserControl
    {
        private UserControl current = null;
        public CrearUs()
        {
            InitializeComponent();
        }

        private void btnRegre_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Clear();
            current = new Inicial();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }
    private void CrearUs_Load(object sender, EventArgs e)
{
    cbxUser.DataSource = new List<string>(){"Administrador", "Regular"};
}

    private void btnCrear_Click(object sender, EventArgs e)
    {
        switch(cbxUser.SelectedIndex)
        {
            case 0:
                {
                ConnectionDB.ExecuteNonQuery($"INSERT INTO APPUSER(fullname, username, password, usertype) " +
                $"VALUES ('{txtName.Text}', '{txtUser.Text}', '{txtUser.Text}', '{true}') ");
                MessageBox.Show("Se ha agregado");
                break;
                }
            case 1:
                {
                 ConnectionDB.ExecuteNonQuery($"INSERT INTO APPUSER(fullname, username, password, usertype) " +
                            $"VALUES ('{txtName.Text}', '{txtUser.Text}', '{txtUser.Text}', '{false}') ");
                 MessageBox.Show("Se ha agregado");
                            break;
                }
            
        }
    }
    }
}