using System;
using System.Collections.Generic;
using System.Data.SQLite;
using GNaviDataClass;

namespace GNaviDataAccess
{
    public class SearchRestaurantDataAccess
    {
        public void CreateTable()
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    cmd.CommandText =
                        "CREATE TABLE IF NOT EXISTS SEARCH_RESTAURANT("
                        + "id STRING NOT NULL,"
                        + "update_date_for_compare INTEGER NOT NULL,"
                        + "update_date TEXT NOT NULL,"
                        + "name STRING,"
                        + "name_kana STRING,"
                        + "latitude STRING,"
                        + "longitude STRING,"
                        + "category STRING,"
                        + "url STRING,"
                        + "url_mobile STRING,"
                        + "coupon_url_pc STRING,"
                        + "coupon_url_mobile STRING,"
                        + "image_url_shop1 STRING,"
                        + "image_url_shop2 STRING,"
                        + "image_url_qrcode STRING,"
                        + "address STRING,"
                        + "tel STRING,"
                        + "tel_sub STRING,"
                        + "fax STRING,"
                        + "opentime STRING,"
                        + "holiday STRING,"
                        + "access_line STRING,"
                        + "access_station STRING,"
                        + "access_station_exit STRING,"
                        + "access_walk STRING,"
                        + "access_note STRING,"
                        + "parking_lots STRING,"
                        + "pr_short STRING,"
                        + "pr_long STRING,"
                        + "code_AreaRegionCode STRING,"
                        + "code_AreaRegionName STRING,"
                        + "code_AreaPrefCode STRING,"
                        + "code_AreaPrefName STRING,"
                        + "code_AreaSmallCode STRING,"
                        + "code_AreaSmallName STRING,"
                        + "code_Category_Code_L STRING,"
                        + "code_Category_Name_L STRING,"
                        + "code_Category_Code_S STRING,"
                        + "code_Category_Name_S STRING,"
                        + "budget STRING,"
                        + "party STRING,"
                        + "lunch STRING,"
                        + "credit_card STRING,"
                        + "e_money STRING,"
                        + "flags_mobile_site STRING,"
                        + "flags_mobile_coupon STRING,"
                        + "flags_pc_coupon STRING,"
                        + "PRIMARY KEY(id, update_date_for_compare))";
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        public void DropTable()
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    cmd.CommandText =
                        "DROP TABLE IF EXISTS SEARCH_RESTAURANT";
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        public void InitializeTable()
        {
            DropTable();
            CreateTable();
        }

        //todo:他以上に改善すべきコード
        //スペシャルロジック
        private string ReplaceChar(string s)
        {
            s = s.Replace("'", "-");
            return s;
        }

