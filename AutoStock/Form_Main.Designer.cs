namespace AutoStock
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer_Main = new SplitContainer();
            splitContainer3 = new SplitContainer();
            btn_SearchStockInfo = new Button();
            b_SearchStockInfo = new TextBox();
            cbo계좌 = new ComboBox();
            tb_cash = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_positions = new DataGridView();
            splitContainer2 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgv_buyList = new DataGridView();
            tabPage2 = new TabPage();
            logList1 = new LogList();
            menuStrip1 = new MenuStrip();
            로그인ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer_Main).BeginInit();
            splitContainer_Main.Panel1.SuspendLayout();
            splitContainer_Main.Panel2.SuspendLayout();
            splitContainer_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_positions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_buyList).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer_Main
            // 
            splitContainer_Main.Dock = DockStyle.Fill;
            splitContainer_Main.Location = new Point(0, 24);
            splitContainer_Main.Name = "splitContainer_Main";
            splitContainer_Main.Orientation = Orientation.Horizontal;
            // 
            // splitContainer_Main.Panel1
            // 
            splitContainer_Main.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer_Main.Panel2
            // 
            splitContainer_Main.Panel2.Controls.Add(splitContainer2);
            splitContainer_Main.Size = new Size(800, 631);
            splitContainer_Main.SplitterDistance = 196;
            splitContainer_Main.TabIndex = 1;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(btn_SearchStockInfo);
            splitContainer3.Panel1.Controls.Add(b_SearchStockInfo);
            splitContainer3.Panel1.Controls.Add(cbo계좌);
            splitContainer3.Panel1.Controls.Add(tb_cash);
            splitContainer3.Panel1.Controls.Add(label2);
            splitContainer3.Panel1.Controls.Add(label1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(dgv_positions);
            splitContainer3.Size = new Size(800, 196);
            splitContainer3.SplitterDistance = 72;
            splitContainer3.TabIndex = 0;
            // 
            // btn_SearchStockInfo
            // 
            btn_SearchStockInfo.Location = new Point(743, 7);
            btn_SearchStockInfo.Name = "btn_SearchStockInfo";
            btn_SearchStockInfo.Size = new Size(45, 23);
            btn_SearchStockInfo.TabIndex = 3;
            btn_SearchStockInfo.Text = "확인";
            btn_SearchStockInfo.UseVisualStyleBackColor = true;
            // 
            // b_SearchStockInfo
            // 
            b_SearchStockInfo.Location = new Point(637, 7);
            b_SearchStockInfo.Name = "b_SearchStockInfo";
            b_SearchStockInfo.Size = new Size(100, 23);
            b_SearchStockInfo.TabIndex = 2;
            b_SearchStockInfo.Text = "171090";
            // 
            // cbo계좌
            // 
            cbo계좌.FormattingEnabled = true;
            cbo계좌.Location = new Point(89, 7);
            cbo계좌.Name = "cbo계좌";
            cbo계좌.Size = new Size(121, 23);
            cbo계좌.TabIndex = 1;
            // 
            // tb_cash
            // 
            tb_cash.Location = new Point(89, 39);
            tb_cash.Name = "tb_cash";
            tb_cash.RightToLeft = RightToLeft.Yes;
            tb_cash.Size = new Size(121, 15);
            tb_cash.TabIndex = 0;
            tb_cash.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 39);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "예수금";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "계좌 리스트";
            // 
            // dgv_positions
            // 
            dgv_positions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_positions.Dock = DockStyle.Fill;
            dgv_positions.Location = new Point(0, 0);
            dgv_positions.Name = "dgv_positions";
            dgv_positions.Size = new Size(800, 120);
            dgv_positions.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(logList1);
            splitContainer2.Size = new Size(800, 431);
            splitContainer2.SplitterDistance = 151;
            splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 151);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgv_buyList);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 123);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_buyList
            // 
            dgv_buyList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_buyList.Dock = DockStyle.Fill;
            dgv_buyList.Location = new Point(3, 3);
            dgv_buyList.Name = "dgv_buyList";
            dgv_buyList.Size = new Size(786, 117);
            dgv_buyList.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 123);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // logList1
            // 
            logList1.Dock = DockStyle.Fill;
            logList1.Location = new Point(0, 0);
            logList1.LogAble = true;
            logList1.Margin = new Padding(3, 4, 3, 4);
            logList1.MaxCount = 100;
            logList1.Name = "logList1";
            logList1.Size = new Size(800, 276);
            logList1.TabIndex = 0;
            logList1.TextColor = SystemColors.WindowText;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 로그인ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // 로그인ToolStripMenuItem
            // 
            로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            로그인ToolStripMenuItem.Size = new Size(55, 20);
            로그인ToolStripMenuItem.Text = "로그인";
            로그인ToolStripMenuItem.Click += 로그인ToolStripMenuItem_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 655);
            Controls.Add(splitContainer_Main);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Main";
            Text = "Form1";
            splitContainer_Main.Panel1.ResumeLayout(false);
            splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_Main).EndInit();
            splitContainer_Main.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_positions).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_buyList).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer splitContainer_Main;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer2;
        private LogList logList1;
        private DataGridView dgv_positions;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgv_buyList;
        private TabPage tabPage2;
        private ComboBox cbo계좌;
        private Label label1;
        private Button btn_SearchStockInfo;
        private TextBox b_SearchStockInfo;
        private Label tb_cash;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 로그인ToolStripMenuItem;
    }
}
