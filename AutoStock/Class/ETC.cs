using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStock.Class
{
    internal class ETC
    {
    }


    public static class EqpLog
    {
        private static readonly object s_lock = new object();
        public static void Write(string log)
        {
            if (log == null) log = string.Empty;

            string time = DateTime.Now.ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture);
            string msg = $"{time} {log}";

            try
            {
                // TextOut/LogList.EnQ가 스레드 안전하지 않다면 이 lock을 유지하세요.
                lock (s_lock)
                {                    
                    // LogList.EnQ가 문자열 포맷을 기대하면 그에 맞게 전달
                    LogList.EnQ(time + "\t" + log);

                    WriteFile(time, log);
                }
            }
            catch (Exception ex)
            {
                // 로깅 실패는 앱을 중단시키면 안 됨 — 디버그 출력으로 실패 기록
                System.Diagnostics.Debug.WriteLine($"EqpLog.Write failed: {ex}");
            }
        }

        private static readonly string _baseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
        private static void WriteFile(string time, string msg)
        {
            try
            {
                var date = DateTime.Now.Date;
                string fileName = $"Log_{date:yyyyMMdd}.csv";
                string filePath = Path.Combine(_baseDirectory, fileName);

                bool exists = File.Exists(filePath);

                using (var sw = new StreamWriter(filePath, append: true, Encoding.UTF8))
                {
                    sw.WriteLine(time + "\t" + msg);
                }
            }
            catch (Exception err)
            {

            }
        }


    }
}
