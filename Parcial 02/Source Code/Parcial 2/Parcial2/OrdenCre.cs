using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class OrdenCre : UserControl
    {
        private UserControl current = null;
        public OrdenCre()
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

        private void OrdenCre_Load(object sender, EventArgs e)
        {
            var listP = new List<string>();
            var prod = ConnectionDB.ExecuteQuery($"SELECT name FROM product");
            foreach (DataRow dr in prod.Rows)
            {
                listP.Add(dr[0].ToString());
            }
            comboBox1.DataSource = listP;

            var listA = new List<string>();
            var addr = ConnectionDB.ExecuteQuery($"SELECT address FROM address");
            foreach (DataRow dr in addr.Rows)
            {
                listA.Add(dr[0].ToString());
            }

            comboBox2.DataSource = listA;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
        
            DateTime dt = DateTime.Now;

            var idProd = "";
            var idP = ConnectionDB.ExecuteQuery($"SELECT idproduct FROM product " +
                                                $"Where name='{comboBox1.Text}'");
            foreach (DataRow dr in idP.Rows)
            {
                idProd = dr[0].ToString();
            }
        
            var idAdd = "";
            var idA = ConnectionDB.ExecuteQuery($"SELECT idaddress FROM address " +
                                                $"WHERE address='{comboBox2.Text}' ");
            foreach (DataRow dr in idA.Rows)
            {
                idAdd = dr[0].ToString();
            }
            
            ConnectionDB.ExecuteNonQuery($"INSERT INTO apporder(createDate, idProduct, idAddress)" +
                                         $"VALUES ('{dt}', '{idProd}', '{idAdd}')");
            MessageBox.Show("Se ha realizado el pedido");
        }
    }
}