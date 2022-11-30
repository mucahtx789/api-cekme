using System.Drawing;

namespace api_cekme.Models
{
   public class info
    {
        public string satis { get; set; }
        public string alis { get; set; }
        public string degisim { get; set; }

    }
    
    public class kurmodel
    {
        //  public info kurlar { get; set; }
        public info USD { get; set; }
        public info EUR { get; set; }
        public info GBP { get; set; }
        public info BTC { get; set; }
        public info ETH { get; set; }
        public info GA { get; set; }
        public info C { get; set; }
        public info GAG { get; set; }
        public info XU100 { get; set; }
    }
    
}
