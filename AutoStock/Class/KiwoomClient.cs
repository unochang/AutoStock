using KHOpenApi.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStock.Class
{
    public class KiwoomClient
    {

        private static readonly Lazy<KiwoomClient> _instance =
                            new Lazy<KiwoomClient>(() => new KiwoomClient());

        public static KiwoomClient Instance => _instance.Value;




        public readonly AxKHOpenAPI _ax;

        #region 생성자
        public KiwoomClient()
        {
            var httpClient = new HttpClient();
            _ax = new AxKHOpenAPI( );

            _ax.OnReceiveTrData += OnReceiveTrData;
            _ax.OnReceiveRealData += OnReceiveRealData;
            _ax.OnReceiveChejanData += OnReceiveChejanData;  // 계약 체결 이벤트 처리기 등록
        }
        private void OnReceiveChejanData(object sender, _DKHOpenAPIEvents_OnReceiveChejanDataEvent e)
        {

        }
        private void OnReceiveRealData(object sender, _DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {

        }

        private void OnReceiveTrData(object sender, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {

        }





        #endregion





        //===============================================================
    }
}
