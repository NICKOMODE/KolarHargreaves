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
using System.IO;

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
                rapperi.Add(new Rapper(Convert.ToInt32(reader["Id"]), reader["prezdivka"].ToString(), Convert.ToInt32(reader["narodnost"]), Convert.ToInt32(reader["zanr"]), Convert.ToBoolean(Convert.ToInt64(reader["nazivu"])), Convert.ToInt32(reader["vek"]), Convert.ToBoolean(Convert.ToInt64(reader["aktivni"])), Convert.ToBoolean(Convert.ToInt64(reader["zenaty"])), reader["pohlavi"].ToString()));
                lbVypis.Items.Add(reader["prezdivka"]);
            }

            sqlconnection.Close();
        }

        private void lbVypis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbVypis.SelectedIndex != -1)
            {
                tbJmeno.Text = rapperi[lbVypis.SelectedIndex].Prezdivka;
                cbNarodnost.SelectedIndex = rapperi[lbVypis.SelectedIndex].Narodnost;
                cbZanr.SelectedIndex = rapperi[lbVypis.SelectedIndex].Zanr;
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

        private void btEditovat_Click(object sender, EventArgs e)
        {
            //David
            int nazivu;
            int aktivni;
            int zenaty;
            if(rb_NazivuAno.Checked == true)
            {
                nazivu = 1;
            }
            else
            {
                nazivu = 0;
            }

            if (cb_AktivniNe.Checked == true)
            {
                aktivni = 1;
            }
            else
            {
                aktivni = 0;
            }

            if (cb_zenatyAno.Checked == true)
            {
                zenaty = 1;
            }
            else
            {
                zenaty = 0;
            }
            string command = $"UPDATE hlavni SET prezdivka = '{tbJmeno.Text}', narodnost = '{cbNarodnost.SelectedIndex +1}', zanr = '{cbZanr.SelectedIndex +1}', nazivu = '{nazivu}', vek = '{numVek.Value}', aktivni = '{aktivni}', zenaty = '{zenaty}', pohlavi = '{tb_pohlavi.Text}' WHERE Id = '{rapperi[lbVypis.SelectedIndex].ID}'";

            sqlconnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlconnection);
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
        }

        private void bt_ulozit_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string radky = "Přezdívka;Národnost;Žánr;Naživu;Věk;Aktivní;Ženatý;Pohlaví;" + Environment.NewLine;
                for (int i = 0; i < rapperi.Count; i++)
                {
                    radky += rapperi[i].Prezdivka + ";" + rapperi[i].Narodnost + ";" + rapperi[i].Zanr + ";" + rapperi[i].Nazivu + ";" + rapperi[i].Vek + ";" + rapperi[i].Aktivni + ";" + rapperi[i].Zenaty + ";" + rapperi[i].Pohlavi + ";" + Environment.NewLine;
                }

                File.WriteAllText(saveFileDialog.FileName, radky);
            }
        }
    }
}
