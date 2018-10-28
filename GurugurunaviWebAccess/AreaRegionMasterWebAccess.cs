using Newtonsoft.Json.Linq;
using GNaviDataClass;
using System.Web.Script.Serialization;

namespace GNaviWebAccess
{
    public static class AreaRegionMasterWebAccess
    {
        private const string URL_AREA_REGION_MASTER = "https://api.gnavi.co.jp/master/AreaSearchAPI/v3/";

        public static AreaRegionMasterDataClass GetDataFromGurunavi()
        {
            CommonWebAccessMasterInfo cWAInfo = new CommonWebAccessMasterInfo(URL_AREA_REGION_MASTER);
            JObject jobj = CommonGNWebAccess.CallWebAccessMaster(cWAInfo);

            CheckWebAccessResult.CheckAndThrowError(jobj);
            AreaRegionMasterDataClass dc = new JavaScriptSerializer().Deserialize<AreaRegionMasterDataClass>(jobj.ToString());
            return dc;
        }
    }
}