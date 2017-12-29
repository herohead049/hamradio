using System;

namespace Gremlin.CallSignResponse
{
    public class CallSign
    {
        public string Status { get; set; }
        public string Type { get; set; }
        public string Handle { get; set; }
        public string Callsign { get; set; }
        public string Name { get; set; }
        public string OperClass { get; set; }
        public string PreCallsign { get; set; }
        public string PreOperClass { get; set; }
        public string TrusteeCallsign { get; set; }
        public string TrusteeName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressAttn { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Gridsquare { get; set; }
        public DateTime GrantDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime LastActionDate { get; set; }
        public string Frn { get; set; }
        public string UlsURL { get; set; }
    }
}
