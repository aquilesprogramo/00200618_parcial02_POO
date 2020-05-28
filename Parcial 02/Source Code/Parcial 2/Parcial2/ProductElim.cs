using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    
    public partial class ProductElim : UserControl
    {
        private UserControl current = null;
        public ProductElim()
        {
            InitializeComponent();
        }
    

    private void btnReg_Click_1(object sender, EventArgs e)
    {
        tableLayoutPanel1.Controls.Remove(current);
        tableLayoutPanel1.Controls.Clear();
        current =new Inicial();
        tableLayoutPanel1.Controls.Add(current, 0, 0);
        tableLayoutPanel1.SetColumnSpan(current, 5);
        tableLayoutPanel1.SetRowSpan(current, 5);
    }

    private void ProductElim_Load(object sender, EventArgs e)
    {
        var listN = new List<string>();
        var nom = ConnectionDB.ExecuteQuery($"SELECT name FROM business");
        foreach (DataRow dr in nom.Rows)
        {
            listN.Add(dr[0].ToString());
        }

        comboBox1.DataSource = listN;
        
    }

    

    private void btnElim_Click(object sender, EventArgs e)
    {
        
        var num = ConnectionDB.ExecuteQuery($"SELECT idbusiness FROM product WHERE name = " +
                                             $"'{comboBox1.Text}'");
        var cosa = "";
        foreach (DataRow dr in num.Rows)
        {
            cosa = dr[0].ToString();
        }
        ConnectionDB.ExecuteNonQuery($"DELETE FROM product WHERE name='{comboBox2.Text}'" );
        MessageBox.Show("Se ha borrado el producto");
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var id = "";
        var nom = ConnectionDB.ExecuteQuery($"SELECT idbusiness FROM business WHERE name = '{comboBox1.Text}'");
        foreach (DataRow dr in nom.Rows)
        {
            id = dr[0].ToString();
        }
        
        
        var listP = new List<string>();
        
        var prod = ConnectionDB.ExecuteQuery($"SELECT name FROM product WHERE idbusiness = {Convert.ToInt32(id)}");
        foreach (DataRow dr in prod.Rows)
        {
            listP.Add(dr[0].ToString());
        }

        comboBox2.DataSource = listP;
    }
    }
}