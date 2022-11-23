namespace HelloMyCSharp03
{
    partial class MainForm
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_mbox = new System.Windows.Forms.Button();
            this.button1_customized = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.circularButton1 = new HelloMyCSharp03.CircularButton();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(121, 37);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(277, 21);
            this.textBox_input.TabIndex = 0;
            // 
            // button_mbox
            // 
            this.button_mbox.Location = new System.Drawing.Point(55, 103);
            this.button_mbox.Name = "button_mbox";
            this.button_mbox.Size = new System.Drawing.Size(75, 23);
            this.button_mbox.TabIndex = 1;
            this.button_mbox.Text = "메시지박스";
            this.button_mbox.UseVisualStyleBackColor = true;
            this.button_mbox.Click += new System.EventHandler(this.MBox_Click);
            // 
            // button1_customized
            // 
            this.button1_customized.Location = new System.Drawing.Point(166, 103);
            this.button1_customized.Name = "button1_customized";
            this.button1_customized.Size = new System.Drawing.Size(75, 23);
            this.button1_customized.TabIndex = 2;
            this.button1_customized.Text = "맞춤박스";
            this.button1_customized.UseVisualStyleBackColor = true;
            this.button1_customized.Click += new System.EventHandler(this.button1_customized_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "글자입력";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(55, 156);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(221, 23);
            this.button_show.TabIndex = 4;
            this.button_show.Text = "그냥 창 띄우기";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Location = new System.Drawing.Point(303, 64);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(365, 342);
            this.circularButton1.TabIndex = 5;
            this.circularButton1.Text = "circularButton1";
            this.circularButton1.UseVisualStyleBackColor = false;
            this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circularButton1);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_customized);
            this.Controls.Add(this.button_mbox);
            this.Controls.Add(this.textBox_input);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_mbox;
        private System.Windows.Forms.Button button1_customized;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private CircularButton circularButton1;
    }
}

