using Newtonsoft.Json.Linq;
using GNaviDataClass;
using System.Web.Script.Serialization;

namespace GNaviWebAccess
{
    public static class AreaPrefMasterWebAccess
    {
        private const string URL_AREA_PREF_MASTER = "https://api.gnavi.co.jp/master/PrefSearchAPI/v3/";

        public static AreaPrefMasterDataClass GetDataFromGurunavi()
        {
            CommonWebAccessMasterInfo cWAInfo = new CommonWebAccessMasterInfo(URL_AREA_PREF_MASTER);
            JObject jobj = CommonGNWebAccess.CallWebAccessMaster(cWAInfo);

            CheckWebAccessResult.CheckAndThrowError(jobj);
            AreaPrefMasterDataClass dc = new JavaScriptSerializer().Deserialize<AreaPrefMasterDataClass>(jobj.ToString());
            return dc;
        }
    }
}