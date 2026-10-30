using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VM
{
    public class CUL_Report_Parameters
    {
        public long Page { get; set; }
        public long PageSize { get; set; }
        public string st_in { get; set; }
        public string MyHiddenId { get; set; }
        public string cl_num_in { get; set; }
        public string score_in { get; set; }
        public string coun_in { get; set; }
        public string cd_in { get; set; }
        public string ld_in { get; set; }
        public string op_in { get; set; }
        public DateTime? ld { get; set; }
        public DateTime? cd { get; set; }
        public string op { get; set; }
        public string st { get; set; }
        public string cl_num { get; set; }
        public string state { get; set; }
        public DateTime? ld_1 { get; set; }
        public DateTime? cd_1 { get; set; }
        public decimal? cl_num_1 { get; set; }
        public string score { get; set; }
        public string score_1 { get; set; }
        public string coun { get; set; }
        public DateTime? wd { get; set; }
        public DateTime? wd_1 { get; set; }
        public string wd_in { get; set; }
        public string ty { get; set; }
        public string ty_in { get; set; }
        public string Channel { get; set; }
        public string Ch_check { get; set; }
        public Int32? Co_Completed { get; set; }
        public string? Co_Who { get; set; }
        public DateTime? co_cd { get; set; }
        public DateTime? co_cd1 { get; set; }
        public string? co_cdin { get; set; }
        public string oos { get; set; }
        public string oos1 { get; set; }
        public string time_z { get; set; }
        public string zip_in { get; set; }
        public bool NeuStar { get; set; }
        
        public string reg_f { get; set; }
        public string sectorL { get; set; }
        public string CollectorIn { get; set; }
        public string Collector { get; set; }
        public string co_description { get; set; }
        public string co_description_in { get; set; }   
        public string Orignal_Creditor { get; set; }
        public string Orignal_Creditor_In { get; set; }
        public string CSV { get; set; }
        public string file_number { get; set; }
        public string file_number_in { get; set; }
        public string owing { get; set; }
        public string owing_1 { get; set; }
        public string owing_in { get; set; }
    }
    
    public class CUL_Report  
    {

        public string CosEmail { get; set; }
        public string Next_Best { get; set; }
        public string Settlement { get; set; }
        public int group_count { get; set; }
        public string address { get; set; }
        public string Rank { get; set; }
        public string city { get; set; }
        public string debtor_Name { get; set; }
        public string debtor_closed { get; set; }
        public string delinquency_date { get; set; }
        public string home_extension { get; set; }
        public string cell_extension { get; set; }
        public string work_extension { get; set; }
        public string other_extension { get; set; }
        public int group_filenumber { get; set; }
        public string Original_Creditor { get; set; }
        public string mode { get; set; }

        public string DeContact { get; set; }
        public string DeState { get; set; }
        public string DeType { get; set; }
        public string DeMode { get; set; }
        public DateTime DeCloseDate { get; set; }

        public decimal Fees { get; set; }
        public decimal Interest { get; set; }
        public decimal Payments { get; set; }
        public decimal Principal { get; set; }
        public int cl_number { get; set; }
        public int COL_score { get; set; }
        public string de_status { get; set; }
        public string Operator { get; set; }
        public string Source { get; set; }
        public string summary { get; set; }
        public string PhoneType { get; set; }
        public string co_description { get; set; }

        public string COL_States { get; set; }
        
        //  

        public string CosFirstName { get; set; }
        public string CosLastName { get; set; }

        public string CosHomePhone { get; set; }
        public string COL_PhoneHome_Ext { get; set; }
        
        public string CosBusinessPhone { get; set; }
        public string CosOtherPhone { get; set; }
        public string CosCellPhone { get; set; }

        public string de_cos_country { get; set; }
        public string COL_Charged { get; set; }
        public string Last_RPC_Date { get; set; }
        public string Last_Payment_Date { get; set; }
        public string TimeZone { get; set; }

        public string Acct { get; set; }
        public string Country { get; set; }
        public decimal Legal { get; set; }


        public Int32? COL_FileNumber { get; set; }
        public string COL_Email { get; set; }
        public string COL_NameFirst { get; set; }
        public string de_contact { get; set; }
        public string COL_NameLast { get; set; }
        public string COL_PhoneHome { get; set; }
        public string COL_PhonePOE { get; set; }
        public string COL_PhoneCell { get; set; }
        public string COL_PhoneOther { get; set; }
        public string COL_Acct { get; set; }
        public string COL_WorkedDate { get; set; }
        public string COL_Client { get; set; }
        public Int32? COL_Client_number { get; set; }
        public Int32? de_owned_by_debtor { get; set; }
        public decimal? COL_Owing { get; set; }
        public decimal? Persantage { get; set; }
        public string COL_ZipCode { get; set; }
        public string COL_Type { get; set; }
        public string COL_Status { get; set; }
        public string COL_Listed { get; set; }
        public string de_country { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public long? de_rowid { get; set; }
        public Int32? Co_Completed { get; set; }
        public string? Co_Who { get; set; }
        public DateTime? Co_cdate { get; set; }


    }
    public class EmailReport
    {
        public string Email { get; set; }
        public string First_Name { get; set; }
        public string InterestRecal { get; set; }
        public string Last_Name { get; set; }
        public string Original_Creditor { get; set; }
        public string Account_Num { get; set; }
        public string Fees { get; set; }
        public int LastEmailSentDate { get; set; }
        public string Interest { get; set; }
        public string Payments { get; set; }
        public string delinquency_date { get; set; }
        public string Outstanding_Balance { get; set; }
        public string Summary { get; set; }
        public string Principal { get; set; }
        public string Setc_Amunt { get; set; }
        public string Savings { get; set; }
        public string Perc { get; set; }
        public string Percentage { get; set; }
        public int Our_File { get; set; }
        public string Reg_Link { get; set; }
        public int group_count { get; set; }
        public string Charged { get; set; }
        public string Settlement { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string Itemization_Date { get; set; }
        public string listed_date { get; set; }
        public string Client { get; set; }
        public int Client_num { get; set; }
        public string mode { get; set; }
        public string debtor_status { get; set; }
        public string Operator { get; set; }
        public string debtor_type { get; set; }
        public string contact { get; set; }
        public string validation_date { get; set; }
        public string debtor_Name { get; set; }
        public string debtor_closed { get; set; }
        public string co_description { get; set; }
        public decimal debtor_legal { get; set; }
        public string home_extension { get; set; }
        public string work_extension { get; set; }
        public string cell_extension { get; set; }
        public string other_extension { get; set; }
        public int group_filenumber { get; set; }
        public string debtor_country { get; set; }
        public string TimeZone { get; set; }
        public int OOS { get; set; }
        public int Score { get; set; }
        public string de_contact { get; set; }
        public long RowNum { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string ResponsibleParty_Email { get; set; }
        public string CosEmail { get; set; }


    }
    public class EmailReport2
    {
        public string Email { get; set; }
        public string InterestRecal { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Original_Creditor { get; set; }
        public string Account_Num { get; set; }
        public string Fees { get; set; }
        public int LastEmailSentDate { get; set; }
        public string Interest { get; set; }
        public string delinquency_date { get; set; }
        public string Payments { get; set; }
        public string Outstanding_Balance { get; set; }
        public string Summary { get; set; }
        public string Principal { get; set; }
        public string Setc_Amunt { get; set; }
        public string Savings { get; set; }
        public string Perc { get; set; }
        public string Percentage { get; set; }
        public int Our_File { get; set; }
        public string Reg_Link { get; set; }
        public int group_count { get; set; }
        public string Charged { get; set; }
        public string Settlement { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string Itemization_Date { get; set; }
        public string listed_date { get; set; }
        public string Client { get; set; }
        public int Client_num { get; set; }
        public string mode { get; set; }
        public string debtor_status { get; set; }
        public string Operator { get; set; }
        public string debtor_type { get; set; }
        public string contact { get; set; }
        public string validation_date { get; set; }
        public string debtor_Name { get; set; }
        public string debtor_closed { get; set; }
        public string co_description { get; set; }
        public decimal debtor_legal { get; set; }
        public string home_extension { get; set; }
        public string work_extension { get; set; }
        public string cell_extension { get; set; }
        public string other_extension { get; set; }
        public int group_filenumber { get; set; }
        public string debtor_country { get; set; }
        public string TimeZone { get; set; }
        public int OOS { get; set; }
        public string de_contact { get; set; }
        public long RowNum { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string ResponsibleParty_Email { get; set; }
        public string CosEmail { get; set; }
        public int Score { get; set; }


    }
    public class WipEmail
    {
        public string coun { get; set; }
        public string per { get; set; }
        public string per1 { get; set; }

    } 
    public class SMSCWip
    {
        public string wip_name { get; set; }
        public string cdate { get; set; }
        public string cdate1 { get; set; }

    }
    public class SMSCreport
    {
        public string Name { get; set; }
        public string Runplan { get; set; }
        public string Legal_entity { get; set; }
        public string Contact { get; set; }
        public string Generation { get; set; }
        public string Address { get; set; }
        public string Street_number { get; set; }
        public string Address_OK { get; set; }
        public string delinquency_date { get; set; }
        public string Addr_1 { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string Timezone { get; set; }
        public string SSN { get; set; }
        public string DL { get; set; }
        public string DOB { get; set; }
        public string Cell { get; set; }
        public string Cell_extension { get; set; }
        public string POE { get; set; }
        public string Cl_File { get; set; }
        public string Orig_Cr { get; set; }
        public string Client { get; set; }
        public string Client_number { get; set; }
        public string Acct { get; set; }
        public string SKPOP { get; set; }
        public string nd_st { get; set; }
        public string Charged { get; set; }
        public string Legal { get; set; }
        public string Delnqnt { get; set; }
        public string Listed { get; set; }
        public string Closed { get; set; }
        public string Type { get; set; }
        public string Mode { get; set; }
        public string Status { get; set; }
        public string Street_type { get; set; }
        public string Worked { get; set; }
        public string Worked_time { get; set; }
        public string Score { get; set; }
        public string Operator { get; set; }
        public string Sales { get; set; }
        public string Rate { get; set; }
        public string Principal { get; set; }
        public string Judgment { get; set; }
        public string Interest { get; set; }
        public string Fees { get; set; }
        public string Legal_fees { get; set; }
        public string CF_upfront_costs { get; set; }
        public string Legal_Atty_Fees { get; set; }
        public string Adjustments { get; set; }
        public string Paid { get; set; }
        public string Owing { get; set; }
        public string Discount { get; set; }
        public string Discount1 { get; set; }
        public string Summary { get; set; }
        public string CD30 { get; set; }
        public string File { get; set; }
        public string Group { get; set; }
        public string Group_member { get; set; }
        public string Payment { get; set; }
        public string Next { get; set; }
        public string Promise { get; set; }
        public string Original_Interest { get; set; }
        public string Interest_Date { get; set; }
        public string Interest_Rate { get; set; }
        public string Accrued { get; set; }
        public string Legal_Costs { get; set; }
        public string Report_Credit { get; set; }
        public string Edit_Date { get; set; }
        public string Client_User_1 { get; set; }
        public string Days30 { get; set; }
        public string Days60 { get; set; }
        public string Days90 { get; set; }
        public string Over90 { get; set; }
        public string UID { get; set; }
        public string SKIP { get; set; }
        public string Summary_Flags { get; set; }
        public string Comm_Rate_Option { get; set; }
        public string Commission_Rate_1 { get; set; }
        public string Commission_Rate_2 { get; set; }
        public string Commission_Rate_3 { get; set; }
        public string Commission_Rate_4 { get; set; }
        public string Tax_Rate_1 { get; set; }
        public string Tax_Rate_2 { get; set; }
        public string Tax_Rate_3 { get; set; }
        public string Tax_Rate_4 { get; set; }
        public string Tax_Rate_Option { get; set; }
        public string Archive_Date { get; set; }
        public string Modified_Date { get; set; }
        public string Cl_Bill_Date { get; set; }
        public string Modified_Time { get; set; }
        public string Speech { get; set; }
        public string SMS { get; set; }

    }

    public enum options
    {
        Include,
        Exclude
    }

}
