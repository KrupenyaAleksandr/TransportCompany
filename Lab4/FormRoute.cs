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
            distanceNumericUpDown.Value = Route.Distance;
            tripTimeNumericUpDown.Value = Route.TripTimeInDays;
            paymentNumericUpDown.Value = Convert.ToDecimal(Route.Payment);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (fromTextBox.Text != "")
            {
                Route.Name.From = fromTextBox.Text;
                if (toTextBox.Text != "")
                {
                    Route.Name.To = toTextBox.Text;
                    Route.Distance = Convert.ToInt32(distanceNumericUpDown.Value);
                    Route.TripTimeInDays = Convert.ToInt32(tripTimeNumericUpDown.Value);
                    Route.Payment = Convert.ToDouble(paymentNumericUpDown.Value);
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
