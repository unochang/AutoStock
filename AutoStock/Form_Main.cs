using AutoStock.Class;
using KHOpenApi.NET;

namespace AutoStock
{
    public partial class Form_Main : Form
    {
        private AxKHOpenAPI axKHOpenAPI;

        public Form_Main()
        {
            InitializeComponent();
            CreateKiwoomApi();
        }

        #region 초기 환경 설정
        private void CreateKiwoomApi()
        {
            axKHOpenAPI = new AxKHOpenAPI(Handle);
        }

        #endregion



            #region Menu Strip Event
        private async void 로그인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var (ret, msg) = await KiwoomClient.Instance._ax.CommConnectAsync();
            if (ret == 0)
            {
                // 로그인 성공
                EqpLog.Write("로그인 성공");
                EqpLog.Write("사용자ID = " + axKHOpenAPI.GetLoginInfo("USER_ID"));
                EqpLog.Write("사용자명 = " + axKHOpenAPI.GetLoginInfo("USER_NAME"));
                EqpLog.Write("계좌 갯수 = " + axKHOpenAPI.GetLoginInfo("ACCOUNT_CNT"));

                string[] accList = axKHOpenAPI.GetLoginInfo("ACCLIST").Split(';', (char)StringSplitOptions.RemoveEmptyEntries);

                cbo계좌.Items.AddRange(accList);
            }
            else
            {
                // 로그인 실패
                EqpLog.Write("로그인 실패: " + msg.ToString());
            }
        }

        #endregion
    }
}
