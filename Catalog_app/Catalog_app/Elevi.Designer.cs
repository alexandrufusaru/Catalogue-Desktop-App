namespace Catalog_app
{
    partial class Elevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elevi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_adaugare = new System.Windows.Forms.Button();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.tB_nume = new System.Windows.Forms.TextBox();
            this.tB_varsta = new System.Windows.Forms.TextBox();
            this.btn_stergere = new System.Windows.Forms.Button();
            this.btn_sortare = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delogare = new System.Windows.Forms.Button();
            this.btn_materii = new System.Windows.Forms.Button();
            this.btn_note = new System.Windows.Forms.Button();
            this.btn_editare = new System.Windows.Forms.Button();
            this.btn_cautare = new System.Windows.Forms.Button();
            this.btn_acasa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Varsta";
            // 
            // btn_adaugare
            // 
            this.btn_adaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_adaugare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adaugare.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adaugare.Location = new System.Drawing.Point(357, 373);
            this.btn_adaugare.Name = "btn_adaugare";
            this.btn_adaugare.Size = new System.Drawing.Size(159, 80);
            this.btn_adaugare.TabIndex = 4;
            this.btn_adaugare.Text = "Adaugare";
            this.btn_adaugare.UseVisualStyleBackColor = false;
            this.btn_adaugare.Click += new System.EventHandler(this.btn_adaugare_Click);
            // 
            // tB_ID
            // 
            this.tB_ID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_ID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_ID.Location = new System.Drawing.Point(357, 184);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(173, 30);
            this.tB_ID.TabIndex = 5;
            // 
            // tB_nume
            // 
            this.tB_nume.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_nume.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_nume.Location = new System.Drawing.Point(357, 224);
            this.tB_nume.Name = "tB_nume";
            this.tB_nume.Size = new System.Drawing.Size(173, 30);
            this.tB_nume.TabIndex = 6;
            // 
            // tB_varsta
            // 
            this.tB_varsta.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_varsta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_varsta.Location = new System.Drawing.Point(357, 266);
            this.tB_varsta.Name = "tB_varsta";
            this.tB_varsta.Size = new System.Drawing.Size(173, 30);
            this.tB_varsta.TabIndex = 7;
            // 
            // btn_stergere
            // 
            this.btn_stergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_stergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stergere.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stergere.Location = new System.Drawing.Point(670, 489);
            this.btn_stergere.Name = "btn_stergere";
            this.btn_stergere.Size = new System.Drawing.Size(159, 80);
            this.btn_stergere.TabIndex = 8;
            this.btn_stergere.Text = "Stergere(ID)";
            this.btn_stergere.UseVisualStyleBackColor = false;
            this.btn_stergere.Click += new System.EventHandler(this.btn_stergere_Click);
            // 
            // btn_sortare
            // 
            this.btn_sortare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_sortare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sortare.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sortare.Location = new System.Drawing.Point(432, 489);
            this.btn_sortare.Name = "btn_sortare";
            this.btn_sortare.Size = new System.Drawing.Size(159, 80);
            this.btn_sortare.TabIndex = 9;
            this.btn_sortare.Text = "Sortare(nume)";
            this.btn_sortare.UseVisualStyleBackColor = false;
            this.btn_sortare.Click += new System.EventHandler(this.btn_sortare_Click);
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
            this.btn_refresh.Location = new System.Drawing.Point(516, 42);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(51, 43);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(573, 18);
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
            this.dataGridView1.Size = new System.Drawing.Size(436, 333);
            this.dataGridView1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(200)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.btn_acasa);
            this.panel1.Controls.Add(this.btn_delogare);
            this.panel1.Controls.Add(this.btn_materii);
            this.panel1.Controls.Add(this.btn_note);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 585);
            this.panel1.TabIndex = 12;
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
            // btn_editare
            // 
            this.btn_editare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_editare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editare.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editare.Location = new System.Drawing.Point(751, 373);
            this.btn_editare.Name = "btn_editare";
            this.btn_editare.Size = new System.Drawing.Size(159, 80);
            this.btn_editare.TabIndex = 13;
            this.btn_editare.Text = "Editare(ID)";
            this.btn_editare.UseVisualStyleBackColor = false;
            this.btn_editare.Click += new System.EventHandler(this.btn_editare_Click);
            // 
            // btn_cautare
            // 
            this.btn_cautare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_cautare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cautare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cautare.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cautare.Location = new System.Drawing.Point(555, 373);
            this.btn_cautare.Name = "btn_cautare";
            this.btn_cautare.Size = new System.Drawing.Size(169, 80);
            this.btn_cautare.TabIndex = 14;
            this.btn_cautare.Text = "Cautare(Varsta)";
            this.btn_cautare.UseVisualStyleBackColor = false;
            this.btn_cautare.Click += new System.EventHandler(this.btn_cautare_Click);
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
            this.btn_acasa.TabIndex = 4;
            this.btn_acasa.Text = "Acasa";
            this.btn_acasa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_acasa.UseVisualStyleBackColor = false;
            this.btn_acasa.Click += new System.EventHandler(this.btn_acasa_Click);
            // 
            // Elevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1029, 585);
            this.Controls.Add(this.btn_cautare);
            this.Controls.Add(this.btn_editare);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_sortare);
            this.Controls.Add(this.btn_stergere);
            this.Controls.Add(this.tB_varsta);
            this.Controls.Add(this.tB_nume);
            this.Controls.Add(this.tB_ID);
            this.Controls.Add(this.btn_adaugare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Elevi";
            this.Load += new System.EventHandler(this.Elevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_adaugare;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.TextBox tB_nume;
        private System.Windows.Forms.TextBox tB_varsta;
        private System.Windows.Forms.Button btn_stergere;
        private System.Windows.Forms.Button btn_sortare;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_materii;
        private System.Windows.Forms.Button btn_note;
        private System.Windows.Forms.Button btn_delogare;
        private System.Windows.Forms.Button btn_editare;
        private System.Windows.Forms.Button btn_cautare;
        private System.Windows.Forms.Button btn_acasa;
    }
}