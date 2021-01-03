namespace Mo_phong_thuat_toan
{
    partial class Form1
    {
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

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ytuong = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.so_phan_tu = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 72);
            this.button2.TabIndex = 3;
            this.button2.Text = "TÌM KIẾM NHỊ PHÂN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Nut_nhi_phan);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 73);
            this.button3.TabIndex = 5;
            this.button3.Text = "TÌM KIẾM NỘI SUY";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Nut_noi_suy);
            // 
            // ytuong
            // 
            this.ytuong.BackColor = System.Drawing.Color.Aqua;
            this.ytuong.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.ytuong.ForeColor = System.Drawing.Color.Navy;
            this.ytuong.Location = new System.Drawing.Point(248, 7);
            this.ytuong.Margin = new System.Windows.Forms.Padding(4);
            this.ytuong.Name = "ytuong";
            this.ytuong.ReadOnly = true;
            this.ytuong.Size = new System.Drawing.Size(417, 229);
            this.ytuong.TabIndex = 6;
            this.ytuong.Text = "";
            this.ytuong.TextChanged += new System.EventHandler(this.ytuong_TextChanged);
            // 
            // button4
            // 
            this.button4.AccessibleName = "";
            this.button4.Location = new System.Drawing.Point(23, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 67);
            this.button4.TabIndex = 7;
            this.button4.Text = "TÌM KIẾM TUYẾN TÍNH";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Nut_tuyen_tinh);
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.Color.Aqua;
            this.code.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.code.ForeColor = System.Drawing.Color.Navy;
            this.code.Location = new System.Drawing.Point(673, 7);
            this.code.Margin = new System.Windows.Forms.Padding(4);
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Size = new System.Drawing.Size(398, 441);
            this.code.TabIndex = 8;
            this.code.Text = "";
            this.code.TextChanged += new System.EventHandler(this.code_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(497, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 66);
            this.button5.TabIndex = 9;
            this.button5.Text = "Tự nhập";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Nut_tu_nhap);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(416, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 66);
            this.button6.TabIndex = 10;
            this.button6.Text = "Random";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Nut_random);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(836, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Code C++/C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(417, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ý tưởng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(39, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 52);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số lượng \nphần tử ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // so_phan_tu
            // 
            this.so_phan_tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.so_phan_tu.Location = new System.Drawing.Point(146, 265);
            this.so_phan_tu.Name = "so_phan_tu";
            this.so_phan_tu.Size = new System.Drawing.Size(72, 64);
            this.so_phan_tu.TabIndex = 14;
            this.so_phan_tu.Text = "10";
            this.so_phan_tu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.so_phan_tu.TextChanged += new System.EventHandler(this.so_phan_tu_TextChanged);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(497, 336);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 52);
            this.button7.TabIndex = 15;
            this.button7.Text = "Thực hiện";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Nut_thuc_hien);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            this.process1.Exited += new System.EventHandler(this.process1_Exited);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(160, 350);
            this.trackBar1.Maximum = 11;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(302, 56);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.Thanh_trackbar);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(39, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 52);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tốc độ \nthực hiện";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(228, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 52);
            this.label5.TabIndex = 13;
            this.label5.Text = " Phần tử \nmuốn tìm ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(575, 265);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 66);
            this.button8.TabIndex = 17;
            this.button8.Text = "Reset giá trị";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Nut_reset);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.textBox1.Location = new System.Drawing.Point(333, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 64);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(497, 394);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(148, 54);
            this.button9.TabIndex = 19;
            this.button9.Text = "Sắp xếp";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Nut_sap_xep);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(667, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 20;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 21;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(461, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 22;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(176, 394);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(140, 54);
            this.button10.TabIndex = 23;
            this.button10.Text = "Bắt đầu";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Nut_bat_dau);
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(333, 394);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(140, 54);
            this.button11.TabIndex = 23;
            this.button11.Text = "Tiếp tục";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Nut_tiep_tuc);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox1.Location = new System.Drawing.Point(23, 419);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 29);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Từng bước";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Checkbox_tungbuoc);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 753);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.so_phan_tu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.code);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ytuong);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.MaximumSize = new System.Drawing.Size(1106, 800);
            this.MinimumSize = new System.Drawing.Size(1106, 800);
            this.Name = "Form1";
            this.Text = "Mô phỏng thuật toán";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox ytuong;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox code;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox so_phan_tu;
        private System.Windows.Forms.Button button7;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

