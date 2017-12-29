using System;

namespace Gremlin.CallSignResponse
{
    public class CallSignOtherInfo
    {
        public DateTime grantDate { get; set; }
        public DateTime expiryDate { get; set; }
        public DateTime lastActionDate { get; set; }
        public string frn { get; set; }
        public string ulsURL { get; set; }
    }
}
