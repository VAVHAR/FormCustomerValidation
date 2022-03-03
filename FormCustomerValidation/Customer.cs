using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormCustomerValidation.DataAccess;

namespace FormCustomerValidation
{
    public class Customer
    {

        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public void SaveData(Customer customer)
        {
            DataIO.SaveRecord(customer);
        }
        public Customer SearchRecord()
        {
            return DataIO.SearchRecord();

        }

        public Customer SearchCustomerID(int CustomerId)
        {
            return DataIO.SearchRecordCusId(CustomerId);

        }
        public Customer SearchFirstName(string FirstName)
        {
            return DataIO.SearchRecordfname(FirstName);
        }

        public Customer SearchLastName(string Lastname)
        {
            return DataIO.SearchRecordlname(LastName);
        }

        public Customer SearchPhoneNumber(string PhoneNumber)
        {
            return DataIO.SearchRecordphno(PhoneNumber);
        }

    }
}
