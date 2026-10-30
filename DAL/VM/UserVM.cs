using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VM
{
    public class uac_notes
    {
        public IQueryable uacnote { get; set; }
        public TimeSpan? ntime { get; set; }
        public DateTime? ndate { get; set; }
        public string nnote { get; set; }
    }

    public class User
    {
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string User4 { get; set; }
        public decimal Rate1 { get; set; }
        public decimal Rate2 { get; set; }
        public decimal Rate3 { get; set; }
        public decimal Rate4 { get; set; }
        public string StatementType { get; set; }
        public Int32 ClNumber { get; set; }
        public string ClName { get; set; }
        public Int32 TrendAvg { get; set; }
        public Int32 LabelsA { get; set; }
        // for Custom date  

        //   public DateTime st_date { get; set; }
        //   public DateTime end_date { get; set; }

        // For Monthly
        public string Labels { get; set; }
        public int DaysInInteger { get; set; }
        public decimal? Revenue1 { get; set; }
        public decimal? Revenue2 { get; set; }
        public decimal? Revenue3 { get; set; }
        public decimal? GrossCollection1 { get; set; }
        public decimal? GrossCollection2 { get; set; }
        public decimal? GrossCollection3 { get; set; }
        public decimal? Rev_year { get; set; }
        public int? Mnth { get; set; }
        public int? TFcount { get; set; }

        public DateTime RevDate { get; set; }
        public string RevAmount { get; set; }

        public Int32 Day { get; set; }

        public string MonthName { get; set; }
        public decimal? TopMonthRev { get; set; }
        // Current Month Revenue
        public string PaymentSource { get; set; }
        public string OpOffice { get; set; }

        // Month Revenue  For Past Two Year
        public decimal? TotalRev { get; set; }

        public decimal? AmountPaid { get; set; }
        public int de_number { get; set; }
        public int? Ribbon { get; set; }
        public string de_cl_account { get; set; }
        public string de_name { get; set; }
        public string tr_description { get; set; }
        public DateTime tr_payment_date { get; set; }
        public string at_detail_2 { get; set; }

        public string StatusCode { get; set; }
        public string StatusDesc { get; set; }



        public decimal? One { get; set; }
        public decimal? Two { get; set; }
        public decimal? Three { get; set; }
        public decimal? Four { get; set; }
        public decimal? Five { get; set; }
        public decimal? Six { get; set; }
        public decimal? Seven { get; set; }
        public decimal? Eight { get; set; }
        public decimal? Nine { get; set; }
        public decimal? Ten { get; set; }
        public decimal? Eleven { get; set; }
        public decimal? Twelve { get; set; }
        public decimal? Thirteen { get; set; }
        public decimal? Fourteen { get; set; }
        public decimal? Fifteen { get; set; }
        public decimal? Sixteen { get; set; }
        public decimal? Seventeen { get; set; }
        public decimal? Eighteen { get; set; }
        public decimal? Nineteen { get; set; }
        public decimal? Twenty { get; set; }
        public decimal? TwentyOne { get; set; }
        public decimal? TwentyTwo { get; set; }
        public decimal? TwentyThree { get; set; }
        public decimal? TwentyFour { get; set; }
        public decimal? TwentyFive { get; set; }
        public decimal? TwentySix { get; set; }
        public decimal? TwentySeven { get; set; }
        public decimal? TwentyEight { get; set; }
        public decimal? TwentyNine { get; set; }
        public decimal? Thirty { get; set; }
        public decimal? ThirtyOne { get; set; }
        //Crm
        public string btype { get; set; }

        //Transaction class to be made
        public decimal? tous;
        public decimal? todirect;
        public IQueryable uac_notes { get; set; }
        //Acknowledgment Form
        public string featrname { get; set; }
        public string tstrname { get; set; }
        public string ctgry { get; set; }
        public string rqstdby { get; set; }
        public string assignto { get; set; }
        public string slctstatus { get; set; }
        public DateTime estmtd_start { get; set; }
        public DateTime estmtd_fnsh { get; set; }
        public DateTime actl_fnsh { get; set; }
        public DateTime tstr_vrfd { get; set; }
        public DateTime rqstr_vrfd { get; set; }
        public string flwup { get; set; }
        public byte[] notes { get; set; }
        //
        public string ttype;
        public short types { get; set; }
        public string paymentdate;
        public string posteddate;
        public Nullable<System.TimeSpan> PostedTime { get; set; }

        public DateTime? paymentdatePromises { get; set; }
        public DateTime? posteddatePromies { get; set; }

        public string desc;
        public string ocs;
        public int? ocs2;
        public string towho;
        public decimal? comRate;
        public decimal? toPrincipal;
        public decimal? toInterest;
        public decimal? toFee;
        public decimal? toLegal;
        public decimal? Legal;
        public string confimationNo;
        public decimal? clientNo;
        public decimal? comR1;
        public decimal? comR2 { get; set; }
        public decimal? comR3;
        public decimal? comR4 { get; set; }
        public decimal? legalfee { get; set; }

        public decimal? comAmount { get; set; }
        public decimal? comInterest { get; set; }
        public decimal? comFees { get; set; }

        public int filenumber { get; set; }
        public short source;
        public int? clientnumber { get; set; }
        public Int64 clientRowId { get; set; }

        public string OpDepartment { get; set; }
        public decimal? TotalCommission { get; set; }

        public string clientname;
        public string pclass;
        public decimal? successRate { get; set; }
        //-----------------//

        public string Cname;
        public string Ccountry;
        public decimal Score;
        public string Country;
        public string Street;
        public string City;
        public string state;
        public string zip;
        public string CStreet;
        public string Ccity;
        public string Cstate;
        public string Czip;
        public string mode;
        public string OrginalCred;
        public string Dname;
        public string opt;
        public string operator_id { get; set; }
        public string co_type { get; set; }
        public string co_des { get; set; }
        public string opid;
        public string work_phone { get; set; }
        public string cell_phone { get; set; }
        public string other_phone { get; set; }
        public string home_phone { get; set; }
        public string email { get; set; }
        public string type { get; set; }
        public string account { get; set; }
        public string op { get; set; }
        public short prio;
        // public List<int> file;
        public decimal? filecount;
        public decimal? totalfilecount;
        public decimal? filesum;
        public decimal? totalfilesum;
        public decimal? totalcom;
        public decimal totalcomperc;
        public decimal? totalcompercS;
        public decimal? rcvrdamnt { get; set; }
        public decimal? mnthly_rcvrdamnt { get; set; }

        // added by asherperc

        public decimal client_percentage;
        public decimal earned_fee_percentage;
        public decimal earned_fee;

        public string client_listed_date { get; set; }
        public string client_worked_date { get; set; }
        public decimal no_of_accounts;
        public decimal active_accounts;
        public decimal dmstc_acnt;
        public decimal? dmstc_amnt { get; set; }
        public decimal intrntnl_acnt;
        public decimal? intrntnl_amnt { get; set; }
        public decimal total_account;
        public decimal age;
        public DateTime? last_placement { get; set; }
        public DateTime? listed_date { get; set; }
        public DateTime? charge_date { get; set; }
        public DateTime? work_date { get; set; }
        public DateTime? listed_date1 { get; set; }
        public DateTime? st_date1 { get; set; }
        public DateTime st_date { get; set; }
        public DateTime end_date { get; set; }
        public string sum_account;
        public string name;
        public string status;
        //for sales 
        public string sales_op;
        public decimal? prncpl_amnt { get; set; }
        public decimal? prncpl_amnt2 { get; set; }
        public decimal? difference { get; set; }
        public decimal filecount2;
        public decimal rowid;
        public int ph_type { get; set; }

        public int ribbon;

        public decimal? clientnumber1 { get; set; }





        public decimal? perc;


        public decimal? owing { get; set; }

        public decimal comsum;
        public decimal median;
        public decimal dpsum;

        public DateTime sdate { get; set; }
        public DateTime edate { get; set; }

        public DateTime s2date { get; set; }
        public DateTime e2date { get; set; }



    }
}
