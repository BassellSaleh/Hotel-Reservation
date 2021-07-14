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
    public partial class Bill : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P1UILE2;Initial Catalog=HotelReservation;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmd;

        public Bill()
        {
            InitializeComponent();

            Da = new SqlDataAdapter("select * from Bill", con);
            Da.Fill(Dt);
            dataGridView9.DataSource = Dt;

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelReservationDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.hotelReservationDataSet.Bill);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("Passed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
