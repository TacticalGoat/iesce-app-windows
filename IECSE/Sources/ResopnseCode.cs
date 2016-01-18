using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IECSE.Sources
{
    public class ResopnseCode
    {
        public ResopnseCode(string code)
        {
            status = code;
        }
        public string status { get; set; }
    }
}
