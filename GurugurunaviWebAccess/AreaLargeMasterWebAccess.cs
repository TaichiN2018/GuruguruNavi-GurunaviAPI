using Newtonsoft.Json.Linq;
using GNaviDataClass;
using System.Web.Script.Serialization;

namespace GNaviWebAccess
{
    public class AreaLargeMasterWebAccess
    {
        private const string URL_AREA_LARGE_MASTER = "https://api.gnavi.co.jp/master/GAreaLargeSearchAPI/v3/";
        public static AreaLargeMasterDataClass GetDataFromGurunavi()
        {
            CommonWebAccessMasterInfo cWAInfo = new CommonWebAccessMasterInfo(URL_AREA_LARGE_MASTER);
            JObject jobj = CommonGNWebAccess.CallWebAccessMaster(cWAInfo);

            CheckWebAccessResult.CheckAndThrowError(jobj);
            AreaLargeMasterDataClass dc = new JavaScriptSerializer().Deserialize<AreaLargeMasterDataClass>(jobj.ToString());
            return dc;
        }
    }
}
