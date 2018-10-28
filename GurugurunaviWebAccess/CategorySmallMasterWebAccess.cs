using Newtonsoft.Json.Linq;
using GNaviDataClass;
using System.Web.Script.Serialization;

namespace GNaviWebAccess
{
    public static class CategorySmallMasterWebAccess
    {
        private const string URL_CATEGORY_SMALL = "https://api.gnavi.co.jp/master/CategorySmallSearchAPI/v3/";

        public static CategorySmallMasterDataClass GetDataFromGurunavi()
        {
            CommonWebAccessMasterInfo cWAInfo = new CommonWebAccessMasterInfo(URL_CATEGORY_SMALL);
            JObject jobj = CommonGNWebAccess.CallWebAccessMaster(cWAInfo);

            CheckWebAccessResult.CheckAndThrowError(jobj);
            CategorySmallMasterDataClass dc = new JavaScriptSerializer().Deserialize<CategorySmallMasterDataClass>(jobj.ToString());
            return dc;
        }
    }
}
