using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RHotelName rhn = new RHotelName();
            rhn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RGuestsReserv rgr = new RGuestsReserv();
            rgr.Show();
        }
    }
}
