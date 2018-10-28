using Newtonsoft.Json.Linq;

namespace GNaviWebAccess
{
    public class CheckGNInfoWebAccess
    {
        private const string URL_AREA_REGION_MASTER = "https://api.gnavi.co.jp/master/AreaSearchAPI/v3/";

        public static string ERROR_CODE_NOT_VALID = "401";
        public static bool IsErrorNotValid(string APIKey)
        {
            //マスターにアクセスしたレスポンスを基に有効性を判断。
            //エラーコード401のみ無効と判断する。
            CommonWebAccessMasterInfo cWAInfo = new CommonWebAccessMasterInfo(URL_AREA_REGION_MASTER);
            JObject jobj = CommonGNWebAccess.CallWebAccessMaster(cWAInfo);

            ErrorResponse er = CheckWebAccessResult.CheckError(jobj);
            if (er != null) {
                if (er.error.code == ERROR_CODE_NOT_VALID) {
                    return false;
                }
            }
            return true;
        }
    }
}
