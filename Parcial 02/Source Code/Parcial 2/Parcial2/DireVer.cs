using System;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class DireVer : UserControl
    {
        private UserControl current = null;
        public DireVer()
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            var idUser = ConnectionDB.ExecuteQuery($"SELECT iduser FROM appuser " +
                                                   $"WHERE username = '{txtUser.Text}' ");
            var id = "";

            foreach (DataRow dr in idUser.Rows)
            {
                id = dr[0].ToString();
            }
            
            var data = ConnectionDB.ExecuteQuery($"SELECT address FROM address " +
            $"WHERE iduser = '{id}' ");
            dataGridView1.DataSource = data;
        }
    }
}