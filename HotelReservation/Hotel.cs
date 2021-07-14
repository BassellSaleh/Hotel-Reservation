using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelReservation
{
    public partial class Hotel : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P1UILE2;Initial Catalog=HotelReservation;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmd;


        public Hotel()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("Select * from Hotel", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelReservationDataSet.Hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter.Fill(this.hotelReservationDataSet.Hotel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("Passed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
