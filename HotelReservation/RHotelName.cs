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
    public partial class RHotelName : Form
    {
        public RHotelName()
        {
            InitializeComponent();
        }

        private void RHotelName_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HotelReservationDataSet.Hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter.Fill(this.HotelReservationDataSet.Hotel);
            // TODO: This line of code loads data into the 'HotelReservationDataSet.RbyHotelName' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RbyHotelNameTableAdapter.Fill(this.HotelReservationDataSet.RbyHotelName,comboBox1.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
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
