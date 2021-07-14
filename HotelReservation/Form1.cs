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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mainEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            hotel.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void guestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guests g = new Guests();
            g.Show();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rooms R = new Rooms();
            R.Show();
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room_Type rt = new Room_Type();
            rt.Show();

        }

        private void bedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beds b = new Beds();
            b.Show();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation res = new Reservation();
            res.Show();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill B = new Bill();
            B.Show();
        }

        private void getBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Get_Room gr = new Get_Room();
            gr.Show();
        }

        private void getBillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Get_Bill gb = new Get_Bill();
            gb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rHotelNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RHotelName hm = new RHotelName();
            hm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Entity me = new Main_Entity();
            me.Show();
        }

        private void queriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Query q = new Query();
            q.Show();
        }
    }
}
