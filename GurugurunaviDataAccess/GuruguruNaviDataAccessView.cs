using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNaviDataAccess
{
    public class GuruguruNaviDataAccessView
    {
    }

    public class FullMasterData
    {
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string PrefCode { get; set; }
        public string PrefName { get; set; }
        public string AreaLCode { get; set; }
        public string AreaLName { get; set; }
        public string AreaMCode { get; set; }
        public string AreaMName { get; set; }
        public string AreaSCode { get; set; }
        public string AreaSName { get; set; }
        public FullMasterData()
        {

        }
        private void Initialize()
        {
        }
    }
    public static class ViewFullMasterData
    {
        public static void Create()
        {
            //Viewの追加処理
        }
        public static FullMasterData Get()
        {
            FullMasterData mdf = null;
            return mdf;
        }
    }

    public class RestaurantData
    {
        public RestaurantData()
        {
        }
    }

    public static class ViewRestaurantData
    {
        public static void Create()
        {
            //Viewの追加処理
        }
    }
}
