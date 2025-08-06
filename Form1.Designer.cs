namespace C_TeamProject
{
    partial class EventMaker
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventMaker));
            pb_clock = new PictureBox();
            pictureBox2 = new PictureBox();
            tb_Title = new TextBox();
            lb_Title = new Label();
            panel1 = new Panel();
            cb_TimeSet2 = new ComboBox();
            cb_TimeSet1 = new ComboBox();
            pb_RightArrow = new PictureBox();
            cb_repeat = new ComboBox();
            btn_AllTime = new Button();
            btn_TimeSlot = new Button();
            btn_Repeat = new Button();
            lb_Repeat = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            cb_Meeting_Tool = new ComboBox();
            lb_Location = new Label();
            tb_Location = new TextBox();
            label3 = new Label();
            cb_Event = new ComboBox();
            btn_setting = new Button();
            lb_Participant = new Label();
            lb_Meeting_Tool = new Label();
            label4 = new Label();
            cb_Status_Setting = new ComboBox();
            cb_Information_Setting = new ComboBox();
            lb_Information_Setting = new Label();
            lb_Status_Setting = new Label();
            pn_Status_Setting = new Panel();
            lb_Possibility = new Label();
            lb_Busy = new Label();
            tb_Participant = new TextBox();
            pb_RightArrow2 = new PictureBox();
            pb_Clock2 = new PictureBox();
            tb_Content = new TextBox();
            btn_Status_Setting = new Button();
            pn_Information_Setting = new Panel();
            label6 = new Label();
            label1 = new Label();
            label5 = new Label();
            btn_Information_Setting = new Button();
            lb_Remind = new Label();
            cb_Remind = new ComboBox();
            lb_ID = new Label();
            pictureBox4 = new PictureBox();
            btn_Event_Color = new Button();
            pn_Event_Color = new Panel();
            btn_Event_Color_Yellow = new Button();
            btn_Event_Color_Purple = new Button();
            btn_Event_Color_Orange = new Button();
            btn_Event_Color_Blue = new Button();
            btn_Event_Color_Gray = new Button();
            btn_Event_Color_Green = new Button();
            btn_Event_Color_Red = new Button();
            lb_Time = new TextBox();
            lb_Time2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pb_clock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_RightArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pn_Status_Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_RightArrow2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Clock2).BeginInit();
            pn_Information_Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pn_Event_Color.SuspendLayout();
            SuspendLayout();
            // 
            // pb_clock
            // 
            pb_clock.Image = (Image)resources.GetObject("pb_clock.Image");
            pb_clock.Location = new Point(15, 89);
            pb_clock.Margin = new Padding(3, 4, 3, 4);
            pb_clock.Name = "pb_clock";
            pb_clock.Size = new Size(25, 31);
            pb_clock.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_clock.TabIndex = 0;
            pb_clock.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 209);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // tb_Title
            // 
            tb_Title.BackColor = Color.White;
            tb_Title.BorderStyle = BorderStyle.None;
            tb_Title.Font = new Font("돋움체", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Title.Location = new Point(14, 54);
            tb_Title.Margin = new Padding(3, 4, 3, 4);
            tb_Title.Name = "tb_Title";
            tb_Title.Size = new Size(257, 22);
            tb_Title.TabIndex = 2;
            tb_Title.TextChanged += tb_Title_TextChanged;
            // 
            // lb_Title
            // 
            lb_Title.AutoSize = true;
            lb_Title.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Title.ForeColor = Color.LightGray;
            lb_Title.Location = new Point(15, 56);
            lb_Title.Name = "lb_Title";
            lb_Title.Size = new Size(41, 16);
            lb_Title.TabIndex = 3;
            lb_Title.Text = "제목";
            lb_Title.UseMnemonic = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(12, 50);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 32);
            panel1.TabIndex = 4;
            // 
            // cb_TimeSet2
            // 
            cb_TimeSet2.FlatStyle = FlatStyle.Flat;
            cb_TimeSet2.Font = new Font("돋움체", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cb_TimeSet2.FormattingEnabled = true;
            cb_TimeSet2.Items.AddRange(new object[] { "12:00 AM", "12:15 AM", "12:30 AM", "12:45 AM", "01:00 AM", "01:15 AM", "01:30 AM", "01:45 AM", "02:00 AM", "02:15 AM", "02:30 AM", "02:45 AM", "03:00 AM", "03:15 AM", "03:30 AM", "03:45 AM", "04:00 AM", "04:15 AM", "04:30 AM", "04:45 AM", "05:00 AM", "05:15 AM", "05:30 AM", "05:45 AM", "06:00 AM", "06:15 AM", "06:30 AM", "06:45 AM", "07:00 AM", "07:15 AM", "07:30 AM", "07:45 AM", "08:00 AM", "08:15 AM", "08:30 AM", "08:45 AM", "09:00 AM", "09:15 AM", "09:30 AM", "09:45 AM", "10:00 AM", "10:15 AM", "10:30 AM", "10:45 AM", "11:00 AM", "11:15 AM", "11:30 AM", "11:45 AM", "12:00 PM", "12:15 PM", "12:30 PM", "12:45 PM", "01:00 PM", "01:15 PM", "01:30 PM", "01:45 PM", "02:00 PM", "02:15 PM", "02:30 PM", "02:45 PM", "03:00 PM", "03:15 PM", "03:30 PM", "03:45 PM", "04:00 PM", "04:15 PM", "04:30 PM", "04:45 PM", "05:00 PM", "05:15 PM", "05:30 PM", "05:45 PM", "06:00 PM", "06:15 PM", "06:30 PM", "06:45 PM", "07:00 PM", "07:15 PM", "07:30 PM", "07:45 PM", "08:00 PM", "08:15 PM", "08:30 PM", "08:45 PM", "09:00 PM", "09:15 PM", "09:30 PM", "09:45 PM", "10:00 PM", "10:15 PM", "10:30 PM", "10:45 PM", "11:00 PM", "11:15 PM", "11:30 PM", "11:45 PM" });
            cb_TimeSet2.Location = new Point(186, 91);
            cb_TimeSet2.Margin = new Padding(3, 4, 3, 4);
            cb_TimeSet2.Name = "cb_TimeSet2";
            cb_TimeSet2.Size = new Size(88, 23);
            cb_TimeSet2.TabIndex = 5;
            // 
            // cb_TimeSet1
            // 
            cb_TimeSet1.FlatStyle = FlatStyle.Flat;
            cb_TimeSet1.Font = new Font("돋움체", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cb_TimeSet1.FormattingEnabled = true;
            cb_TimeSet1.Items.AddRange(new object[] { "12:00 AM", "12:15 AM", "12:30 AM", "12:45 AM", "01:00 AM", "01:15 AM", "01:30 AM", "01:45 AM", "02:00 AM", "02:15 AM", "02:30 AM", "02:45 AM", "03:00 AM", "03:15 AM", "03:30 AM", "03:45 AM", "04:00 AM", "04:15 AM", "04:30 AM", "04:45 AM", "05:00 AM", "05:15 AM", "05:30 AM", "05:45 AM", "06:00 AM", "06:15 AM", "06:30 AM", "06:45 AM", "07:00 AM", "07:15 AM", "07:30 AM", "07:45 AM", "08:00 AM", "08:15 AM", "08:30 AM", "08:45 AM", "09:00 AM", "09:15 AM", "09:30 AM", "09:45 AM", "10:00 AM", "10:15 AM", "10:30 AM", "10:45 AM", "11:00 AM", "11:15 AM", "11:30 AM", "11:45 AM", "12:00 PM", "12:15 PM", "12:30 PM", "12:45 PM", "01:00 PM", "01:15 PM", "01:30 PM", "01:45 PM", "02:00 PM", "02:15 PM", "02:30 PM", "02:45 PM", "03:00 PM", "03:15 PM", "03:30 PM", "03:45 PM", "04:00 PM", "04:15 PM", "04:30 PM", "04:45 PM", "05:00 PM", "05:15 PM", "05:30 PM", "05:45 PM", "06:00 PM", "06:15 PM", "06:30 PM", "06:45 PM", "07:00 PM", "07:15 PM", "07:30 PM", "07:45 PM", "08:00 PM", "08:15 PM", "08:30 PM", "08:45 PM", "09:00 PM", "09:15 PM", "09:30 PM", "09:45 PM", "10:00 PM", "10:15 PM", "10:30 PM", "10:45 PM", "11:00 PM", "11:15 PM", "11:30 PM", "11:45 PM" });
            cb_TimeSet1.Location = new Point(45, 91);
            cb_TimeSet1.Margin = new Padding(3, 4, 3, 4);
            cb_TimeSet1.Name = "cb_TimeSet1";
            cb_TimeSet1.Size = new Size(90, 23);
            cb_TimeSet1.TabIndex = 5;
            // 
            // pb_RightArrow
            // 
            pb_RightArrow.Image = (Image)resources.GetObject("pb_RightArrow.Image");
            pb_RightArrow.Location = new Point(137, 81);
            pb_RightArrow.Margin = new Padding(3, 4, 3, 4);
            pb_RightArrow.Name = "pb_RightArrow";
            pb_RightArrow.Size = new Size(39, 44);
            pb_RightArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_RightArrow.TabIndex = 6;
            pb_RightArrow.TabStop = false;
            // 
            // cb_repeat
            // 
            cb_repeat.FlatStyle = FlatStyle.Flat;
            cb_repeat.Font = new Font("돋움체", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_repeat.FormattingEnabled = true;
            cb_repeat.Items.AddRange(new object[] { "1일마다", "평일마다", "1주마다", "2주마다", "1개월마다", "1년마다", "반복하지 않음" });
            cb_repeat.Location = new Point(43, 209);
            cb_repeat.Margin = new Padding(3, 4, 3, 4);
            cb_repeat.Name = "cb_repeat";
            cb_repeat.Size = new Size(133, 24);
            cb_repeat.TabIndex = 8;
            cb_repeat.SelectedIndexChanged += cb_repeat_SelectedIndexChanged;
            // 
            // btn_AllTime
            // 
            btn_AllTime.FlatAppearance.BorderSize = 0;
            btn_AllTime.FlatStyle = FlatStyle.Flat;
            btn_AllTime.Font = new Font("돋움체", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AllTime.ForeColor = Color.DarkGray;
            btn_AllTime.Location = new Point(43, 172);
            btn_AllTime.Margin = new Padding(3, 4, 3, 4);
            btn_AllTime.Name = "btn_AllTime";
            btn_AllTime.Size = new Size(48, 29);
            btn_AllTime.TabIndex = 9;
            btn_AllTime.Text = "종일";
            btn_AllTime.UseVisualStyleBackColor = true;
            btn_AllTime.Click += btn_AllTime_Click;
            // 
            // btn_TimeSlot
            // 
            btn_TimeSlot.FlatAppearance.BorderSize = 0;
            btn_TimeSlot.FlatStyle = FlatStyle.Flat;
            btn_TimeSlot.Font = new Font("돋움체", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TimeSlot.ForeColor = Color.DarkGray;
            btn_TimeSlot.Location = new Point(102, 172);
            btn_TimeSlot.Margin = new Padding(3, 4, 3, 4);
            btn_TimeSlot.Name = "btn_TimeSlot";
            btn_TimeSlot.Size = new Size(76, 29);
            btn_TimeSlot.TabIndex = 9;
            btn_TimeSlot.Text = "시간대";
            btn_TimeSlot.UseVisualStyleBackColor = true;
            btn_TimeSlot.Click += btn_TimeSlot_Click;
            // 
            // btn_Repeat
            // 
            btn_Repeat.FlatAppearance.BorderSize = 0;
            btn_Repeat.FlatStyle = FlatStyle.Flat;
            btn_Repeat.Font = new Font("돋움체", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Repeat.ForeColor = Color.DarkGray;
            btn_Repeat.Location = new Point(184, 172);
            btn_Repeat.Margin = new Padding(3, 4, 3, 4);
            btn_Repeat.Name = "btn_Repeat";
            btn_Repeat.Size = new Size(48, 29);
            btn_Repeat.TabIndex = 9;
            btn_Repeat.Text = "기간";
            btn_Repeat.UseVisualStyleBackColor = true;
            btn_Repeat.Click += btn_Repeat_Click;
            // 
            // lb_Repeat
            // 
            lb_Repeat.AutoSize = true;
            lb_Repeat.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Repeat.ForeColor = Color.LightGray;
            lb_Repeat.Location = new Point(45, 212);
            lb_Repeat.Name = "lb_Repeat";
            lb_Repeat.Size = new Size(41, 16);
            lb_Repeat.TabIndex = 11;
            lb_Repeat.Text = "반복";
            lb_Repeat.UseMnemonic = false;
            lb_Repeat.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 248);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 295);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(11, 334);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 549);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 31);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // cb_Meeting_Tool
            // 
            cb_Meeting_Tool.FlatStyle = FlatStyle.Flat;
            cb_Meeting_Tool.Font = new Font("돋움체", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Meeting_Tool.FormattingEnabled = true;
            cb_Meeting_Tool.Items.AddRange(new object[] { "ZOOM", "Google Meet", "선택 안 함" });
            cb_Meeting_Tool.Location = new Point(43, 296);
            cb_Meeting_Tool.Margin = new Padding(3, 4, 3, 4);
            cb_Meeting_Tool.Name = "cb_Meeting_Tool";
            cb_Meeting_Tool.Size = new Size(133, 24);
            cb_Meeting_Tool.TabIndex = 17;
            cb_Meeting_Tool.SelectedIndexChanged += cb_Meeting_Tool_SelectedIndexChanged;
            // 
            // lb_Location
            // 
            lb_Location.AutoSize = true;
            lb_Location.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Location.ForeColor = Color.LightGray;
            lb_Location.Location = new Point(45, 342);
            lb_Location.Name = "lb_Location";
            lb_Location.Size = new Size(41, 16);
            lb_Location.TabIndex = 19;
            lb_Location.Text = "위치";
            lb_Location.UseMnemonic = false;
            lb_Location.UseWaitCursor = true;
            // 
            // tb_Location
            // 
            tb_Location.BackColor = Color.White;
            tb_Location.BorderStyle = BorderStyle.None;
            tb_Location.Font = new Font("돋움체", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Location.Location = new Point(43, 338);
            tb_Location.Margin = new Padding(3, 4, 3, 4);
            tb_Location.Name = "tb_Location";
            tb_Location.Size = new Size(226, 22);
            tb_Location.TabIndex = 18;
            tb_Location.TextChanged += tb_Location_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(9, 381);
            label3.Name = "label3";
            label3.Size = new Size(41, 16);
            label3.TabIndex = 21;
            label3.Text = "내용";
            label3.UseMnemonic = false;
            // 
            // cb_Event
            // 
            cb_Event.FlatStyle = FlatStyle.Flat;
            cb_Event.Font = new Font("돋움체", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Event.FormattingEnabled = true;
            cb_Event.Items.AddRange(new object[] { "이벤트" });
            cb_Event.Location = new Point(12, 15);
            cb_Event.Margin = new Padding(3, 4, 3, 4);
            cb_Event.Name = "cb_Event";
            cb_Event.Size = new Size(141, 24);
            cb_Event.TabIndex = 22;
            // 
            // btn_setting
            // 
            btn_setting.Font = new Font("돋움", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_setting.Location = new Point(214, 18);
            btn_setting.Margin = new Padding(3, 4, 3, 4);
            btn_setting.Name = "btn_setting";
            btn_setting.Size = new Size(58, 29);
            btn_setting.TabIndex = 23;
            btn_setting.Text = "추가";
            btn_setting.UseVisualStyleBackColor = true;
            btn_setting.Click += btn_setting_Click_1;
            // 
            // lb_Participant
            // 
            lb_Participant.AutoSize = true;
            lb_Participant.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Participant.ForeColor = Color.LightGray;
            lb_Participant.Location = new Point(45, 254);
            lb_Participant.Name = "lb_Participant";
            lb_Participant.Size = new Size(58, 16);
            lb_Participant.TabIndex = 24;
            lb_Participant.Text = "참가자";
            lb_Participant.UseMnemonic = false;
            lb_Participant.UseWaitCursor = true;
            // 
            // lb_Meeting_Tool
            // 
            lb_Meeting_Tool.AutoSize = true;
            lb_Meeting_Tool.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Meeting_Tool.ForeColor = Color.LightGray;
            lb_Meeting_Tool.Location = new Point(45, 300);
            lb_Meeting_Tool.Name = "lb_Meeting_Tool";
            lb_Meeting_Tool.Size = new Size(84, 16);
            lb_Meeting_Tool.TabIndex = 25;
            lb_Meeting_Tool.Text = "회의 도구";
            lb_Meeting_Tool.UseMnemonic = false;
            lb_Meeting_Tool.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(8, 518);
            label4.Name = "label4";
            label4.Size = new Size(41, 16);
            label4.TabIndex = 26;
            label4.Text = "계정";
            label4.UseMnemonic = false;
            // 
            // cb_Status_Setting
            // 
            cb_Status_Setting.FlatStyle = FlatStyle.Flat;
            cb_Status_Setting.Font = new Font("돋움체", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Status_Setting.FormattingEnabled = true;
            cb_Status_Setting.Items.AddRange(new object[] { "바쁨", "가능" });
            cb_Status_Setting.Location = new Point(12, 782);
            cb_Status_Setting.Margin = new Padding(3, 4, 3, 4);
            cb_Status_Setting.Name = "cb_Status_Setting";
            cb_Status_Setting.Size = new Size(107, 24);
            cb_Status_Setting.TabIndex = 27;
            // 
            // cb_Information_Setting
            // 
            cb_Information_Setting.FlatStyle = FlatStyle.Flat;
            cb_Information_Setting.Font = new Font("돋움체", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Information_Setting.FormattingEnabled = true;
            cb_Information_Setting.Items.AddRange(new object[] { "공개", "비공개" });
            cb_Information_Setting.Location = new Point(132, 782);
            cb_Information_Setting.Margin = new Padding(3, 4, 3, 4);
            cb_Information_Setting.Name = "cb_Information_Setting";
            cb_Information_Setting.Size = new Size(124, 24);
            cb_Information_Setting.TabIndex = 28;
            // 
            // lb_Information_Setting
            // 
            lb_Information_Setting.AutoSize = true;
            lb_Information_Setting.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Information_Setting.ForeColor = Color.Black;
            lb_Information_Setting.Location = new Point(129, 759);
            lb_Information_Setting.Name = "lb_Information_Setting";
            lb_Information_Setting.Size = new Size(127, 16);
            lb_Information_Setting.TabIndex = 29;
            lb_Information_Setting.Text = "정보 표시 여부";
            lb_Information_Setting.UseMnemonic = false;
            // 
            // lb_Status_Setting
            // 
            lb_Status_Setting.AutoSize = true;
            lb_Status_Setting.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Status_Setting.ForeColor = Color.Black;
            lb_Status_Setting.Location = new Point(12, 759);
            lb_Status_Setting.Name = "lb_Status_Setting";
            lb_Status_Setting.Size = new Size(84, 16);
            lb_Status_Setting.TabIndex = 30;
            lb_Status_Setting.Text = "상태 설정";
            lb_Status_Setting.UseMnemonic = false;
            // 
            // pn_Status_Setting
            // 
            pn_Status_Setting.BorderStyle = BorderStyle.FixedSingle;
            pn_Status_Setting.Controls.Add(lb_Possibility);
            pn_Status_Setting.Controls.Add(lb_Busy);
            pn_Status_Setting.Location = new Point(108, 622);
            pn_Status_Setting.Margin = new Padding(3, 4, 3, 4);
            pn_Status_Setting.Name = "pn_Status_Setting";
            pn_Status_Setting.Size = new Size(170, 124);
            pn_Status_Setting.TabIndex = 31;
            pn_Status_Setting.Visible = false;
            // 
            // lb_Possibility
            // 
            lb_Possibility.AutoSize = true;
            lb_Possibility.Location = new Point(3, 74);
            lb_Possibility.Name = "lb_Possibility";
            lb_Possibility.Size = new Size(167, 45);
            lb_Possibility.TabIndex = 1;
            lb_Possibility.Text = "가능\r\n이 이벤트 중에 다른 사람에게\r\n'가능'으로 표시";
            // 
            // lb_Busy
            // 
            lb_Busy.AutoSize = true;
            lb_Busy.Location = new Point(3, 11);
            lb_Busy.Name = "lb_Busy";
            lb_Busy.Size = new Size(167, 45);
            lb_Busy.TabIndex = 0;
            lb_Busy.Text = "바쁨\r\n이 이벤트 중에 다른 사람에게\r\n'바쁨'으로 표시";
            // 
            // tb_Participant
            // 
            tb_Participant.BackColor = Color.White;
            tb_Participant.BorderStyle = BorderStyle.None;
            tb_Participant.Font = new Font("돋움체", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Participant.Location = new Point(43, 251);
            tb_Participant.Margin = new Padding(3, 4, 3, 4);
            tb_Participant.Name = "tb_Participant";
            tb_Participant.Size = new Size(229, 22);
            tb_Participant.TabIndex = 32;
            tb_Participant.TextChanged += tb_Participant_TextChanged;
            // 
            // pb_RightArrow2
            // 
            pb_RightArrow2.Image = (Image)resources.GetObject("pb_RightArrow2.Image");
            pb_RightArrow2.Location = new Point(141, 125);
            pb_RightArrow2.Margin = new Padding(3, 4, 3, 4);
            pb_RightArrow2.Name = "pb_RightArrow2";
            pb_RightArrow2.Size = new Size(39, 44);
            pb_RightArrow2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_RightArrow2.TabIndex = 33;
            pb_RightArrow2.TabStop = false;
            pb_RightArrow2.Visible = false;
            // 
            // pb_Clock2
            // 
            pb_Clock2.Image = (Image)resources.GetObject("pb_Clock2.Image");
            pb_Clock2.Location = new Point(15, 132);
            pb_Clock2.Margin = new Padding(3, 4, 3, 4);
            pb_Clock2.Name = "pb_Clock2";
            pb_Clock2.Size = new Size(25, 31);
            pb_Clock2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Clock2.TabIndex = 34;
            pb_Clock2.TabStop = false;
            pb_Clock2.Visible = false;
            // 
            // tb_Content
            // 
            tb_Content.BackColor = Color.White;
            tb_Content.BorderStyle = BorderStyle.None;
            tb_Content.Font = new Font("돋움체", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Content.Location = new Point(12, 405);
            tb_Content.Margin = new Padding(3, 4, 3, 4);
            tb_Content.Multiline = true;
            tb_Content.Name = "tb_Content";
            tb_Content.Size = new Size(260, 109);
            tb_Content.TabIndex = 35;
            // 
            // btn_Status_Setting
            // 
            btn_Status_Setting.FlatStyle = FlatStyle.Flat;
            btn_Status_Setting.Font = new Font("돋움", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Status_Setting.Location = new Point(95, 752);
            btn_Status_Setting.Margin = new Padding(3, 4, 3, 4);
            btn_Status_Setting.Name = "btn_Status_Setting";
            btn_Status_Setting.Size = new Size(25, 31);
            btn_Status_Setting.TabIndex = 36;
            btn_Status_Setting.Text = "?";
            btn_Status_Setting.UseVisualStyleBackColor = true;
            btn_Status_Setting.Click += btn_Status_Setting_Click;
            // 
            // pn_Information_Setting
            // 
            pn_Information_Setting.BorderStyle = BorderStyle.FixedSingle;
            pn_Information_Setting.Controls.Add(label6);
            pn_Information_Setting.Controls.Add(label1);
            pn_Information_Setting.Controls.Add(label5);
            pn_Information_Setting.Location = new Point(9, 575);
            pn_Information_Setting.Margin = new Padding(3, 4, 3, 4);
            pn_Information_Setting.Name = "pn_Information_Setting";
            pn_Information_Setting.Size = new Size(270, 177);
            pn_Information_Setting.TabIndex = 32;
            pn_Information_Setting.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 125);
            label6.Name = "label6";
            label6.Size = new Size(226, 45);
            label6.TabIndex = 2;
            label6.Text = "비공개\r\n이 캘린터를 변경할 권한이 있는 사람만\r\n이 이벤트의 세부 정보를 볼 수 있습니다.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 84);
            label1.Name = "label1";
            label1.Size = new Size(266, 30);
            label1.TabIndex = 1;
            label1.Text = "공개\r\n누구나 이 이벤트의 세부 정보를 볼 수 있습니다.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 12);
            label5.Name = "label5";
            label5.Size = new Size(266, 60);
            label5.TabIndex = 0;
            label5.Text = "이 이벤트 표시 여부는\r\n이 캘린더의 공유 설정에 따릅니다.\r\n이 캘린더를 볼 수 있는 사람은\r\n누구나 이 이벤트의 세부 정보를 볼 수 있습니다.";
            // 
            // btn_Information_Setting
            // 
            btn_Information_Setting.FlatStyle = FlatStyle.Flat;
            btn_Information_Setting.Font = new Font("돋움", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Information_Setting.Location = new Point(252, 752);
            btn_Information_Setting.Margin = new Padding(3, 4, 3, 4);
            btn_Information_Setting.Name = "btn_Information_Setting";
            btn_Information_Setting.Size = new Size(25, 31);
            btn_Information_Setting.TabIndex = 37;
            btn_Information_Setting.Text = "?";
            btn_Information_Setting.UseVisualStyleBackColor = true;
            btn_Information_Setting.Click += btn_Information_Setting_Click;
            // 
            // lb_Remind
            // 
            lb_Remind.AutoSize = true;
            lb_Remind.Font = new Font("돋움체", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Remind.ForeColor = Color.LightGray;
            lb_Remind.Location = new Point(46, 555);
            lb_Remind.Name = "lb_Remind";
            lb_Remind.Size = new Size(75, 16);
            lb_Remind.TabIndex = 38;
            lb_Remind.Text = "리마인더";
            lb_Remind.UseMnemonic = false;
            lb_Remind.UseWaitCursor = true;
            // 
            // cb_Remind
            // 
            cb_Remind.FlatStyle = FlatStyle.Flat;
            cb_Remind.Font = new Font("돋움체", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Remind.FormattingEnabled = true;
            cb_Remind.Items.AddRange(new object[] { "이벤트 시작 시", "5분 전", "10분 전", "30분 전", "1시간 전", "리마인더 삭제" });
            cb_Remind.Location = new Point(12, 588);
            cb_Remind.Margin = new Padding(3, 4, 3, 4);
            cb_Remind.Name = "cb_Remind";
            cb_Remind.Size = new Size(141, 24);
            cb_Remind.TabIndex = 38;
            cb_Remind.SelectedIndexChanged += cb_Remind_SelectedIndexChanged;
            // 
            // lb_ID
            // 
            lb_ID.AutoSize = true;
            lb_ID.Font = new Font("돋움체", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ID.ForeColor = Color.Black;
            lb_ID.Location = new Point(51, 518);
            lb_ID.Name = "lb_ID";
            lb_ID.Size = new Size(127, 16);
            lb_ID.TabIndex = 39;
            lb_ID.Text = "로그인한 아이디";
            lb_ID.UseMnemonic = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 625);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            // 
            // btn_Event_Color
            // 
            btn_Event_Color.FlatAppearance.BorderSize = 0;
            btn_Event_Color.FlatStyle = FlatStyle.Flat;
            btn_Event_Color.Font = new Font("돋움", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Event_Color.Location = new Point(40, 628);
            btn_Event_Color.Margin = new Padding(3, 4, 3, 4);
            btn_Event_Color.Name = "btn_Event_Color";
            btn_Event_Color.Size = new Size(95, 31);
            btn_Event_Color.TabIndex = 42;
            btn_Event_Color.Text = "이벤트 색";
            btn_Event_Color.UseVisualStyleBackColor = true;
            btn_Event_Color.Click += btn_Event_Color_Click;
            // 
            // pn_Event_Color
            // 
            pn_Event_Color.BackColor = Color.Silver;
            pn_Event_Color.Controls.Add(btn_Event_Color_Yellow);
            pn_Event_Color.Controls.Add(btn_Event_Color_Purple);
            pn_Event_Color.Controls.Add(btn_Event_Color_Orange);
            pn_Event_Color.Controls.Add(btn_Event_Color_Blue);
            pn_Event_Color.Controls.Add(btn_Event_Color_Gray);
            pn_Event_Color.Controls.Add(btn_Event_Color_Green);
            pn_Event_Color.Controls.Add(btn_Event_Color_Red);
            pn_Event_Color.Location = new Point(49, 666);
            pn_Event_Color.Margin = new Padding(3, 4, 3, 4);
            pn_Event_Color.Name = "pn_Event_Color";
            pn_Event_Color.Size = new Size(220, 75);
            pn_Event_Color.TabIndex = 44;
            pn_Event_Color.Visible = false;
            // 
            // btn_Event_Color_Yellow
            // 
            btn_Event_Color_Yellow.BackColor = Color.Yellow;
            btn_Event_Color_Yellow.FlatAppearance.BorderSize = 0;
            btn_Event_Color_Yellow.FlatStyle = FlatStyle.Flat;
            btn_Event_Color_Yellow.Location = new Point(112, 6);
            btn_Event_Color_Yellow.Margin = new Padding(3, 4, 3, 4);
            btn_Event_Color_Yellow.Name = "btn_Event_Color_Yellow";
            btn_Event_Color_Yellow.Size = new Size(50, 31);
            btn_Event_Color_Yellow.TabIndex = 8;
            btn_Event_Color_Yellow.Text = "노란색";
            btn_Event_Color_Yellow.UseVisualStyleBackColor = false;
            // 
            // btn_Event_Color_Purple
            // 
            btn_Event_Color_Purple.BackColor = Color.Purple;
            btn_Event_Color_Purple.FlatAppearance.BorderSize = 0;
            btn_Event_Color_Purple.FlatStyle = FlatStyle.Flat;
            btn_Event_Color_Purple.ForeColor = Color.White;
            btn_Event_Color_Purple.Location = new Point(112, 40);
            btn_Event_Color_Purple.Margin = new Padding(3, 4, 3, 4);
            btn_Event_Color_Purple.Name = "btn_Event_Color_Purple";
            btn_Event_Color_Purple.Size = new Size(50, 31);
            btn_Event_Color_Purple.TabIndex = 7;
            btn_Event_Color_Purple.Text = "보라색";
            btn_Event_Color_Purple.UseVisualStyleBackColor = false;
            // 
            // btn_Event_Color_Orange
            // 
            btn_Event_Color_Orange.BackColor = Color.Orange;
            btn_Event_Color_Orange.FlatAppearance.BorderSize = 0;
            btn_Event_Color_Orange.FlatStyle = FlatStyle.Flat;
            btn_Event_Color_Orange.ForeColor = Color.White;
            btn_Event_Color_Orange.Location = new Point(58, 6);
            btn_Event_Color_Orange.Margin = new Padding(3, 4, 3, 4);
            btn_Event_Color_Orange.Name = "btn_Event_Color_Orange";
            btn_Event_Color_Orange.Size = new Size(50, 31);
            btn_Event_Color_Orange.TabIndex = 4;
            btn_Event_Color_Orange.Text = "주황색";
            btn_Event_Color_Orange.UseVisualStyleBackColor = false;
            // 
            // btn_Event_Color_Blue
            // 
            btn_Event_Color_Blue.BackColor = Color.Blue;
            btn_Event_Color_Blue.FlatAppearance.BorderSize = 0;
            btn_Event_Color_Blue.FlatStyle = FlatStyle.Flat;
            btn_Event_Color_Blue.ForeColor = Color.White;
            btn_Event_Color_Blue.Location = new Point(58, 40);
            btn_Event_Color_Blue.Margin = new Padding(3, 4, 3, 4);
            btn_Event_Color_Blue.Name = "btn_Event_Color_Blue";
            btn_Event_Color_Blue.Size = new Size(50, 31);
            btn_Event_Color_Blue.TabIndex = 3;
            btn_Event_Color_Blue.Text = "파란색";
            btn_Event_Color_Blue.UseVisualStyleBackColor = false;
            // 
            // btn_Event_Color_Gray
            // 
            btn_Event_Color_Gray.BackColor = Color.Gray;
            btn_Event_Color_Gray.FlatAppearance.BorderSize = 0;
            btn_Event_Color_Gray.FlatStyle = FlatStyle.Flat;
            btn_Event_Color_Gray.ForeColor = Color.White;
            btn_Event_Color_Gray.Location = new Point(165, 40);
            btn_Event_Color_Gray.Margin = new Padding(3, 4, 3, 4);
            btn_Event_Color_Gray.Name = "btn_Event_Color_Gray";
            btn_Event_Color_Gray.Size = new Size(50, 31);
            btn_Event_Color_Gray.TabIndex = 2;
            btn_Event_Color_Gray.Text = "회색";
            btn_Event_Color_Gray.UseVisualStyleBackColor = false;
            // 
            // btn_Event_Color_Green
            // 
            btn_Event_Color_Green.BackColor = Color.Green;
            btn_Event_Color_Green.FlatAppearance.BorderSize = 0;
            btn_Event_Color_Green.FlatStyle = FlatStyle.Flat;
            btn_Event_Color_Green.ForeColor = Color.White;
            btn_Event_Color_Green.Location = new Point(4, 40);
            btn_Event_Color_Green.Margin = new Padding(3, 4, 3, 4);
            btn_Event_Color_Green.Name = "btn_Event_Color_Green";
            btn_Event_Color_Green.Size = new Size(50, 31);
            btn_Event_Color_Green.TabIndex = 1;
            btn_Event_Color_Green.Text = "초록색";
            btn_Event_Color_Green.UseVisualStyleBackColor = false;
            // 
            // btn_Event_Color_Red
            // 
            btn_Event_Color_Red.BackColor = Color.Red;
            btn_Event_Color_Red.FlatAppearance.BorderSize = 0;
            btn_Event_Color_Red.FlatStyle = FlatStyle.Flat;
            btn_Event_Color_Red.ForeColor = Color.White;
            btn_Event_Color_Red.Location = new Point(4, 6);
            btn_Event_Color_Red.Margin = new Padding(3, 4, 3, 4);
            btn_Event_Color_Red.Name = "btn_Event_Color_Red";
            btn_Event_Color_Red.Size = new Size(50, 31);
            btn_Event_Color_Red.TabIndex = 0;
            btn_Event_Color_Red.Text = "빨간색";
            btn_Event_Color_Red.UseVisualStyleBackColor = false;
            // 
            // lb_Time
            // 
            lb_Time.Location = new Point(40, 132);
            lb_Time.Name = "lb_Time";
            lb_Time.Size = new Size(95, 23);
            lb_Time.TabIndex = 45;
            lb_Time.TextChanged += lb_Text_TextChanged;
            // 
            // lb_Time2
            // 
            lb_Time2.Location = new Point(186, 132);
            lb_Time2.Name = "lb_Time2";
            lb_Time2.Size = new Size(86, 23);
            lb_Time2.TabIndex = 45;
            // 
            // EventMaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 880);
            Controls.Add(lb_Time2);
            Controls.Add(lb_Time);
            Controls.Add(pn_Status_Setting);
            Controls.Add(pn_Information_Setting);
            Controls.Add(pn_Event_Color);
            Controls.Add(btn_Event_Color);
            Controls.Add(pictureBox4);
            Controls.Add(lb_ID);
            Controls.Add(lb_Remind);
            Controls.Add(cb_Remind);
            Controls.Add(pictureBox6);
            Controls.Add(btn_Information_Setting);
            Controls.Add(btn_Status_Setting);
            Controls.Add(tb_Content);
            Controls.Add(pb_Clock2);
            Controls.Add(pb_RightArrow2);
            Controls.Add(lb_Status_Setting);
            Controls.Add(lb_Information_Setting);
            Controls.Add(cb_Information_Setting);
            Controls.Add(cb_Status_Setting);
            Controls.Add(label4);
            Controls.Add(lb_Meeting_Tool);
            Controls.Add(lb_Participant);
            Controls.Add(btn_setting);
            Controls.Add(cb_Event);
            Controls.Add(label3);
            Controls.Add(lb_Location);
            Controls.Add(tb_Location);
            Controls.Add(cb_Meeting_Tool);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(lb_Repeat);
            Controls.Add(btn_Repeat);
            Controls.Add(btn_TimeSlot);
            Controls.Add(btn_AllTime);
            Controls.Add(cb_repeat);
            Controls.Add(cb_TimeSet1);
            Controls.Add(cb_TimeSet2);
            Controls.Add(lb_Title);
            Controls.Add(tb_Title);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pb_clock);
            Controls.Add(tb_Participant);
            Controls.Add(pb_RightArrow);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EventMaker";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pb_clock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_RightArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pn_Status_Setting.ResumeLayout(false);
            pn_Status_Setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_RightArrow2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Clock2).EndInit();
            pn_Information_Setting.ResumeLayout(false);
            pn_Information_Setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pn_Event_Color.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_clock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_TimeSet2;
        private System.Windows.Forms.ComboBox cb_TimeSet1;
        private System.Windows.Forms.PictureBox pb_RightArrow;
        private System.Windows.Forms.ComboBox cb_repeat;
        private System.Windows.Forms.Button btn_AllTime;
        private System.Windows.Forms.Button btn_TimeSlot;
        private System.Windows.Forms.Button btn_Repeat;
        private System.Windows.Forms.Label lb_Repeat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox cb_Meeting_Tool;
        private System.Windows.Forms.Label lb_Location;
        private System.Windows.Forms.TextBox tb_Location;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Event;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Label lb_Participant;
        private System.Windows.Forms.Label lb_Meeting_Tool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Status_Setting;
        private System.Windows.Forms.ComboBox cb_Information_Setting;
        private System.Windows.Forms.Label lb_Information_Setting;
        private System.Windows.Forms.Label lb_Status_Setting;
        private System.Windows.Forms.Panel pn_Status_Setting;
        private System.Windows.Forms.Label lb_Busy;
        private System.Windows.Forms.Label lb_Possibility;
        private System.Windows.Forms.TextBox tb_Participant;
        private System.Windows.Forms.PictureBox pb_RightArrow2;
        private System.Windows.Forms.PictureBox pb_Clock2;
        private System.Windows.Forms.TextBox tb_Content;
        private System.Windows.Forms.Button btn_Status_Setting;
        private System.Windows.Forms.Panel pn_Information_Setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Information_Setting;
        private System.Windows.Forms.ComboBox cb_Remind;
        private System.Windows.Forms.Label lb_Remind;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_Event_Color;
        private System.Windows.Forms.Panel pn_Event_Color;
        private System.Windows.Forms.Button btn_Event_Color_Yellow;
        private System.Windows.Forms.Button btn_Event_Color_Purple;
        private System.Windows.Forms.Button btn_Event_Color_Orange;
        private System.Windows.Forms.Button btn_Event_Color_Blue;
        private System.Windows.Forms.Button btn_Event_Color_Gray;
        private System.Windows.Forms.Button btn_Event_Color_Green;
        private System.Windows.Forms.Button btn_Event_Color_Red;
        private TextBox lb_Time;
        private TextBox lb_Time2;
    }
}

