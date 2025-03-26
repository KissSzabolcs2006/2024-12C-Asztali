using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySQLUsersElo
{
    public partial class Form1 : Form
    {
        private MySqlConnection msqlConn;
        private MySqlConnection msqlDr;

        private string openSikeres = "A kapcsolódás az adatbázishoz sikeres",
            openNemSikeres = "A kapcsolódás sikertelen!",
            canToRead = "Az olvasás megkezdődött",
            closeDB = "Az adatbázis bezárva";

        private enum FormState
        {
            Closed,
            Opened,
            Reading,
            EditInsert,
            EditUpdate,
        }
        private FormState formState=FormState.Closed;

        private string insBasic = "Beszúrás";
        private string insEdit = "Beszúrás vége";
        private string updBasic = "Módosítás";
        private string updEdit = "Módosítás vége";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            msqlConn.Close();
            MessageBox.Show(closeDB);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlConnect();
        }

        private void mysqlConnect()
        {
            MySqlConnectionStringBuilder sb=new
                MySqlConnectionStringBuilder();
            sb.Server="localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "iktat";

            try
            {
                msqlConn = new MySqlConnection(sb.ToString());
                msqlConn.Open();
                MessageBox.Show(openSikeres);

                formState = FormState.Opened;
                /*buttonSwich(formState);*/
            }
            catch (Exception ex) { 
                MessageBox.Show($"{openNemSikeres} \n { ex.Message}");
            }
        }
    }
}
