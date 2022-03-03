using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormCustomerValidation.Validation;

namespace FormCustomerValidation
{
    public partial class FormCustomer : Form
    {

        private Customer ocustomer = new Customer();
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
              ListViewItem lvitem = new ListViewItem(Convert.ToString(ocustomer.CustomerID));
              lvitem.SubItems.Add(ocustomer.FirstName);
              lvitem.SubItems.Add(ocustomer.LastName);
              lvitem.SubItems.Add(ocustomer.PhoneNumber);

             if (Convert.ToInt32(comboBoxSearch.SelectedIndex.ToString()) == 0)
             {
                ocustomer = ocustomer.SearchCustomerID(Convert.ToInt32(textBox1CstmID.Text));
                if (ocustomer != null)
                {
                    ListViewData.Items.Add(lvitem);
                }
             }
             if (Convert.ToInt32(comboBoxSearch.SelectedIndex.ToString()) == 1)
             {
                ocustomer = ocustomer.SearchFirstName(textBoxFirstName.Text);
                if (ocustomer != null)
                {
                    ListViewData.Items.Add(lvitem);
                }
             }
              if (Convert.ToInt32(comboBoxSearch.SelectedIndex.ToString()) == 2)
              {
                ocustomer = ocustomer.SearchLastName(textBoxLastName.Text);
                if (ocustomer != null)
                {
                    ListViewData.Items.Add(lvitem);
                }
              }
              if (Convert.ToInt32(comboBoxSearch.SelectedIndex.ToString()) == 3)
            {
                ocustomer = ocustomer.SearchPhoneNumber(maskedTextBoxPhonenumber.Text);
                if (ocustomer != null)
                {
                    ListViewData.Items.Add(lvitem);
                }
            }

             
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int counter = 0;

            if (validation.isvalidId(textBox1CstmID, 7))
            {
                ocustomer.CustomerID = Convert.ToInt32(textBox1CstmID.Text);
                counter++;
            }

            if (validation.IsPresent(textBoxFirstName))
            {
                ocustomer.FirstName = textBoxFirstName.Text;
                counter++;
            }

            if (validation.IsPresent(textBoxLastName))
            {
                ocustomer.LastName = textBoxLastName.Text;
                counter++;
            }
            if (validation.isvalidnumber(maskedTextBoxPhonenumber, 14))
            {
                ocustomer.PhoneNumber = maskedTextBoxPhonenumber.Text;
                counter++;

            }
            if (counter == 4)
            {

                ocustomer.SaveData(ocustomer);

            }
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(comboBoxSearch.SelectedIndex.ToString()) == 0)
            {
                ocustomer = ocustomer.SearchCustomerID(Convert.ToInt32(textBox1CstmID.Text));
                if (ocustomer != null)
                {
                    MessageBox.Show("Data Found SuccesFully");
                }
            }
            else if (Convert.ToInt32(comboBoxSearch.SelectedIndex.ToString()) == 1)
            {
                ocustomer = ocustomer.SearchFirstName(textBoxFirstName.Text);
                if (ocustomer != null)
                {
                     MessageBox.Show("Data Found SuccesFully");
                }
            }

            else if (Convert.ToInt32(comboBoxSearch.SelectedIndex.ToString()) == 2)
            {
                ocustomer = ocustomer.SearchLastName(textBoxLastName.Text);
                if (ocustomer != null)
                {
                     MessageBox.Show("Data Found SuccesFully");

                }
            }
            else if (Convert.ToInt32(comboBoxSearch.SelectedIndex.ToString()) == 3)
            {
                ocustomer = ocustomer.SearchPhoneNumber(maskedTextBoxPhonenumber.Text);
                if (ocustomer != null)
                {
                    MessageBox.Show("Data Found Successfully");
                }
            }
        }

        private void ListViewData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
