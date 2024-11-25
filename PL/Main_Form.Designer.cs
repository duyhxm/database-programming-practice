namespace PL
{
    partial class Main_Form
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
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_right = new System.Windows.Forms.Panel();
            this.pictureBox_avt = new System.Windows.Forms.PictureBox();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_pos = new System.Windows.Forms.Button();
            this.btn_staff = new System.Windows.Forms.Button();
            this.btn_table = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_kitchen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_message = new System.Windows.Forms.TextBox();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_left.Controls.Add(this.txtBx_message);
            this.panel_left.Controls.Add(this.label1);
            this.panel_left.Controls.Add(this.btn_setting);
            this.panel_left.Controls.Add(this.btn_kitchen);
            this.panel_left.Controls.Add(this.btn_pos);
            this.panel_left.Controls.Add(this.btn_staff);
            this.panel_left.Controls.Add(this.btn_table);
            this.panel_left.Controls.Add(this.btn_customer);
            this.panel_left.Controls.Add(this.btn_category);
            this.panel_left.Controls.Add(this.pictureBox_avt);
            this.panel_left.Controls.Add(this.btn_home);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(200, 644);
            this.panel_left.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Image = global::PL.Properties.Resources.Home_S;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(9, 220);
            this.btn_home.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(180, 50);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(194, 0);
            this.panel_right.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(1084, 644);
            this.panel_right.TabIndex = 1;
            // 
            // pictureBox_avt
            // 
            this.pictureBox_avt.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_avt.BackgroundImage = global::PL.Properties.Resources.restaurant;
            this.pictureBox_avt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_avt.Location = new System.Drawing.Point(17, 8);
            this.pictureBox_avt.Name = "pictureBox_avt";
            this.pictureBox_avt.Size = new System.Drawing.Size(154, 82);
            this.pictureBox_avt.TabIndex = 8;
            this.pictureBox_avt.TabStop = false;
            // 
            // btn_category
            // 
            this.btn_category.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category.Image = global::PL.Properties.Resources.Category_S;
            this.btn_category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_category.Location = new System.Drawing.Point(9, 271);
            this.btn_category.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_category.Name = "btn_category";
            this.btn_category.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_category.Size = new System.Drawing.Size(180, 50);
            this.btn_category.TabIndex = 9;
            this.btn_category.Text = "Categories";
            this.btn_category.UseVisualStyleBackColor = true;
            // 
            // btn_customer
            // 
            this.btn_customer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.Image = global::PL.Properties.Resources.Customer_S;
            this.btn_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.Location = new System.Drawing.Point(9, 322);
            this.btn_customer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_customer.Size = new System.Drawing.Size(180, 50);
            this.btn_customer.TabIndex = 10;
            this.btn_customer.Text = "Customer";
            this.btn_customer.UseVisualStyleBackColor = true;
            // 
            // btn_pos
            // 
            this.btn_pos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pos.Image = global::PL.Properties.Resources.Pos_S;
            this.btn_pos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pos.Location = new System.Drawing.Point(9, 474);
            this.btn_pos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_pos.Name = "btn_pos";
            this.btn_pos.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.btn_pos.Size = new System.Drawing.Size(180, 50);
            this.btn_pos.TabIndex = 13;
            this.btn_pos.Text = "POS";
            this.btn_pos.UseVisualStyleBackColor = true;
            // 
            // btn_staff
            // 
            this.btn_staff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_staff.Image = global::PL.Properties.Resources.Staff_S;
            this.btn_staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staff.Location = new System.Drawing.Point(9, 423);
            this.btn_staff.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.btn_staff.Size = new System.Drawing.Size(180, 50);
            this.btn_staff.TabIndex = 12;
            this.btn_staff.Text = "Staff";
            this.btn_staff.UseVisualStyleBackColor = true;
            // 
            // btn_table
            // 
            this.btn_table.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table.Image = global::PL.Properties.Resources.Table_S;
            this.btn_table.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_table.Location = new System.Drawing.Point(9, 372);
            this.btn_table.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_table.Name = "btn_table";
            this.btn_table.Padding = new System.Windows.Forms.Padding(10, 0, 50, 0);
            this.btn_table.Size = new System.Drawing.Size(180, 50);
            this.btn_table.TabIndex = 11;
            this.btn_table.Text = "Tables";
            this.btn_table.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_table.UseVisualStyleBackColor = true;
            // 
            // btn_setting
            // 
            this.btn_setting.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.Image = global::PL.Properties.Resources.Setting_S;
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(9, 577);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Padding = new System.Windows.Forms.Padding(10, 0, 50, 0);
            this.btn_setting.Size = new System.Drawing.Size(180, 50);
            this.btn_setting.TabIndex = 15;
            this.btn_setting.Text = "Setting";
            this.btn_setting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_setting.UseVisualStyleBackColor = true;
            // 
            // btn_kitchen
            // 
            this.btn_kitchen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kitchen.Image = global::PL.Properties.Resources.Kitchen_S;
            this.btn_kitchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kitchen.Location = new System.Drawing.Point(9, 525);
            this.btn_kitchen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_kitchen.Name = "btn_kitchen";
            this.btn_kitchen.Padding = new System.Windows.Forms.Padding(10, 0, 50, 0);
            this.btn_kitchen.Size = new System.Drawing.Size(180, 50);
            this.btn_kitchen.TabIndex = 14;
            this.btn_kitchen.Text = "Kitchen";
            this.btn_kitchen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kitchen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 16;
            // 
            // txtBx_message
            // 
            this.txtBx_message.BackColor = System.Drawing.SystemColors.Info;
            this.txtBx_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_message.Location = new System.Drawing.Point(11, 106);
            this.txtBx_message.Multiline = true;
            this.txtBx_message.Name = "txtBx_message";
            this.txtBx_message.Size = new System.Drawing.Size(174, 105);
            this.txtBx_message.TabIndex = 17;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Management";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.PictureBox pictureBox_avt;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_kitchen;
        private System.Windows.Forms.Button btn_pos;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.Button btn_table;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.TextBox txtBx_message;
        private System.Windows.Forms.Label label1;
    }
}