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
    public partial class Elevi : Form
    {

        public Elevi()
        {
            InitializeComponent();
        }

        private void Elevi_Load(object sender, EventArgs e)
        {
            string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string tabel_date = "select * from Elevi";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Elevi");
            dataGridView1.DataSource = ds.Tables["Elevi"].DefaultView;
            cnn.Close();
        }

        private void btn_acasa_Click(object sender, EventArgs e)
        {
            Acasa f= new Acasa();
            this.Hide();
            f.ShowDialog();
        }
        private void btn_note_Click(object sender, EventArgs e)
        {
            Note f = new Note();
            this.Hide();
            f.ShowDialog();
        }
        private void btn_materii_Click(object sender, EventArgs e)
        {
            Materii f = new Materii();
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
            string tabel_date = "select * from Elevi";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Elevi");
            dataGridView1.DataSource = ds.Tables["Elevi"].DefaultView;
            cnn.Close();
        }

        private void btn_adaugare_Click(object sender, EventArgs e)
        {
            if (tB_ID.Text != string.Empty)
                if (tB_nume.Text != string.Empty)
                {
                    string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();

                    string checkStudID = "select id_elev from Elevi where id_elev=" + tB_ID.Text;
                    SqlCommand commToCheckStuID = new SqlCommand(checkStudID, cnn);
                    SqlDataAdapter sd = new SqlDataAdapter(commToCheckStuID);
                    DataTable dtStuID = new DataTable();
                    sd.Fill(dtStuID);
                    if (dtStuID.Rows.Count > 0)
                    {
                        MessageBox.Show("Acest ID exista deja! Ii puteti face update sau puteti pune alt ID");
                        tB_ID.Clear();
                    }
                    else
                    {
                        string stmt = "insert into Elevi ([ID_elev], [Nume], [Varsta]) values (@id, @nume, @varsta)";
                        SqlCommand sc = new SqlCommand(stmt, cnn);
                        sc.Parameters.AddWithValue("@id", tB_ID.Text);
                        sc.Parameters.AddWithValue("@nume", tB_nume.Text);
                        sc.Parameters.AddWithValue("@varsta", tB_varsta.Text);
                        sc.ExecuteNonQuery();
                        cnn.Close();

                        tB_ID.Clear();
                        tB_nume.Clear();
                        tB_varsta.Clear();
                    }
                }
                else
                    MessageBox.Show("Nu ati introdus un nume!");
            else
                MessageBox.Show("Nu ati introdus ID-ul");
        }

        private void btn_cautare_Click(object sender, EventArgs e)
        {
            if (tB_varsta.Text != string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                string tabel_date = "select * from Elevi where varsta=" + tB_varsta.Text;
                SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                DataSet ds = new DataSet();
                da.Fill(ds, "Elevi");
                dataGridView1.DataSource = ds.Tables["Elevi"].DefaultView;
                cnn.Close();

                tB_varsta.Clear();
            }
            else
                MessageBox.Show("Nu ati bagat varsta!");
        }

        private void btn_editare_Click(object sender, EventArgs e)
        {
            if (tB_ID.Text != string.Empty)
            {              
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();

                string checkStudID = "select id_elev from Elevi where id_elev=" + tB_ID.Text;
                SqlCommand commToCheckStuID = new SqlCommand(checkStudID, cnn);
                SqlDataAdapter sd = new SqlDataAdapter(commToCheckStuID);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Acest ID nu exista!");
                    tB_ID.Clear();
                }
                else
                {
                    if (tB_nume.Text != string.Empty && tB_varsta.Text != string.Empty)
                    {
                        string tabel_date = "update elevi set nume = '" + tB_nume.Text + "',varsta= " + tB_varsta.Text + " where ID_elev = " + tB_ID.Text;
                        SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Elevi");
                        cnn.Close();

                        tB_nume.Clear();
                        tB_ID.Clear();
                        tB_varsta.Clear();
                    }
                    else
                        MessageBox.Show("Nume/Parola neintroduse!");
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
            string tabel_date = "select * from elevi order by nume";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Elevi");
            dataGridView1.DataSource = ds.Tables["Elevi"].DefaultView;
            cnn.Close();
        }

        private void btn_stergere_Click(object sender, EventArgs e)
        {
            if (tB_ID.Text != string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();

                string checkStudID = "select id_elev from elevi where id_elev=" + tB_ID.Text;
                SqlCommand commToCheckStuID = new SqlCommand(checkStudID, cnn);
                SqlDataAdapter sd = new SqlDataAdapter(commToCheckStuID);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Acest ID nu exista!");
                else
                {
                    string checkStudIDinNote = "select id_elev from note where id_elev=" + tB_ID.Text;
                    SqlCommand commToCheckStuIDinNote = new SqlCommand(checkStudIDinNote, cnn);
                    SqlDataAdapter SD = new SqlDataAdapter(commToCheckStuIDinNote);
                    DataTable DT = new DataTable();
                    SD.Fill(DT);
                    if (DT.Rows.Count > 0)
                        MessageBox.Show("Acest student are note! Mai intai trebuie stearsa nota");
                    else
                    {
                        string tabel_date = "delete from elevi where ID_elev = " + tB_ID.Text;
                        SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Elevi");

                        cnn.Close();
                    }
                }

                tB_ID.Clear();
            }
            else
                MessageBox.Show("Nu ati introdus ID");
        }
    }
}
