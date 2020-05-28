using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class OrdenUsA : UserControl
    {
        private UserControl current = null;
    
        public OrdenUsA()
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

    private void btnAct_Click(object sender, EventArgs e)
    {
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