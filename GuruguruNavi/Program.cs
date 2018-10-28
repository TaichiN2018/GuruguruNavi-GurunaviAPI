using System;
using System.Windows.Forms;

using GNaviManager;
using GNaviCommonInfo;

namespace GNaviMain
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //API用Keyの入力を求めるフォームを表示
            using (var dlg = new InputGurunaviApiDialog())
            {
                DialogResult dr = dlg.ExecuteModal();
                if (dr == DialogResult.OK)
                {
                    //最新のマスターとレストラン情報を全取得する。
                    if (!dlg.StartByOnlyLocalData)
                    {
                        GurugurunaviInfo.ApiKey = dlg.gNAPIKey;
                        GuruguruNaviManager.ReloadMasterData();
                        GuruguruNaviManager.GetLeatestRestaurantDataFromWeb();
                    }

                    Application.Run(new MainForm());
                }
            }
        }
    }
}
