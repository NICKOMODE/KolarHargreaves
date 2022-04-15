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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Nick
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
            //Nick
            if(lbVypis.SelectedIndex != -1)
            {
                btFiltrovats.Enabled = true;
                btEditovat.Enabled = true;
                btPridat.Enabled = true;    
                btSmazat.Enabled = true;     
                bt_ulozit.Enabled = true;
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
            if (tbJmeno.Text.Length > 3 && cbNarodnost.SelectedIndex != -1 && cbZanr.SelectedIndex != -1)
            {
                int nazivu;
                int aktivni;
                int zenaty;
                if (rb_NazivuAno.Checked == true)
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
                string command = $"UPDATE hlavni SET prezdivka = '{tbJmeno.Text}', narodnost = '{cbNarodnost.SelectedIndex + 1}', zanr = '{cbZanr.SelectedIndex + 1}', nazivu = '{nazivu}', vek = '{numVek.Value}', aktivni = '{aktivni}', zenaty = '{zenaty}', pohlavi = '{tb_pohlavi.Text}' WHERE Id = '{rapperi[lbVypis.SelectedIndex].ID}'";

                sqlconnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlconnection);
                sqlCommand.ExecuteNonQuery();
                sqlconnection.Close();
            }
            else
            {
                MessageBox.Show("Vyplňte všechna validní data - Přezdívka, národnost a žánr");
            }
        }

        private void bt_ulozit_Click(object sender, EventArgs e)
        {
            //Nick
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

        private void btPridat_Click(object sender, EventArgs e)
        {
            //David
            if(tbJmeno.Text.Length > 3 && cbNarodnost.SelectedIndex != -1 && cbZanr.SelectedIndex != -1)
            {
                int nazivu;
                int aktivni;
                int zenaty;
                if (rb_NazivuAno.Checked == true)
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
                string command = $"INSERT INTO hlavni (prezdivka, narodnost, zanr, nazivu, vek, aktivni, zenaty, Pohlavi) VALUES ('{tbJmeno.Text}','{cbNarodnost.SelectedIndex + 1}','{cbZanr.SelectedIndex + 1}','{nazivu}','{numVek.Value}','{aktivni}','{zenaty}','{tb_pohlavi.Text}')";

                sqlconnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlconnection);
                sqlCommand.ExecuteNonQuery();
                sqlconnection.Close();
            }  
            else
            {
                MessageBox.Show("Vyplňte všechna validní data - Přezdívka, národnost a žánr");
            }
        }

        private void btSmazat_Click(object sender, EventArgs e)
        {
            //David
                string command = $"DELETE FROM hlavni WHERE Id='{rapperi[lbVypis.SelectedIndex].ID}'";

                sqlconnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlconnection);
                sqlCommand.ExecuteNonQuery();
                sqlconnection.Close();
        }

        private void cb_zanrnavic_CheckedChanged(object sender, EventArgs e)
        {
            //Nick
            lbVypis.Items.Clear();
            for (int i = 0; i < rapperi.Count; i++)
            {
                lbVypis.Items.Add(rapperi[i].Prezdivka + " " + cbZanr.Items[rapperi[i].Zanr]);
            }
        }

        private void rb_editace_CheckedChanged(object sender, EventArgs e)
        {
            lbVypis.Items.Clear();
            for (int i = 0; i < rapperi.Count; i++)
            {
                lbVypis.Items.Add(rapperi[i].Prezdivka);
            }
            if (rb_editace.Checked == true)
            {
                rb_NazivuAno.Enabled = true;
                rb_NazivuNe.Enabled = true;
                cb_zenatyAno.Enabled = true;
                cb_zenatyNe.Enabled = true;
                tb_pohlavi.Enabled = true;
                tbJmeno.Enabled = true;
            }
        }

        private void rb_filtrace_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_filtrace.Checked == true)
            {
                rb_NazivuAno.Enabled = false;
                rb_NazivuNe.Enabled = false;    
                cb_zenatyAno.Enabled = false;
                cb_zenatyNe.Enabled = false;
                tb_pohlavi.Enabled = false;
                tbJmeno.Enabled = false;
            }
        }

        private void cbNarodnost_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrace();
        }

        private void cbZanr_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrace();
        }

        private void cbVek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrace();
        }

        private void cb_AktivniNe_CheckedChanged(object sender, EventArgs e)
        {
            Filtrace();
        }

        private void Filtrace()
        {
            if(rb_filtrace.Checked == true)
            {
                List<Rapper> filtraceRapperu = new List<Rapper>();

                lbVypis.Items.Clear();

                for (int i = 0; i < rapperi.Count; i++)
                {
                    filtraceRapperu.Add(rapperi[i]);
                }

                if (cbNarodnost.SelectedIndex != -1)
                {
                    for (int i = 0; i < filtraceRapperu.Count; i++)
                    {
                        if (cbNarodnost.SelectedIndex != filtraceRapperu[i].Narodnost)
                        {
                            filtraceRapperu.RemoveAt(i);
                            i--;
                        }
                    }
                }

                if (cbZanr.SelectedIndex != -1)
                {
                    for (int i = 0; i < filtraceRapperu.Count; i++)
                    {
                        if (cbZanr.SelectedIndex != filtraceRapperu[i].Zanr)
                        {
                            filtraceRapperu.RemoveAt(i);
                            i--;
                        }
                    }
                }

                if (cbVek.SelectedIndex != -1)
                {
                    for (int i = 0; i < filtraceRapperu.Count; i++)
                    {
                        switch (cbVek.SelectedIndex)
                        {
                            case 0:
                                {
                                    if (filtraceRapperu[i].Vek != numVek.Value)
                                    {
                                        filtraceRapperu.RemoveAt(i);
                                        i--;
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if (filtraceRapperu[i].Vek > numVek.Value)
                                    {
                                        filtraceRapperu.RemoveAt(i);
                                        i--;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if (filtraceRapperu[i].Vek < numVek.Value)
                                    {
                                        filtraceRapperu.RemoveAt(i);
                                        i--;
                                    }
                                    break;
                                }
                        }
                    }
                }

                for (int i = 0; i < filtraceRapperu.Count; i++)
                {
                    if (cb_AktivniNe.Checked != filtraceRapperu[i].Nazivu)
                    {
                        filtraceRapperu.RemoveAt(i);
                        i--;
                    }
                }

                for (int i = 0; i < filtraceRapperu.Count; i++)
                {
                    lbVypis.Items.Add(filtraceRapperu[i].Prezdivka);
                }
            }
        }
    }
}
