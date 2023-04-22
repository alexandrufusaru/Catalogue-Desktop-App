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
    public partial class Cautare : Form
    {
        public Cautare()
        {
            InitializeComponent();
        }

        private void btn_elev_Click(object sender, EventArgs e)
        {
            if (tB_cautare.Text != string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                string tabel_date = "select id_elev,nume from elevi where id_elev=" + tB_cautare.Text;
                SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                DataSet ds = new DataSet();
                da.Fill(ds, "Elevi");
                dataGridView1.DataSource = ds.Tables["Elevi"].DefaultView;
                cnn.Close();

                tB_cautare.Clear();
            }
            else
                MessageBox.Show("Nu ati introdus ID-ul!");
        }

        private void btn_materie_Click(object sender, EventArgs e)
        {
            if (tB_cautare.Text != string.Empty)
            {
                string connect = @"Data Source=Alex;Initial Catalog=Catalog;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                string tabel_date = "select id_materie,titlu from materii where id_materie='" + tB_cautare.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
                DataSet ds = new DataSet();
                da.Fill(ds, "materii");
                dataGridView1.DataSource = ds.Tables["materii"].DefaultView;
                cnn.Close();

                tB_cautare.Clear();
            }
            else
                MessageBox.Show("Nu ati introdus ID-ul!");
        }
    }
}
