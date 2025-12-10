namespace AutoStock
{
    partial class LogList
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbLog = new ListBox();
            tmUpdate = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbLog
            // 
            lbLog.Dock = DockStyle.Fill;
            lbLog.FormattingEnabled = true;
            lbLog.ItemHeight = 15;
            lbLog.Location = new Point(0, 0);
            lbLog.Margin = new Padding(3, 4, 3, 4);
            lbLog.Name = "lbLog";
            lbLog.Size = new Size(548, 212);
            lbLog.TabIndex = 0;
            // 
            // tmUpdate
            // 
            tmUpdate.Enabled = true;
            tmUpdate.Tick += tmUpdate_Tick;
            // 
            // LogList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbLog);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LogList";
            Size = new Size(548, 212);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Timer tmUpdate;
    }
}
