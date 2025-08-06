namespace C_TeamProject
{
    partial class loginudc
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoing = new Button();
            button1 = new Button();
            lb_id = new Label();
            SuspendLayout();
            // 
            // btnLoing
            // 
            btnLoing.Location = new Point(19, 107);
            btnLoing.Name = "btnLoing";
            btnLoing.Size = new Size(75, 23);
            btnLoing.TabIndex = 9;
            btnLoing.Text = "로그인";
            btnLoing.UseVisualStyleBackColor = true;
            btnLoing.Click += btnLoing_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(113, 107);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "로그아웃";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lb_id
            // 
            lb_id.Location = new Point(53, 45);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(100, 23);
            lb_id.TabIndex = 12;
            lb_id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginudc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb_id);
            Controls.Add(button1);
            Controls.Add(btnLoing);
            Name = "loginudc";
            Size = new Size(210, 186);
            ResumeLayout(false);
        }

        #endregion
        private Button btnLoing;
        private Button button1;
        private Label lb_id;
    }
}
