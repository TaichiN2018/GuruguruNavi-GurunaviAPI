using System.Collections.Generic;

namespace GNaviDataClass
{
    public class Category
    {
        public string category_s_code { get; set; }
        public string category_s_name { get; set; }
        public string category_l_code { get; set; }
    }
    public class CategoryL
    {
        public string category_l_code { get; set; }
        public string category_l_name { get; set; }
    }

    public class CategorySmallMasterDataClass
    {
        public List<Category> category_s { get; set; }
    }
    public class CategoryLargeMasterDataClass
    {
        public List<CategoryL> category_l { get; set; }
    }
}
