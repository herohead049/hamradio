namespace HR.CallookInfo.CallSignResponse
{
    public class CallsignResponse
    {
        public string status { get; set; }
        public string type { get; set; }
        public CallSignCurrent current { get; set; }
        public CallSignPrevious previous { get; set; }
        public CallSignTrustee trustee { get; set; }
        public string name { get; set; }
        public CallSignAddress address { get; set; }
        public CallSignLocation location { get; set; }
        public CallSignOtherInfo otherInfo { get; set; }

    }
}
