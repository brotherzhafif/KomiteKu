namespace KomiteKu
{
    partial class Ruangan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_Ruangan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.action_ruangan = new System.Windows.Forms.Label();
            this.txt_kelas = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ruangan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Ruangan
            // 
            this.DGV_Ruangan.AllowUserToAddRows = false;
            this.DGV_Ruangan.AllowUserToDeleteRows = false;
            this.DGV_Ruangan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Ruangan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_Ruangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Ruangan.Dock = System.Windows.Forms.DockStyle.Right;
            this.DGV_Ruangan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_Ruangan.Enabled = false;
            this.DGV_Ruangan.Location = new System.Drawing.Point(218, 0);
            this.DGV_Ruangan.Name = "DGV_Ruangan";
            this.DGV_Ruangan.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Ruangan.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Ruangan.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Ruangan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Ruangan.Size = new System.Drawing.Size(219, 234);
            this.DGV_Ruangan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_hapus);
            this.panel1.Controls.Add(this.action_ruangan);
            this.panel1.Controls.Add(this.txt_kelas);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 234);
            this.panel1.TabIndex = 1;
            // 
            // btn_hapus
            // 
            this.btn_hapus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Location = new System.Drawing.Point(107, 172);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(101, 34);
            this.btn_hapus.TabIndex = 14;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.Action);
            // 
            // action_ruangan
            // 
            this.action_ruangan.AutoSize = true;
            this.action_ruangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.action_ruangan.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_ruangan.Location = new System.Drawing.Point(0, 0);
            this.action_ruangan.Name = "action_ruangan";
            this.action_ruangan.Size = new System.Drawing.Size(208, 29);
            this.action_ruangan.TabIndex = 13;
            this.action_ruangan.Text = "Data Ruangan Kelas";
            this.action_ruangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_kelas
            // 
            this.txt_kelas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kelas.Location = new System.Drawing.Point(11, 112);
            this.txt_kelas.Name = "txt_kelas";
            this.txt_kelas.Size = new System.Drawing.Size(197, 31);
            this.txt_kelas.TabIndex = 10;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(11, 172);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(97, 34);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "Tambah";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.Action);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kelas";
            // 
            // Ruangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 234);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_Ruangan);
            this.Location = new System.Drawing.Point(235, 5);
            this.MaximumSize = new System.Drawing.Size(453, 700);
            this.MinimumSize = new System.Drawing.Size(233, 250);
            this.Name = "Ruangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ruangan";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ruangan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Ruangan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label action_ruangan;
        private System.Windows.Forms.TextBox txt_kelas;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hapus;
    }
}