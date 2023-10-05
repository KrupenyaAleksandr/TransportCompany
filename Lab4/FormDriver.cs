using ClassLibraryTransportDelivery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class FormDriver : Form
    {
        public Driver Driver { get; }
        public FormDriver(Driver driver)
        {
            InitializeComponent();
            Driver = driver;
            lastNameTextBox.Text = Driver.LastName;
            firstNameTextBox.Text = Driver.FirstName;
            middleNameTextBox.Text = Driver.MiddleName;
            experienceNumericUpDown.Value = Driver.Experience;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text != "")
            {
                Driver.LastName = lastNameTextBox.Text;
                if (firstNameTextBox.Text != "")
                {
                    Driver.FirstName = firstNameTextBox.Text;
                    if (middleNameTextBox.Text != "")
                    {
                        Driver.MiddleName = middleNameTextBox.Text;
                        Driver.Experience = Convert.ToInt32(experienceNumericUpDown.Value);
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}
