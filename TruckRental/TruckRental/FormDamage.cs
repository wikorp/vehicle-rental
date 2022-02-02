using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckRental
{
    public partial class FormDamage : Form
    {
        string damage = "";
        int vehicleId = -1;
        int clientId = -1;
        private readonly Repository repository = new Repository();
        public FormDamage(int clientId)
        {
            this.clientId = clientId;
            InitializeComponent();
            RefreshDataGridViewRentals();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (vehicleId != -1 && damage != "")
            {
                repository.CreateDamage(vehicleId, damage);
                MessageBox.Show("Damage reported");
            }
            this.Close();
        }

        private void textBoxDamege_TextChanged(object sender, EventArgs e)
        {
            damage = textBoxDamege.Text;
        }

        private void dataGridViewRentals_SelectionChanged_1(object sender, EventArgs e)
        {
            if (!isSelected())
            {
                return;
            }

            DataGridViewRow row = dataGridViewRentals.SelectedRows[0];
            vehicleId = Int32.Parse(row.Cells[1].Value.ToString());
            //selectedId = Int32.Parse(row.Cells[0].Value.ToString());
            // selectedIsAvaliable = row.Cells[7].Value.ToString();

            // labelId.Text = selectedId.ToString(); ;
            // labelVehicle.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
        }

        private void RefreshDataGridViewRentals()
        {
            DataTable table = repository.GetRentals(clientId);
            dataGridViewRentals.DataSource = table;
        }

        private bool isSelected()
        {
            int rowCount = dataGridViewRentals.SelectedRows.Count;
            if (rowCount == 0 || rowCount > 1)
            {
                return false;
            }
            return true;
        }

        private void FormDamage_Load(object sender, EventArgs e)
        {

        }
    }
}
