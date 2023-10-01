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
    public partial class FormRoute : Form
    {
        public Route Route { get; }
        public FormRoute(Route route)
        {
            InitializeComponent();
            Route = route;
            fromTextBox.Text = Route.Name.From;
            toTextBox.Text = Route.Name.To;
            distanceTextBox.Text = Route.Distance.ToString();
            tripTimeTextBox.Text = Route.TripTimeInDays.ToString();
            paymentTextBox.Text = Route.Payment.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Route.Name.From = fromTextBox.Text;
            Route.Name.To = toTextBox.Text;
            Route.Distance = Convert.ToInt32(distanceTextBox.Text); //сколько это???????потом узнаю
            Route.TripTimeInDays = Convert.ToInt32(tripTimeTextBox.Text);
            Route.Payment = Convert.ToDouble(paymentTextBox.Text);
        }
    }
}
