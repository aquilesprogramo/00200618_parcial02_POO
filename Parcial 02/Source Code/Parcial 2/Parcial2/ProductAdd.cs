using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class ProductAdd : UserControl
    {
        private UserControl current = null;
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            var lista = new List<string>();
            var nom = ConnectionDB.ExecuteQuery($"SELECT name FROM business");
            foreach(DataRow dr in nom.Rows)
            {
                lista.Add(dr[0].ToString());
            }

            comboBox1.DataSource = lista;

        }


        private void btnReg_Click_1(object sender, EventArgs e)
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
            if (txtNom.Text.Equals(""))
            {
                MessageBox.Show("No pueden haber casos vacios");
            }
            else
            {
                var idBu = "";
                var listBusi = ConnectionDB.ExecuteQuery($"SELECT idbusiness FROM business " +
                                                            $"WHERE name='{comboBox1.Text}'");
                foreach (DataRow dr in listBusi.Rows)
                {
                    idBu = dr[0].ToString();
                }
                ConnectionDB.ExecuteNonQuery($"INSERT INTO product(idbusiness, name)" +
                                             $"VALUES({idBu}, '{txtNom.Text}')");
                MessageBox.Show("Se ha agregado el producto");
            }
        }
    }
}