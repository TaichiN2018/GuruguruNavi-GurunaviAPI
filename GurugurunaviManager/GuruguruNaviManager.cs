using System.Collections.Generic;
using GNaviWebAccess;
using GNaviDataAccess;
using GNaviDataClass;

namespace GNaviManager
{
    public static class GuruguruNaviManager
    {
        /// <summary>
        /// レストラン情報を取得して、差分をDBにInsert
        /// </summary>
        public static void GetLeatestRestaurantDataFromWeb()
        {
            List<string> prefCodesList = new List<string>();
            AreaPrefMasterDataAccess da = new AreaPrefMasterDataAccess();
            da.SelectAllPrefCode(prefCodesList);

            SearchRestaurantDataClass dc = null;
            foreach (string prefcode in prefCodesList)
            {
                SearchRestaurantDataClass dcAdd = SearchRestaurantWebAccess.GetDataFromGurunaviByPrefCode(prefcode);
                if (dc == null)
                {
                    dc = dcAdd;
                }
                else
                {
                    dc.rest.AddRange(dcAdd.rest);
                }
            }
            SearchRestaurantDataAccess daSr = new SearchRestaurantDataAccess();
            daSr.CreateTable();
            daSr.UpdateData(dc);
        }

        ////debug用
        ////WebAccessのJsonObjectをローカルに物理ファイルでバックアップを取っている場合
        ////物理ファイルを基にSearchRestaurantDataClassオブジェクトを生成する。
        //public static void InsertRestaurantDataFromFiles(IEnumerable<string> filePaths)
        //{
        //    SearchRestaurantDataClass dc = null;
        //    SearchRestaurantDataClass dcAdd = null;
        //    foreach (string filepath in filePaths)
        //    {
        //        if (dc == null)
        //        {
        //            dc = SearchRestaurantWebAccess.GetDataFromJsonFile(filepath);
        //        }
        //        else
        //        {
        //            dcAdd = SearchRestaurantWebAccess.GetDataFromJsonFile(filepath);
        //            dc.rest.AddRange(dcAdd.rest);
        //        }
        //    }
        //    if (dc == null)
        //    {
        //        return;
        //    }

        //    SearchRestaurantDataAccess daSr = new SearchRestaurantDataAccess();
        //    daSr.CreateTable();
        //    daSr.UpdateData(dc);
        //}

        /// <summary>
        /// マスター系のテーブルを全てリクリエイトする。
        /// </summary>
        public static void ReloadMasterData()
        {
            AreaRegionMasterDataClass armdc = AreaRegionMasterWebAccess.GetDataFromGurunavi();
            AreaRegionMasterDataAccess arda = new AreaRegionMasterDataAccess() { };
            arda.RecreateTable(armdc);

            AreaPrefMasterDataClass apmdc = AreaPrefMasterWebAccess.GetDataFromGurunavi();
            AreaPrefMasterDataAccess apda = new AreaPrefMasterDataAccess() { };
            apda.RecreateTable(apmdc);

            AreaLargeMasterDataClass almdc = AreaLargeMasterWebAccess.GetDataFromGurunavi();
            AreaLargeMasterDataAccess alda = new AreaLargeMasterDataAccess() { };
            alda.RecreateTable(almdc);

            AreaMiddleMasterDataClass ammdc = AreaMiddleMasterWebAccess.GetDataFromGurunavi();
            AreaMiddleMasterDataAccess amda = new AreaMiddleMasterDataAccess() { };
            amda.RecreateTable(ammdc);

            AreaSmallMasterDataClass asmdc = AreaSmallMasterWebAccess.GetDataFromGurunavi();
            AreaSmallMasterDataAccess asda = new AreaSmallMasterDataAccess() { };
            asda.RecreateTable(asmdc);

            CategoryLargeMasterDataClass clmdc = CategoryLargeMasterWebAccess.GetDataFromGurunavi();
            CategoryLargeMasterDataAccess clda = new CategoryLargeMasterDataAccess() { };
            clda.RecreateTable(clmdc);

            CategorySmallMasterDataClass csmdc = CategorySmallMasterWebAccess.GetDataFromGurunavi();
            CategorySmallMasterDataAccess csda = new CategorySmallMasterDataAccess() { };
            csda.RecreateTable(csmdc);
        }

        public static void GetRestaurantData(SearchRestaurantInfo sRInfo, ShowRestaurantDataClass dc)
        {
            SearchRestaurantDataAccess da = new SearchRestaurantDataAccess() { };
            da.SelectDataFromSpecificFilteredByAreaCodes(sRInfo, dc);
        }

        public static void GetRegionAreaMasterData(AreaRegionMasterDataClass dc)
        {
            AreaRegionMasterDataAccess da = new AreaRegionMasterDataAccess() { };
            da.SelectData(dc);
        }

        public static void GetPrefAreaMasterData(string regionCode, AreaPrefMasterDataClass dcPref)
        {
            AreaPrefMasterDataAccess da = new AreaPrefMasterDataAccess() { };
            da.SelectPrefDatas(regionCode, dcPref);
        }

        public static void GetAreaSmallMasterData(string prefCode, AreaSmallMasterDataClass dcSmall)
        {
            AreaSmallMasterDataAccess da = new AreaSmallMasterDataAccess() { };
            da.GetAreaSmallData(prefCode, dcSmall);
        }

        public static bool IsAPIKeyValid(string apiKey)
        {
            if (CheckGNInfoWebAccess.IsErrorNotValid(apiKey))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
