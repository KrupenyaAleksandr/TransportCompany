using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTransportDelivery;

namespace Lab4
{
    public partial class FormDoneWork : Form
    {
        public DoneWork DoneWork { get; }
        public FormDoneWork(DoneWork doneWork)
        {
            InitializeComponent();
            DoneWork = doneWork;
            foreach(var item in TransportCompany.Drivers)
            {
                var driver = item.Value;
                driverComboBox.Items.Add(driver);
            }
            foreach(var item in TransportCompany.Routes)
            {
                var route = item.Value;
                routeComboBox.Items.Add(route);
            }
            driverComboBox.SelectedItem = doneWork.Driver;
            routeComboBox.SelectedItem = doneWork.Route;
            startDateTimePicker.Value = doneWork.StartDate;
            awardNumericUpDown.Value = Convert.ToDecimal(doneWork.Award);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DoneWork.Driver = driverComboBox.SelectedItem as Driver;
            DoneWork.Route = routeComboBox.SelectedItem as Route;
            if (startDateTimePicker.Value >= DateTime.Now) {
                DoneWork.StartDate = startDateTimePicker.Value;
                DoneWork.EndDate = DoneWork.StartDate.AddDays(Convert.ToDouble(DoneWork.Route.TripTimeInDays));
                DoneWork.Award = Convert.ToDouble(awardNumericUpDown.Value);
                DialogResult = DialogResult.OK;
            }
        }

    }
}
