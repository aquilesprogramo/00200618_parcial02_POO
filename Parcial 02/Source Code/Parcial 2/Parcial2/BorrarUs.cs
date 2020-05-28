using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class BorrarUs : UserControl
    {
        private UserControl current = null;
        public BorrarUs()
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

        private void btnElimi_Click(object sender, EventArgs e)
        {
            ConnectionDB.ExecuteNonQuery($"DELETE FROM appuser WHERE username='{txtNom.Text}'");
            MessageBox.Show("Usuario eliminado");
        }
    }
}