using lab1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private PostalAddress organizationAddress;

        public Form1()
        {
            InitializeComponent();

            organizationAddress = new PostalAddress();

            txtCountry.Text = organizationAddress.Country;
            txtCity.Text = organizationAddress.City;
            txtStreet.Text = organizationAddress.Street;
            txtPostalCode.Text = organizationAddress.PostalCode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string country = txtCountry.Text;
                string city = txtCity.Text;
                string street = txtStreet.Text;
                string postalCode = txtPostalCode.Text;

                if (!string.IsNullOrWhiteSpace(country) &&
                    !string.IsNullOrWhiteSpace(city) &&
                    !string.IsNullOrWhiteSpace(street) &&
                    !string.IsNullOrWhiteSpace(postalCode))
                {
                    organizationAddress.Country = country;
                    organizationAddress.City = city;
                    organizationAddress.Street = street;
                    organizationAddress.PostalCode = postalCode;

                    organizationAddress.PrintInfo();
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

