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
    public partial class Main_Entity : Form
    {
        public Main_Entity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            hotel.Show();
        }

        private void Main_Entity_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guests g = new Guests();
            g.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rooms R = new Rooms();
            R.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Room_Type rt = new Room_Type();
            rt.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Beds b = new Beds();
            b.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reservation res = new Reservation();
            res.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bill B = new Bill();
            B.Show();
        }
    }
}
