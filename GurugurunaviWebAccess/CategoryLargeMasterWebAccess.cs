using Newtonsoft.Json.Linq;
using GNaviDataClass;
using System.Web.Script.Serialization;

namespace GNaviWebAccess
{
    public static class CategoryLargeMasterWebAccess
    {

        private const string URL_CATEGORY_LARGE = "https://api.gnavi.co.jp/master/CategoryLargeSearchAPI/v3/";

        public static CategoryLargeMasterDataClass GetDataFromGurunavi()
        {
            CommonWebAccessMasterInfo cWAInfo = new CommonWebAccessMasterInfo(URL_CATEGORY_LARGE);
            JObject jobj = CommonGNWebAccess.CallWebAccessMaster(cWAInfo);

            CheckWebAccessResult.CheckAndThrowError(jobj);
            CategoryLargeMasterDataClass dc = new JavaScriptSerializer().Deserialize<CategoryLargeMasterDataClass>(jobj.ToString());
            return dc;
        }
    }
}
