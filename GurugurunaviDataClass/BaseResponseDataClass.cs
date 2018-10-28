using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GurugurunaviDataClass
{
    public class BaseResponseDataClass
    {
        public string api_version { get; set; }
        private List<IFMasterDataClass> _baseDataClassList = new List<IFMasterDataClass>() { };
        public List<IFMasterDataClass> DetailList {
            get{ return _baseDataClassList; }
            private set {; }
        }

        protected void Initialize() {
            this.api_version = string.Empty;
            this._baseDataClassList.Clear();
        }
    }
}
