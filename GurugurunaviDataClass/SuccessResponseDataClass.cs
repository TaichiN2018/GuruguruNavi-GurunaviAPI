using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GurugurunaviDataClass
{
    [DataContract]
    public class SuccessResponseDataClass : BaseResponseDataClass
    {
        private List<IFMasterDataClass> _individualDataClassList = new List<IFMasterDataClass>();
        public IEnumerable<IFMasterDataClass> IndivDCList
        {
            get { return _individualDataClassList; }
            private set {; }
        }

        public new void Initialize()
        {
            base.Initialize();

            _individualDataClassList.Clear();
        }
    }
}
