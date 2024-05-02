namespace ngminhhieuu
{
    partial class Form1
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
            this.mahoso_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hoten_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.luong_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ngaylam_date = new System.Windows.Forms.DateTimePicker();
            this.them_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timkiem_name = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.timebatdau = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.timeketthuc = new System.Windows.Forms.DateTimePicker();
            this.timkiem_time = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gioitinh_text = new System.Windows.Forms.ComboBox();
            this.Tai_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mahoso_text
            // 
            this.mahoso_text.Location = new System.Drawing.Point(94, 10);
            this.mahoso_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mahoso_text.Name = "mahoso_text";
            this.mahoso_text.Size = new System.Drawing.Size(128, 22);
            this.mahoso_text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hồ sơ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hoten_text
            // 
            this.hoten_text.Location = new System.Drawing.Point(97, 69);
            this.hoten_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoten_text.Name = "hoten_text";
            this.hoten_text.Size = new System.Drawing.Size(258, 22);
            this.hoten_text.TabIndex = 3;
            this.hoten_text.TextChanged += new System.EventHandler(this.hoten_textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lương";
            // 
            // luong_text
            // 
            this.luong_text.Location = new System.Drawing.Point(453, 69);
            this.luong_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.luong_text.Name = "luong_text";
            this.luong_text.Size = new System.Drawing.Size(146, 22);
            this.luong_text.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày làm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ngaylam_date
            // 
            this.ngaylam_date.CustomFormat = "dd/mm/yyyy";
            this.ngaylam_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaylam_date.Location = new System.Drawing.Point(653, 8);
            this.ngaylam_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngaylam_date.Name = "ngaylam_date";
            this.ngaylam_date.ShowUpDown = true;
            this.ngaylam_date.Size = new System.Drawing.Size(105, 22);
            this.ngaylam_date.TabIndex = 9;
            this.ngaylam_date.Value = new System.DateTime(2024, 5, 1, 0, 0, 0, 0);
            // 
            // them_button
            // 
            this.them_button.Location = new System.Drawing.Point(653, 66);
            this.them_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.them_button.Name = "them_button";
            this.them_button.Size = new System.Drawing.Size(90, 28);
            this.them_button.TabIndex = 10;
            this.them_button.Text = "Thêm";
            this.them_button.UseVisualStyleBackColor = true;
            this.them_button.Click += new System.EventHandler(this.them_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tìm kiếm theo tên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 145);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 22);
            this.textBox1.TabIndex = 12;
            // 
            // timkiem_name
            // 
            this.timkiem_name.Location = new System.Drawing.Point(576, 141);
            this.timkiem_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timkiem_name.Name = "timkiem_name";
            this.timkiem_name.Size = new System.Drawing.Size(79, 29);
            this.timkiem_name.TabIndex = 13;
            this.timkiem_name.Text = "Tìm kiếm";
            this.timkiem_name.UseVisualStyleBackColor = true;
            this.timkiem_name.Click += new System.EventHandler(this.timkiem_name_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tìm kiếm theo thời gian: từ";
            // 
            // timebatdau
            // 
            this.timebatdau.CustomFormat = "dd/mm/yyyy";
            this.timebatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timebatdau.Location = new System.Drawing.Point(200, 189);
            this.timebatdau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timebatdau.Name = "timebatdau";
            this.timebatdau.ShowUpDown = true;
            this.timebatdau.Size = new System.Drawing.Size(105, 22);
            this.timebatdau.TabIndex = 15;
            this.timebatdau.Value = new System.DateTime(2024, 5, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "tới";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // timeketthuc
            // 
            this.timeketthuc.CustomFormat = "dd/mm/yyyy";
            this.timeketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeketthuc.Location = new System.Drawing.Point(339, 189);
            this.timeketthuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeketthuc.Name = "timeketthuc";
            this.timeketthuc.ShowUpDown = true;
            this.timeketthuc.Size = new System.Drawing.Size(105, 22);
            this.timeketthuc.TabIndex = 17;
            this.timeketthuc.Value = new System.DateTime(2024, 5, 1, 0, 0, 0, 0);
            // 
            // timkiem_time
            // 
            this.timkiem_time.Location = new System.Drawing.Point(472, 183);
            this.timkiem_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timkiem_time.Name = "timkiem_time";
            this.timkiem_time.Size = new System.Drawing.Size(90, 26);
            this.timkiem_time.TabIndex = 18;
            this.timkiem_time.Text = "Tìm kiếm";
            this.timkiem_time.UseVisualStyleBackColor = true;
            this.timkiem_time.Click += new System.EventHandler(this.timkiem_time_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 234);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(716, 157);
            this.dataGridView1.TabIndex = 19;
            // 
            // gioitinh_text
            // 
            this.gioitinh_text.FormattingEnabled = true;
            this.gioitinh_text.Items.AddRange(new object[] {
            "Nữ",
            "Nam",
            "Khác"});
            this.gioitinh_text.Location = new System.Drawing.Point(360, 10);
            this.gioitinh_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gioitinh_text.Name = "gioitinh_text";
            this.gioitinh_text.Size = new System.Drawing.Size(149, 24);
            this.gioitinh_text.TabIndex = 20;
            // 
            // Tai_button
            // 
            this.Tai_button.Location = new System.Drawing.Point(339, 402);
            this.Tai_button.Name = "Tai_button";
            this.Tai_button.Size = new System.Drawing.Size(75, 23);
            this.Tai_button.TabIndex = 21;
            this.Tai_button.Text = "Tải";
            this.Tai_button.UseVisualStyleBackColor = true;
            this.Tai_button.Click += new System.EventHandler(this.Tai_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(772, 437);
            this.Controls.Add(this.Tai_button);
            this.Controls.Add(this.gioitinh_text);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.timkiem_time);
            this.Controls.Add(this.timeketthuc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timebatdau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timkiem_name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.them_button);
            this.Controls.Add(this.ngaylam_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.luong_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hoten_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mahoso_text);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Quản lý hồ sơ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mahoso_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hoten_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox luong_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ngaylam_date;
        private System.Windows.Forms.Button them_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button timkiem_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker timebatdau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker timeketthuc;
        private System.Windows.Forms.Button timkiem_time;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox gioitinh_text;
        private System.Windows.Forms.Button Tai_button;
    }
}

