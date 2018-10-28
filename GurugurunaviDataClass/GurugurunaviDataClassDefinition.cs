using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNaviDataClass
{
    public enum KEY_REQUEST_MASTER 
    {
        keyid = 0,
        lang = 1
    }

    public enum KEY_RESPONSE_MASTER
    {
        response = 0,
        api_version = 1
    }

    public enum KEY_RESPONSE_AREAREGIONMASTER
    {
        area = 0,
        area_code = 1,
        area_name = 2
    }

    public enum AreaPrefMaster
    {
        KEYID,
        LANG,
        API_VERSION,
        PREF_CODE,
        PREF_NAME,
        AREA_CODE
    }

    public enum GurugurunaviErrorCode
    {
        E400,
        E401,
        E404,
        E405,
        E429,
        E500
    }

    public enum SearchRestaurant
    {
        KEYID,
        ID,
        NAME,
        NAME_KANA,
        TEL,
        ADDRESS,
        AREA,
        PREF,
        AREACODE_L,
        AREACODE_M,
        AREACODE_S,
        CATEGORY_L,
        CATEGORY_S,
        INPUT_COORDINATES_MODE,
        COORDINATES_MODE,
        LATITUDE,
        LONGITUDE,
        RANGE,
        SORT,
        OFFSET,
        HIT_PER_PAGE,
        OFFSET_PAGE,
        FREEWORD,
        FREEWORD_CONDITION,
        LUNCH,
        NO_SMOKING,
        CARD,
        MOBILEPHONE,
        BOTTOMLESS_CUP,
        SUNDAY_OPEN,
        TAKEOUT,
        PRIVATE_ROOM,
        MIDNIGHT,
        PARKING,
        MEMORIAL_SERVICE,
        BIRTHDAY_PRIVILEGE,
        BETROTHAL_PRESENT,
        KIDS_MENU,
        OUTRET,
        WIFI,
        MICROPHONE,
        BUFFET,
        LATELUNCH,
        SPORTS,
        UNTIL_MORNING,
        LUNCH_DESERT,
        PROJECTER_SCREEN,
        WITH_PET,
        DELIVERLY,
        SPECIAL_HOLIDAY_LUNCH,
        E_MONEY,
        CATERLING,
        BRAEKFAST,
        DESERT_BUFFET,
        LUNCH_BUFFET,
        BENTO,
        LUNCH_SALAD_BUFFET,
        DARTS,
        WEB_RESERVE,

        API_VERSION,
        TOTAL_HIT_COUNT,
        PAGE_OFFSET,

        REST_ID,
        REST_UPDATE_DATE,
        REST_NAME,
        REST_NAME_KANA,
        REST_LATITUDE,
        REST_CATEGORY,
        REST_URL,
        REST_URL_MOBILE,
        REST_COUPON_URL_PC,
        REST_COUPON_URL_MOBILE,
        REST_IMAGE_URL_SHOP_IMAGE1,
        REST_IMAGE_URL_SHOP_IMAGE2,
        REST_IMAGE_URL_QRCODE,
        REST_ADDRESS,
        REST_TEL,
        REST_TEL_SUB,
        REST_FAX,
        REST_OPENTIME,
        REST_HOLIDAY,
        REST_ACCESS,
        REST_ACCESS_LINE,
        REST_ACCESS_STATION,
        REST_ACCESS_STATION_EXIT,
        REST_ACCESS_WALK,
        REST_ACCESS_NOTE,
        REST_PARLING_LOTS,
        REST_PR_PR_SHORT,
        REST_PR_PR_LONG,
        REST_CODE_AREACODE,
        REST_CODE_AREANAME,
        REST_CODE_PREFCODE,
        REST_CODE_PREFNAME,
        REST_CODE_AREACODE_S,
        REST_CODE_AREANAME_S,
        REST_CODE_CATEGORY_CODE_L,
        REST_CODE_CATEGORY_CODE_L_ORDER,
        REST_CODE_CATEGORY_NAME_L,
        REST_CODE_CATEGORY_NAME_L_ORDER,
        REST_CODE_CATEGORY_CODE_S,
        REST_CODE_CATEGORY_CODE_S_ORDER,
        REST_CODE_CATEGORY_NAME_S,
        REST_CODE_CATEGORY_NAME_S_ORDER,
        REST_BUDGET,
        REST_PARTY,
        REST_LUNCH,
        REST_CREDIT_CARD,
        REST_E_MONEY,
        REST_FLAGS_MOBILE_SITE,
        REST_FLAGS_MOBILE_COUPON,
        REST_FLAGS_PC_COUPON
    }

    public enum AreaSmallMaster
    {
        KEYID,
        LANG,
        API_VERSION,
        AREACODE_S,
        AREANAME_S,
        AREACODE_M,
        AREANAME_M,
        AREACODE_L,
        AREANAME_L,
        PREF_CODE,
        PREF_NAME
    }
}
