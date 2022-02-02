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
    public partial class FormLogin : Form
    {
        private FormMain formMain;
        string name = "", surname = "", street = "", city = "";
        int streetNumber = -1, accountNumber = -1;
        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

       

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            name = textBoxName.Text;
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            surname = textBoxSurname.Text;
        }

        private void textBoxAccount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                accountNumber = Int32.Parse(textBoxAccount.Text);
            } catch(Exception ex)
            {

            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStreet_TextChanged(object sender, EventArgs e)
        {
                street = textBoxStreet.Text;            
        }

        private void textBoxStreetNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                streetNumber = Int32.Parse(textBoxStreetNumber.Text);
            } catch (Exception ex)
            {

            }
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            city = textBoxCity.Text;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (name != "" && surname != "" && street != "" && city != "" && textBoxAccount.Text.Length != 0 && streetNumber != -1)
            {
                formMain = new FormMain(name, surname, accountNumber, street, streetNumber, city);
                formMain.Show();
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.ShowInTaskbar = false;
                this.Size = new Size(0, 0);
                //this.Load += new EventHandler(FormLogin_Load);
                //zrobic niewidoczne logowanie
            }
        }

        void FormLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
