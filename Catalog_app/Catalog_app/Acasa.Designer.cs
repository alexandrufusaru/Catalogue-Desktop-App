namespace Catalog_app
{
    partial class Acasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acasa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_elevi = new System.Windows.Forms.Button();
            this.btn_delogare = new System.Windows.Forms.Button();
            this.btn_materii = new System.Windows.Forms.Button();
            this.btn_note = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tB_cautare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cautare_elev = new System.Windows.Forms.Button();
            this.btn_materie = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(200)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.btn_elevi);
            this.panel1.Controls.Add(this.btn_delogare);
            this.panel1.Controls.Add(this.btn_materii);
            this.panel1.Controls.Add(this.btn_note);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 658);
            this.panel1.TabIndex = 13;
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
            this.btn_elevi.TabIndex = 4;
            this.btn_elevi.Text = "Elevi";
            this.btn_elevi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_elevi.UseVisualStyleBackColor = false;
            this.btn_elevi.Click += new System.EventHandler(this.btn_elevi_Click);
            // 
            // btn_delogare
            // 
            this.btn_delogare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btn_delogare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delogare.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_delogare.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delogare.Image = ((System.Drawing.Image)(resources.GetObject("btn_delogare.Image")));
            this.btn_delogare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delogare.Location = new System.Drawing.Point(0, 558);
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
            this.btn_materii.Location = new System.Drawing.Point(0, 100);
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
            this.btn_note.Location = new System.Drawing.Point(0, 0);
            this.btn_note.Name = "btn_note";
            this.btn_note.Size = new System.Drawing.Size(221, 100);
            this.btn_note.TabIndex = 0;
            this.btn_note.Text = "Note";
            this.btn_note.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_note.UseVisualStyleBackColor = false;
            this.btn_note.Click += new System.EventHandler(this.btn_note_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(320, 316);
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
            this.dataGridView1.Size = new System.Drawing.Size(812, 293);
            this.dataGridView1.TabIndex = 18;
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
            this.btn_refresh.Location = new System.Drawing.Point(256, 316);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(51, 43);
            this.btn_refresh.TabIndex = 17;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // tB_cautare
            // 
            this.tB_cautare.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_cautare.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_cautare.Location = new System.Drawing.Point(557, 179);
            this.tB_cautare.Name = "tB_cautare";
            this.tB_cautare.Size = new System.Drawing.Size(221, 30);
            this.tB_cautare.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Introduceti numele cautat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 80);
            this.label1.TabIndex = 14;
            this.label1.Text = "Catalog";
            // 
            // btn_cautare_elev
            // 
            this.btn_cautare_elev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_cautare_elev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cautare_elev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cautare_elev.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cautare_elev.Location = new System.Drawing.Point(826, 127);
            this.btn_cautare_elev.Name = "btn_cautare_elev";
            this.btn_cautare_elev.Size = new System.Drawing.Size(130, 51);
            this.btn_cautare_elev.TabIndex = 19;
            this.btn_cautare_elev.Text = "Elev";
            this.btn_cautare_elev.UseVisualStyleBackColor = false;
            this.btn_cautare_elev.Click += new System.EventHandler(this.btn_cautare_elev_Click);
            // 
            // btn_materie
            // 
            this.btn_materie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(138)))), ((int)(((byte)(121)))));
            this.btn_materie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_materie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_materie.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_materie.Location = new System.Drawing.Point(826, 200);
            this.btn_materie.Name = "btn_materie";
            this.btn_materie.Size = new System.Drawing.Size(130, 51);
            this.btn_materie.TabIndex = 20;
            this.btn_materie.Text = "Materie";
            this.btn_materie.UseVisualStyleBackColor = false;
            this.btn_materie.Click += new System.EventHandler(this.btn_materie_Click);
            // 
            // Acasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1140, 658);
            this.Controls.Add(this.btn_materie);
            this.Controls.Add(this.btn_cautare_elev);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.tB_cautare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Acasa";
            this.Load += new System.EventHandler(this.Acasa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_delogare;
        private System.Windows.Forms.Button btn_materii;
        private System.Windows.Forms.Button btn_note;
        private System.Windows.Forms.Button btn_elevi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox tB_cautare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cautare_elev;
        private System.Windows.Forms.Button btn_materie;
    }
}