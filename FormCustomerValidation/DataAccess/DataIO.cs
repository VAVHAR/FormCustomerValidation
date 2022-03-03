using FormCustomerValidation.Validation;
using System;
using System.IO;
using System.Windows.Forms;

namespace FormCustomerValidation.DataAccess
{
    public static class DataIO
    {
        private const string dir = @" ";

        private const string filepath = dir + "Customer.dat";

        public static void SaveRecord(Customer customer)
        {
            StreamWriter sw = new StreamWriter(filepath, true);
            sw.WriteLine(customer.CustomerID + "," + customer.FirstName+ "," + customer.LastName + "," + customer.PhoneNumber);
            MessageBox.Show("Data Sucessfully Saved");
            sw.Close();
        }

        public static Customer SearchRecord()
        {
            Customer customer = new Customer();

            if (File.Exists(filepath))
            {

                StreamReader sr = new StreamReader(filepath);
                string line = sr.ReadLine();
                bool found = false;

                while (line != null)
                {
                    /* line = sr.ReadLine();*/
                    string[] fields = line.Split(',');
                   
                        customer.CustomerID = Convert.ToInt32(fields[0]);
                        customer.FirstName = fields[1];
                        customer.LastName = fields[2];
                        customer.PhoneNumber = fields[3];

                        found = true;
                        break;
                    

                    line = sr.ReadLine();
                }

                sr.Close();

                if (!found)
                {
                    MessageBox.Show("Data not found");

                    customer = null;
                }
            }
            else
            {
                MessageBox.Show("File not found");
            }

            return customer;
        }


        public static Customer SearchRecordCusId(int id)
        {
            Customer customer = new Customer();

            if (File.Exists(filepath))
            {

                StreamReader sr = new StreamReader(filepath);
                string line = sr.ReadLine();
                bool found = false;

                while (line != null)
                {
                    /* line = sr.ReadLine();*/
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(fields[0]) == id)
                    {
                        customer.CustomerID = Convert.ToInt32(fields[0]);
                        customer.FirstName = fields[1];
                        customer.LastName = fields[2];
                        customer.PhoneNumber = fields[3];

                        found = true;
                        break;
                    }

                    line = sr.ReadLine();
                }

                sr.Close();

                if (!found)
                {
                    MessageBox.Show("Data not found");

                    customer = null;
                }
            }
            else
            {
                MessageBox.Show("File not found");
            }

            return customer;
        }

        public static Customer SearchRecordfname(string fname)
        {
            Customer customer = new Customer();

            if (File.Exists(filepath))
            {

                StreamReader sr = new StreamReader(filepath);
                string line = sr.ReadLine();
                bool found = false;

                while (line != null)
                {
                   /* line = sr.ReadLine();*/
                    string[] fields = line.Split(',');
                    if (fields[1].Equals(fname))
                    {
                        customer.CustomerID = Convert.ToInt32(fields[0]);
                        customer.FirstName = fields[1];
                        customer.LastName = fields[2];
                        customer.PhoneNumber = fields[3];

                        found = true;
                        break;
                    }

                    line = sr.ReadLine();
                }

                sr.Close();

                if (!found)
                {
                    MessageBox.Show("Data not found");

                    customer = null;
                }
            }
            else
            {
                MessageBox.Show("File not found");
            }

            return customer;
        }
        public static Customer SearchRecordlname(string lname)
        {
            Customer customer = new Customer();

            if (File.Exists(filepath))
            {

                StreamReader sr = new StreamReader(filepath);
                string line = sr.ReadLine();
                bool found = false;

                while (line != null)
                {
                    /* line = sr.ReadLine();*/
                    string[] fields = line.Split(',');
                    if (fields[2].Equals(lname))
                    {
                        customer.CustomerID = Convert.ToInt32(fields[0]);
                        customer.FirstName = fields[1];
                        customer.LastName = fields[2];
                        customer.PhoneNumber = fields[3];

                        found = true;
                        break;
                    }

                    line = sr.ReadLine();
                }

                sr.Close();

                if (!found)
                {
                    MessageBox.Show("Data not found");

                    customer = null;
                }
            }
            else
            {
                MessageBox.Show("File not found");
            }

            return customer;
        }
        public static Customer SearchRecordphno(string phno)
        {
            Customer customer = new Customer();

            if (File.Exists(filepath))
            {

                StreamReader sr = new StreamReader(filepath);
                string line = sr.ReadLine();
                bool found = false;

                while (line != null)
                {
                    /* line = sr.ReadLine();*/
                    string[] fields = line.Split(',');
                    if (fields[3].Equals(phno))
                    {
                        customer.CustomerID = Convert.ToInt32(fields[0]);
                        customer.FirstName = fields[1];
                        customer.LastName = fields[2];
                        customer.PhoneNumber = fields[3];

                        found = true;
                        break;
                    }

                    line = sr.ReadLine();
                }

                sr.Close();

                if (!found)
                {
                    MessageBox.Show("Data not found");

                    customer = null;
                }
            }
            else
            {
                MessageBox.Show("File not found");
            }

            return customer;
        }
        public static Customer SearchCustomer(string input)
        {
            Customer customer = new Customer();

            return customer;
        }

    }
}