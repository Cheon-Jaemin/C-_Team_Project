namespace Calendar
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_setting2 = new System.Windows.Forms.Button();
            this.cb_Event2 = new System.Windows.Forms.ComboBox();
            this.lb_Title2 = new System.Windows.Forms.Label();
            this.tb_Title2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_Clock2_2 = new System.Windows.Forms.PictureBox();
            this.lb_Time_2 = new System.Windows.Forms.Label();
            this.cb_TimeSet1_2 = new System.Windows.Forms.ComboBox();
            this.cb_TimeSet2_2 = new System.Windows.Forms.ComboBox();
            this.pb_clock_2 = new System.Windows.Forms.PictureBox();
            this.pb_RightArrow_2 = new System.Windows.Forms.PictureBox();
            this.tb_Content2 = new System.Windows.Forms.TextBox();
            this.lb_Content = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Event_Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Clock2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clock_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RightArrow_2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_setting2
            // 
            this.btn_setting2.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_setting2.Location = new System.Drawing.Point(224, 12);
            this.btn_setting2.Name = "btn_setting2";
            this.btn_setting2.Size = new System.Drawing.Size(48, 23);
            this.btn_setting2.TabIndex = 24;
            this.btn_setting2.Text = "•••";
            this.btn_setting2.UseVisualStyleBackColor = true;
            // 
            // cb_Event2
            // 
            this.cb_Event2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Event2.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Event2.FormattingEnabled = true;
            this.cb_Event2.Items.AddRange(new object[] {
            "할 일"});
            this.cb_Event2.Location = new System.Drawing.Point(12, 12);
            this.cb_Event2.Name = "cb_Event2";
            this.cb_Event2.Size = new System.Drawing.Size(161, 24);
            this.cb_Event2.TabIndex = 28;
            // 
            // lb_Title2
            // 
            this.lb_Title2.AutoSize = true;
            this.lb_Title2.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Title2.ForeColor = System.Drawing.Color.LightGray;
            this.lb_Title2.Location = new System.Drawing.Point(15, 45);
            this.lb_Title2.Name = "lb_Title2";
            this.lb_Title2.Size = new System.Drawing.Size(41, 16);
            this.lb_Title2.TabIndex = 26;
            this.lb_Title2.Text = "제목";
            this.lb_Title2.UseMnemonic = false;
            // 
            // tb_Title2
            // 
            this.tb_Title2.BackColor = System.Drawing.Color.White;
            this.tb_Title2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Title2.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Title2.Location = new System.Drawing.Point(2, 2);
            this.tb_Title2.Name = "tb_Title2";
            this.tb_Title2.Size = new System.Drawing.Size(257, 22);
            this.tb_Title2.TabIndex = 25;
            this.tb_Title2.TextChanged += new System.EventHandler(this.tb_Title2_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.tb_Title2);
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 26);
            this.panel2.TabIndex = 27;
            // 
            // pb_Clock2_2
            // 
            this.pb_Clock2_2.Image = ((System.Drawing.Image)(resources.GetObject("pb_Clock2_2.Image")));
            this.pb_Clock2_2.Location = new System.Drawing.Point(12, 107);
            this.pb_Clock2_2.Name = "pb_Clock2_2";
            this.pb_Clock2_2.Size = new System.Drawing.Size(25, 25);
            this.pb_Clock2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Clock2_2.TabIndex = 40;
            this.pb_Clock2_2.TabStop = false;
            this.pb_Clock2_2.Visible = false;
            // 
            // lb_Time_2
            // 
            this.lb_Time_2.AutoSize = true;
            this.lb_Time_2.Font = new System.Drawing.Font("돋움체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Time_2.Location = new System.Drawing.Point(43, 112);
            this.lb_Time_2.Name = "lb_Time_2";
            this.lb_Time_2.Size = new System.Drawing.Size(79, 15);
            this.lb_Time_2.TabIndex = 39;
            this.lb_Time_2.Text = "선택 날짜";
            // 
            // cb_TimeSet1_2
            // 
            this.cb_TimeSet1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_TimeSet1_2.Font = new System.Drawing.Font("돋움체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_TimeSet1_2.FormattingEnabled = true;
            this.cb_TimeSet1_2.Items.AddRange(new object[] {
            "12:00 AM",
            "12:15 AM",
            "12:30 AM",
            "12:45 AM",
            "1:00 AM",
            "1:15 AM",
            "1:30 AM",
            "1:45 AM",
            "2:00 AM",
            "2:15 AM",
            "2:30 AM",
            "2:45 AM",
            "3:00 AM",
            "3:15 AM",
            "3:30 AM",
            "3:45 AM",
            "4:00 AM",
            "4:15 AM",
            "4:30 AM",
            "4:45 AM",
            "5:00 AM",
            "5:15 AM",
            "5:30 AM",
            "5:45 AM",
            "6:00 AM",
            "6:15 AM",
            "6:30 AM",
            "6:45 AM",
            "7:00 AM",
            "7:15 AM",
            "7:30 AM",
            "7:45 AM",
            "8:00 AM",
            "8:15 AM",
            "8:30 AM",
            "8:45 AM",
            "9:00 AM",
            "9:15 AM",
            "9:30 AM",
            "9:45 AM",
            "10:00 AM",
            "10:15 AM",
            "10:30 AM",
            "10:45 AM",
            "11:00 AM",
            "11:15 AM",
            "11:30 AM",
            "11:45 AM",
            "12:00 PM",
            "12:15 PM",
            "12:30 PM",
            "12:45 PM",
            "13:00 PM",
            "13:15 PM",
            "13:30 PM",
            "13:45 PM",
            "14:00 PM",
            "14:15 PM",
            "14:30 PM",
            "14:45 PM",
            "15:00 PM",
            "15:15 PM",
            "15:30 PM",
            "15:45 PM",
            "16:00 PM",
            "16:15 PM",
            "16:30 PM",
            "16:45 PM",
            "17:00 PM",
            "17:15 PM",
            "17:30 PM",
            "17:45 PM",
            "18:00 PM",
            "18:15 PM",
            "18:30 PM",
            "18:45 PM",
            "19:00 PM",
            "19:15 PM",
            "19:30 PM",
            "19:45 PM",
            "20:00 PM",
            "20:15 PM",
            "20:30 PM",
            "20:45 PM",
            "21:00 PM",
            "21:15 PM",
            "21:30 PM",
            "21:45 PM",
            "22:00 PM",
            "22:15 PM",
            "22:30 PM",
            "22:45 PM",
            "23:00 PM",
            "23:15 PM",
            "23:30 PM",
            "23:45 PM"});
            this.cb_TimeSet1_2.Location = new System.Drawing.Point(42, 74);
            this.cb_TimeSet1_2.Name = "cb_TimeSet1_2";
            this.cb_TimeSet1_2.Size = new System.Drawing.Size(90, 23);
            this.cb_TimeSet1_2.TabIndex = 36;
            // 
            // cb_TimeSet2_2
            // 
            this.cb_TimeSet2_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_TimeSet2_2.Font = new System.Drawing.Font("돋움체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_TimeSet2_2.FormattingEnabled = true;
            this.cb_TimeSet2_2.Items.AddRange(new object[] {
            "12:00 AM",
            "12:15 AM",
            "12:30 AM",
            "12:45 AM",
            "1:00 AM",
            "1:15 AM",
            "1:30 AM",
            "1:45 AM",
            "2:00 AM",
            "2:15 AM",
            "2:30 AM",
            "2:45 AM",
            "3:00 AM",
            "3:15 AM",
            "3:30 AM",
            "3:45 AM",
            "4:00 AM",
            "4:15 AM",
            "4:30 AM",
            "4:45 AM",
            "5:00 AM",
            "5:15 AM",
            "5:30 AM",
            "5:45 AM",
            "6:00 AM",
            "6:15 AM",
            "6:30 AM",
            "6:45 AM",
            "7:00 AM",
            "7:15 AM",
            "7:30 AM",
            "7:45 AM",
            "8:00 AM",
            "8:15 AM",
            "8:30 AM",
            "8:45 AM",
            "9:00 AM",
            "9:15 AM",
            "9:30 AM",
            "9:45 AM",
            "10:00 AM",
            "10:15 AM",
            "10:30 AM",
            "10:45 AM",
            "11:00 AM",
            "11:15 AM",
            "11:30 AM",
            "11:45 AM",
            "12:00 PM",
            "12:15 PM",
            "12:30 PM",
            "12:45 PM",
            "13:00 PM",
            "13:15 PM",
            "13:30 PM",
            "13:45 PM",
            "14:00 PM",
            "14:15 PM",
            "14:30 PM",
            "14:45 PM",
            "15:00 PM",
            "15:15 PM",
            "15:30 PM",
            "15:45 PM",
            "16:00 PM",
            "16:15 PM",
            "16:30 PM",
            "16:45 PM",
            "17:00 PM",
            "17:15 PM",
            "17:30 PM",
            "17:45 PM",
            "18:00 PM",
            "18:15 PM",
            "18:30 PM",
            "18:45 PM",
            "19:00 PM",
            "19:15 PM",
            "19:30 PM",
            "19:45 PM",
            "20:00 PM",
            "20:15 PM",
            "20:30 PM",
            "20:45 PM",
            "21:00 PM",
            "21:15 PM",
            "21:30 PM",
            "21:45 PM",
            "22:00 PM",
            "22:15 PM",
            "22:30 PM",
            "22:45 PM",
            "23:00 PM",
            "23:15 PM",
            "23:30 PM",
            "23:45 PM"});
            this.cb_TimeSet2_2.Location = new System.Drawing.Point(183, 74);
            this.cb_TimeSet2_2.Name = "cb_TimeSet2_2";
            this.cb_TimeSet2_2.Size = new System.Drawing.Size(88, 23);
            this.cb_TimeSet2_2.TabIndex = 37;
            // 
            // pb_clock_2
            // 
            this.pb_clock_2.Image = ((System.Drawing.Image)(resources.GetObject("pb_clock_2.Image")));
            this.pb_clock_2.Location = new System.Drawing.Point(12, 72);
            this.pb_clock_2.Name = "pb_clock_2";
            this.pb_clock_2.Size = new System.Drawing.Size(25, 25);
            this.pb_clock_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_clock_2.TabIndex = 35;
            this.pb_clock_2.TabStop = false;
            // 
            // pb_RightArrow_2
            // 
            this.pb_RightArrow_2.Image = ((System.Drawing.Image)(resources.GetObject("pb_RightArrow_2.Image")));
            this.pb_RightArrow_2.Location = new System.Drawing.Point(134, 66);
            this.pb_RightArrow_2.Name = "pb_RightArrow_2";
            this.pb_RightArrow_2.Size = new System.Drawing.Size(39, 35);
            this.pb_RightArrow_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_RightArrow_2.TabIndex = 38;
            this.pb_RightArrow_2.TabStop = false;
            // 
            // tb_Content2
            // 
            this.tb_Content2.BackColor = System.Drawing.Color.White;
            this.tb_Content2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Content2.Font = new System.Drawing.Font("돋움체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Content2.Location = new System.Drawing.Point(14, 172);
            this.tb_Content2.Multiline = true;
            this.tb_Content2.Name = "tb_Content2";
            this.tb_Content2.Size = new System.Drawing.Size(260, 87);
            this.tb_Content2.TabIndex = 42;
            // 
            // lb_Content
            // 
            this.lb_Content.AutoSize = true;
            this.lb_Content.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Content.ForeColor = System.Drawing.Color.Black;
            this.lb_Content.Location = new System.Drawing.Point(11, 153);
            this.lb_Content.Name = "lb_Content";
            this.lb_Content.Size = new System.Drawing.Size(41, 16);
            this.lb_Content.TabIndex = 41;
            this.lb_Content.Text = "내용";
            this.lb_Content.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "할 일 목록";
            this.label1.UseMnemonic = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 295);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(259, 564);
            this.flowLayoutPanel1.TabIndex = 44;
            // 
            // btn_Event_Add
            // 
            this.btn_Event_Add.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Event_Add.Location = new System.Drawing.Point(181, 109);
            this.btn_Event_Add.Name = "btn_Event_Add";
            this.btn_Event_Add.Size = new System.Drawing.Size(90, 23);
            this.btn_Event_Add.TabIndex = 45;
            this.btn_Event_Add.Text = "일정 추가";
            this.btn_Event_Add.UseVisualStyleBackColor = true;
            this.btn_Event_Add.Click += new System.EventHandler(this.btn_Event_Add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(10, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 568);
            this.panel1.TabIndex = 46;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 871);
            this.Controls.Add(this.btn_Event_Add);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Content2);
            this.Controls.Add(this.lb_Content);
            this.Controls.Add(this.pb_Clock2_2);
            this.Controls.Add(this.lb_Time_2);
            this.Controls.Add(this.cb_TimeSet1_2);
            this.Controls.Add(this.cb_TimeSet2_2);
            this.Controls.Add(this.pb_clock_2);
            this.Controls.Add(this.pb_RightArrow_2);
            this.Controls.Add(this.cb_Event2);
            this.Controls.Add(this.lb_Title2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_setting2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Clock2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clock_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RightArrow_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_setting2;
        private System.Windows.Forms.ComboBox cb_Event2;
        private System.Windows.Forms.Label lb_Title2;
        private System.Windows.Forms.TextBox tb_Title2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_Clock2_2;
        private System.Windows.Forms.Label lb_Time_2;
        private System.Windows.Forms.ComboBox cb_TimeSet1_2;
        private System.Windows.Forms.ComboBox cb_TimeSet2_2;
        private System.Windows.Forms.PictureBox pb_clock_2;
        private System.Windows.Forms.PictureBox pb_RightArrow_2;
        private System.Windows.Forms.TextBox tb_Content2;
        private System.Windows.Forms.Label lb_Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Event_Add;
        private System.Windows.Forms.Panel panel1;
    }
}