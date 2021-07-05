using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.Extensions
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public int ExpirationHoras { get; set; }
        public string Emissor { get; set; }
        public string ValidEm { get; set; }
    }
}
