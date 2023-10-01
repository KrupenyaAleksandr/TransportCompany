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
        private Route route;
        private Driver driver;
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuRouteAdd_Click(object sender, EventArgs e)
        {
            route = new Route();
            FormRoute formRoute = new FormRoute(route);
            if (formRoute.ShowDialog() == DialogResult.OK) {
                route = formRoute.Route;
            }
        }

        private void toolStripMenuRouteEdit_Click(object sender, EventArgs e)
        {
            FormRoute formRoute = new FormRoute(route);
            if (formRoute.ShowDialog() == DialogResult.OK)
            {
                route = formRoute.Route;
            }
        }

        private void toolStripMenuDriverAdd_Click(object sender, EventArgs e)
        {
            driver = new Driver();
            FormDriver formDriver = new FormDriver(driver);
            if (formDriver.ShowDialog() == DialogResult.OK)
            {
                driver = formDriver.Driver;
            }
        }

        private void toolStripMenuDriverEdit_Click(object sender, EventArgs e)
        {
            FormDriver formDriver = new FormDriver(driver);
            if (formDriver.ShowDialog() == DialogResult.OK)
            {
                driver = formDriver.Driver;
            }
        }
    }
}