        public void UpdateData(SearchRestaurantDataClass dc)
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    foreach (Rest r in dc.rest)
                    {
                        cmd.CommandText = "SELECT * FROM SEARCH_RESTAURANT WHERE id = :id and update_date_for_compare = :update_date_for_compare";
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("id", System.Data.DbType.String).Value = r.id;
                        cmd.Parameters.Add("update_date_for_compare", System.Data.DbType.Int32).Value = $" {r.update_date.Year * 10000 + r.update_date.Month * 100 + r.update_date.Day}";
                        bool IsRowAri = false;
                        var reader = cmd.ExecuteReader();
                        try
                        {
                            while (reader.Read())
                            {
                                IsRowAri = true;
                                break;
                            }
                        }
                        finally
                        {
                            reader.Close();
                        }
                        if (IsRowAri)
                        {

                        }
                        else
                        {
                            cmd.CommandText =
                                "INSERT INTO SEARCH_RESTAURANT("
                                + "id, "
                                + "update_date_for_compare, "
                                + "update_date, "
                                + "name, "
                                + "name_kana, "
                                + "latitude, "
                                + "longitude, "
                                + "category, "
                                + "url, "
                                + "url_mobile, "
                                + "coupon_url_pc, "
                                + "coupon_url_mobile, "
                                + "image_url_shop1, "
                                + "image_url_shop2, "
                                + "image_url_qrcode, "
                                + "address, "
                                + "tel, "
                                + "tel_sub, "
                                + "fax, "
                                + "opentime, "
                                + "holiday, "
                                + "access_line, "
                                + "access_station ,"
                                + "access_station_exit, "
                                + "access_walk, "
                                + "access_note, "
                                + "parking_lots, "
                                + "pr_short, "
                                + "pr_long, "
                                + "code_AreaRegionCode, "
                                + "code_AreaRegionName, "
                                + "code_AreaPrefCode, "
                                + "code_AreaPrefName, "
                                + "code_AreaSmallCode, "
                                + "code_AreaSmallName, "
                                + "code_Category_Code_L, "
                                + "code_Category_Name_L, "
                                + "code_Category_Code_S, "
                                + "code_Category_Name_S, "
                                + "budget, "
                                + "party, "
                                + "lunch, "
                                + "credit_card, "
                                + "e_money, "
                                + "flags_mobile_site, "
                                + "flags_mobile_coupon, "
                                + "flags_pc_coupon) VALUES(" +
                                $"'{r.id}'," +
                                $" {r.update_date.Year * 10000 + r.update_date.Month * 100 + r.update_date.Day}, " +
                                $"'{r.update_date}', " +
                                $"'{ReplaceChar(r.name)}', " +
                                $"'{r.name_kana}', " +
                                $"'{r.latitude}', " +
                                $"'{r.longitude}', " +
                                $"'{r.category}', " +
                                $"'{r.url}', " +
                                $"'{r.url_mobile}', " +
                                $"'{r.coupon_url.pc}', " +
                                $"'{r.coupon_url.mobile}', " +
                                $"'{r.image_url.shop_image1}', " +
                                $"'{r.image_url.shop_image2}', " +
                                $"'{r.image_url.qrcode}', " +
                                $"'{ReplaceChar(r.address)}', " +
                                $"'{r.tel}', " +
                                $"'{r.tel_sub}', " +
                                $"'{r.fax}', " +
                                $"'{r.opentime}', " +
                                $"'{r.holiday}', " +
                                $"'{ReplaceChar(r.access.line)}', " +
                                $"'{ReplaceChar(r.access.station)}', " +
                                $"'{ReplaceChar(r.access.station_exit)}', " +
                                $"'{ReplaceChar(r.access.walk)}', " +
                                $"'{ReplaceChar(r.access.note)}', " +
                                $"'{ReplaceChar(r.parking_lots)}', " +
                                $"'{ReplaceChar(r.pr.pr_short)}', " +
                                $"'{ReplaceChar(r.pr.pr_long)}', " +
                                $"'{r.code.areacode}', " +
                                $"'{r.code.areaname}', " +
                                $"'{r.code.prefcode}', " +
                                $"'{r.code.prefname}', " +
                                $"'{r.code.areacode_s}', " +
                                $"'{r.code.areaname_s}', " +
                                $"'{r.code.category_code_l[0]}', " +
                                $"'{r.code.category_name_l[0]}', " +
                                $"'{r.code.category_code_s[0]}', " +
                                $"'{r.code.category_name_s[0]}', " +
                                $"'{r.budget.ToString()}', " +
                                $"'{r.party.ToString()}', " +
                                $"'{r.lunch.ToString()}', " +
                                $"'{r.credit_card}', " +
                                $"'{r.e_money}', " +
                                $"'{r.flags.mobile_site}', " +
                                $"'{r.flags.mobile_coupon}', " +
                                $"'{r.flags.pc_coupon}')";
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        public void SelectData(SearchRestaurantInfo sRInfo)
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                con.OpenConnection();
                try
                {
                    //MASTER(AREA)
                    cmd.CommandText =
                        "CREATE TABLE IF NOT EXISTS MASTER_AREA("
                        + "area_code STRING NOT NULL PRIMARY KEY,"
                        + "area_name STRING NOT NULL)";
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        private void SetSelectResultToDataClass(SQLiteCommand cmd, SearchRestaurantDataClass dc)
        {
            SQLiteDataReader resultReader = cmd.ExecuteReader();
            try
            {
                while (resultReader.Read())
                {
                    Rest r = new Rest() { };
                    r.id = resultReader["id"].ToString();
                    r.update_date = DateTime.Parse(resultReader["update_date"].ToString());
                    r.name = resultReader["name"].ToString();
                    r.name_kana = resultReader["name_kana"].ToString();
                    r.latitude = resultReader["latitude"].ToString();
                    r.longitude = resultReader["longitude"].ToString();
                    r.category = resultReader["category"].ToString();
                    r.url = resultReader["url"].ToString();
                    r.url_mobile = resultReader["url_mobile"].ToString();
                    r.coupon_url = new Coupon_Url() { };
                    r.coupon_url.pc = resultReader["coupon_url_pc"].ToString();
                    r.coupon_url.mobile = resultReader["coupon_url_mobile"].ToString();
                    r.image_url = new Image_Url() { };
                    r.image_url.shop_image1 = resultReader["image_url_shop1"].ToString();
                    r.image_url.shop_image2 = resultReader["image_url_shop2"].ToString();
                    r.image_url.qrcode = resultReader["image_url_qrcode"].ToString();
                    r.address = resultReader["address"].ToString();
                    r.tel = resultReader["tel"].ToString();
                    r.tel_sub = resultReader["tel_sub"].ToString();
                    r.fax = resultReader["fax"].ToString();
                    r.opentime = resultReader["opentime"].ToString();
                    r.holiday = resultReader["holiday"].ToString();
                    r.access = new Access() { };
                    r.access.line = resultReader["access_line"].ToString();
                    r.access.station = resultReader["access_station"].ToString();
                    r.access.station_exit = resultReader["access_station_exit"].ToString();
                    r.access.walk = resultReader["access_walk"].ToString();
                    r.access.note = resultReader["access_note"].ToString();
                    r.parking_lots = resultReader["parking_lots"].ToString();
                    r.pr = new Pr() { };
                    r.pr.pr_short = resultReader["pr_short"].ToString();
                    r.pr.pr_long = resultReader["pr_long"].ToString();
                    r.code = new Code() { };
                    r.code.areacode = resultReader["code_AreaRegionCode"].ToString();
                    r.code.areaname = resultReader["code_AreaRegionName"].ToString();
                    r.code.prefcode = resultReader["code_AreaPrefCode"].ToString();
                    r.code.prefname = resultReader["code_AreaPrefName"].ToString();
                    r.code.areacode_s = resultReader["code_AreaSmallCode"].ToString();
                    r.code.areaname_s = resultReader["code_AreaSmallName"].ToString();
                    r.code.category_code_l = new List<string>() { };
                    r.code.category_code_l.Add(resultReader["code_Category_Code_L"].ToString());
                    r.code.category_name_l = new List<string>() { };
                    r.code.category_name_l.Add(resultReader["code_Category_Name_L"].ToString());
                    r.code.category_code_s = new List<string>() { };
                    r.code.category_code_s.Add(resultReader["code_Category_Code_S"].ToString());
                    r.code.category_name_s = new List<string>() { };
                    r.code.category_name_s.Add(resultReader["code_Category_Name_S"].ToString());
                    r.budget = resultReader["budget"].ToString();
                    r.party = resultReader["party"].ToString();
                    r.lunch = resultReader["lunch"].ToString();
                    r.credit_card = resultReader["credit_card"].ToString();
                    r.e_money = resultReader["e_money"].ToString();
                    r.flags = new Flags() { };
                    r.flags.mobile_site = int.Parse(resultReader["flags_mobile_site"].ToString());
                    r.flags.mobile_coupon = int.Parse(resultReader["flags_mobile_coupon"].ToString());
                    r.flags.pc_coupon = int.Parse(resultReader["flags_pc_coupon"].ToString());

                    dc.rest.Add(r);
                }
            }
            finally
            {
                resultReader.Close();
            }
        }

        private void SetSelectResultToDataClass(SQLiteCommand cmd, ShowRestaurantDataClass dc)
        {
            SQLiteDataReader resultReader = cmd.ExecuteReader();
            try
            {
                while (resultReader.Read())
                {
                    ShowRestaurantItem rItem = new ShowRestaurantItem() { };
                    dc.restList.Add(rItem);

                    rItem.id = resultReader["id"].ToString();
                    rItem.update_compare_leatest = int.Parse(resultReader["leatestDate"].ToString());
                    rItem.update_compare_oldest = int.Parse(resultReader["oldestDate"].ToString());
                    rItem.restInfo.id = resultReader["id"].ToString();
                    rItem.restInfo.update_date = DateTime.Parse(resultReader["update_date"].ToString());
                    rItem.restInfo.name = resultReader["name"].ToString();
                    rItem.restInfo.name_kana = resultReader["name_kana"].ToString();
                    rItem.restInfo.latitude = resultReader["latitude"].ToString();
                    rItem.restInfo.longitude = resultReader["longitude"].ToString();
                    rItem.restInfo.category = resultReader["category"].ToString();
                    rItem.restInfo.url = resultReader["url"].ToString();
                    rItem.restInfo.url_mobile = resultReader["url_mobile"].ToString();
                    rItem.restInfo.coupon_url = new Coupon_Url() { };
                    rItem.restInfo.coupon_url.pc = resultReader["coupon_url_pc"].ToString();
                    rItem.restInfo.coupon_url.mobile = resultReader["coupon_url_mobile"].ToString();
                    rItem.restInfo.image_url = new Image_Url() { };
                    rItem.restInfo.image_url.shop_image1 = resultReader["image_url_shop1"].ToString();
                    rItem.restInfo.image_url.shop_image2 = resultReader["image_url_shop2"].ToString();
                    rItem.restInfo.image_url.qrcode = resultReader["image_url_qrcode"].ToString();
                    rItem.restInfo.address = resultReader["address"].ToString();
                    rItem.restInfo.tel = resultReader["tel"].ToString();
                    rItem.restInfo.tel_sub = resultReader["tel_sub"].ToString();
                    rItem.restInfo.fax = resultReader["fax"].ToString();
                    rItem.restInfo.opentime = resultReader["opentime"].ToString();
                    rItem.restInfo.holiday = resultReader["holiday"].ToString();
                    rItem.restInfo.access = new Access() { };
                    rItem.restInfo.access.line = resultReader["access_line"].ToString();
                    rItem.restInfo.access.station = resultReader["access_station"].ToString();
                    rItem.restInfo.access.station_exit = resultReader["access_station_exit"].ToString();
                    rItem.restInfo.access.walk = resultReader["access_walk"].ToString();
                    rItem.restInfo.access.note = resultReader["access_note"].ToString();
                    rItem.restInfo.parking_lots = resultReader["parking_lots"].ToString();
                    rItem.restInfo.pr = new Pr() { };
                    rItem.restInfo.pr.pr_short = resultReader["pr_short"].ToString();
                    rItem.restInfo.pr.pr_long = resultReader["pr_long"].ToString();
                    rItem.restInfo.code = new Code() { };
                    rItem.restInfo.code.areacode = resultReader["code_AreaRegionCode"].ToString();
                    rItem.restInfo.code.areaname = resultReader["code_AreaRegionName"].ToString();
                    rItem.restInfo.code.prefcode = resultReader["code_AreaPrefCode"].ToString();
                    rItem.restInfo.code.prefname = resultReader["code_AreaPrefName"].ToString();
                    rItem.restInfo.code.areacode_s = resultReader["code_AreaSmallCode"].ToString();
                    rItem.restInfo.code.areaname_s = resultReader["code_AreaSmallName"].ToString();
                    rItem.restInfo.code.category_code_l = new List<string>() { };
                    rItem.restInfo.code.category_code_l.Add(resultReader["code_Category_Code_L"].ToString());
                    rItem.restInfo.code.category_name_l = new List<string>() { };
                    rItem.restInfo.code.category_name_l.Add(resultReader["code_Category_Name_L"].ToString());
                    rItem.restInfo.code.category_code_s = new List<string>() { };
                    rItem.restInfo.code.category_code_s.Add(resultReader["code_Category_Code_S"].ToString());
                    rItem.restInfo.code.category_name_s = new List<string>() { };
                    rItem.restInfo.code.category_name_s.Add(resultReader["code_Category_Name_S"].ToString());
                    rItem.restInfo.budget = resultReader["budget"].ToString();
                    rItem.restInfo.party = resultReader["party"].ToString();
                    rItem.restInfo.lunch = resultReader["lunch"].ToString();
                    rItem.restInfo.credit_card = resultReader["credit_card"].ToString();
                    rItem.restInfo.e_money = resultReader["e_money"].ToString();
                    rItem.restInfo.flags = new Flags() { };
                    rItem.restInfo.flags.mobile_site = int.Parse(resultReader["flags_mobile_site"].ToString());
                    rItem.restInfo.flags.mobile_coupon = int.Parse(resultReader["flags_mobile_coupon"].ToString());
                    rItem.restInfo.flags.pc_coupon = int.Parse(resultReader["flags_pc_coupon"].ToString());
                }
            }
            finally
            {
                resultReader.Close();
            }
        }

        public void SelectDataFromSpecificFilteredByAreaCodes(SearchRestaurantInfo sRInfo, ShowRestaurantDataClass returnDc)
        {
            DateTime dt = DateTime.Now;
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    //MASTER(AREA)
                    string baseCommandText =
                        "SELECT tbl1.id, MAX(tbl1.update_date_for_compare) as leatestDate, MIN(tbl1.update_date_for_compare) as oldestDate, * FROM SEARCH_RESTAURANT as tbl1"
                        + " {0}"
                        + " Group by tbl1.id";

                    string filterCommandText = string.Empty;


                    //code(Region)
                    if (!string.IsNullOrEmpty(sRInfo.rest.code.areacode))
                    {
                        if (!string.IsNullOrEmpty(filterCommandText))
                        {
                            filterCommandText += " and";
                        }
                        filterCommandText += " code_AreaRegionCode = :code_AreaRegionCode";
                        cmd.Parameters.Add("code_AreaRegionCode", System.Data.DbType.String).Value = sRInfo.rest.code.areacode;
                    }

                    //code(Prefecture)
                    if (!string.IsNullOrEmpty(sRInfo.rest.code.prefcode))
                    {
                        if (!string.IsNullOrEmpty(filterCommandText))
                        {
                            filterCommandText += " and";
                        }
                        filterCommandText += " code_AreaPrefCode = :code_AreaPrefCode";
                        cmd.Parameters.Add("code_AreaPrefCode", System.Data.DbType.String).Value = sRInfo.rest.code.prefcode;
                    }

                    //code(smallArea)
                    if (!string.IsNullOrEmpty(sRInfo.rest.code.areacode_s))
                    {
                        if (!string.IsNullOrEmpty(filterCommandText))
                        {
                            filterCommandText += " and";
                        }
                        filterCommandText += " code_AreaSmallCode = :code_AreaSmallCode";
                        cmd.Parameters.Add("code_AreaSmallCode", System.Data.DbType.String).Value = sRInfo.rest.code.areacode_s;
                    }
                    cmd.CommandText = string.Format(baseCommandText, "WHERE " + filterCommandText);

                    if (sRInfo.DaysAgo != 0)
                    {
                        int compareDate = dt.Year * 10000 + dt.Month * 100 + dt.Day - sRInfo.DaysAgo;
                        cmd.CommandText += $" HAVING leatestDate >= {compareDate}";
                    }

                    SetSelectResultToDataClass(cmd, returnDc);
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }
    }
}
