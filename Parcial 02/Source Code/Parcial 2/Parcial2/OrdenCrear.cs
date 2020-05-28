using System;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class OrdenCrear : UserControl
    {
        private UserControl current = null;

        public OrdenCrear()
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

        private void btnBus_Click(object sender, EventArgs e)
        {
            var idU = "";
            var id = ConnectionDB.ExecuteQuery($"SELECT iduser FROM appuser Where " +
                                               $"username = '{txtUser.Text}'");
            foreach(DataRow dr in id.Rows)
            {
                idU = dr[0].ToString();
            }
            
            var tabla = ConnectionDB.ExecuteQuery($"SELECT ord.idOrder, add.address, " +
                                                  $"pro.name, aus.fullname FROM apporder ord, " +
                                                  $"address add, product pro, appuser aus " +
                                                  $"WHERE ord.idAddress = add.idAddress " +
                                                  $"AND ord.idProduct = pro.idProduct " +
                                                  $"AND add.idUser = aus.idUser");
            dataGridView1.DataSource = tabla;
        }
    }
}