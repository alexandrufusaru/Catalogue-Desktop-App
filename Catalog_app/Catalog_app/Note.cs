using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog_app
{
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }
        private void Note_Load(object sender, EventArgs e)
        {
            string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string tabel_date = "select * from note";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "note");
            dataGridView1.DataSource = ds.Tables["note"].DefaultView;
            cnn.Close();
        }

        private void btn_acasa_Click(object sender, EventArgs e)
        {
            Acasa f=new Acasa();
            this.Hide();
            f.ShowDialog();
        }
        private void btn_materii_Click(object sender, EventArgs e)
        {
            Materii f = new Materii();
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
            string tabel_date = "select * from note";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "note");
            dataGridView1.DataSource = ds.Tables["note"].DefaultView;
            cnn.Close();
        }

        private void btn_adaugare_Click(object sender, EventArgs e)
        {
            if (tB_ID_materie.Text != string.Empty && tB_ID_elev.Text !=string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                
                string checkStudID = "select id_elev from Elevi where id_elev=" + tB_ID_elev.Text;
                SqlCommand commToCheckStuID = new SqlCommand(checkStudID, cnn);
                SqlDataAdapter sd = new SqlDataAdapter(commToCheckStuID);
                DataTable dtStuID = new DataTable();
                sd.Fill(dtStuID);
                if (dtStuID.Rows.Count == 0)
                {
                    MessageBox.Show("Acest ID de elev nu exista!");
                    tB_ID_elev.Clear();
                }
                else
                {
                    string checkSubID = "select id_materie from materii where id_materie='" + tB_ID_materie.Text + "'";
                    SqlCommand commToCheckSubID = new SqlCommand(checkSubID, cnn);
                    SqlDataAdapter SD = new SqlDataAdapter(commToCheckSubID);
                    DataTable DT = new DataTable();
                    SD.Fill(DT);
                    if (DT.Rows.Count == 0)
                    {
                        MessageBox.Show("Acest ID de materie nu exista!");
                        tB_ID_materie.Clear();
                    }
                    else
                    {
                        if (tB_nota.Text != string.Empty && tB_data.Text != string.Empty)
                        {
                            string stmt = "insert into note ([ID_elev], [ID_materie], [nota], [data]) values (@ide, @idm, @nota, @data)";
                            SqlCommand sc = new SqlCommand(stmt, cnn);
                            sc.Parameters.AddWithValue("@ide", tB_ID_elev.Text);
                            sc.Parameters.AddWithValue("@idm", tB_ID_materie.Text);
                            sc.Parameters.AddWithValue("@nota", tB_nota.Text);
                            sc.Parameters.AddWithValue("@data", DateTime.Parse(tB_data.Text));
                            sc.ExecuteNonQuery();
                            cnn.Close();

                            tB_ID_elev.Clear();
                            tB_ID_materie.Clear();
                            tB_nota.Clear();
                            tB_data.Clear();
                        }
                        else
                            MessageBox.Show("Trebuie completate toate campurile");
                    }
                }
            }
            else
                MessageBox.Show("Nu ati introdus ID-ul");
         }
        

        private void btn_cautare_Click(object sender, EventArgs e)
        {
            if (tB_ID_materie.Text != string.Empty && tB_nota.Text!=string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();

                string checkSubID = "select id_materie from materii where id_materie='" + tB_ID_materie.Text + "'";
                SqlCommand commToCheckSubID = new SqlCommand(checkSubID, cnn);
                SqlDataAdapter SD = new SqlDataAdapter(commToCheckSubID);
                DataTable DT = new DataTable();
                SD.Fill(DT);
                if (DT.Rows.Count == 0)
                {
                    MessageBox.Show("Acest ID de materie nu exista!");
                    tB_ID_materie.Clear();
                }
                else
                {
                    string tabel_date = "select * from note where id_materie='" + tB_ID_materie.Text + "' and nota=" + tB_nota.Text;
                    SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "note");
                    dataGridView1.DataSource = ds.Tables["note"].DefaultView;
                    cnn.Close();

                    tB_ID_materie.Clear();
                    tB_nota.Clear();
                }
            }
            else
                MessageBox.Show("Nu ati bagat id materie/nota!");
        }

        private void btn_editare_Click(object sender, EventArgs e)
        {
            if (tB_ID_materie.Text != string.Empty && tB_ID_elev.Text!=string.Empty && tB_data.Text!=string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();

                string checkSubID = "select id_elev, id_materie, data from note where id_materie='" + tB_ID_materie.Text + "' AND id_elev=" +tB_ID_elev.Text+" AND data='"+tB_data.Text+"'";
                SqlCommand commToCheckSubID = new SqlCommand(checkSubID, cnn);
                SqlDataAdapter SD = new SqlDataAdapter(commToCheckSubID);
                DataTable DT = new DataTable();
                SD.Fill(DT);
                if (DT.Rows.Count == 0)
                    MessageBox.Show("Elevul cu ID-ul "+tB_ID_elev.Text + " nu are nota la materia cu id-ul " +tB_ID_materie.Text+" in data de "+tB_data.Text);
                else
                {
                    if (tB_nota.Text != string.Empty)
                    {
                        string tabel_date = "update note set nota=" + tB_nota.Text + " where ID_materie ='" + tB_ID_materie.Text + "' AND id_elev=" + tB_ID_elev.Text+" AND data='"+tB_data.Text+"'";
                        SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "note");
                        cnn.Close();
                    }
                    else
                        MessageBox.Show("Nota necompletata!");
                }
                tB_ID_elev.Clear();
                tB_ID_materie.Clear();
                tB_nota.Clear();
                tB_data.Clear();
            }
            else
                MessageBox.Show("Nu ati introdus ID-ul materiei/elevului/data");
        }

        private void btn_sortare_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string tabel_date = "select * from note order by id_materie,id_elev";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "note");
            dataGridView1.DataSource = ds.Tables["note"].DefaultView;
            cnn.Close();
        }

        private void btn_stergere_Click(object sender, EventArgs e)
        {
            if (tB_ID_elev.Text != string.Empty && tB_ID_materie.Text!=string.Empty && tB_data.Text!=string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();

                string checkSubID = "select id_elev, id_materie, data from note where id_materie='" + tB_ID_materie.Text + "' AND id_elev=" + tB_ID_elev.Text + " AND data='" + tB_data.Text + "'";
                SqlCommand commToCheckSubID = new SqlCommand(checkSubID, cnn);
                SqlDataAdapter SD = new SqlDataAdapter(commToCheckSubID);
                DataTable DT = new DataTable();
                SD.Fill(DT);
                if (DT.Rows.Count == 0)
                    MessageBox.Show("Elevul cu ID-ul " + tB_ID_elev.Text + " nu are nota la materia cu id-ul " + tB_ID_materie.Text + " in data de " + tB_data.Text);
                else
                {
                    string tabel_date = "delete from note where ID_elev =" + tB_ID_elev.Text + " AND ID_materie='" + tB_ID_materie.Text + "' AND data='" + tB_data.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "note");
                    cnn.Close();
                }
                tB_ID_materie.Clear();
                tB_ID_elev.Clear();
                tB_data.Clear();
            }
            else
                MessageBox.Show("Nu ati introdus ID-ul elevului/materiei/data");
        }

        private void lbl_cauta_Click(object sender, EventArgs e)
        {
            Cautare f=new Cautare();
            f.Show();
        }
    }
}
