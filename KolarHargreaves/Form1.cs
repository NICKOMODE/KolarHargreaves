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
using KolarHargreaves;

namespace Hudební_umělci
{
    public partial class Form1 : Form
    {
        SqlConnection sqlconnection;
        string connecting;
        List<Rapper> rapperi = new List<Rapper>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//Nick
        {
            connecting = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\kolar\source\repos\KolarHargreaves\databaze\rapperi.mdf; Integrated Security = True; Connect Timeout = 30";
            sqlconnection = new SqlConnection(connecting);

            string sqlquerry = "SELECT * FROM hlavni";

            SqlCommand sqlcommand = new SqlCommand(sqlquerry, sqlconnection);

            sqlconnection.Open();

            SqlDataReader reader = sqlcommand.ExecuteReader();

            while (reader.Read())
            {
                rapperi.Add(new Rapper(reader["prezdivka"].ToString(), reader["narodnost"].ToString(), reader["zanr"].ToString(), Convert.ToBoolean(Convert.ToInt64(reader["nazivu"])), Convert.ToInt32(reader["vek"]), Convert.ToBoolean(Convert.ToInt64(reader["aktivni"])), Convert.ToBoolean(Convert.ToInt64(reader["zenaty"])), reader["pohlavi"].ToString()));
                lbVypis.Items.Add(reader["prezdivka"]);
            }

            sqlconnection.Close();
        }

        private void lbVypis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbVypis.SelectedIndex != -1)
            {
                tbJmeno.Text = rapperi[lbVypis.SelectedIndex].Prezdivka;
                cbNarodnost.Text = rapperi[lbVypis.SelectedIndex].Narodnost;
                cbZanr.Text = rapperi[lbVypis.SelectedIndex].Zanr;
                if(rapperi[lbVypis.SelectedIndex].Nazivu == true)
                {
                    rb_NazivuAno.Checked = true;
                }
                else
                {
                    rb_NazivuNe.Checked = true;
                }
                numVek.Value = rapperi[lbVypis.SelectedIndex].Vek;
                if (rapperi[lbVypis.SelectedIndex].Aktivni == true)
                {
                    cb_AktivniNe.Checked = true;
                }
                else
                {
                    cb_AktivniNe.Checked = false;
                }
                if (rapperi[lbVypis.SelectedIndex].Zenaty == true)
                {
                    cb_zenatyAno.Checked = true;
                }
                else
                {
                    cb_zenatyNe.Checked = true;
                }
                tb_pohlavi.Text = rapperi[lbVypis.SelectedIndex].Pohlavi;
            }
        }
    }
}
