using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTransportDelivery;

namespace WindowsFormsControlLibraryTransportCompany
{
    public partial class UserControlDoneWork: UserControl
    {
        private readonly TransportCompany _transportCompany = TransportCompany.Instance;
        public DoneWork DoneWork { get; }
        private bool _selected;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if (value)
                {
                    var controls = Parent?.Controls;
                    if (controls != null)
                    {
                        foreach (var control in controls )
                        {
                            if (!(control is UserControlDoneWork)) continue;
                            var userControlDoneWork = control as UserControlDoneWork;
                            if (userControlDoneWork != this)
                            {
                                userControlDoneWork.Selected = false;
                            }
                        }
                    }
                }
                _selected = value;
                Refresh();
            }
        }
        public UserControlDoneWork(DoneWork doneWork)
        {
            InitializeComponent();
            DoneWork = doneWork;
        }
        private void UserControlDoneWork_Paint(object sender, PaintEventArgs e)
        {
            routeTextBox.Text = DoneWork.Route.Name.ToString();
            driverTextBox.Text = DoneWork.Driver.ToString();
            dateTextBox.Text = $@"{DoneWork.StartDate: dd MMMM yyyy} - {DoneWork.EndDate: dd MMMM yyyy}";
            if (DoneWork.EndDate < DateTime.Today)
            {
                dateTextBox.BackColor = Color.Green;
            }
            else
            {
                dateTextBox.BackColor = DoneWork.StartDate < DateTime.Today ? Color.Yellow : Color.Red;
            }
            awardTextBox.Text = DoneWork.Award.ToString();
            BackColor = _selected ? Color.CornflowerBlue : DefaultBackColor;
        }

        private void UserControlDoneWork_Click(object sender, EventArgs e)
        {
            Selected = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _transportCompany.RemoveDoneWork(DoneWork);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись о выполненном заказе");
            }
        }
    }
}
