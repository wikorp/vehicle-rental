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
    public partial class FormMain : Form
    {
        string name = "", surname = "", street = "", city = "";
        int streetNumber = -1, accountNumber = -1;
        int selectedId;
        string selectedIsAvaliable;
        int clientId;
        private readonly Repository repository = new Repository();
        private FormDamage formDamage;

        public FormMain()
        {
        }

        public FormMain(string name, string surname, int accountNumber, string street, int streetNumber, string city)
        {
            InitializeComponent();
            RefreshDataGridViewVehicles();
            this.name = name;
            this.surname = surname;
            this.accountNumber = accountNumber;
            this.street = street;
            this.streetNumber = streetNumber;
            this.city = city;

            labelClient.Text = name + " " + surname;

            int adressId = repository.getAdressId(street, streetNumber, city);
            if (adressId == -1) 
            {
                adressId = repository.CreateAdressRow(street, streetNumber, city);
            }

            clientId = repository.getClientId(name, surname, adressId, accountNumber);
            if (clientId == -1) 
            {
                clientId = repository.CreateClientRow(name, surname, adressId, accountNumber);
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void RefreshDataGridViewVehicles()
        {
            DataTable table = repository.GetVehicles();
            dataGridViewVehicles.DataSource = table;
        }


        private void dataGridViewVehicles_SelectionChanged_1(object sender, EventArgs e)
        {
            if (!isSelected())
            {
                return;
            }

            DataGridViewRow row = dataGridViewVehicles.SelectedRows[0];

            selectedId = Int32.Parse(row.Cells[0].Value.ToString());
            selectedIsAvaliable = row.Cells[7].Value.ToString();

            labelId.Text = selectedId.ToString(); ;
            labelVehicle.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
        }

        private bool isSelected()
        {
            int rowCount = dataGridViewVehicles.SelectedRows.Count;
            if (rowCount == 0 || rowCount > 1)
            {
                return false;
            }
            return true;
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            if (!isSelected())
            {
                MessageBox.Show("Select vehicle");
                return;
            }
            if (selectedIsAvaliable == "N")
            {
                MessageBox.Show("This vehicle is not currently avaliable");
                return;
            }
            repository.SetIsAvaliableVehicle(selectedId, 'N');
            repository.CreateRental(selectedId, clientId); 

            labelId.Text = "";
            labelVehicle.Text = "";
            RefreshDataGridViewVehicles();
        }

        private void buttonDamage_Click(object sender, EventArgs e)
        {
            formDamage = new FormDamage(clientId);
            formDamage.Show();
            RefreshDataGridViewVehicles();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void FormMain_Closing(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void labelIdVehicle_Click(object sender, EventArgs e)
        {

        }
    }
}
