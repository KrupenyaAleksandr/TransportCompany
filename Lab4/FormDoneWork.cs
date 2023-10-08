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
        private DoneWork _doneWork;
        public DoneWork DoneWork {
            get {  return _doneWork; }
            set
            {
                _doneWork = value;
                driverComboBox.SelectedItem = _doneWork.Driver;
                routeComboBox.SelectedItem = _doneWork.Route;
                startDateTimePicker.Value = _doneWork.StartDate;
                awardNumericUpDown.Value = Convert.ToDecimal(_doneWork.Award);
            }
        }
        private readonly TransportCompany _transportCompany = TransportCompany.Instance;
        public FormDoneWork()
        {
            InitializeComponent();
            _transportCompany.RouteAdded += _transportCompany_RouteAdded;
            _transportCompany.RouteRemoved += _transportCompany_RouteRemoved;
            _transportCompany.DriverAdded += _transportCompany_DriverAdded;
            _transportCompany.DriverRemoved += _transportCompany_DriverRemoved;
            foreach (var driver in _transportCompany.Drivers)
            {
                driverComboBox.Items.Add(driver);
            }
            foreach(var route in _transportCompany.Routes)
            {
                routeComboBox.Items.Add(route);
            }
        }
        private void _transportCompany_RouteAdded(object sender, EventArgs e)
        {
            routeComboBox.Items.Add(sender);
        }
        private void _transportCompany_RouteRemoved(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(sender);
            for (int i = 0; i < routeComboBox.Items.Count; ++i)
            {
                var route = routeComboBox.Items[i] as Route;
                if (route?.RouteId == key)
                {
                    routeComboBox.Items.RemoveAt(i);
                    break;
                }
            }
        }
        private void _transportCompany_DriverAdded(object sender, EventArgs e)
        {
            driverComboBox.Items.Add(sender);
        }
        private void _transportCompany_DriverRemoved(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(sender);
            for (int i = 0; i < driverComboBox.Items.Count; ++i)
            {
                var driver = driverComboBox.Items[i] as Driver;
                if (driver?.DriverId == key)
                {
                    driverComboBox.Items.RemoveAt(i);
                    break;
                }
            }
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
