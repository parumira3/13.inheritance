namespace _13.inheritance
{
    partial class Form1
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
            this.pMain = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.btnOneCycle = new System.Windows.Forms.Button();
            this.btnCycle = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(600, 300);
            this.pMain.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbName.Location = new System.Drawing.Point(22, 331);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(72, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "외발자전거";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOneCycle
            // 
            this.btnOneCycle.Location = new System.Drawing.Point(107, 333);
            this.btnOneCycle.Name = "btnOneCycle";
            this.btnOneCycle.Size = new System.Drawing.Size(159, 23);
            this.btnOneCycle.TabIndex = 2;
            this.btnOneCycle.Text = "1단계 : 외발자전거";
            this.btnOneCycle.UseVisualStyleBackColor = true;
            this.btnOneCycle.Click += new System.EventHandler(this.btnOneCycle_Click);
            // 
            // btnCycle
            // 
            this.btnCycle.Location = new System.Drawing.Point(272, 333);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(159, 23);
            this.btnCycle.TabIndex = 3;
            this.btnCycle.Text = "2단계 : 자전거";
            this.btnCycle.UseVisualStyleBackColor = true;
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(438, 333);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(159, 23);
            this.btnCar.TabIndex = 4;
            this.btnCar.Text = "3단계 : 자동차";
            this.btnCar.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(189, 363);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(159, 43);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "<--";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(355, 363);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(159, 43);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "-->";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 473);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnCycle);
            this.Controls.Add(this.btnOneCycle);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnOneCycle;
        private System.Windows.Forms.Button btnCycle;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
    }
}

