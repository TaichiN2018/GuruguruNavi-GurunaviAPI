using System;
using System.Collections.Generic;

namespace GNaviDataClass
{
    public class Coupon_Url
    {
        public string pc { get; set; }
        public string mobile { get; set; }
    }

    public class Image_Url
    {
        public string shop_image1 { get; set; }
        public string shop_image2 { get; set; }
        public string qrcode { get; set; }
    }

    public class Access
    {
        public string line { get; set; }
        public string station { get; set; }
        public string station_exit { get; set; }
        public string walk { get; set; }
        public string note { get; set; }
    }

    public class Pr
    {
        public string pr_short { get; set; }
        public string pr_long { get; set; }
    }

    public class Code
    {
        public string areacode { get; set; }
        public string areaname { get; set; }
        public string prefcode { get; set; }
        public string prefname { get; set; }
        public string areacode_s { get; set; }
        public string areaname_s { get; set; }
        public List<string> category_code_l { get; set; }
        public List<string> category_name_l { get; set; }
        public List<string> category_code_s { get; set; }
        public List<string> category_name_s { get; set; }
    }

    public class Flags
    {
        public int mobile_site { get; set; }
        public int mobile_coupon { get; set; }
        public int pc_coupon { get; set; }
    }

    public class Rest
    {
        public string id { get; set; }
        public DateTime update_date { get; set; }
        public string name { get; set; }
        public string name_kana { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string category { get; set; }
        public string url { get; set; }
        public string url_mobile { get; set; }
        public Coupon_Url coupon_url { get; set; }
        public Image_Url image_url { get; set; }
        public string address { get; set; }
        public string tel { get; set; }
        public string tel_sub { get; set; }
        public string fax { get; set; }
        public string opentime { get; set; }
        public string holiday { get; set; }
        public Access access { get; set; }
        public string parking_lots { get; set; }
        public Pr pr { get; set; }
        public Code code { get; set; }
        public object budget { get; set; }
        public object party { get; set; }
        public object lunch { get; set; }
        public string credit_card { get; set; }
        public string e_money { get; set; }
        public Flags flags { get; set; }
    }

    public class SearchRestaurantDataClass
    {
        public int total_hit_count { get; set; }
        public int hit_per_page { get; set; }
        public int page_offset { get; set; }
        public List<Rest> rest { get; set; }
    }

    public class SearchRestaurantInfo
    {
        public Rest rest { get; set; }
        private int _daysAgo = 14;
        public int DaysAgo
        {
            get { return _daysAgo; }
            set { _daysAgo = value; }
        }
        public SearchRestaurantInfo()
        {
            this.rest = new Rest() { };
            this.rest.code = new Code() { };
        }
    }

    public class ShowRestaurantItem {
        public string id { get; set; }
        public int update_compare_leatest { get; set; }
        public int update_compare_oldest { get; set; }
        public Rest restInfo { get; set; }

        public ShowRestaurantItem() {
            this.id = string.Empty;
            this.update_compare_leatest = int.MinValue;
            this.update_compare_oldest = int.MinValue;
            restInfo = new Rest() { };
        }
    }

    public class ShowRestaurantDataClass
    {
        public List<ShowRestaurantItem> restList { get; set; }
        public ShowRestaurantDataClass() {
            restList = new List<ShowRestaurantItem>() { };
        }
    }
}
