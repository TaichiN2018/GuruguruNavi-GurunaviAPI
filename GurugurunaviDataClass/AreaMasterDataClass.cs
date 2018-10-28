using System.Collections.Generic;

namespace GNaviDataClass
{
    public class Area
    {
        public string area_code { get; set; }
        public string area_name { get; set; }
    }

    public class Pref
    {
        public string pref_code { get; set; }
        public string pref_name { get; set; }
        public string area_code { get; set; }
    }

    public class GareaLarge
    {
        public string areacode_l { get; set; }
        public string areaname_l { get; set; }
        public Pref pref { get; set; }
    }

    public class GareaMiddle
    {
        public string areacode_m { get; set; }
        public string areaname_m { get; set; }
        public GareaLarge garea_large { get; set; }
        public Pref pref { get; set; }
    }

    public class GareaSmall
    {
        public string areacode_s { get; set; }
        public string areaname_s { get; set; }
        public GareaMiddle garea_middle { get; set; }
        public GareaLarge garea_large { get; set; }
        public Pref pref { get; set; }
    }

    public class AreaRegionMasterDataClass
    {
        public List<Area> area { get; set; }
    }
    public class AreaPrefMasterDataClass
    {
        public List<Pref> pref { get; set; }
    }
    public class AreaLargeMasterDataClass
    {
        public List<GareaLarge> garea_large { get; set; }
    }
    public class AreaMiddleMasterDataClass
    {
        public List<GareaMiddle> garea_middle { get; set; }
    }
    public class AreaSmallMasterDataClass
    {
        public List<GareaSmall> garea_small { get; set; }
    }
}
