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
            if (fromTextBox.Text != "")
            {
                Route.Name.From = fromTextBox.Text;
                if (toTextBox.Text != "")
                {
                    Route.Name.To = toTextBox.Text;
                    if (int.TryParse(distanceTextBox.Text, out int dist))
                    {
                        Route.Distance = dist;
                        if (int.TryParse(tripTimeTextBox.Text, out int tripTime))
                        {
                            Route.TripTimeInDays = tripTime;
                            if (double.TryParse(paymentTextBox.Text, out double pay))
                            {
                                Route.Payment = pay;
                                DialogResult = DialogResult.OK;
                            }
                        }
                    }
                }
            }
        }
    }
}
