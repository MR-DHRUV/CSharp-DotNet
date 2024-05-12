using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            // Validate if all fields are filled
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(yearsOfExperienceTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(pincodeTextBox.Text) ||
                string.IsNullOrWhiteSpace(countryTextBox.Text) ||
                string.IsNullOrWhiteSpace(stateTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected gender
            string gender = maleRadioButton.Checked ? "Male" : "Female";

            // Get entered data
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string yearsOfExperience = yearsOfExperienceTextBox.Text;
            string address = addressTextBox.Text;
            string pincode = pincodeTextBox.Text;
            string country = countryTextBox.Text;
            string state = stateTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string email = emailTextBox.Text;
            DateTime dob = dobDateTimePicker.Value;

            // Display entered data
            string message = $"First Name: {firstName}\n" +
                             $"Last Name: {lastName}\n" +
                             $"Gender: {gender}\n" +
                             $"Years of Experience: {yearsOfExperience}\n" +
                             $"Date of Birth: {dob.ToShortDateString()}\n" +
                             $"Address: {address}\n" +
                             $"Pincode: {pincode}\n" +
                             $"Country: {country}\n" +
                             $"State: {state}\n" +
                             $"Phone Number: {phoneNumber}\n" +
                             $"Email: {email}";

            MessageBox.Show(message, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
