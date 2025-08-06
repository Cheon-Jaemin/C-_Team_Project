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
            btn_setting2 = new Button();
            cb_Event2 = new ComboBox();
            lb_Title2 = new Label();
            tb_Title2 = new TextBox();
            panel2 = new Panel();
            pb_Clock2_2 = new PictureBox();
            lb_Time_2 = new Label();
            cb_TimeSet1_2 = new ComboBox();
            cb_TimeSet2_2 = new ComboBox();
            pb_clock_2 = new PictureBox();
            pb_RightArrow_2 = new PictureBox();
            tb_Content2 = new TextBox();
            lb_Content = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_Event_Add = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Clock2_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_clock_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_RightArrow_2).BeginInit();
            SuspendLayout();
            // 
            // btn_setting2
            // 
            btn_setting2.Font = new Font("돋움", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_setting2.Location = new Point(224, 15);
            btn_setting2.Margin = new Padding(3, 4, 3, 4);
            btn_setting2.Name = "btn_setting2";
            btn_setting2.Size = new Size(48, 29);
            btn_setting2.TabIndex = 24;
            btn_setting2.Text = "•••";
            btn_setting2.UseVisualStyleBackColor = true;
            // 
            // cb_Event2
            // 
            cb_Event2.FlatStyle = FlatStyle.Flat;
            cb_Event2.Font = new Font("돋움체", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Event2.FormattingEnabled = true;
            cb_Event2.Items.AddRange(new object[] { "할 일" });
            cb_Event2.Location = new Point(12, 15);
            cb_Event2.Margin = new Padding(3, 4, 3, 4);
            cb_Event2.Name = "cb_Event2";
            cb_Event2.Size = new Size(161, 24);
            cb_Event2.TabIndex = 28;
            // 
            // lb_Title2
            // 
            lb_Title2.AutoSize = true;
            lb_Title2.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Title2.ForeColor = Color.LightGray;
            lb_Title2.Location = new Point(15, 56);
            lb_Title2.Name = "lb_Title2";
            lb_Title2.Size = new Size(41, 16);
            lb_Title2.TabIndex = 26;
            lb_Title2.Text = "제목";
            lb_Title2.UseMnemonic = false;
            // 
            // tb_Title2
            // 
            tb_Title2.BackColor = Color.White;
            tb_Title2.BorderStyle = BorderStyle.None;
            tb_Title2.Font = new Font("돋움체", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Title2.Location = new Point(2, 2);
            tb_Title2.Margin = new Padding(3, 4, 3, 4);
            tb_Title2.Name = "tb_Title2";
            tb_Title2.Size = new Size(257, 22);
            tb_Title2.TabIndex = 25;
            tb_Title2.TextChanged += tb_Title2_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(tb_Title2);
            panel2.Location = new Point(12, 50);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 32);
            panel2.TabIndex = 27;
            // 
            // pb_Clock2_2
            // 
            pb_Clock2_2.Image = (Image)resources.GetObject("pb_Clock2_2.Image");
            pb_Clock2_2.Location = new Point(12, 134);
            pb_Clock2_2.Margin = new Padding(3, 4, 3, 4);
            pb_Clock2_2.Name = "pb_Clock2_2";
            pb_Clock2_2.Size = new Size(25, 31);
            pb_Clock2_2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Clock2_2.TabIndex = 40;
            pb_Clock2_2.TabStop = false;
            pb_Clock2_2.Visible = false;
            // 
            // lb_Time_2
            // 
            lb_Time_2.AutoSize = true;
            lb_Time_2.Font = new Font("돋움체", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Time_2.Location = new Point(43, 140);
            lb_Time_2.Name = "lb_Time_2";
            lb_Time_2.Size = new Size(79, 15);
            lb_Time_2.TabIndex = 39;
            lb_Time_2.Text = "선택 날짜";
            // 
            // cb_TimeSet1_2
            // 
            cb_TimeSet1_2.FlatStyle = FlatStyle.Flat;
            cb_TimeSet1_2.Font = new Font("돋움체", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cb_TimeSet1_2.FormattingEnabled = true;
            cb_TimeSet1_2.Items.AddRange(new object[] { "12:00 AM", "12:15 AM", "12:30 AM", "12:45 AM", "1:00 AM", "1:15 AM", "1:30 AM", "1:45 AM", "2:00 AM", "2:15 AM", "2:30 AM", "2:45 AM", "3:00 AM", "3:15 AM", "3:30 AM", "3:45 AM", "4:00 AM", "4:15 AM", "4:30 AM", "4:45 AM", "5:00 AM", "5:15 AM", "5:30 AM", "5:45 AM", "6:00 AM", "6:15 AM", "6:30 AM", "6:45 AM", "7:00 AM", "7:15 AM", "7:30 AM", "7:45 AM", "8:00 AM", "8:15 AM", "8:30 AM", "8:45 AM", "9:00 AM", "9:15 AM", "9:30 AM", "9:45 AM", "10:00 AM", "10:15 AM", "10:30 AM", "10:45 AM", "11:00 AM", "11:15 AM", "11:30 AM", "11:45 AM", "12:00 PM", "12:15 PM", "12:30 PM", "12:45 PM", "13:00 PM", "13:15 PM", "13:30 PM", "13:45 PM", "14:00 PM", "14:15 PM", "14:30 PM", "14:45 PM", "15:00 PM", "15:15 PM", "15:30 PM", "15:45 PM", "16:00 PM", "16:15 PM", "16:30 PM", "16:45 PM", "17:00 PM", "17:15 PM", "17:30 PM", "17:45 PM", "18:00 PM", "18:15 PM", "18:30 PM", "18:45 PM", "19:00 PM", "19:15 PM", "19:30 PM", "19:45 PM", "20:00 PM", "20:15 PM", "20:30 PM", "20:45 PM", "21:00 PM", "21:15 PM", "21:30 PM", "21:45 PM", "22:00 PM", "22:15 PM", "22:30 PM", "22:45 PM", "23:00 PM", "23:15 PM", "23:30 PM", "23:45 PM" });
            cb_TimeSet1_2.Location = new Point(42, 92);
            cb_TimeSet1_2.Margin = new Padding(3, 4, 3, 4);
            cb_TimeSet1_2.Name = "cb_TimeSet1_2";
            cb_TimeSet1_2.Size = new Size(90, 23);
            cb_TimeSet1_2.TabIndex = 36;
            // 
            // cb_TimeSet2_2
            // 
            cb_TimeSet2_2.FlatStyle = FlatStyle.Flat;
            cb_TimeSet2_2.Font = new Font("돋움체", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cb_TimeSet2_2.FormattingEnabled = true;
            cb_TimeSet2_2.Items.AddRange(new object[] { "12:00 AM", "12:15 AM", "12:30 AM", "12:45 AM", "1:00 AM", "1:15 AM", "1:30 AM", "1:45 AM", "2:00 AM", "2:15 AM", "2:30 AM", "2:45 AM", "3:00 AM", "3:15 AM", "3:30 AM", "3:45 AM", "4:00 AM", "4:15 AM", "4:30 AM", "4:45 AM", "5:00 AM", "5:15 AM", "5:30 AM", "5:45 AM", "6:00 AM", "6:15 AM", "6:30 AM", "6:45 AM", "7:00 AM", "7:15 AM", "7:30 AM", "7:45 AM", "8:00 AM", "8:15 AM", "8:30 AM", "8:45 AM", "9:00 AM", "9:15 AM", "9:30 AM", "9:45 AM", "10:00 AM", "10:15 AM", "10:30 AM", "10:45 AM", "11:00 AM", "11:15 AM", "11:30 AM", "11:45 AM", "12:00 PM", "12:15 PM", "12:30 PM", "12:45 PM", "13:00 PM", "13:15 PM", "13:30 PM", "13:45 PM", "14:00 PM", "14:15 PM", "14:30 PM", "14:45 PM", "15:00 PM", "15:15 PM", "15:30 PM", "15:45 PM", "16:00 PM", "16:15 PM", "16:30 PM", "16:45 PM", "17:00 PM", "17:15 PM", "17:30 PM", "17:45 PM", "18:00 PM", "18:15 PM", "18:30 PM", "18:45 PM", "19:00 PM", "19:15 PM", "19:30 PM", "19:45 PM", "20:00 PM", "20:15 PM", "20:30 PM", "20:45 PM", "21:00 PM", "21:15 PM", "21:30 PM", "21:45 PM", "22:00 PM", "22:15 PM", "22:30 PM", "22:45 PM", "23:00 PM", "23:15 PM", "23:30 PM", "23:45 PM" });
            cb_TimeSet2_2.Location = new Point(183, 92);
            cb_TimeSet2_2.Margin = new Padding(3, 4, 3, 4);
            cb_TimeSet2_2.Name = "cb_TimeSet2_2";
            cb_TimeSet2_2.Size = new Size(88, 23);
            cb_TimeSet2_2.TabIndex = 37;
            // 
            // pb_clock_2
            // 
            pb_clock_2.Image = (Image)resources.GetObject("pb_clock_2.Image");
            pb_clock_2.Location = new Point(12, 90);
            pb_clock_2.Margin = new Padding(3, 4, 3, 4);
            pb_clock_2.Name = "pb_clock_2";
            pb_clock_2.Size = new Size(25, 31);
            pb_clock_2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_clock_2.TabIndex = 35;
            pb_clock_2.TabStop = false;
            // 
            // pb_RightArrow_2
            // 
            pb_RightArrow_2.Image = (Image)resources.GetObject("pb_RightArrow_2.Image");
            pb_RightArrow_2.Location = new Point(134, 82);
            pb_RightArrow_2.Margin = new Padding(3, 4, 3, 4);
            pb_RightArrow_2.Name = "pb_RightArrow_2";
            pb_RightArrow_2.Size = new Size(39, 44);
            pb_RightArrow_2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_RightArrow_2.TabIndex = 38;
            pb_RightArrow_2.TabStop = false;
            // 
            // tb_Content2
            // 
            tb_Content2.BackColor = Color.White;
            tb_Content2.BorderStyle = BorderStyle.None;
            tb_Content2.Font = new Font("돋움체", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Content2.Location = new Point(14, 215);
            tb_Content2.Margin = new Padding(3, 4, 3, 4);
            tb_Content2.Multiline = true;
            tb_Content2.Name = "tb_Content2";
            tb_Content2.Size = new Size(260, 109);
            tb_Content2.TabIndex = 42;
            // 
            // lb_Content
            // 
            lb_Content.AutoSize = true;
            lb_Content.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Content.ForeColor = Color.Black;
            lb_Content.Location = new Point(11, 191);
            lb_Content.Name = "lb_Content";
            lb_Content.Size = new Size(41, 16);
            lb_Content.TabIndex = 41;
            lb_Content.Text = "내용";
            lb_Content.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 341);
            label1.Name = "label1";
            label1.Size = new Size(93, 16);
            label1.TabIndex = 43;
            label1.Text = "할 일 목록";
            label1.UseMnemonic = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(12, 369);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(259, 705);
            flowLayoutPanel1.TabIndex = 44;
            // 
            // btn_Event_Add
            // 
            btn_Event_Add.Font = new Font("돋움", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Event_Add.Location = new Point(181, 136);
            btn_Event_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Event_Add.Name = "btn_Event_Add";
            btn_Event_Add.Size = new Size(90, 29);
            btn_Event_Add.TabIndex = 45;
            btn_Event_Add.Text = "일정 추가";
            btn_Event_Add.UseVisualStyleBackColor = true;
            btn_Event_Add.Click += btn_Event_Add_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(10, 366);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 710);
            panel1.TabIndex = 46;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(284, 1061);
            Controls.Add(btn_Event_Add);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(tb_Content2);
            Controls.Add(lb_Content);
            Controls.Add(pb_Clock2_2);
            Controls.Add(lb_Time_2);
            Controls.Add(cb_TimeSet1_2);
            Controls.Add(cb_TimeSet2_2);
            Controls.Add(pb_clock_2);
            Controls.Add(pb_RightArrow_2);
            Controls.Add(cb_Event2);
            Controls.Add(lb_Title2);
            Controls.Add(panel2);
            Controls.Add(btn_setting2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Clock2_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_clock_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_RightArrow_2).EndInit();
            ResumeLayout(false);
            PerformLayout();

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