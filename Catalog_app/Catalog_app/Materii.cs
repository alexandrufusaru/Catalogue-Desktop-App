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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Catalog_app
{
    public partial class Materii : Form
    {
        public Materii()
        {
            InitializeComponent();
        }
        private void Materii_Load(object sender, EventArgs e)
        {
            string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string tabel_date = "select * from Materii";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Materii");
            dataGridView1.DataSource = ds.Tables["Materii"].DefaultView;
            cnn.Close();
        }

        private void btn_acasa_Click(object sender, EventArgs e)
        {
            Acasa f = new Acasa();
            this.Hide();
            f.ShowDialog();
        }

        private void btn_note_Click(object sender, EventArgs e)
        {
            Note f = new Note();
            this.Hide();
            f.ShowDialog();
        }

        private void btn_elevi_Click(object sender, EventArgs e)
        {
            Elevi f = new Elevi();
            this.Hide();
            f.ShowDialog();
        }

        private void btn_delogare_Click(object sender, EventArgs e)
        {
            Logare f = new Logare();
            this.Hide();
            f.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string tabel_date = "select * from Materii";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Materii");
            dataGridView1.DataSource = ds.Tables["Materii"].DefaultView;
            cnn.Close();
        }

        private void btn_adaugare_Click(object sender, EventArgs e)
        {
            if (tB_ID.Text != string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();

                string checkSUbID = "select id_materie from materii where id_materie='" + tB_ID.Text+"'";
                SqlCommand commToCheckSubID = new SqlCommand(checkSUbID, cnn);
                SqlDataAdapter sd = new SqlDataAdapter(commToCheckSubID);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Acest ID exista deja!");
                    tB_ID.Clear();
                }
                else
                {
                    if (tB_prof.Text != string.Empty)
                    {
                        if (tB_nr_ore.Text != string.Empty)
                        {
                            string stmt = "insert into Materii ([ID_materie], [Titlu], [Numar_ore], [Profesor]) values (@id, @titlu, @nr_ore, @prof)";
                            SqlCommand sc = new SqlCommand(stmt, cnn);
                            sc.Parameters.AddWithValue("@id", tB_ID.Text);
                            sc.Parameters.AddWithValue("@titlu", tB_titlu.Text);
                            sc.Parameters.AddWithValue("@nr_ore", tB_nr_ore.Text);
                            sc.Parameters.AddWithValue("@prof", tB_prof.Text);
                            sc.ExecuteNonQuery();
                            cnn.Close();

                            //adaugam si in fisierul txt proful
                            string[] inregistrare = tB_prof.Text.Split(' ');
                            using (StreamWriter w = File.AppendText("utilizatori.txt"))
                            {
                                w.WriteLine(inregistrare[0] + "," + inregistrare[1] + tB_nr_ore.Text);
                            }

                            tB_titlu.Clear();
                            tB_prof.Clear();
                            tB_ID.Clear();
                        }
                        else
                            MessageBox.Show("Nr ore nu sunt bagate!");
                        tB_nr_ore.Clear();
                    }
                    else
                        MessageBox.Show("Nu ati bagat proful!");
                }
            }
            else
                MessageBox.Show("Nu ati introdus ID-ul");
        }

        private void btn_cautare_Click(object sender, EventArgs e)
        {
            if (tB_nr_ore.Text != string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                string tabel_date = "select * from materii where numar_ore=" + tB_nr_ore.Text;
                SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                DataSet ds = new DataSet();
                da.Fill(ds, "Materii");
                dataGridView1.DataSource = ds.Tables["materii"].DefaultView;
                cnn.Close();

                tB_nr_ore.Clear();
            }
            else
                MessageBox.Show("Nu ati bagat numarul de ore!");
        }

        private void btn_editare_Click(object sender, EventArgs e)
        {
            if (tB_ID.Text != string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();

                string checkSUbID = "select id_materie from materii where id_materie='" + tB_ID.Text + "'";
                SqlCommand commToCheckSubID = new SqlCommand(checkSUbID, cnn);
                SqlDataAdapter sd = new SqlDataAdapter(commToCheckSubID);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Acest ID nu exista!");
                else
                {
                    if (tB_titlu.Text != string.Empty && tB_nr_ore.Text != string.Empty && tB_prof.Text != string.Empty)
                    {
                        string tabel_date = "update materii set titlu = '" + tB_titlu.Text + "',numar_ore= " + tB_nr_ore.Text + ", profesor='" + tB_prof.Text + "' where ID_materie ='" + tB_ID.Text + "'";
                        SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "materii");
                        cnn.Close();

                        tB_titlu.Clear();
                        tB_ID.Clear();
                        tB_nr_ore.Clear();
                        tB_prof.Clear();
                    }
                    else
                        MessageBox.Show("Trebuie introduse toate campurile!");
                }
            }
            else
                MessageBox.Show("Nu ati introdus ID");
        }

        private void btn_sortare_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string tabel_date = "select * from materii order by titlu, id_materie";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "materii");
            dataGridView1.DataSource = ds.Tables["materii"].DefaultView;
            cnn.Close();
        }

        private void btn_stergere_Click(object sender, EventArgs e)
        {
            if (tB_ID.Text != string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();

                string checkSUbID = "select id_materie from materii where id_materie='" + tB_ID.Text + "'";
                SqlCommand commToCheckSubID = new SqlCommand(checkSUbID, cnn);
                SqlDataAdapter sd = new SqlDataAdapter(commToCheckSubID);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Acest ID nu exista!");
                else
                {
                    string checkSUbIDinNote = "select id_materie from note where id_materie='" + tB_ID.Text + "'";
                    SqlCommand commToCheckSubIDinNote = new SqlCommand(checkSUbIDinNote, cnn);
                    SqlDataAdapter sD = new SqlDataAdapter(commToCheckSubIDinNote);
                    DataTable dT = new DataTable();
                    sD.Fill(dT);
                    if (dT.Rows.Count > 0)
                        MessageBox.Show("Aceasta materie este notata!Stergeti nota intai");
                    else
                    {
                        string tabel_date = "delete from materii where ID_materie ='" + tB_ID.Text + "'";
                        SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "materii");
                    }
                }
                cnn.Close();
                tB_ID.Clear();
            }
            else
                MessageBox.Show("Nu ati introdus ID");
        }
    }
}
