namespace Catalog_app
{
    partial class Logare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logare));
            this.lbl_utilizator = new System.Windows.Forms.Label();
            this.lbl_parola = new System.Windows.Forms.Label();
            this.tB_parola = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_incorect = new System.Windows.Forms.Label();
            this.cB_utilizatori = new System.Windows.Forms.ComboBox();
            this.lbl_incercari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_utilizator
            // 
            this.lbl_utilizator.AutoSize = true;
            this.lbl_utilizator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.lbl_utilizator.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_utilizator.Location = new System.Drawing.Point(101, 242);
            this.lbl_utilizator.Name = "lbl_utilizator";
            this.lbl_utilizator.Size = new System.Drawing.Size(82, 30);
            this.lbl_utilizator.TabIndex = 0;
            this.lbl_utilizator.Text = "Utilizator";
            // 
            // lbl_parola
            // 
            this.lbl_parola.AutoSize = true;
            this.lbl_parola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.lbl_parola.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parola.Location = new System.Drawing.Point(122, 296);
            this.lbl_parola.Name = "lbl_parola";
            this.lbl_parola.Size = new System.Drawing.Size(61, 30);
            this.lbl_parola.TabIndex = 1;
            this.lbl_parola.Text = "Parola";
            // 
            // tB_parola
            // 
            this.tB_parola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.tB_parola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_parola.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_parola.Location = new System.Drawing.Point(196, 293);
            this.tB_parola.Name = "tB_parola";
            this.tB_parola.PasswordChar = '*';
            this.tB_parola.Size = new System.Drawing.Size(164, 35);
            this.tB_parola.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(438, 242);
            this.btn_login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(187, 67);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Autentificare";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 106);
            this.label1.TabIndex = 5;
            this.label1.Text = "Catalog";
            // 
            // lbl_incorect
            // 
            this.lbl_incorect.AutoSize = true;
            this.lbl_incorect.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incorect.ForeColor = System.Drawing.Color.Red;
            this.lbl_incorect.Location = new System.Drawing.Point(433, 326);
            this.lbl_incorect.Name = "lbl_incorect";
            this.lbl_incorect.Size = new System.Drawing.Size(194, 27);
            this.lbl_incorect.TabIndex = 6;
            this.lbl_incorect.Text = "Utilizator/Parola incorecte!!";
            this.lbl_incorect.Visible = false;
            // 
            // cB_utilizatori
            // 
            this.cB_utilizatori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.cB_utilizatori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cB_utilizatori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cB_utilizatori.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_utilizatori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cB_utilizatori.FormattingEnabled = true;
            this.cB_utilizatori.Location = new System.Drawing.Point(196, 237);
            this.cB_utilizatori.Name = "cB_utilizatori";
            this.cB_utilizatori.Size = new System.Drawing.Size(164, 40);
            this.cB_utilizatori.TabIndex = 7;
            // 
            // lbl_incercari
            // 
            this.lbl_incercari.AutoSize = true;
            this.lbl_incercari.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incercari.ForeColor = System.Drawing.Color.Red;
            this.lbl_incercari.Location = new System.Drawing.Point(471, 353);
            this.lbl_incercari.Name = "lbl_incercari";
            this.lbl_incercari.Size = new System.Drawing.Size(0, 27);
            this.lbl_incercari.TabIndex = 8;
            this.lbl_incercari.Visible = false;
            // 
            // Logare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 457);
            this.Controls.Add(this.lbl_incercari);
            this.Controls.Add(this.cB_utilizatori);
            this.Controls.Add(this.lbl_incorect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tB_parola);
            this.Controls.Add(this.lbl_parola);
            this.Controls.Add(this.lbl_utilizator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Logare";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Load += new System.EventHandler(this.Logare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_utilizator;
        private System.Windows.Forms.Label lbl_parola;
        private System.Windows.Forms.TextBox tB_parola;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_incorect;
        private System.Windows.Forms.ComboBox cB_utilizatori;
        private System.Windows.Forms.Label lbl_incercari;
    }
}

