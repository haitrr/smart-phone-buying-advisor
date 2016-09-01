namespace SmartphoneAdvisor
{
    partial class Manage
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
            this.lb_manage = new System.Windows.Forms.Label();
            this.tb_rule = new System.Windows.Forms.TextBox();
            this.bt_addrule = new System.Windows.Forms.Button();
            this.bt_deleterule = new System.Windows.Forms.Button();
            this.lb_rule = new System.Windows.Forms.ListBox();
            this.bt_finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_manage
            // 
            this.lb_manage.AutoSize = true;
            this.lb_manage.Location = new System.Drawing.Point(324, 34);
            this.lb_manage.Name = "lb_manage";
            this.lb_manage.Size = new System.Drawing.Size(85, 13);
            this.lb_manage.TabIndex = 0;
            this.lb_manage.Text = "QUẢN LÝ LUẬT";
            // 
            // tb_rule
            // 
            this.tb_rule.Location = new System.Drawing.Point(33, 287);
            this.tb_rule.Name = "tb_rule";
            this.tb_rule.Size = new System.Drawing.Size(592, 20);
            this.tb_rule.TabIndex = 2;
            // 
            // bt_addrule
            // 
            this.bt_addrule.Location = new System.Drawing.Point(640, 284);
            this.bt_addrule.Name = "bt_addrule";
            this.bt_addrule.Size = new System.Drawing.Size(75, 23);
            this.bt_addrule.TabIndex = 3;
            this.bt_addrule.Text = "Thêm";
            this.bt_addrule.UseVisualStyleBackColor = true;
            this.bt_addrule.Click += new System.EventHandler(this.bt_addrule_Click);
            // 
            // bt_deleterule
            // 
            this.bt_deleterule.Location = new System.Drawing.Point(313, 313);
            this.bt_deleterule.Name = "bt_deleterule";
            this.bt_deleterule.Size = new System.Drawing.Size(128, 23);
            this.bt_deleterule.TabIndex = 4;
            this.bt_deleterule.Text = "Xóa";
            this.bt_deleterule.UseVisualStyleBackColor = true;
            this.bt_deleterule.Click += new System.EventHandler(this.bt_deleterule_Click);
            // 
            // lb_rule
            // 
            this.lb_rule.BackColor = System.Drawing.SystemColors.Window;
            this.lb_rule.FormattingEnabled = true;
            this.lb_rule.HorizontalScrollbar = true;
            this.lb_rule.Location = new System.Drawing.Point(33, 60);
            this.lb_rule.Name = "lb_rule";
            this.lb_rule.Size = new System.Drawing.Size(682, 212);
            this.lb_rule.TabIndex = 5;
            this.lb_rule.SelectedIndexChanged += new System.EventHandler(this.lb_rule_SelectedIndexChanged);
            // 
            // bt_finish
            // 
            this.bt_finish.Location = new System.Drawing.Point(610, 24);
            this.bt_finish.Name = "bt_finish";
            this.bt_finish.Size = new System.Drawing.Size(75, 23);
            this.bt_finish.TabIndex = 6;
            this.bt_finish.Text = "Xong";
            this.bt_finish.UseVisualStyleBackColor = true;
            this.bt_finish.Click += new System.EventHandler(this.bt_finish_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 337);
            this.Controls.Add(this.bt_finish);
            this.Controls.Add(this.lb_rule);
            this.Controls.Add(this.bt_deleterule);
            this.Controls.Add(this.bt_addrule);
            this.Controls.Add(this.tb_rule);
            this.Controls.Add(this.lb_manage);
            this.Name = "Manage";
            this.Text = "Quản lý luật";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_manage;
        private System.Windows.Forms.TextBox tb_rule;
        private System.Windows.Forms.Button bt_addrule;
        private System.Windows.Forms.Button bt_deleterule;
        private System.Windows.Forms.ListBox lb_rule;
        private System.Windows.Forms.Button bt_finish;
    }
}