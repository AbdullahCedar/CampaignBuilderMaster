using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VM
{
    internal class HomeVM
    {
        public class RevenueHeaders
        {
            public decimal? TotalFileSum { get; set; }
            public int? TotalFileCount { get; set; }
            public decimal? TotalFileCommission { get; set; }
            public int? Agents { get; set; }
            public int? Ribbon { get; set; }
        }
        public class FileCostPricing
        {
            public double TLO { get; set; }
            public double Neustar { get; set; }
            public double Webrecon { get; set; }
            public double NLP { get; set; }
            public double CreditReport { get; set; }
            public double LetterCost { get; set; }
            public double FileEntry { get; set; }
            public double Insurance { get; set; }
        }

        public class ClientRevenue
        {
            public string ClientName { get; set; }
            public int ClientNumber { get; set; }
            public string Operator { get; set; }

            public decimal? TotalSum { get; set; }
            public int Ribbon { get; set; }
            public int? files { get; set; }
            public decimal? Comission { get; set; }

        }

        public class PaymentSoucreRevenue
        {
            public string PaymentSourceA { get; set; }
            public string PaymentSource { get; set; }
            public decimal? TotalSum { get; set; }
            public int? files { get; set; }
            public decimal? Comission { get; set; }
        }

        public class TransactionLog
        {
            public string opid { get; set; }
            public string PostedBy { get; set; }
            public Int64 ClientRowID { get; set; }
            public string CollectOperator { get; set; }
            public int? clientnumber { get; set; }
            public int? filenumber { get; set; }
            public int Ribbon { get; set; }
            public string op { get; set; }
            public DateTime paymentdate { get; set; }
            public DateTime posteddate { get; set; }
            public Nullable<System.TimeSpan> PostedTime { get; set; }
            public string tr_ctime { get; set; }

            public string ttype { get; set; }
            public string totalcom { get; set; }
            public string desc { get; set; }
            public string tous { get; set; }
            public string todirect { get; set; }

            public decimal? totalcomA { get; set; }
            public decimal? tousA { get; set; }
            public decimal? todirectA { get; set; }
            public string ocs { get; set; }
            public string tr_user_5 { get; set; }
            public string cl_name { get; set; }


        }

        public class OperatorRevenue
        {
            public string Office { get; set; }
            public string Tenure { get; set; }
            public short? Team { get; set; }
            public string Operator_id { get; set; }
            public string Operator_name { get; set; }
            public decimal? TotalSum { get; set; }
            public int? files { get; set; }
            public decimal? Comission { get; set; }
        }

        public class DepartmentRevenue
        {
            public short? Department { get; set; }
            public decimal? TotalSum { get; set; }
            public int? files { get; set; }
            public decimal? Comission { get; set; }
        }

        public class SalesRevenue
        {
            public string CollectorID { get; set; }
            public string op_name { get; set; }
            public string Office { get; set; }
            public string Department { get; set; }
            public string Tenure { get; set; }

            public string SalesMan { get; set; }
            public decimal? TotalSum { get; set; }
            public int? files { get; set; }
            public decimal? Comission { get; set; }
        }

        public class OfficeRevenue
        {
            public string Office { get; set; }
            public decimal? TotalSum { get; set; }
            public int? files { get; set; }
            public decimal? Comission { get; set; }
        }

        public class Sectorrevenue
        {
            public string ClientType { get; set; }
            public decimal? TotalSum { get; set; }
            public int? files { get; set; }
            public decimal? Comission { get; set; }
        }

        public class SectorrevenueCGS
        {
            public short ClientType { get; set; }
            public decimal? TotalSum { get; set; }
            public int? files { get; set; }
            public decimal? Comission { get; set; }
        }

        public class DebtorTypeRevenue
        {
            public string DebtorType { get; set; }
            public decimal? TotalSum { get; set; }
            public int? files { get; set; }
            public decimal? Comission { get; set; }
        }
    }
}
