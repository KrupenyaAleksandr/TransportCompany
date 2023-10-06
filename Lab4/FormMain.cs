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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuRouteAdd_Click(object sender, EventArgs e)
        {
            var route = new Route();
            FormRoute formRoute = new FormRoute(route);
            if (formRoute.ShowDialog() == DialogResult.OK) {
                route = formRoute.Route;
            }
            TransportCompany.Routes.Add(route.RouteId, route);
            UpdateRoutesList();
        }

        private void toolStripMenuRouteEdit_Click(object sender, EventArgs e)
        {
            if (routeListView.SelectedItems.Count > 0) {
                var route = routeListView.SelectedItems[0].Tag as Route;
                FormRoute formRoute = new FormRoute(route);
                if (formRoute.ShowDialog() == DialogResult.OK)
                {
                    UpdateRoutesList();
                }
            }
        }

        private void UpdateRoutesList()
        {
            routeListView.Items.Clear();
            foreach(var item in TransportCompany.Routes)
            {
                var route = item.Value;
                var listViewItem = new ListViewItem() {
                    Tag = route,
                    Text = route.Name.ToString()
                };
                listViewItem.SubItems.Add(route.Distance.ToString());
                listViewItem.SubItems.Add(route.TripTimeInDays.ToString());
                listViewItem.SubItems.Add(route.Payment.ToString());
                routeListView.Items.Add(listViewItem);
            }
        }

        private void toolStripMenuDriverAdd_Click(object sender, EventArgs e)
        {
            var driver = new Driver();
            FormDriver formDriver = new FormDriver(driver);
            if (formDriver.ShowDialog() == DialogResult.OK) {
                driver = formDriver.Driver;
            }
            TransportCompany.Drivers.Add(driver.DriverId, driver);
            UpdateDriversList();
        }

        private void toolStripMenuDriverEdit_Click(object sender, EventArgs e)
        {
            if (driverListView.SelectedItems.Count > 0) {
                var driver = driverListView.SelectedItems[0].Tag as Driver;
                FormDriver formDriver = new FormDriver(driver);
                if (formDriver.ShowDialog() == DialogResult.OK)
                {
                    UpdateDriversList();
                }
            }
        }
        private void UpdateDriversList()
        {
            driverListView.Items.Clear();
            foreach (var item in TransportCompany.Drivers)
            {
                var driver = item.Value;
                var listViewItem = new ListViewItem()
                {
                    Tag = driver,
                    Text = driver.LastName.ToString()
                };
                listViewItem.SubItems.Add(driver.FirstName.ToString());
                listViewItem.SubItems.Add(driver.MiddleName.ToString());
                listViewItem.SubItems.Add(driver.Experience.ToString());
                driverListView.Items.Add(listViewItem);
            }
        }

        private void toolStripMenuDoneWorkAdd_Click(object sender, EventArgs e)
        {
            var donework = new DoneWork();
            FormDoneWork formDoneWork = new FormDoneWork(donework);
            if (formDoneWork.ShowDialog() == DialogResult.OK) {
                TransportCompany.DoneWorks.Add(donework);
                UpdateDoneWorks();
            }
        }

        private void toolStripMenuDoneWorkEdit_Click(object sender, EventArgs e)
        {
            if (doneWorkListView.SelectedItems.Count > 0) {
                var donework = doneWorkListView.SelectedItems[0].Tag as DoneWork;
                FormDoneWork formDoneWork = new FormDoneWork(donework);
                if (formDoneWork.ShowDialog() == DialogResult.OK)
                {
                    UpdateDoneWorks();
                }
            }
        }

        private void UpdateDoneWorks()
        {
            doneWorkListView.Items.Clear();
            string tmp = "";
            foreach (var donework in TransportCompany.DoneWorks)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = donework,
                    Text = donework.Route.Name.ToString()
                };
                listViewItem.SubItems.Add(donework.Driver.ToString());
                listViewItem.SubItems.Add(donework.StartDate.ToShortDateString());
                listViewItem.SubItems.Add(donework.EndDate.ToShortDateString());
                listViewItem.SubItems.Add(donework.Award.ToString());
                doneWorkListView.Items.Add(listViewItem);
            }
        }
    }
}
