using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCustomerValidation.Validation
{
    public class validation
    {
        public static bool isvalidId(TextBox textInput, int size)
        {
            int tempId = 0;
            if ((textInput.TextLength) != size || (!int.TryParse(textInput.Text, out tempId)))
            {
                MessageBox.Show("Student Id must have 7 number digits!", "Invalid StudentID");
                textInput.Clear();
                textInput.Focus();

                return false;
            }

            return true;
        }

 
        public static bool IsPresent(TextBox txtInput)
        {
           /* if(string.IsNullOrWhiteSpace(txtInput.Text))
            {

                return false;
            }
            return true;
*/
            bool isValid = true;
            for (int i = 0; i < txtInput.TextLength; i++)
            {

                if (char.IsDigit(txtInput.Text[i]) || (char.IsWhiteSpace(txtInput.Text[i])))
                {
                    MessageBox.Show("Please enter valid Name");
                    isValid = false;
                    txtInput.Clear();
                    txtInput.Focus();
                    break;
                }
            }

            return isValid;
        }


        public static bool isvalidnumber(MaskedTextBox textInput, int size)
        {
            if ((textInput.TextLength) != size )
            {
                MessageBox.Show("Mobile Number should be 10 digits!", "Invalid Phone Number");
                textInput.Clear();
                textInput.Focus();

                return false;
            }

            return true;
        }
    }
}
