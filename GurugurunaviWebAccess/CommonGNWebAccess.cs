using System;
using GNaviCommonInfo;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;

namespace GNaviWebAccess
{
    public class CommonWebAccessMasterInfo
    {
        public string Url { get; private set; }
        public string Key { get { return GurugurunaviInfo.ApiKey; } private set {GurugurunaviInfo.ApiKey = value; } }
        public string Lang { get { return GurugurunaviInfo.Lang; } private set {GurugurunaviInfo.Lang = value; } }
        public CommonWebAccessMasterInfo(string url)
        {
            this.Url = url;
        }
        public CommonWebAccessMasterInfo(string url, string key)
        {
            this.Url = url;
            this.Key = key;
        }
    }

    public class CommonWebAccessRestaurantInfo
    {
        public string Url { get; private set; }
        public string Key { get { return GurugurunaviInfo.ApiKey; } private set {; } }
        public string Lang { get { return GurugurunaviInfo.Lang; } private set {; } }
        public string PrefCode { get; set; }
        public int Offset { get; set; }
        public int Hit_Per_Page { get; set; }
        public CommonWebAccessRestaurantInfo(string url, string prefCode, int offset, int hitPerPage)
        {
            this.Url = url;
            this.PrefCode = prefCode;
            this.Offset = offset;
            this.Hit_Per_Page = hitPerPage;
        }
    }

    public class Error
    {
        public string code { get; set; }
        public string message { get; set; }
    }

    public class ErrorResponse
    {
        public Error error { get; set; }
    }

    public static class CheckWebAccessResult
    {
        public static ErrorResponse CheckError(JObject jObj)
        {
            if (jObj.ContainsKey("error"))
            {
                return new JavaScriptSerializer().Deserialize<ErrorResponse>(jObj.ToString()); ;
            }
            return null;
        }

        public static void CheckAndThrowError(JObject jObj) {
            ErrorResponse er = CheckError(jObj);
            if (er == null)
            {
                throw new Exception($"{er.error.message}(errorcode:{er.error.code}) ");
            }
        }
    }

    public static class CommonGNWebAccess
    {
        public static JObject CallWebAccessMaster(CommonWebAccessMasterInfo cMasterInfo)
        {
            //接続先URLを作成
            string masterUrl = $"{cMasterInfo.Url}?keyid={cMasterInfo.Key}&lang={cMasterInfo.Lang}";

            string json = new HttpClient().GetStringAsync(masterUrl).Result;
            return JObject.Parse(json);
        }

        public static JObject CallWebAccessRestaurant(CommonWebAccessRestaurantInfo cRestaurantInfo)
        {
            //接続先URLを作成
            string baseUrl = cRestaurantInfo.Url;
            string keyid = cRestaurantInfo.Key;
            string pref = cRestaurantInfo.PrefCode;
            int offset = cRestaurantInfo.Offset;
            int hit_per_page = cRestaurantInfo.Hit_Per_Page;
            string url = $"{baseUrl}?keyid={keyid}&pref={pref}&hit_per_page={hit_per_page}&offset={offset}";

            string json = new HttpClient().GetStringAsync(url).Result;
            return JObject.Parse(json);
        }
    }
}
