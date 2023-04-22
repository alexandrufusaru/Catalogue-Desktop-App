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
    public partial class Acasa : Form
    {
        public Acasa()
        {
            InitializeComponent();
        }

        private void Acasa_Load(object sender, EventArgs e)
        {
            string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string tabel_date = "select n.id_elev,n.id_materie,e.nume,m.titlu,n.nota,n.data from note n, elevi e, materii m WHERE n.id_elev=e.id_elev AND n.id_materie=m.id_materie";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Elevi,Note,materii");
            dataGridView1.DataSource = ds.Tables["Elevi,Note,materii"].DefaultView;
            cnn.Close();
        }
        private void btn_elevi_Click(object sender, EventArgs e)
        {
            Elevi f = new Elevi();
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
            string tabel_date = "select n.id_elev,n.id_materie,e.nume,m.titlu,n.nota,n.data from note n, elevi e, materii m WHERE n.id_elev=e.id_elev AND n.id_materie=m.id_materie";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "elevi,note,materii");
            dataGridView1.DataSource = ds.Tables["elevi,note,materii"].DefaultView;
            cnn.Close();
        }

        private void btn_cautare_elev_Click(object sender, EventArgs e)
        {
            if (tB_cautare.Text != string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                string tabel_date = "select n.id_elev,e.nume,n.id_materie,n.nota,n.data from note n join elevi e ON n.id_elev=e.id_elev where e.nume='"+tB_cautare.Text+"'";
                SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                DataSet ds = new DataSet();
                da.Fill(ds, "Elevi,Note");
                dataGridView1.DataSource = ds.Tables["Elevi,Note"].DefaultView;
                cnn.Close();

                tB_cautare.Clear();
            }
            else
                MessageBox.Show("Nu ati introdus numele!");
        }

        private void btn_materie_Click(object sender, EventArgs e)
        {
            if (tB_cautare.Text != string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                string tabel_date = "select m.titlu,e.nume,n.id_materie,n.nota,n.data from note n,elevi e,materii m WHERE n.id_elev=e.id_elev AND n.id_materie=m.id_materie AND m.titlu='" + tB_cautare.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                DataSet ds = new DataSet();
                da.Fill(ds, "Elevi,Note,materii");
                dataGridView1.DataSource = ds.Tables["Elevi,Note,materii"].DefaultView;
                cnn.Close();

                tB_cautare.Clear();
            }
            else
                MessageBox.Show("Nu ati introdus numele!");
        }
    }
}
