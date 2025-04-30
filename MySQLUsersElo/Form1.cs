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
        private string userTeljesLista = "userTeljesLista";
        private string userInsert = "userInsert";
        private string userUpdate = "userUpdate";
        private string userDelete = "userDelete";

        private MySqlConnection msqlConn;
        private MySqlDataReader msqlDr;

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

        private void buttonSwitch(FormState fs)
        {
            switch (fs)
            {
                case FormState.Closed:
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    btnClose.Enabled = false;
                    break;
                case FormState.Opened:
                    button1.Enabled = false;
                    button2.Enabled = true;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    btnClose.Enabled = false;

                    tbxID.Enabled = false;
                    tbxNev.Enabled = false;
                    tbxJelszo.Enabled = false;
                    tbxAdmin.Enabled = false;

                    button4.Text = insBasic;
                    button5.Text = updBasic;
                    break;
                case FormState.Reading:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    btnClose.Enabled = true;
                    break;
                case FormState.EditInsert:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = true;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    btnClose.Enabled = true;

                    tbxNev.Enabled = true;
                    tbxJelszo.Enabled = true;
                    tbxAdmin.Enabled = true;

                    tbxNev.Text=string.Empty;
                    tbxJelszo.Text=string.Empty;
                    tbxAdmin.Checked=false;

                    button4.Text = insEdit;
                    break;

                case FormState.EditUpdate:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = true;
                    button6.Enabled = false;
                    btnClose.Enabled = true;

                    tbxNev.Enabled = true;
                    tbxJelszo.Enabled=true;
                    tbxAdmin.Enabled = true;

                    button5.Text = updEdit;
                    break;
            }
        }
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(userTeljesLista, msqlConn))
            {
                sqlComm.CommandType=CommandType.StoredProcedure;

                try
                {
                    msqlDr = sqlComm.ExecuteReader();

                    MessageBox.Show(canToRead);

                    formState = FormState.Reading;
                    buttonSwitch(formState);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NextUser();
        }

        private void NextUser()
        {
            msqlDr.Read();
            tbxID.Text = msqlDr[0].ToString().Trim();
            tbxNev.Text=msqlDr[1].ToString().Trim();
            tbxJelszo.Text=msqlDr[2].ToString().Trim();
            tbxAdmin.Checked = (bool)msqlDr[3];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Opened:
                    formState = FormState.EditInsert;
                    buttonSwitch(formState);
                    break;
                case FormState.Reading:
                    msqlDr.Close();
                    formState = FormState.EditInsert;
                    buttonSwitch(formState);
                    break;
                case FormState.EditInsert:
                    InsertUser(tbxNev.Text, tbxJelszo.Text, tbxAdmin.Checked ? 1 : 0);
                    formState = FormState.Opened;
                    buttonSwitch(formState);
                    break;
            }
        }

        private void InsertUser(string pNev, string pJelszo, int pAdmin)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(userInsert, msqlConn))
            {
                sqlComm.CommandType=CommandType.StoredProcedure;

                MySqlParameter p = new MySqlParameter();
                p.ParameterName = "pNev";
                p.Value = pNev;
                p.MySqlDbType = MySqlDbType.String;
                sqlComm.Parameters.Add(p);

                sqlComm.Parameters.AddWithValue("pJelszo", pJelszo);
                sqlComm.Parameters.AddWithValue("pAdmin", pAdmin);

                try
                {
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("A rekord felvéve.");
                }
                catch (Exception ex) { 
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Opened:
                    formState = FormState.EditUpdate;
                    buttonSwitch(formState);
                    break;
                case FormState.Reading:
                    msqlDr.Close();
                    formState = FormState.EditUpdate;
                    buttonSwitch(formState);
                    break;
                case FormState.EditUpdate:
                    UpdateUser(Convert.ToInt32(tbxID.Text), tbxNev.Text, tbxJelszo.Text, (tbxAdmin.Checked) ? 1 : 0);
                    formState = FormState.Opened;
                    buttonSwitch(formState);
                    break;
            }
        }

        private void UpdateUser(int pID, string pNev, string pJelszo, int pAdmin)
        {
            using (MySqlCommand sqlComm = new MySqlCommand())
            {
                sqlComm.CommandType=CommandType.StoredProcedure;
                sqlComm.Parameters.AddWithValue("ID", pID);

                MySqlParameter p = new MySqlParameter();
                p.ParameterName = "Nev";
                p.Value = pNev;
                p.MySqlDbType= MySqlDbType.String;
                sqlComm.Parameters.Add(p);

                sqlComm.Parameters.AddWithValue("Jelszo", pJelszo);
                sqlComm.Parameters.AddWithValue("Admin", pAdmin);

                try
                {
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("A rekord módosítása sikeres");
                }
                catch(Exception ex) { 
                    MessageBox.Show(ex.Message);
                }
            }
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
