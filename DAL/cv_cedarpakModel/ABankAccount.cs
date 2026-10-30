using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class ABankAccount
    {
        public ABankAccount()
        {
            ABanks = new HashSet<ABank>();
        }

        public long BkaccRowid { get; set; }
        public long? BkaccRowidDebtor { get; set; }
        public long? BkaccRowidClient { get; set; }
        public long? BkaccRowidCosigner { get; set; }
        public long? BkaccRowidAssociated { get; set; }
        public long? BkaccUid { get; set; }
        public DateTime? BkaccCdate { get; set; }
        public TimeSpan? BkaccCtime { get; set; }
        public string? BkaccCby { get; set; }
        public DateTime? BkaccMdate { get; set; }
        public TimeSpan? BkaccMtime { get; set; }
        public string? BkaccMby { get; set; }
        public int? BkaccUidm { get; set; }
        public long? BkaccUido { get; set; }
        public long? BkaccUido1 { get; set; }
        public long? BkaccUido2 { get; set; }
        public long? BkaccUido3 { get; set; }
        public short? BkaccCategory { get; set; }
        public short? BkaccCategory1 { get; set; }
        public short? BkaccCategory2 { get; set; }
        public string? BkaccId { get; set; }
        public string? BkaccAccount { get; set; }
        public DateTime? BkaccExpDate { get; set; }
        public string? BkaccNameOnAccount { get; set; }
        public int? BkaccCurrency { get; set; }
        public string? BkaccBankRoutingNo { get; set; }
        public string? BkaccUser1 { get; set; }
        public string? BkaccUser2 { get; set; }
        public string? BkaccUser3 { get; set; }
        public string? BkaccUser4 { get; set; }
        public decimal? BkaccPercent1 { get; set; }
        public decimal? BkaccPercent2 { get; set; }
        public decimal? BkaccMoney1 { get; set; }
        public decimal? BkaccMoney2 { get; set; }
        public string? BkaccOp1 { get; set; }
        public string? BkaccOp2 { get; set; }
        public int? BkaccNumber1 { get; set; }
        public int? BkaccNumber2 { get; set; }
        public short? BkaccFlags1 { get; set; }
        public short? BkaccFlags2 { get; set; }
        public DateTime? BkaccDate1 { get; set; }
        public DateTime? BkaccDate2 { get; set; }
        public string? BkaccPin { get; set; }

        public virtual AAssociated? BkaccRowidAssociatedNavigation { get; set; }
        public virtual AClient? BkaccRowidClientNavigation { get; set; }
        public virtual ACosigner? BkaccRowidCosignerNavigation { get; set; }
        public virtual ADebtor? BkaccRowidDebtorNavigation { get; set; }
        public virtual ICollection<ABank> ABanks { get; set; }
    }
}
