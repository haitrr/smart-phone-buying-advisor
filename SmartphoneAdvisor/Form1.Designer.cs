namespace SmartphoneAdvisor
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
            this.lb1 = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.cbb_profession = new System.Windows.Forms.ComboBox();
            this.cbb_gender = new System.Windows.Forms.ComboBox();
            this.lb_age = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_profession = new System.Windows.Forms.Label();
            this.lb_hobbies = new System.Windows.Forms.Label();
            this.tb_pricebegin = new System.Windows.Forms.TextBox();
            this.tb_priceend = new System.Windows.Forms.TextBox();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_arrow = new System.Windows.Forms.Label();
            this.cbb_color = new System.Windows.Forms.ComboBox();
            this.lb_color = new System.Windows.Forms.Label();
            this.cbb_manufacturer = new System.Windows.Forms.ComboBox();
            this.lb_manufacturer = new System.Windows.Forms.Label();
            this.cbb_os = new System.Windows.Forms.ComboBox();
            this.lb_os = new System.Windows.Forms.Label();
            this.pn_resuilt = new System.Windows.Forms.Panel();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_previous = new System.Windows.Forms.Button();
            this.bt_manage = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.clb_hobbie = new System.Windows.Forms.CheckedListBox();
            this.lb_page = new System.Windows.Forms.Label();
            this.lb_pageindex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(376, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(132, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "THÔNG TIN NGƯỜI MUA";
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(12, 58);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(100, 20);
            this.tb_age.TabIndex = 1;
            this.tb_age.TextChanged += new System.EventHandler(this.tb_age_TextChanged);
            this.tb_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_age_KeyPress);
            // 
            // cbb_profession
            // 
            this.cbb_profession.FormattingEnabled = true;
            this.cbb_profession.Location = new System.Drawing.Point(457, 58);
            this.cbb_profession.Name = "cbb_profession";
            this.cbb_profession.Size = new System.Drawing.Size(121, 21);
            this.cbb_profession.TabIndex = 2;
            this.cbb_profession.SelectedIndexChanged += new System.EventHandler(this.cbb_profession_SelectedIndexChanged);
            // 
            // cbb_gender
            // 
            this.cbb_gender.FormattingEnabled = true;
            this.cbb_gender.Location = new System.Drawing.Point(218, 57);
            this.cbb_gender.Name = "cbb_gender";
            this.cbb_gender.Size = new System.Drawing.Size(121, 21);
            this.cbb_gender.TabIndex = 4;
            this.cbb_gender.SelectedIndexChanged += new System.EventHandler(this.cbb_gender_SelectedIndexChanged);
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Location = new System.Drawing.Point(43, 42);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(28, 13);
            this.lb_age.TabIndex = 5;
            this.lb_age.Text = "Tuổi";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Location = new System.Drawing.Point(262, 41);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(47, 13);
            this.lb_gender.TabIndex = 6;
            this.lb_gender.Text = "Giới tính";
            // 
            // lb_profession
            // 
            this.lb_profession.AutoSize = true;
            this.lb_profession.Location = new System.Drawing.Point(484, 41);
            this.lb_profession.Name = "lb_profession";
            this.lb_profession.Size = new System.Drawing.Size(68, 13);
            this.lb_profession.TabIndex = 7;
            this.lb_profession.Text = "Nghề nghiệp";
            // 
            // lb_hobbies
            // 
            this.lb_hobbies.AutoSize = true;
            this.lb_hobbies.Location = new System.Drawing.Point(718, 41);
            this.lb_hobbies.Name = "lb_hobbies";
            this.lb_hobbies.Size = new System.Drawing.Size(48, 13);
            this.lb_hobbies.TabIndex = 8;
            this.lb_hobbies.Text = "Sở thích";
            // 
            // tb_pricebegin
            // 
            this.tb_pricebegin.Location = new System.Drawing.Point(12, 108);
            this.tb_pricebegin.Name = "tb_pricebegin";
            this.tb_pricebegin.Size = new System.Drawing.Size(100, 20);
            this.tb_pricebegin.TabIndex = 9;
            this.tb_pricebegin.TextChanged += new System.EventHandler(this.tb_pricebegin_TextChanged);
            this.tb_pricebegin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pricebegin_KeyPress);
            // 
            // tb_priceend
            // 
            this.tb_priceend.Location = new System.Drawing.Point(218, 108);
            this.tb_priceend.Name = "tb_priceend";
            this.tb_priceend.Size = new System.Drawing.Size(100, 20);
            this.tb_priceend.TabIndex = 10;
            this.tb_priceend.TextChanged += new System.EventHandler(this.tb_priceend_TextChanged);
            this.tb_priceend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_priceend_KeyPress);
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(43, 92);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(23, 13);
            this.lb_price.TabIndex = 11;
            this.lb_price.Text = "Giá";
            // 
            // lb_arrow
            // 
            this.lb_arrow.AutoSize = true;
            this.lb_arrow.Location = new System.Drawing.Point(145, 115);
            this.lb_arrow.Name = "lb_arrow";
            this.lb_arrow.Size = new System.Drawing.Size(16, 13);
            this.lb_arrow.TabIndex = 12;
            this.lb_arrow.Text = "->";
            // 
            // cbb_color
            // 
            this.cbb_color.FormattingEnabled = true;
            this.cbb_color.Location = new System.Drawing.Point(457, 107);
            this.cbb_color.Name = "cbb_color";
            this.cbb_color.Size = new System.Drawing.Size(121, 21);
            this.cbb_color.TabIndex = 13;
            this.cbb_color.SelectedIndexChanged += new System.EventHandler(this.cbb_color_SelectedIndexChanged);
            // 
            // lb_color
            // 
            this.lb_color.AutoSize = true;
            this.lb_color.Location = new System.Drawing.Point(497, 91);
            this.lb_color.Name = "lb_color";
            this.lb_color.Size = new System.Drawing.Size(28, 13);
            this.lb_color.TabIndex = 14;
            this.lb_color.Text = "Màu";
            // 
            // cbb_manufacturer
            // 
            this.cbb_manufacturer.FormattingEnabled = true;
            this.cbb_manufacturer.Location = new System.Drawing.Point(218, 159);
            this.cbb_manufacturer.Name = "cbb_manufacturer";
            this.cbb_manufacturer.Size = new System.Drawing.Size(121, 21);
            this.cbb_manufacturer.TabIndex = 15;
            this.cbb_manufacturer.SelectedIndexChanged += new System.EventHandler(this.cbb_manufacturer_SelectedIndexChanged);
            // 
            // lb_manufacturer
            // 
            this.lb_manufacturer.AutoSize = true;
            this.lb_manufacturer.Location = new System.Drawing.Point(262, 143);
            this.lb_manufacturer.Name = "lb_manufacturer";
            this.lb_manufacturer.Size = new System.Drawing.Size(33, 13);
            this.lb_manufacturer.TabIndex = 16;
            this.lb_manufacturer.Text = "Hãng";
            // 
            // cbb_os
            // 
            this.cbb_os.FormattingEnabled = true;
            this.cbb_os.Location = new System.Drawing.Point(2, 159);
            this.cbb_os.Name = "cbb_os";
            this.cbb_os.Size = new System.Drawing.Size(121, 21);
            this.cbb_os.TabIndex = 17;
            this.cbb_os.SelectedIndexChanged += new System.EventHandler(this.cbb_os_SelectedIndexChanged);
            // 
            // lb_os
            // 
            this.lb_os.AutoSize = true;
            this.lb_os.Location = new System.Drawing.Point(21, 143);
            this.lb_os.Name = "lb_os";
            this.lb_os.Size = new System.Drawing.Size(72, 13);
            this.lb_os.TabIndex = 18;
            this.lb_os.Text = "Hệ điều hành";
            // 
            // pn_resuilt
            // 
            this.pn_resuilt.Location = new System.Drawing.Point(89, 186);
            this.pn_resuilt.Name = "pn_resuilt";
            this.pn_resuilt.Size = new System.Drawing.Size(800, 300);
            this.pn_resuilt.TabIndex = 19;
            this.pn_resuilt.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_resuilt_Paint);
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(12, 332);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(69, 60);
            this.bt_next.TabIndex = 21;
            this.bt_next.Text = "Tiếp";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_previous
            // 
            this.bt_previous.Location = new System.Drawing.Point(12, 204);
            this.bt_previous.Name = "bt_previous";
            this.bt_previous.Size = new System.Drawing.Size(69, 60);
            this.bt_previous.TabIndex = 22;
            this.bt_previous.Text = "Trước";
            this.bt_previous.UseCompatibleTextRendering = true;
            this.bt_previous.UseVisualStyleBackColor = true;
            this.bt_previous.Click += new System.EventHandler(this.bt_previous_Click);
            // 
            // bt_manage
            // 
            this.bt_manage.Location = new System.Drawing.Point(477, 143);
            this.bt_manage.Name = "bt_manage";
            this.bt_manage.Size = new System.Drawing.Size(75, 23);
            this.bt_manage.TabIndex = 23;
            this.bt_manage.Text = "Quản lý";
            this.bt_manage.UseVisualStyleBackColor = true;
            this.bt_manage.Click += new System.EventHandler(this.bt_manage_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(814, 157);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 24;
            this.bt_exit.Text = "Thoát";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // clb_hobbie
            // 
            this.clb_hobbie.CheckOnClick = true;
            this.clb_hobbie.FormattingEnabled = true;
            this.clb_hobbie.Location = new System.Drawing.Point(683, 62);
            this.clb_hobbie.Name = "clb_hobbie";
            this.clb_hobbie.Size = new System.Drawing.Size(120, 94);
            this.clb_hobbie.TabIndex = 25;
            this.clb_hobbie.SelectedIndexChanged += new System.EventHandler(this.clb_hobbie_SelectedIndexChanged);
            // 
            // lb_page
            // 
            this.lb_page.AutoSize = true;
            this.lb_page.Location = new System.Drawing.Point(21, 276);
            this.lb_page.Name = "lb_page";
            this.lb_page.Size = new System.Drawing.Size(45, 13);
            this.lb_page.TabIndex = 26;
            this.lb_page.Text = "TRANG";
            // 
            // lb_pageindex
            // 
            this.lb_pageindex.AutoSize = true;
            this.lb_pageindex.Location = new System.Drawing.Point(36, 300);
            this.lb_pageindex.Name = "lb_pageindex";
            this.lb_pageindex.Size = new System.Drawing.Size(35, 13);
            this.lb_pageindex.TabIndex = 27;
            this.lb_pageindex.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 496);
            this.Controls.Add(this.lb_pageindex);
            this.Controls.Add(this.lb_page);
            this.Controls.Add(this.clb_hobbie);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_manage);
            this.Controls.Add(this.bt_previous);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.pn_resuilt);
            this.Controls.Add(this.lb_os);
            this.Controls.Add(this.cbb_os);
            this.Controls.Add(this.lb_manufacturer);
            this.Controls.Add(this.cbb_manufacturer);
            this.Controls.Add(this.lb_color);
            this.Controls.Add(this.cbb_color);
            this.Controls.Add(this.lb_arrow);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.tb_priceend);
            this.Controls.Add(this.tb_pricebegin);
            this.Controls.Add(this.lb_hobbies);
            this.Controls.Add(this.lb_profession);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.lb_age);
            this.Controls.Add(this.cbb_gender);
            this.Controls.Add(this.cbb_profession);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Tư vấn mua smartphone";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.ComboBox cbb_profession;
        private System.Windows.Forms.ComboBox cbb_gender;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_profession;
        private System.Windows.Forms.Label lb_hobbies;
        private System.Windows.Forms.TextBox tb_pricebegin;
        private System.Windows.Forms.TextBox tb_priceend;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_arrow;
        private System.Windows.Forms.ComboBox cbb_color;
        private System.Windows.Forms.Label lb_color;
        private System.Windows.Forms.ComboBox cbb_manufacturer;
        private System.Windows.Forms.Label lb_manufacturer;
        private System.Windows.Forms.ComboBox cbb_os;
        private System.Windows.Forms.Label lb_os;
        private System.Windows.Forms.Panel pn_resuilt;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_previous;
        private System.Windows.Forms.Button bt_manage;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.CheckedListBox clb_hobbie;
        private System.Windows.Forms.Label lb_page;
        private System.Windows.Forms.Label lb_pageindex;
    }
}

