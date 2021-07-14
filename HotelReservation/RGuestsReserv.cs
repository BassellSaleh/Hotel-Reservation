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
    public partial class RGuestsReserv : Form
    {
        public RGuestsReserv()
        {
            InitializeComponent();
        }

        private void RGuestsReserv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HotelReservationDataSet.Guests' table. You can move, or remove it, as needed.
            this.guestsTableAdapter.Fill(this.HotelReservationDataSet.Guests);
            // TODO: This line of code loads data into the 'HotelReservationDataSet.RGuestsReserv' table. You can move, or remove it, as needed.

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.RGuestsReservTableAdapter.Fill(this.HotelReservationDataSet.RGuestsReserv);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
