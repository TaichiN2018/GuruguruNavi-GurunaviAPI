using Newtonsoft.Json.Linq;
using GNaviDataClass;
using System.Web.Script.Serialization;

namespace GNaviWebAccess
{
    public static class AreaSmallMasterWebAccess
    {
        private const string URL_AREA_SMALL_MASTER = "https://api.gnavi.co.jp/master/GAreaSmallSearchAPI/v3/";

        public static AreaSmallMasterDataClass GetDataFromGurunavi()
        {
            CommonWebAccessMasterInfo cMasterInfo = new CommonWebAccessMasterInfo(URL_AREA_SMALL_MASTER);
            JObject jobj = CommonGNWebAccess.CallWebAccessMaster(cMasterInfo);

            CheckWebAccessResult.CheckAndThrowError(jobj);
            AreaSmallMasterDataClass dc = new JavaScriptSerializer().Deserialize<AreaSmallMasterDataClass>(jobj.ToString());
            return dc;
        }
    }
}