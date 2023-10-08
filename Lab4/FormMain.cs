using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTransportDelivery;

namespace Lab4
{
    public partial class FormMain : Form
    {
        private readonly TransportCompany _transportCompany = TransportCompany.Instance;
        readonly FormRoute _formRoute = new FormRoute();
        readonly FormDriver _formDriver = new FormDriver();
        readonly FormDoneWork _formDoneWork = new FormDoneWork();
        public FormMain()
        {
            InitializeComponent();
            _transportCompany.RouteAdded += _transportCompany_RouteAdded;
            _transportCompany.RouteRemoved += _transportCompany_RouteRemoved;
            _transportCompany.DriverAdded += _transportCompany_DriverAdded;
            _transportCompany.DriverRemoved += _transportCompany_DriverRemoved;
            _transportCompany.DoneWorkAdded += _transportCompany_DoneWorkAdded;
            _transportCompany.DoneWorkRemoved += _transportCompany_DoneWorkRemoved;
        }

        private void _transportCompany_RouteAdded(object sender, EventArgs e)
        {
            var route = sender as Route;
            if (route != null)
            {
                var listViewItem = new ListViewItem()
                {
                    Tag = route,
                    Text = route.Name.ToString()
                };
                listViewItem.SubItems.Add(route.Distance.ToString());
                listViewItem.SubItems.Add(route.TripTimeInDays.ToString());
                listViewItem.SubItems.Add(route.Payment.ToString());
                routeListView.Items.Add(listViewItem);
            }
        }
        private void _transportCompany_RouteRemoved(object sender, EventArgs e)
        {
            var routeId = Convert.ToInt32(sender);
            for (int i = 0; i <  routeListView.Items.Count; ++i)
            {
                if (((Route)routeListView.Items[i].Tag).RouteId == routeId)
                {
                    routeListView.Items.RemoveAt(i);
                    break;
                }
            }
        }
        private void _transportCompany_DriverAdded(object sender, EventArgs e)
        {
            var driver = sender as Driver;
            if (driver != null)
            {
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
        private void _transportCompany_DriverRemoved(object sender, EventArgs e)
        {
            var driverId = Convert.ToInt32(sender);
            for (int i = 0; i <  driverListView.Items.Count; ++i)
            {
                if (((Driver)driverListView.Items[i].Tag).DriverId == driverId)
                {
                    driverListView.Items.RemoveAt(i);
                    break;
                }
            }
        }
        private void _transportCompany_DoneWorkAdded(object sender, EventArgs e)
        {
            var doneWork = sender as DoneWork;
            if (doneWork != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = doneWork,
                    Text = doneWork.Route.Name.ToString()
                };
                listViewItem.SubItems.Add(doneWork.Driver.ToString());
                listViewItem.SubItems.Add(doneWork.StartDate.ToShortDateString());
                listViewItem.SubItems.Add(doneWork.EndDate.ToShortDateString());
                listViewItem.SubItems.Add(doneWork.Award.ToString());
                doneWorkListView.Items.Add(listViewItem);
            }
        }
        private void _transportCompany_DoneWorkRemoved(object sender, EventArgs e)
        {
            var doneWork = sender as DoneWork;
            for (int i = 0; i < doneWorkListView.Items.Count; ++i)
            {
                if ((DoneWork)doneWorkListView.Items[i].Tag == doneWork)
                {
                    doneWorkListView.Items.RemoveAt(i);
                    break;
                }
            }
        }
        private void toolStripMenuRouteAdd_Click(object sender, EventArgs e)
        {
            var route = new Route();
            _formRoute.Route = route;
            if (_formRoute.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _transportCompany.AddRoute(route);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void toolStripMenuRouteEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var route = routeListView.SelectedItems[0].Tag as Route;
                _formRoute.Route = route;
                if (_formRoute.ShowDialog() == DialogResult.OK) {
                    route = _formRoute.Route;
                    var listViewItem = routeListView.SelectedItems[0];
                    listViewItem.Text = route.Name.ToString();
                    listViewItem.SubItems[1].Text = route.Distance.ToString();
                    listViewItem.SubItems[2].Text = route.TripTimeInDays.ToString();
                    listViewItem.SubItems[3].Text = route.Payment.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с маршрутом");
            }
        }

        private void toolStripMenuDriverAdd_Click(object sender, EventArgs e)
        {
            var driver = new Driver();
            _formDriver.Driver = driver;
            if (_formDriver.ShowDialog() == DialogResult.OK) {
                try
                {
                    _transportCompany.AddDriver(driver);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void toolStripMenuDriverEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var driver = driverListView.SelectedItems[0].Tag as Driver;
                _formDriver.Driver = driver;
                if (_formDriver.ShowDialog() == DialogResult.OK)
                {
                    driver = _formDriver.Driver;
                    var listViewItem = driverListView.SelectedItems[0];
                    listViewItem.Text = driver.LastName.ToString();
                    listViewItem.SubItems[1].Text = driver.FirstName.ToString();
                    listViewItem.SubItems[2].Text = driver.MiddleName.ToString();
                    listViewItem.SubItems[3].Text = driver.Experience.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с водителем");
            }
        }

        private void toolStripMenuDoneWorkAdd_Click(object sender, EventArgs e)
        {
            var doneWork = new DoneWork();
            _formDoneWork.DoneWork = doneWork;
            if (_formDoneWork.ShowDialog() == DialogResult.OK) {
                try
                {
                    _transportCompany.AddDoneWork(doneWork);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void toolStripMenuDoneWorkEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var doneWork = doneWorkListView.SelectedItems[0].Tag as DoneWork;
                _formDoneWork.DoneWork = doneWork;
                if (_formDoneWork.ShowDialog() == DialogResult.OK)
                {
                    doneWork = _formDoneWork.DoneWork;
                    var listViewItem = doneWorkListView.SelectedItems[0];
                    listViewItem.Text = doneWork.Route.Name.ToString();
                    listViewItem.SubItems[1].Text = doneWork.Driver.ToString();
                    listViewItem.SubItems[2].Text = doneWork.StartDate.ToShortDateString();
                    listViewItem.SubItems[3].Text = doneWork.EndDate.ToShortDateString();
                    listViewItem.SubItems[4].Text = doneWork.Award.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с выполненным заказом");
            }
        }
        private void toolStripMenuFileItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void routeListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var route = routeListView.SelectedItems[0].Tag as Route;
                    if (route != null)
                    {
                        _transportCompany.RemoveRoute(route.RouteId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с маршрутом");
                }
            }
        }
        private void driverListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var driver = driverListView.SelectedItems[0].Tag as Driver;
                    if (driver != null)
                    {
                        _transportCompany.RemoveDriver(driver.DriverId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с водителем");
                }
            }
        }
        private void doneWorkListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var doneWork = doneWorkListView.SelectedItems[0].Tag as DoneWork;
                    if (doneWork != null)
                    {
                        _transportCompany.RemoveDoneWork(doneWork);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с выполненным заказом");
                }
            }
        }
    }
}
