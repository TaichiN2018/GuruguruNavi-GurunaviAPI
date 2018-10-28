using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GurugurunaviDataClass
{
    public class ErrorResponseDataClass : BaseResponseDataClass
    {
        public string code { get; set; }
        public string message { get; set; }

        public void initialize()
        {
            base.Initialize();

            this.code = string.Empty;
            this.message = string.Empty;
        }
    }
}
