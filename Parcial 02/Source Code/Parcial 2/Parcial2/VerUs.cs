using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class VerUs : UserControl
    {
        private UserControl current = null;
        public VerUs()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Clear();
            current = new Inicial();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 5);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void btnActua_Click(object sender, EventArgs e)
        {
            var dt = ConnectionDB.ExecuteQuery(
                $"SELECT * FROM appuser ");
            dataGridView1.DataSource = dt;
        }
    }
}