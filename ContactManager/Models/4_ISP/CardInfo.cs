using Microsoft.AspNetCore.Identity;

namespace ContactManager.Models.ISP
{
    public class CardInfo
    {
        public int CardInfoId { get; set; }
        public string CardNo { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
    }
}
