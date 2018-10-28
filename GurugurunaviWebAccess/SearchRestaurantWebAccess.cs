using System.IO;
using Newtonsoft.Json.Linq;
using GNaviDataClass;
using System.Web.Script.Serialization;

namespace GNaviWebAccess
{
    public static class SearchRestaurantWebAccess
    {
        private const string URL_SEARCH_RESTAURANT = "https://api.gnavi.co.jp/RestSearchAPI/v3/";

        public static SearchRestaurantDataClass GetDataFromJsonFile(string filepath)
        {
            SearchRestaurantDataClass dc = null;

            if (File.Exists(filepath))
            {
                JObject jobj = JObject.Parse(File.ReadAllText(filepath));
                CheckWebAccessResult.CheckAndThrowError(jobj);
                dc = new JavaScriptSerializer().Deserialize<SearchRestaurantDataClass>(jobj.ToString());
            }
            return dc;
        }

        public static SearchRestaurantDataClass GetDataFromGurunaviByPrefCode(string prefCode)
        {
            int hitPerPage = 100; //1page当たりで表示するレストラン数
            CommonWebAccessRestaurantInfo cRestaurantInfo = new CommonWebAccessRestaurantInfo(
                URL_SEARCH_RESTAURANT,
                prefCode,
                1,//一軒目から
                hitPerPage
                );
            JObject jobj = CommonGNWebAccess.CallWebAccessRestaurant(cRestaurantInfo);
            CheckWebAccessResult.CheckAndThrowError(jobj);
            SearchRestaurantDataClass dc = new JavaScriptSerializer().Deserialize<SearchRestaurantDataClass>(jobj.ToString());

            //複数ページ取得
            int total = dc.total_hit_count;
            int pageCount = total / cRestaurantInfo.Hit_Per_Page;
            bool hasuuAri = total % cRestaurantInfo.Hit_Per_Page > 0;
            if (hasuuAri)
            {
                pageCount++;
            }

            //※ぐるなびの仕様対応
            //10ページが上限
            if (pageCount > 10)
            {
                pageCount = 10;
            }

            for (int i = 1; i < pageCount; i++)
            {
                //開始位置だけ変更(次の{hitPerPage}件)
                cRestaurantInfo.Offset += hitPerPage;
                jobj = CommonGNWebAccess.CallWebAccessRestaurant(cRestaurantInfo);
                CheckWebAccessResult.CheckAndThrowError(jobj);
                SearchRestaurantDataClass dcMultiPage = new JavaScriptSerializer().Deserialize<SearchRestaurantDataClass>(jobj.ToString());
                dc.rest.AddRange(dcMultiPage.rest);
            }
            return dc;
        }
    }
}