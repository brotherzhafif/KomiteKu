﻿namespace KomiteKu
{
    partial class Siswa
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
            this.dgv_siswa = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nis = new System.Windows.Forms.TextBox();
            this.label_action_status = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.cbox_kelas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siswa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_siswa
            // 
            this.dgv_siswa.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_siswa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_siswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_siswa.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_siswa.Location = new System.Drawing.Point(367, 0);
            this.dgv_siswa.Name = "dgv_siswa";
            this.dgv_siswa.Size = new System.Drawing.Size(609, 388);
            this.dgv_siswa.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_nis);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_action_status);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbox_kelas);
            this.panel1.Controls.Add(this.txt_nama);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(367, 388);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "NIS";
            // 
            // txt_nis
            // 
            this.txt_nis.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nis.Location = new System.Drawing.Point(12, 115);
            this.txt_nis.Name = "txt_nis";
            this.txt_nis.Size = new System.Drawing.Size(341, 31);
            this.txt_nis.TabIndex = 12;
            // 
            // label_action_status
            // 
            this.label_action_status.AutoSize = true;
            this.label_action_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_action_status.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_action_status.Location = new System.Drawing.Point(5, 5);
            this.label_action_status.Name = "label_action_status";
            this.label_action_status.Size = new System.Drawing.Size(120, 29);
            this.label_action_status.TabIndex = 9;
            this.label_action_status.Text = "Data Siswa";
            this.label_action_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(10, 333);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(341, 34);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Tambah";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.Action);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nama";
            // 
            // txt_nama
            // 
            this.txt_nama.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama.Location = new System.Drawing.Point(12, 191);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(341, 31);
            this.txt_nama.TabIndex = 4;
            // 
            // cbox_kelas
            // 
            this.cbox_kelas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_kelas.FormattingEnabled = true;
            this.cbox_kelas.Location = new System.Drawing.Point(12, 270);
            this.cbox_kelas.Name = "cbox_kelas";
            this.cbox_kelas.Size = new System.Drawing.Size(341, 31);
            this.cbox_kelas.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kelas";
            // 
            // Siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 388);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_siswa);
            this.Location = new System.Drawing.Point(235, 5);
            this.MaximumSize = new System.Drawing.Size(992, 490);
            this.MinimumSize = new System.Drawing.Size(382, 0);
            this.Name = "Siswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Siswa";
            this.Load += new System.EventHandler(this.Siswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siswa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_siswa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label label_action_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_kelas;
    }
}