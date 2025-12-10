using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AutoStock
{
    public partial class LogList : UserControl
    {
        #region Fields
        private static Queue<string> LogQ = new Queue<string>();
        private readonly static object m_LockKey = new object();
        private int m_MaxCount = 100;
        private static bool m_LogAble = false;
        #endregion

        #region Properties
        public bool LogAble
        {
            get { return m_LogAble; }
            set
            {
                m_LogAble = value;
                tmUpdate.Enabled = value;
                tmUpdate.Interval = 100;
            }
        }

        public int MaxCount
        {
            get { return m_MaxCount; }
            set { m_MaxCount = value; }
        }

        public Color TextColor
        {
            get { return this.lbLog.ForeColor; }
            set { this.lbLog.ForeColor = value; }
        }
        #endregion

        #region Constructor
        public LogList()
        {
            InitializeComponent();
            this.tmUpdate.Enabled = true;
        }
        #endregion

        public static void EnQ(string msg)
        {
            lock (m_LockKey)
            {
                if (m_LogAble)
                    LogQ.Enqueue(msg);
            }
        }

        private void tmUpdate_Tick(object sender, EventArgs e)
        {
            lock (m_LockKey)
            {
                if (LogQ.Count > 0)
                {
                    do
                    {
                        if (lbLog.Items.Count > m_MaxCount) lbLog.Items.RemoveAt(0);
                        lbLog.Items.Add(LogQ.Dequeue());
                        lbLog.SetSelected(lbLog.Items.Count - 1, true);
                    }
                    while (LogQ.Count > 0);
                }
            }
        }
    }
}
