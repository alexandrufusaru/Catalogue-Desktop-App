namespace Catalog_app
{
    partial class Materii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materii));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_delogare = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_acasa = new System.Windows.Forms.Button();
            this.btn_elevi = new System.Windows.Forms.Button();
            this.btn_note = new System.Windows.Forms.Button();
            this.btn_cautare = new System.Windows.Forms.Button();
            this.btn_editare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_sortare = new System.Windows.Forms.Button();
            this.btn_stergere = new System.Windows.Forms.Button();
            this.tB_nr_ore = new System.Windows.Forms.TextBox();
            this.tB_titlu = new System.Windows.Forms.TextBox();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.btn_adaugare = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_materie = new System.Windows.Forms.Label();
            this.tB_prof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delogare
            // 
            this.btn_delogare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btn_delogare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delogare.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_delogare.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delogare.Image = ((System.Drawing.Image)(resources.GetObject("btn_delogare.Image")));
            this.btn_delogare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delogare.Location = new System.Drawing.Point(0, 485);
            this.btn_delogare.Name = "btn_delogare";
            this.btn_delogare.Size = new System.Drawing.Size(221, 100);
            this.btn_delogare.TabIndex = 3;
            this.btn_delogare.Text = "Log Out";
            this.btn_delogare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delogare.UseVisualStyleBackColor = false;
            this.btn_delogare.Click += new System.EventHandler(this.btn_delogare_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(200)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.btn_acasa);
            this.panel1.Controls.Add(this.btn_delogare);
            this.panel1.Controls.Add(this.btn_elevi);
            this.panel1.Controls.Add(this.btn_note);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 585);
            this.panel1.TabIndex = 13;
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
            // btn_elevi
            // 
            this.btn_elevi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btn_elevi.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elevi.Image = ((System.Drawing.Image)(resources.GetObject("btn_elevi.Image")));
            this.btn_elevi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_elevi.Location = new System.Drawing.Point(0, 200);
            this.btn_elevi.Name = "btn_elevi";
            this.btn_elevi.Size = new System.Drawing.Size(221, 100);
            this.btn_elevi.TabIndex = 1;
            this.btn_elevi.Text = "Elevi";
            this.btn_elevi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_elevi.UseVisualStyleBackColor = false;
            this.btn_elevi.Click += new System.EventHandler(this.btn_elevi_Click);
            // 
            // btn_note
            // 
            this.btn_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btn_note.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_note.Image = ((System.Drawing.Image)(resources.GetObject("btn_note.Image")));
            this.btn_note.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_note.Location = new System.Drawing.Point(0, 100);
            this.btn_note.Name = "btn_note";
            this.btn_note.Size = new System.Drawing.Size(221, 100);
            this.btn_note.TabIndex = 0;
            this.btn_note.Text = "Note";
            this.btn_note.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_note.UseVisualStyleBackColor = false;
            this.btn_note.Click += new System.EventHandler(this.btn_note_Click);
            // 
            // btn_cautare
            // 
            this.btn_cautare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_cautare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cautare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cautare.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cautare.Location = new System.Drawing.Point(610, 376);
            this.btn_cautare.Name = "btn_cautare";
            this.btn_cautare.Size = new System.Drawing.Size(169, 80);
            this.btn_cautare.TabIndex = 28;
            this.btn_cautare.Text = "Cautare\r\n(Nr ore)";
            this.btn_cautare.UseVisualStyleBackColor = false;
            this.btn_cautare.Click += new System.EventHandler(this.btn_cautare_Click);
            // 
            // btn_editare
            // 
            this.btn_editare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_editare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editare.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editare.Location = new System.Drawing.Point(806, 376);
            this.btn_editare.Name = "btn_editare";
            this.btn_editare.Size = new System.Drawing.Size(159, 80);
            this.btn_editare.TabIndex = 27;
            this.btn_editare.Text = "Editare(ID)";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(567, 24);
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
            this.dataGridView1.Size = new System.Drawing.Size(563, 333);
            this.dataGridView1.TabIndex = 26;
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
            this.btn_refresh.Location = new System.Drawing.Point(510, 48);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(51, 43);
            this.btn_refresh.TabIndex = 25;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_sortare
            // 
            this.btn_sortare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_sortare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sortare.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sortare.Location = new System.Drawing.Point(487, 492);
            this.btn_sortare.Name = "btn_sortare";
            this.btn_sortare.Size = new System.Drawing.Size(159, 80);
            this.btn_sortare.TabIndex = 24;
            this.btn_sortare.Text = "Sortare(titlu)";
            this.btn_sortare.UseVisualStyleBackColor = false;
            this.btn_sortare.Click += new System.EventHandler(this.btn_sortare_Click);
            // 
            // btn_stergere
            // 
            this.btn_stergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_stergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stergere.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stergere.Location = new System.Drawing.Point(725, 492);
            this.btn_stergere.Name = "btn_stergere";
            this.btn_stergere.Size = new System.Drawing.Size(159, 80);
            this.btn_stergere.TabIndex = 23;
            this.btn_stergere.Text = "Stergere(ID)";
            this.btn_stergere.UseVisualStyleBackColor = false;
            this.btn_stergere.Click += new System.EventHandler(this.btn_stergere_Click);
            // 
            // tB_nr_ore
            // 
            this.tB_nr_ore.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_nr_ore.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_nr_ore.Location = new System.Drawing.Point(351, 272);
            this.tB_nr_ore.Name = "tB_nr_ore";
            this.tB_nr_ore.Size = new System.Drawing.Size(173, 30);
            this.tB_nr_ore.TabIndex = 22;
            // 
            // tB_titlu
            // 
            this.tB_titlu.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_titlu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_titlu.Location = new System.Drawing.Point(351, 230);
            this.tB_titlu.Name = "tB_titlu";
            this.tB_titlu.Size = new System.Drawing.Size(173, 30);
            this.tB_titlu.TabIndex = 21;
            // 
            // tB_ID
            // 
            this.tB_ID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_ID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_ID.Location = new System.Drawing.Point(351, 190);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(173, 30);
            this.tB_ID.TabIndex = 20;
            // 
            // btn_adaugare
            // 
            this.btn_adaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_adaugare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adaugare.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adaugare.Location = new System.Drawing.Point(412, 376);
            this.btn_adaugare.Name = "btn_adaugare";
            this.btn_adaugare.Size = new System.Drawing.Size(159, 80);
            this.btn_adaugare.TabIndex = 19;
            this.btn_adaugare.Text = "Adaugare";
            this.btn_adaugare.UseVisualStyleBackColor = false;
            this.btn_adaugare.Click += new System.EventHandler(this.btn_adaugare_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Numar ore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Titlu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID";
            // 
            // lbl_materie
            // 
            this.lbl_materie.AutoSize = true;
            this.lbl_materie.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_materie.Location = new System.Drawing.Point(250, 48);
            this.lbl_materie.Name = "lbl_materie";
            this.lbl_materie.Size = new System.Drawing.Size(240, 80);
            this.lbl_materie.TabIndex = 15;
            this.lbl_materie.Text = "Materie";
            // 
            // tB_prof
            // 
            this.tB_prof.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_prof.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_prof.Location = new System.Drawing.Point(351, 318);
            this.tB_prof.Name = "tB_prof";
            this.tB_prof.Size = new System.Drawing.Size(173, 30);
            this.tB_prof.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "Profesor";
            // 
            // Materii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1139, 585);
            this.Controls.Add(this.tB_prof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cautare);
            this.Controls.Add(this.btn_editare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_sortare);
            this.Controls.Add(this.btn_stergere);
            this.Controls.Add(this.tB_nr_ore);
            this.Controls.Add(this.tB_titlu);
            this.Controls.Add(this.tB_ID);
            this.Controls.Add(this.btn_adaugare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_materie);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Materii";
            this.Load += new System.EventHandler(this.Materii_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delogare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_elevi;
        private System.Windows.Forms.Button btn_note;
        private System.Windows.Forms.Button btn_cautare;
        private System.Windows.Forms.Button btn_editare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_sortare;
        private System.Windows.Forms.Button btn_stergere;
        private System.Windows.Forms.TextBox tB_nr_ore;
        private System.Windows.Forms.TextBox tB_titlu;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Button btn_adaugare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_materie;
        private System.Windows.Forms.TextBox tB_prof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_acasa;
    }
}