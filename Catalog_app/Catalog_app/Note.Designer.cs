namespace Catalog_app
{
    partial class Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_acasa = new System.Windows.Forms.Button();
            this.btn_delogare = new System.Windows.Forms.Button();
            this.btn_materii = new System.Windows.Forms.Button();
            this.btn_elevi = new System.Windows.Forms.Button();
            this.tB_data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cautare = new System.Windows.Forms.Button();
            this.btn_editare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_sortare = new System.Windows.Forms.Button();
            this.btn_stergere = new System.Windows.Forms.Button();
            this.tB_nota = new System.Windows.Forms.TextBox();
            this.tB_ID_materie = new System.Windows.Forms.TextBox();
            this.btn_adaugare = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_materie = new System.Windows.Forms.Label();
            this.tB_ID_elev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_cauta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(200)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.btn_acasa);
            this.panel1.Controls.Add(this.btn_delogare);
            this.panel1.Controls.Add(this.btn_materii);
            this.panel1.Controls.Add(this.btn_elevi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 610);
            this.panel1.TabIndex = 14;
            // 
            // btn_acasa
            // 
            this.btn_acasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btn_acasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_acasa.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acasa.Image = ((System.Drawing.Image)(resources.GetObject("btn_acasa.Image")));
            this.btn_acasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_acasa.Location = new System.Drawing.Point(0, 0);
            this.btn_acasa.Name = "btn_acasa";
            this.btn_acasa.Size = new System.Drawing.Size(221, 100);
            this.btn_acasa.TabIndex = 5;
            this.btn_acasa.Text = "Acasa";
            this.btn_acasa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_acasa.UseVisualStyleBackColor = false;
            this.btn_acasa.Click += new System.EventHandler(this.btn_acasa_Click);
            // 
            // btn_delogare
            // 
            this.btn_delogare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btn_delogare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delogare.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_delogare.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delogare.Image = ((System.Drawing.Image)(resources.GetObject("btn_delogare.Image")));
            this.btn_delogare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delogare.Location = new System.Drawing.Point(0, 510);
            this.btn_delogare.Name = "btn_delogare";
            this.btn_delogare.Size = new System.Drawing.Size(221, 100);
            this.btn_delogare.TabIndex = 3;
            this.btn_delogare.Text = "Log Out";
            this.btn_delogare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delogare.UseVisualStyleBackColor = false;
            this.btn_delogare.Click += new System.EventHandler(this.btn_delogare_Click);
            // 
            // btn_materii
            // 
            this.btn_materii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btn_materii.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_materii.Image = ((System.Drawing.Image)(resources.GetObject("btn_materii.Image")));
            this.btn_materii.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_materii.Location = new System.Drawing.Point(0, 200);
            this.btn_materii.Name = "btn_materii";
            this.btn_materii.Size = new System.Drawing.Size(221, 100);
            this.btn_materii.TabIndex = 2;
            this.btn_materii.Text = "Materii";
            this.btn_materii.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_materii.UseVisualStyleBackColor = false;
            this.btn_materii.Click += new System.EventHandler(this.btn_materii_Click);
            // 
            // btn_elevi
            // 
            this.btn_elevi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btn_elevi.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elevi.Image = ((System.Drawing.Image)(resources.GetObject("btn_elevi.Image")));
            this.btn_elevi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_elevi.Location = new System.Drawing.Point(0, 100);
            this.btn_elevi.Name = "btn_elevi";
            this.btn_elevi.Size = new System.Drawing.Size(221, 100);
            this.btn_elevi.TabIndex = 1;
            this.btn_elevi.Text = "Elevi";
            this.btn_elevi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_elevi.UseVisualStyleBackColor = false;
            this.btn_elevi.Click += new System.EventHandler(this.btn_elevi_Click);
            // 
            // tB_data
            // 
            this.tB_data.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_data.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_data.Location = new System.Drawing.Point(369, 289);
            this.tB_data.Name = "tB_data";
            this.tB_data.Size = new System.Drawing.Size(173, 30);
            this.tB_data.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 27);
            this.label1.TabIndex = 45;
            this.label1.Text = "Data";
            // 
            // btn_cautare
            // 
            this.btn_cautare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_cautare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cautare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cautare.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cautare.Location = new System.Drawing.Point(665, 393);
            this.btn_cautare.Name = "btn_cautare";
            this.btn_cautare.Size = new System.Drawing.Size(169, 80);
            this.btn_cautare.TabIndex = 44;
            this.btn_cautare.Text = "   Cautare\r\n(IDM+Nota)";
            this.btn_cautare.UseVisualStyleBackColor = false;
            this.btn_cautare.Click += new System.EventHandler(this.btn_cautare_Click);
            // 
            // btn_editare
            // 
            this.btn_editare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_editare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editare.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editare.Location = new System.Drawing.Point(940, 393);
            this.btn_editare.Name = "btn_editare";
            this.btn_editare.Size = new System.Drawing.Size(159, 80);
            this.btn_editare.TabIndex = 43;
            this.btn_editare.Text = "Editare Nota";
            this.btn_editare.UseVisualStyleBackColor = false;
            this.btn_editare.Click += new System.EventHandler(this.btn_editare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(608, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(200)))), ((int)(((byte)(179)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.DividerHeight = 3;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(535, 333);
            this.dataGridView1.TabIndex = 42;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.BackgroundImage")));
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_refresh.Location = new System.Drawing.Point(522, 33);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(51, 43);
            this.btn_refresh.TabIndex = 41;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_sortare
            // 
            this.btn_sortare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_sortare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sortare.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sortare.Location = new System.Drawing.Point(675, 510);
            this.btn_sortare.Name = "btn_sortare";
            this.btn_sortare.Size = new System.Drawing.Size(159, 80);
            this.btn_sortare.TabIndex = 40;
            this.btn_sortare.Text = "Sortare(IDM)";
            this.btn_sortare.UseVisualStyleBackColor = false;
            this.btn_sortare.Click += new System.EventHandler(this.btn_sortare_Click);
            // 
            // btn_stergere
            // 
            this.btn_stergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_stergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stergere.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stergere.Location = new System.Drawing.Point(940, 510);
            this.btn_stergere.Name = "btn_stergere";
            this.btn_stergere.Size = new System.Drawing.Size(159, 80);
            this.btn_stergere.TabIndex = 39;
            this.btn_stergere.Text = " Stergere\r\n(ID+Nota)";
            this.btn_stergere.UseVisualStyleBackColor = false;
            this.btn_stergere.Click += new System.EventHandler(this.btn_stergere_Click);
            // 
            // tB_nota
            // 
            this.tB_nota.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_nota.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_nota.Location = new System.Drawing.Point(369, 240);
            this.tB_nota.Name = "tB_nota";
            this.tB_nota.Size = new System.Drawing.Size(173, 30);
            this.tB_nota.TabIndex = 38;
            // 
            // tB_ID_materie
            // 
            this.tB_ID_materie.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_ID_materie.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_ID_materie.Location = new System.Drawing.Point(369, 189);
            this.tB_ID_materie.Name = "tB_ID_materie";
            this.tB_ID_materie.Size = new System.Drawing.Size(173, 30);
            this.tB_ID_materie.TabIndex = 36;
            // 
            // btn_adaugare
            // 
            this.btn_adaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_adaugare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adaugare.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adaugare.Location = new System.Drawing.Point(414, 458);
            this.btn_adaugare.Name = "btn_adaugare";
            this.btn_adaugare.Size = new System.Drawing.Size(159, 80);
            this.btn_adaugare.TabIndex = 35;
            this.btn_adaugare.Text = "Adaugare";
            this.btn_adaugare.UseVisualStyleBackColor = false;
            this.btn_adaugare.Click += new System.EventHandler(this.btn_adaugare_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 27);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID Materie";
            // 
            // lbl_materie
            // 
            this.lbl_materie.AutoSize = true;
            this.lbl_materie.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_materie.Location = new System.Drawing.Point(262, 20);
            this.lbl_materie.Name = "lbl_materie";
            this.lbl_materie.Size = new System.Drawing.Size(167, 80);
            this.lbl_materie.TabIndex = 31;
            this.lbl_materie.Text = "Nota";
            // 
            // tB_ID_elev
            // 
            this.tB_ID_elev.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_ID_elev.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_ID_elev.Location = new System.Drawing.Point(369, 143);
            this.tB_ID_elev.Name = "tB_ID_elev";
            this.tB_ID_elev.Size = new System.Drawing.Size(173, 30);
            this.tB_ID_elev.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 27);
            this.label5.TabIndex = 47;
            this.label5.Text = "ID Elev";
            // 
            // lbl_cauta
            // 
            this.lbl_cauta.AutoSize = true;
            this.lbl_cauta.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cauta.Location = new System.Drawing.Point(255, 365);
            this.lbl_cauta.Name = "lbl_cauta";
            this.lbl_cauta.Size = new System.Drawing.Size(236, 42);
            this.lbl_cauta.TabIndex = 54;
            this.lbl_cauta.Text = "Ai uitat id-ul elevului/materiei? \r\nApasa aici";
            this.lbl_cauta.Click += new System.EventHandler(this.lbl_cauta_Click);
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1163, 610);
            this.Controls.Add(this.lbl_cauta);
            this.Controls.Add(this.tB_ID_elev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tB_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cautare);
            this.Controls.Add(this.btn_editare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_sortare);
            this.Controls.Add(this.btn_stergere);
            this.Controls.Add(this.tB_nota);
            this.Controls.Add(this.tB_ID_materie);
            this.Controls.Add(this.btn_adaugare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_materie);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Note";
            this.Load += new System.EventHandler(this.Note_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_delogare;
        private System.Windows.Forms.Button btn_materii;
        private System.Windows.Forms.Button btn_elevi;
        private System.Windows.Forms.TextBox tB_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cautare;
        private System.Windows.Forms.Button btn_editare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_sortare;
        private System.Windows.Forms.Button btn_stergere;
        private System.Windows.Forms.TextBox tB_nota;
        private System.Windows.Forms.TextBox tB_ID_materie;
        private System.Windows.Forms.Button btn_adaugare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_materie;
        private System.Windows.Forms.TextBox tB_ID_elev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_acasa;
        private System.Windows.Forms.Label lbl_cauta;
    }
}