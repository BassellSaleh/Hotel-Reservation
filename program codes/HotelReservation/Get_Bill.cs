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
    public partial class Get_Bill : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P1UILE2;Initial Catalog=HotelReservation;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmd;


        public Get_Bill()
        {
            InitializeComponent();

            Da = new SqlDataAdapter("Select F_name, Amount from Guests,Bill Where Bill.G_id = Guests.Acc_Number and Amount = '30000' ", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("Passed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
