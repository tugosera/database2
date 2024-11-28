using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database2
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=database01;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        //use database01

        //create table tooded(
        //ID int primary key identity(1,1),
        //nimetus varchar(50),
        //kogus int,
        //hind float);

        SqlCommand command;
        SqlDataAdapter adapter;
        int currentMouseOverRow;
        ContextMenu contextMenu = new ContextMenu(
        new MenuItem[] { new MenuItem("Kustuta") }
        );
        byte[] bytes;
        MemoryStream ms;

        private void lisa_btn_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand("INSERT INTO tooded(nimetus, kogus, hind) VALUES (@nimetus, @kogus, @hind)", connection);
            command.Parameters.AddWithValue("@nimetus", Nimetus.Text);
            command.Parameters.AddWithValue("@kogus", Kogus.Text);
            command.Parameters.AddWithValue("@hind", Hind.Text);
            command.ExecuteNonQuery();

            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database01DataSet.tooded' table. You can move, or remove it, as needed.
            toodedTableAdapter.Fill(database01DataSet.tooded);

        }
    }
}
