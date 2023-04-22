using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Catalog_app
{
    public partial class Logare : Form
    {
        public Logare()
        {
            InitializeComponent();           
        }


        private int incercari = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string[] utilizatori = File.ReadAllLines("utilizatori.txt");

            foreach (var line in utilizatori)
            {
                string[] inregistrare = line.Split(',');
                if ((cB_utilizatori.Text).Equals(inregistrare[0]))
                {
                    if ((tB_parola.Text.Trim()).Equals(inregistrare[1].Trim()))
                    {
                        lbl_incorect.Visible = false;
                        lbl_incercari.Visible = false;
                        Acasa f = new Acasa();
                        this.Hide();
                        f.ShowDialog();
                    }
                    else
                    {
                        incercari++;
                        lbl_incercari.Text=("Inca " + (3 - incercari).ToString() + " incercari");
                        lbl_incorect.Visible=true;
                        lbl_incercari.Visible=true;
                    }
                }
                if (incercari == 3)
                    Application.Exit();
            }
        }

        private void Logare_Load(object sender, EventArgs e)
        {
            string[] utilizatori = File.ReadAllLines("utilizatori.txt");
            foreach (var line in utilizatori)
            {
                string[] inregistrare = line.Split(',');
                cB_utilizatori.Items.Add(inregistrare[0]);
            }
        }
    }
}