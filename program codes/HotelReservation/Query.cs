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
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Get_Room gr = new Get_Room();
            gr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Get_Bill gb = new Get_Bill();
            gb.Show();
        }
    }
}
