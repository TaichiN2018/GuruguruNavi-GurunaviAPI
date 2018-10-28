using Newtonsoft.Json.Linq;
using GNaviDataClass;
using System.Web.Script.Serialization;

namespace GNaviWebAccess
{
    public static class AreaMiddleMasterWebAccess
    {
        private const string URL_AREA_MIDDLE_MASTER = "https://api.gnavi.co.jp/master/GAreaMiddleSearchAPI/v3/";

        public static AreaMiddleMasterDataClass GetDataFromGurunavi()
        {
            CommonWebAccessMasterInfo cWAInfo = new CommonWebAccessMasterInfo(URL_AREA_MIDDLE_MASTER);
            JObject jobj = CommonGNWebAccess.CallWebAccessMaster(cWAInfo);

            CheckWebAccessResult.CheckAndThrowError(jobj);
            AreaMiddleMasterDataClass dc = new JavaScriptSerializer().Deserialize<AreaMiddleMasterDataClass>(jobj.ToString());
            return dc;
        }
    }
}