using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloverPos.Models
{
    class Authdetails_Refresh
    {
        public string client_id { get; set; }
        public string refresh_token { get; set; }
    }
    class Syncgo_Refresh
    {
        public string referenceId { get; set; }
        public string accessToken { get; set; }
    }
}
