
using DAL.cv_masterdbModel;
using DAL.Interfaces;
using DAL.VM;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using RestSharp.Authenticators;
using RestSharp;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using RestSharp;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IO.Compression;
using DAL.aPortalContext;
using DAL.aPortalModel;
using DAL.effortContext;
using DAL.aPortalContext;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace DAL.Repositories
{
    public class CUL_ReportRepository : ICUL_ReportRepository
    {
        private readonly cv_masterdbContext _context1;
        public readonly aPortalContext.aPortalContext _context2;
        private readonly effortsContext _context3;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IConfiguration _configuration;
        public CUL_ReportRepository(IHttpContextAccessor httpContextAccessor, cv_masterdbContext db2, IConfiguration config, aPortalContext.aPortalContext db1, effortsContext db3)
        {
            _httpContextAccessor = httpContextAccessor;
            _context1 = db2;
            _context2 = db1;
            _context3 = db3;
            _configuration = config;
        }
        private async Task<List<string>> GetInvalidPhoneNumbersAsync()
        {
            List<string> invalidNumbers = new List<string>();

            using (SqlConnection con = new SqlConnection("Server=192.168.20.90;Database=efforts;User Id=root;password=Qwerty1234567890;"))
            {
                using (SqlCommand cmd = new SqlCommand("Invalid_Numbers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 600000;
                    con.Open();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            if (reader["Phone"] != DBNull.Value)
                            {
                                invalidNumbers.Add(reader["Phone"].ToString());
                            }
                        }
                    }
                }
            }

            return invalidNumbers;
        }

        public async Task<List<CUL_Report>> ColReportIndex(CUL_Report_Parameters col, string constrr)
        {

            List<CUL_Report> q1List = new List<CUL_Report>();
            var skip = col.PageSize * (col.Page - 1);
            if (col.Page == 0 && col.PageSize == 0)
            {
                col.Page = 1;
                col.PageSize = 1000000000;
            }
            if (col != null)
            {


                using (SqlConnection con = new SqlConnection(constrr))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_CUL_Report_Index", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 600000;

                        cmd.Parameters.AddWithValue("@MyHiddenId", "A");
                        cmd.Parameters.AddWithValue("@st_in", col.st_in); // Set NULL if needed
                        cmd.Parameters.AddWithValue("@cl_num_in", col.cl_num_in);
                        cmd.Parameters.AddWithValue("@score_in", col.score_in);
                        cmd.Parameters.AddWithValue("@coun_in", col.coun_in);
                        cmd.Parameters.AddWithValue("@cd_in", col.cd_in);
                        cmd.Parameters.AddWithValue("@ld_in", col.ld_in);
                        cmd.Parameters.AddWithValue("@op_in", col.op_in);
                        cmd.Parameters.AddWithValue("@ld", col.ld);
                        cmd.Parameters.AddWithValue("@cd", col.cd);
                        cmd.Parameters.AddWithValue("@op", col.op);
                        cmd.Parameters.AddWithValue("@st", col.st);
                        cmd.Parameters.AddWithValue("@cl_num", col.cl_num);
                        cmd.Parameters.AddWithValue("@state", col.state);
                        cmd.Parameters.AddWithValue("@ld_1", col.ld_1);
                        cmd.Parameters.AddWithValue("@cd_1", col.cd_1);
                        cmd.Parameters.AddWithValue("@cl_num_1", col.cl_num_1);
                        cmd.Parameters.AddWithValue("@score", col.score);
                        cmd.Parameters.AddWithValue("@score_1", col.score_1);
                        cmd.Parameters.AddWithValue("@coun", col.coun);
                        cmd.Parameters.AddWithValue("@wd", col.wd);
                        cmd.Parameters.AddWithValue("@wd_1", col.wd_1);
                        cmd.Parameters.AddWithValue("@wd_in", col.wd_in);
                        cmd.Parameters.AddWithValue("@reg_f", col.reg_f);
                        cmd.Parameters.AddWithValue("@sectorL", col.sectorL);
                        cmd.Parameters.AddWithValue("@CollectorIn", col.CollectorIn);
                        cmd.Parameters.AddWithValue("@Collector", col.Collector);
                        cmd.Parameters.AddWithValue("@co_description", col.co_description);
                        cmd.Parameters.AddWithValue("@co_description_in", col.co_description_in);
                        if (col.ty == "CON")
                        {
                            cmd.Parameters.AddWithValue("@ty", 1);
                        }
                        else if (col.ty == "COM")
                        {
                            cmd.Parameters.AddWithValue("@ty", 2);
                        }
                        else if (col.ty == "BAS")
                        {
                            cmd.Parameters.AddWithValue("@ty", 3);
                        }
                        else if (col.ty == "COR")
                        {
                            cmd.Parameters.AddWithValue("@ty", 4);
                        }
                        else if (col.ty == "INT")
                        {
                            cmd.Parameters.AddWithValue("@ty", 5);
                        }
                        else if (col.ty == "GRAD")
                        {
                            cmd.Parameters.AddWithValue("@ty", 6);
                        }
                        else if (col.ty == "DROP")
                        {
                            cmd.Parameters.AddWithValue("@ty", 7);
                        }
                        else if (col.ty == "DISR")
                        {
                            cmd.Parameters.AddWithValue("@ty", 8);
                        }
                        else if (col.ty == "MED")
                        {
                            cmd.Parameters.AddWithValue("@ty", 9);
                        }
                        else if (col.ty == "EDU")
                        {
                            cmd.Parameters.AddWithValue("@ty", 10);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ty", col.ty);
                        }
                        // cmd.Parameters.AddWithValue("@ty", col.ty);
                        cmd.Parameters.AddWithValue("@ty_in", col.ty_in);
                        cmd.Parameters.AddWithValue("@Channel", col.Channel);
                        cmd.Parameters.AddWithValue("@Ch_check", col.Ch_check);
                        cmd.Parameters.AddWithValue("@val", DBNull.Value);
                        cmd.Parameters.AddWithValue("@co_cd", col.co_cd);
                        cmd.Parameters.AddWithValue("@co_cd1", col.co_cd1);
                        cmd.Parameters.AddWithValue("@co_cdin", col.co_cdin);
                        cmd.Parameters.AddWithValue("@co_completed", col.Co_Completed);
                        cmd.Parameters.AddWithValue("@co_who", col.Co_Who);
                        cmd.Parameters.AddWithValue("@owing", col.owing);
                        cmd.Parameters.AddWithValue("@owing_1", col.owing_1);
                        cmd.Parameters.AddWithValue("@owing_in", col.owing_in);


                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            try
                            {
                                //List<string> invalidNumber = await GetInvalidPhoneNumbersAsync();

                                while (reader.Read())
                                {

                                    CUL_Report q1 = new CUL_Report();
                                    try
                                    {
                                        //if ((reader["de_home_phone"] != DBNull.Value) || (reader["de_work_phone"] != DBNull.Value) || (reader["de_cell_phone"] != DBNull.Value) || (reader["de_other_phone"] != DBNull.Value))
                                        {
                                            if (reader["COL_Email"] != DBNull.Value)
                                            {
                                                q1.COL_Email = reader["COL_Email"].ToString().Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["COL_FileNumber"] != DBNull.Value)
                                            {
                                                q1.COL_FileNumber = ((int?)reader["COL_FileNumber"]);
                                            }
                                            //if (reader["de_Contact"] != DBNull.Value)
                                            //{
                                            //    if (reader["COL_Type"].ToString().Contains("COM"))
                                            //    {
                                            //        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                            //        q1.COL_NameFirst = textInfo.ToTitleCase(((string)reader["debtor_Name"]).ToLower().Trim());
                                            //        q1.COL_NameLast = ((string)reader["de_Contact"]).Trim();
                                            //    }
                                            //    else
                                            //    {
                                            //        q1.de_contact = reader["de_Contact"].ToString().Trim();
                                            //        if (q1.de_contact.Contains(','))
                                            //        {
                                            //            string[] name = q1.de_contact.Split(',');
                                            //            q1.COL_NameFirst = name[0].Trim();

                                            //            if (name.Length > 1)
                                            //            {
                                            //                q1.COL_NameLast = name[1].Trim();

                                            //                if (name.Length > 2)
                                            //                {
                                            //                    q1.COL_NameLast += name[2].Trim();
                                            //                }
                                            //            }
                                            //        }
                                            //        else
                                            //        {
                                            //            string[] name = q1.de_contact.Split(' ');
                                            //            q1.COL_NameFirst = name[0].Trim();

                                            //            if (name.Length > 1)
                                            //            {
                                            //                q1.COL_NameLast = name[1].Trim();

                                            //                if (name.Length > 2)
                                            //                {
                                            //                    q1.COL_NameLast += name[2].Trim();
                                            //                }
                                            //            }
                                            //        }
                                            //    }


                                            //}
                                            if (reader["de_Contact"] != DBNull.Value)
                                            {
                                                if (reader["COL_Type"].ToString().Contains("COM"))
                                                {
                                                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                                    q1.COL_NameFirst = textInfo.ToTitleCase(((string)reader["debtor_Name"]).ToLower().Trim());
                                                    q1.COL_NameLast = ((string)reader["de_Contact"]).Trim();
                                                }
                                                else
                                                {
                                                    q1.de_contact = reader["de_Contact"].ToString().Trim();

                                                    string[] parts = q1.de_contact.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                                                    if (parts.Length > 0)
                                                    {
                                                        // first word = first name
                                                        q1.COL_NameFirst = parts[0].Trim();

                                                        if (parts.Length > 1)
                                                        {
                                                            // everything else = last name (including parent tag if exists)
                                                            q1.COL_NameLast = string.Join(" ", parts.Skip(1)).Trim();
                                                        }
                                                    }
                                                }
                                            }



                                            if (reader["CELL"] != DBNull.Value)
                                            {
                                                q1.COL_PhoneHome = ((string)reader["CELL"]);
                                            }
                                            if (reader["Next_Best"] != DBNull.Value)
                                            {
                                                q1.Next_Best = ((string)reader["Next_Best"]);
                                            }
                                            if (reader["Rank"] != DBNull.Value)
                                            {
                                                q1.Rank = ((string)reader["Rank"]);
                                            }
                                            if (reader["Source"] != DBNull.Value)
                                            {
                                                q1.Source = ((string)reader["Source"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["COL_PhoneHome_Ext"] != DBNull.Value)
                                            {
                                                q1.COL_PhoneHome_Ext = ((string)reader["COL_PhoneHome_Ext"]);
                                            }
                                            if (reader["COL_Acct"] != DBNull.Value)
                                            {
                                                q1.COL_Acct = (reader["COL_Acct"].ToString().Replace("\r", "").Replace("\n", " "));
                                            }
                                            if (reader["COL_Charged"] != DBNull.Value)
                                            {
                                                q1.COL_Charged = (String)reader["COL_Charged"];
                                            }
                                            if (reader["Last_RPC_Date"] != DBNull.Value)
                                            {
                                                q1.Last_RPC_Date = (String)reader["COL_Charged"];
                                            }
                                            if (reader["Last_Payment_Date"] != DBNull.Value)
                                            {
                                                q1.Last_Payment_Date = (String)reader["COL_Charged"];
                                            }
                                            if (reader["delinquency_date"] != DBNull.Value)
                                            {
                                                q1.delinquency_date = reader["delinquency_date"].ToString();
                                            }

                                            if (reader["COL_States"] != DBNull.Value)
                                            {
                                                q1.COL_States = (string)reader["COL_States"];
                                            }
                                            if (reader["COL_Client"] != DBNull.Value)
                                            {
                                                q1.COL_Client = (reader["COL_Client"].ToString().Replace("\r", "").Replace("\n", " "));
                                            }
                                            if (reader["COL_Client_number"] != DBNull.Value)
                                            {
                                                q1.COL_Client_number = ((int)reader["COL_Client_number"]);
                                            }
                                            if (reader["COL_ZipCode"] != DBNull.Value)
                                            {
                                                q1.COL_ZipCode = (reader["COL_ZipCode"].ToString().Replace("\r", "").Replace("\n", " "));
                                            }
                                            if (reader["COL_Type"] != DBNull.Value)
                                            {
                                                q1.COL_Type = (reader["COL_Type"].ToString().Replace("\r", "").Replace("\n", " "));
                                            }
                                            if (reader["COL_Status"] != DBNull.Value)
                                            {
                                                q1.COL_Status = (reader["COL_Status"].ToString().Replace("\r", "").Replace("\n", " "));
                                            }
                                            if (reader["COL_Listed"] != DBNull.Value)
                                            {
                                                q1.COL_Listed = (string)reader["COL_Listed"];
                                            }
                                            if (reader["COL_Owing"] != DBNull.Value)
                                            {
                                                q1.COL_Owing = ((decimal)reader["COL_Owing"]);
                                            }       
                                            if (reader["COL_score"] != DBNull.Value)
                                            {
                                                q1.COL_score = ((int)reader["COL_score"]);
                                            }
                                            if (reader["co_description"] != DBNull.Value)
                                            {
                                                q1.co_description = ((string)reader["co_description"]);
                                            }
                                            if (reader["Operator"] != DBNull.Value)
                                            {
                                                q1.Operator = ((string)reader["Operator"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["Orignal_Creditor"] != DBNull.Value)
                                            {
                                                q1.Original_Creditor = ((string)reader["Orignal_Creditor"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["Settlement"] != DBNull.Value)
                                            {
                                                q1.Settlement = ((string)reader["Settlement"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["group_count"] != DBNull.Value)
                                            {
                                                q1.group_count = ((Int16)reader["group_count"]);
                                            }

                                            if (reader["address"] != DBNull.Value)
                                            {
                                                q1.address = ((string)reader["address"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["city"] != DBNull.Value)
                                            {
                                                q1.city = ((string)reader["city"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["mode"] != DBNull.Value)
                                            {
                                                q1.mode = ((string)reader["mode"]).Replace("\r", "").Replace("\n", " ");
                                            }

                                            if (reader["de_Contact"] != DBNull.Value)
                                            {
                                                q1.DeContact = ((string)reader["de_Contact"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["debtor_Name"] != DBNull.Value)
                                            {
                                                q1.debtor_Name = ((string)reader["debtor_Name"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["debtor_closed"] != DBNull.Value)
                                            {
                                                q1.debtor_closed = ((string)reader["debtor_closed"]);
                                            }
                                            if (reader["debtor_legal"] != DBNull.Value)
                                            {
                                                q1.Legal = Convert.ToDecimal(reader["debtor_legal"]);
                                            }
                                            if (reader["home_extension"] != DBNull.Value)
                                            {
                                                q1.home_extension = ((string)reader["home_extension"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["cell_extension"] != DBNull.Value)
                                            {
                                                q1.cell_extension = ((string)reader["cell_extension"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["work_extension"] != DBNull.Value)
                                            {
                                                q1.work_extension = ((string)reader["work_extension"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["other_extension"] != DBNull.Value)
                                            {
                                                q1.other_extension = ((string)reader["other_extension"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["group_filenumber"] != DBNull.Value)
                                            {
                                                q1.group_filenumber = ((Int32)reader["group_filenumber"]);
                                            }
                                            if (reader["de_country"] != DBNull.Value)
                                            {
                                                q1.Country = ((string)reader["de_country"]).Replace("\r", "").Replace("\n", " ");
                                            }
                                            if (reader["COL_States"] != DBNull.Value)
                                            {
                                                string stateAbbreviation = reader["COL_States"].ToString();
                                                if (stateTimeZones.TryGetValue(stateAbbreviation, out string timeZone))
                                                {
                                                    q1.TimeZone = timeZone;
                                                }
                                                else
                                                {
                                                    q1.TimeZone = "Unknown Time Zone"; // fallback if not found
                                                }
                                            }

                                            if (reader["summary"] != DBNull.Value)
                                            {
                                                q1.summary = ((string)reader["summary"]).Replace("\r", "").Replace("\n", " ");
                                            }



                                            q1List.Add(q1);
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("An error occurred: " + ex.Message);
                                    }


                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("An error occurred: " + ex.Message);
                            }
                        }
                    }
                }
            }

            List<CUL_Report> uniqueQ1List = q1List.Distinct(new CUL_ReportComparer()).ToList();
            List<CUL_Report> uniqueQ2List = uniqueQ1List.Distinct(new CUL_ReportComparer2()).ToList();

            return uniqueQ2List.Skip((int)skip)
                               .Take((int)col.PageSize)
                               .ToList();
            //return q1List.Skip((int)skip)
            //                   .Take((int)col.PageSize)
            //                   .ToList();
        }
        //private string MapTimezone(decimal offset)
        //{
        //    switch (offset)
        //    {
        //        case -12:
        //            return "Anywhere on Earth";
        //        case -11:
        //            return "Samoa";
        //        case -10:
        //            return "Hawaii";
        //        case -9:
        //            return "Alaska";
        //        case -8:
        //            return "Pacific Standard Time";
        //        case -7:
        //            return "Mountain Standard Time";
        //        case -6:
        //            return "Central Standard Time";
        //        case -5:
        //            return "Eastern Standard Time";
        //        case -4:
        //            return "Atlantic Standard Time";
        //        case -3.5m:
        //            return "Newfoundland Time";
        //        case -3:
        //            return "Greenland Time";
        //        case -2:
        //            return "Mid-Atlantic";
        //        case -1:
        //            return "Azores";
        //        case 0:
        //            return "Greenwich Mean Time";
        //        case 1:
        //            return "Central European Time";
        //        case 2:
        //            return "Eastern European Time";
        //        case 3:
        //            return "Moscow Time";
        //        case 3.5m:
        //            return "Iran Standard Time";
        //        case 4:
        //            return "Gulf Standard Time";
        //        case 4.5m:
        //            return "Afghanistan";
        //        case 5:
        //            return "Pakistan Standard Time";
        //        case 5.5m:
        //            return "India Standard Time";
        //        case 6:
        //            return "Bangladesh Standard Time";
        //        case 6.5m:
        //            return "Myanmar";
        //        case 7:
        //            return "Indochina Time";
        //        case 8:
        //            return "China Standard Time";
        //        case 9:
        //            return "Japan Standard Time";
        //        case 9.5m:
        //            return "Central Australia";
        //        case 10:
        //            return "Eastern Australia";
        //        case 11:
        //            return "Solomon Islands Time";
        //        case 12:
        //            return "New Zealand Standard Time";
        //        default:
        //            // If no mapping exists, you can return the numeric value as a string.
        //            return offset.ToString("0.##");
        //    }
        //}
        Dictionary<string, string> stateTimeZones = new Dictionary<string, string>()
        {
            { "AL", "-600 Central Standard Time" },
            { "AK", "-900 Alaska Time" },
            { "AZ", "-700 Mountain Standard Time (No DST)" },
            { "AR", "-600 Central Standard Time" },
            { "CA", "-800 Pacific Standard Time" },
            { "CO", "-700 Mountain Standard Time" },
            { "CT", "-500 Eastern Standard Time" },
            { "DE", "-500 Eastern Standard Time" },
            { "FL", "-500 Eastern / Central Standard Time" },
            { "GA", "-500 Eastern Standard Time" },
            { "HI", "-1000 Hawaii (No DST)" },
            { "ID", "-700 Mountain / Pacific Standard Time" },
            { "IL", "-600 Central Standard Time" },
            { "IN", "-500 Eastern / Central Standard Time" },
            { "IA", "-600 Central Standard Time" },
            { "KS", "-600 Central / Mountain Standard Time" },
            { "KY", "-500 Eastern / Central Standard Time" },
            { "LA", "-600 Central Standard Time" },
            { "ME", "-500 Eastern Standard Time" },
            { "MD", "-500 Eastern Standard Time" },
            { "MA", "-500 Eastern Standard Time" },
            { "MI", "-500 Eastern / Central Standard Time" },
            { "MN", "-600 Central Standard Time" },
            { "MS", "-600 Central Standard Time" },
            { "MO", "-600 Central Standard Time" },
            { "MT", "-700 Mountain Standard Time" },
            { "NE", "-600 Central / Mountain Standard Time" },
            { "NV", "-800 Pacific / Mountain Standard Time" },
            { "NH", "-500 Eastern Standard Time" },
            { "NJ", "-500 Eastern Standard Time" },
            { "NM", "-700 Mountain Standard Time" },
            { "NY", "-500 Eastern Standard Time" },
            { "NC", "-500 Eastern Standard Time" },
            { "ND", "-600 Central / Mountain Standard Time" },
            { "OH", "-500 Eastern Standard Time" },
            { "OK", "-600 Central Standard Time" },
            { "OR", "-800 Pacific / Mountain Standard Time" },
            { "PA", "-500 Eastern Standard Time" },
            { "RI", "-500 Eastern Standard Time" },
            { "SC", "-500 Eastern Standard Time" },
            { "SD", "-600 Central / Mountain Standard Time" },
            { "TN", "-600 Central / Eastern Standard Time" },
            { "TX", "-600 Central Standard Time" },
            { "UT", "-700 Mountain Standard Time" },
            { "VT", "-500 Eastern Standard Time" },
            { "VA", "-500 Eastern Standard Time" },
            { "WA", "-800 Pacific Standard Time" },
            { "WV", "-500 Eastern Standard Time" },
            { "WI", "-600 Central Standard Time" },
            { "WY", "-700 Mountain Standard Time" },
            { "DC", "-500 Eastern Standard Time" }
        };
        
        public class CUL_ReportComparer : IEqualityComparer<CUL_Report>
        {
            public bool Equals(CUL_Report x, CUL_Report y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null) || ReferenceEquals(y, null)) return false;
                return x.COL_FileNumber == y.COL_FileNumber;
            }

            public int GetHashCode(CUL_Report obj)
            {
                // Use both fields to ensure uniqueness in hashing
                int hashFileNumber = obj.COL_FileNumber?.GetHashCode() ?? 0;
                return hashFileNumber;
            }
        }
        public class CUL_ReportComparer2 : IEqualityComparer<CUL_Report>
        {
            public bool Equals(CUL_Report x, CUL_Report y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null) || ReferenceEquals(y, null)) return false;
                return x.COL_PhoneHome == y.COL_PhoneHome;
            }

            public int GetHashCode(CUL_Report obj)
            {
                // Use both fields to ensure uniqueness in hashing

                int hashPhoneHome = obj.COL_PhoneHome?.GetHashCode() ?? 0;
                return hashPhoneHome;
            }
        }
        //public async Task<List<CUL_Report>> ColReportIndex(CUL_Report_Parameters col, string constrr)
        //{
        //    if (col == null)
        //    {
        //        throw new ArgumentNullException(nameof(col), "Parameters cannot be null");
        //    }
        //    var resultList = new List<CUL_Report>();
        //    List<CUL_Report> q1List = new List<CUL_Report>();

        //    using (SqlConnection con = new SqlConnection(constrr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SP_CUL_Report_Index1", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandTimeout = 600000;

        //            // Add parameters to the command
        //            cmd.Parameters.AddWithValue("@MyHiddenId", "A");
        //            cmd.Parameters.AddWithValue("@st_in", col.st_in);
        //            cmd.Parameters.AddWithValue("@cl_num_in", col.cl_num_in);
        //            cmd.Parameters.AddWithValue("@score_in", col.score_in);
        //            cmd.Parameters.AddWithValue("@coun_in", col.coun_in);
        //            cmd.Parameters.AddWithValue("@cd_in", col.cd_in);
        //            cmd.Parameters.AddWithValue("@ld_in", col.ld_in);
        //            cmd.Parameters.AddWithValue("@op_in", col.op_in);
        //            cmd.Parameters.AddWithValue("@ld", col.ld);
        //            cmd.Parameters.AddWithValue("@cd", col.cd);
        //            cmd.Parameters.AddWithValue("@op", col.op);
        //            cmd.Parameters.AddWithValue("@st", col.st);
        //            cmd.Parameters.AddWithValue("@cl_num", col.cl_num);
        //            cmd.Parameters.AddWithValue("@state", col.state);
        //            cmd.Parameters.AddWithValue("@ld_1", col.ld_1);
        //            cmd.Parameters.AddWithValue("@cd_1", col.cd_1);
        //            cmd.Parameters.AddWithValue("@cl_num_1", col.cl_num_1);
        //            cmd.Parameters.AddWithValue("@score", col.score);
        //            cmd.Parameters.AddWithValue("@score_1", col.score_1);
        //            cmd.Parameters.AddWithValue("@coun", col.coun);
        //            cmd.Parameters.AddWithValue("@wd", col.wd);
        //            cmd.Parameters.AddWithValue("@wd_1", col.wd_1);
        //            cmd.Parameters.AddWithValue("@wd_in", col.wd_in);
        //            cmd.Parameters.AddWithValue("@reg_f", col.reg_f);
        //            cmd.Parameters.AddWithValue("@sectorL", col.sectorL);
        //            cmd.Parameters.AddWithValue("@CollectorIn", col.CollectorIn);
        //            cmd.Parameters.AddWithValue("@Collector", col.Collector);
        //            cmd.Parameters.AddWithValue("@co_description", col.co_description);
        //            cmd.Parameters.AddWithValue("@co_description_in", col.co_description_in);

        //            // Add parameter for "ty" based on its value
        //            switch (col.ty)
        //            {
        //                case "CON":
        //                    cmd.Parameters.AddWithValue("@ty", 1);
        //                    break;
        //                case "COM":
        //                    cmd.Parameters.AddWithValue("@ty", 2);
        //                    break;
        //                case "BAS":
        //                    cmd.Parameters.AddWithValue("@ty", 3);
        //                    break;
        //                case "COR":
        //                    cmd.Parameters.AddWithValue("@ty", 4);
        //                    break;
        //                case "INT":
        //                    cmd.Parameters.AddWithValue("@ty", 5);
        //                    break;
        //                case "GRAD":
        //                    cmd.Parameters.AddWithValue("@ty", 6);
        //                    break;
        //                case "DROP":
        //                    cmd.Parameters.AddWithValue("@ty", 7);
        //                    break;
        //                case "DISR":
        //                    cmd.Parameters.AddWithValue("@ty", 8);
        //                    break;
        //                case "MED":
        //                    cmd.Parameters.AddWithValue("@ty", 9);
        //                    break;
        //                case "EDU":
        //                    cmd.Parameters.AddWithValue("@ty", 10);
        //                    break;
        //                default:
        //                    cmd.Parameters.AddWithValue("@ty", col.ty);
        //                    break;
        //            }

        //            cmd.Parameters.AddWithValue("@ty_in", col.ty_in);
        //            cmd.Parameters.AddWithValue("@Channel", col.Channel);
        //            cmd.Parameters.AddWithValue("@Ch_check", col.Ch_check);
        //            cmd.Parameters.AddWithValue("@val", DBNull.Value);
        //            cmd.Parameters.AddWithValue("@co_cd", col.co_cd);
        //            cmd.Parameters.AddWithValue("@co_cd1", col.co_cd1);
        //            cmd.Parameters.AddWithValue("@co_cdin", col.co_cdin);
        //            cmd.Parameters.AddWithValue("@co_completed", col.Co_Completed);
        //            cmd.Parameters.AddWithValue("@co_who", col.Co_Who);
        //            cmd.Parameters.AddWithValue("@owing", col.owing);
        //            cmd.Parameters.AddWithValue("@owing_1", col.owing_1);
        //            cmd.Parameters.AddWithValue("@owing_in", col.owing_in);

        //            // Execute the command
        //            con.Open();
        //            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
        //            {
        //                // Loop through all the rows and save them into q1List
        //                while (await reader.ReadAsync())
        //                {
        //                    var report = CreateCULReport(reader); // Create a report object for each row
        //                    q1List.Add(report); // Add the report object to the list
        //                }
        //                var tempList = q1List;
        //                q1List.AsReadOnly();

        //                HashSet<string> processedFileNumbers = new HashSet<string>();

        //                for (int i = tempList.Count - 1; i >= 0; i--)
        //                {
        //                    var temp = tempList[i];

        //                    if (processedFileNumbers.Contains(temp.COL_FileNumber.ToString()))
        //                    {
        //                        continue;
        //                    }

        //                    var sameFileNumbersList = tempList.Where(x => x.COL_FileNumber == temp.COL_FileNumber).ToList();

        //                    if (sameFileNumbersList.Any())
        //                    {
        //                        var rpcPhone = sameFileNumbersList.Where(x => x.Source == "RPC").FirstOrDefault();
        //                        if (rpcPhone != null)
        //                        { resultList.Add(rpcPhone); goto labelName; }


        //                        var creditorPhone = sameFileNumbersList.Where(x => x.Source == "Creditor").FirstOrDefault();
        //                        if (creditorPhone != null)
        //                        { resultList.Add(creditorPhone); goto labelName; }

        //                        var tloPhone = sameFileNumbersList.Where(x => x.Source == "TLO").FirstOrDefault();
        //                        if (tloPhone != null)
        //                        {
        //                            if (tloPhone.PhoneType.Contains("Mobile"))
        //                            { resultList.Add(tloPhone); goto labelName; }
        //                            else if (tloPhone.PhoneType.Contains("Land Line"))
        //                            { resultList.Add(tloPhone); goto labelName; }
        //                            else if (tloPhone.PhoneType.Contains("Voip"))
        //                            { resultList.Add(tloPhone); goto labelName; }
        //                        }

        //                        var homePhone = sameFileNumbersList.Where(x => x.Source == "HOME").FirstOrDefault();
        //                        if (homePhone != null)
        //                        { resultList.Add(homePhone); goto labelName; }

        //                        var cellPhone = sameFileNumbersList.Where(x => x.Source == "CELL").FirstOrDefault();
        //                        if (cellPhone != null)
        //                        { resultList.Add(cellPhone); goto labelName; }

        //                        var otherPhone = sameFileNumbersList.Where(x => x.Source == "OTHER").FirstOrDefault();
        //                        if (otherPhone != null)
        //                        { resultList.Add(otherPhone); goto labelName; }

        //                        var workPhone = sameFileNumbersList.Where(x => x.Source == "WORK").FirstOrDefault();
        //                        if (workPhone != null)
        //                        { resultList.Add(workPhone); goto labelName; }

        //                    labelName:
        //                        processedFileNumbers.Add(temp.COL_FileNumber.ToString());
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return resultList; // Return the list with all the data
        //}

        //private CUL_Report CreateCULReport(SqlDataReader reader)
        //{
        //    var report = new CUL_Report();

        //    if (reader["COL_Email"] != DBNull.Value)
        //        report.COL_Email = reader["COL_Email"].ToString();
        //    if (reader["COL_FileNumber"] != DBNull.Value)
        //        report.COL_FileNumber = (int?)reader["COL_FileNumber"];
        //    if (reader["de_Contact"] != DBNull.Value)
        //    {
        //        report.de_contact = reader["de_Contact"].ToString();
        //        var name = reader["de_Contact"].ToString().Split(',');
        //        report.COL_NameFirst = name.Length > 0 ? name[0].Trim() : string.Empty;
        //        report.COL_NameLast = name.Length > 1 ? name[1].Trim() : string.Empty;
        //    }
        //    if (reader["RPCNumber"] != DBNull.Value)
        //        report.COL_PhoneHome = reader["RPCNumber"].ToString();
        //    else if (reader["CELL"] != DBNull.Value)
        //        report.COL_PhoneHome = reader["CELL"].ToString();

        //    if (reader["Sources"] != DBNull.Value && reader["RPCNumber"] != DBNull.Value)
        //    {
        //        report.Source = "RPC";
        //    }
        //    else
        //    {
        //        report.Source = reader["Sources"].ToString();
        //    }
        //    if (reader["Phone_Type"] != DBNull.Value)
        //        report.PhoneType = reader["Phone_Type"].ToString();
        //    if (reader["COL_PhoneHome_Ext"] != DBNull.Value)
        //        report.COL_PhoneHome_Ext = reader["COL_PhoneHome_Ext"].ToString();
        //    if (reader["COL_Acct"] != DBNull.Value)
        //        report.COL_Acct = reader["COL_Acct"].ToString();
        //    if (reader["COL_Charged"] != DBNull.Value)
        //        report.COL_Charged = reader["COL_Charged"].ToString();
        //    if (reader["COL_States"] != DBNull.Value)
        //        report.COL_States = reader["COL_States"].ToString();
        //    if (reader["COL_Client"] != DBNull.Value)
        //        report.COL_Client = reader["COL_Client"].ToString();
        //    if (reader["COL_Client_number"] != DBNull.Value)
        //        report.COL_Client_number = (int)reader["COL_Client_number"];
        //    if (reader["COL_ZipCode"] != DBNull.Value)
        //        report.COL_ZipCode = reader["COL_ZipCode"].ToString();
        //    if (reader["COL_Type"] != DBNull.Value)
        //        report.COL_Type = reader["COL_Type"].ToString();
        //    if (reader["COL_Status"] != DBNull.Value)
        //        report.COL_Status = reader["COL_Status"].ToString();
        //    if (reader["COL_Listed"] != DBNull.Value)
        //        report.COL_Listed = reader["COL_Listed"].ToString();
        //    if (reader["COL_Owing"] != DBNull.Value)
        //        report.COL_Owing = (decimal)reader["COL_Owing"];
        //    if (reader["COL_score"] != DBNull.Value)
        //        report.COL_score = (int)reader["COL_score"];
        //    if (reader["co_description"] != DBNull.Value)
        //        report.co_description = reader["co_description"].ToString();
        //    if (reader["Operator"] != DBNull.Value)
        //        report.Operator = reader["Operator"].ToString();

        //    return report;
        //}

        public async Task<List<CUL_Report>> CosignerReport(CUL_Report_Parameters col, string constrr)

        {
            List<CUL_Report> Listq1 = new List<CUL_Report>();
            if (col != null)
            {

                using (SqlConnection con = new SqlConnection(constrr))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_CosignerReport", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 900000;

                        cmd.Parameters.AddWithValue("@MyHiddenId", "A");
                        cmd.Parameters.AddWithValue("@st_in", col.st_in); // Set NULL if needed
                        cmd.Parameters.AddWithValue("@cl_num_in", col.cl_num_in);
                        cmd.Parameters.AddWithValue("@score_in", col.score_in);
                        cmd.Parameters.AddWithValue("@coun_in", col.coun_in);
                        cmd.Parameters.AddWithValue("@cd_in", col.cd_in);
                        cmd.Parameters.AddWithValue("@ld_in", col.ld_in);
                        cmd.Parameters.AddWithValue("@op_in", col.op_in);
                        cmd.Parameters.AddWithValue("@ld", col.ld);
                        cmd.Parameters.AddWithValue("@cd", col.cd);
                        cmd.Parameters.AddWithValue("@op", col.op);
                        cmd.Parameters.AddWithValue("@st", col.st);
                        cmd.Parameters.AddWithValue("@cl_num", col.cl_num);
                        cmd.Parameters.AddWithValue("@state", col.state);
                        cmd.Parameters.AddWithValue("@ld_1", col.ld_1);
                        cmd.Parameters.AddWithValue("@cd_1", col.cd_1);
                        cmd.Parameters.AddWithValue("@cl_num_1", col.cl_num_1);
                        cmd.Parameters.AddWithValue("@score", col.score);
                        cmd.Parameters.AddWithValue("@score_1", col.score_1);
                        cmd.Parameters.AddWithValue("@coun", col.coun);
                        cmd.Parameters.AddWithValue("@wd", col.wd);
                        cmd.Parameters.AddWithValue("@wd_1", col.wd_1);
                        cmd.Parameters.AddWithValue("@wd_in", col.wd_in);
                        cmd.Parameters.AddWithValue("@ty", col.ty);
                        cmd.Parameters.AddWithValue("@ty_in", col.ty_in);
                        cmd.Parameters.AddWithValue("@Channel", col.Channel);
                        cmd.Parameters.AddWithValue("@Ch_check", col.Ch_check);
                        cmd.Parameters.AddWithValue("@val", DBNull.Value);
                        cmd.Parameters.AddWithValue("@co_cd", col.co_cd);
                        cmd.Parameters.AddWithValue("@co_cd1", col.co_cd1);
                        cmd.Parameters.AddWithValue("@co_cdin", col.co_cdin);
                        cmd.Parameters.AddWithValue("@co_completed", col.Co_Completed);
                        cmd.Parameters.AddWithValue("@co_who", col.Co_Who);


                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                CUL_Report q1 = new CUL_Report();


                                if (reader["COL_FileNumber"] != DBNull.Value)
                                {
                                    q1.COL_FileNumber = ((int?)reader["COL_FileNumber"]);
                                }
                                if (reader["de_Contact"] != DBNull.Value)
                                {
                                    q1.de_contact = reader["de_Contact"].ToString();
                                    if (q1.de_contact.Contains(','))
                                    {
                                        string[] name = q1.de_contact.Split(',');
                                        q1.COL_NameFirst = name[0].Trim();

                                        if (name.Length > 1)
                                        {
                                            q1.COL_NameLast = name[1].Trim();

                                            if (name.Length > 2)
                                            {
                                                q1.COL_NameLast += name[2].Trim();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        string[] name = q1.de_contact.Split(' ');
                                        q1.COL_NameFirst = name[0].Trim();

                                        if (name.Length > 1)
                                        {
                                            q1.COL_NameLast = name[1].Trim();

                                            if (name.Length > 2)
                                            {
                                                q1.COL_NameLast += name[2].Trim();
                                            }
                                        }
                                    }

                                }
                                if (reader["CosEmail"] != DBNull.Value)
                                {
                                    q1.CosEmail = reader["CosEmail"].ToString();
                                }
                                if (reader["de_cos_country"] != DBNull.Value)
                                {
                                    q1.de_cos_country = (reader["de_cos_country"].ToString());
                                }
                                if (reader["COL_PhoneHome"] != DBNull.Value)
                                {
                                    q1.COL_PhoneHome = (reader["COL_PhoneHome"].ToString());

                                    if (q1.COL_PhoneHome.Contains('-'))
                                    {
                                        q1.COL_PhoneHome = q1.COL_PhoneHome.Replace("-", "");
                                    }

                                    if (q1.de_country != "United States" && !q1.COL_PhoneHome.Contains("+"))
                                    {
                                        q1.COL_PhoneHome = "+" + q1.COL_PhoneHome;
                                    }

                                }
                                if (reader["COL_PhonePOE"] != DBNull.Value)
                                {
                                    q1.COL_PhonePOE = (reader["COL_PhonePOE"].ToString());

                                    if (q1.COL_PhonePOE.Contains('-'))
                                    {
                                        q1.COL_PhonePOE = q1.COL_PhonePOE.Replace("-", "");
                                    }

                                    if (q1.de_country != "United States" && !q1.COL_PhonePOE.Contains("+"))
                                    {
                                        q1.COL_PhonePOE = "+" + q1.COL_PhonePOE;
                                    }

                                }
                                if (reader["COL_PhoneCell"] != DBNull.Value)
                                {
                                    q1.COL_PhoneCell = (reader["COL_PhoneCell"].ToString());
                                    if (q1.COL_PhoneCell.Contains('-'))
                                    {
                                        q1.COL_PhoneCell = q1.COL_PhoneCell.Replace("-", "");
                                    }

                                    if (q1.de_country != "United States" && !q1.COL_PhoneCell.Contains("+"))
                                    {
                                        q1.COL_PhoneCell = "+" + q1.COL_PhoneCell;
                                    }
                                }
                                if (reader["COL_PhoneOther"] != DBNull.Value)
                                {
                                    q1.COL_PhoneOther = (reader["COL_PhoneOther"].ToString());

                                    if (q1.COL_PhoneOther.Contains('-'))
                                    {
                                        q1.COL_PhoneOther = q1.COL_PhoneOther.Replace("-", "");
                                    }

                                    if (q1.de_country != "United States" && !q1.COL_PhoneOther.Contains("+"))
                                    {
                                        q1.COL_PhoneOther = "+" + q1.COL_PhoneOther;
                                    }

                                }
                                if (reader["COL_Acct"] != DBNull.Value)
                                {
                                    q1.COL_Acct = (reader["COL_Acct"].ToString());
                                }
                                if (reader["COL_Charged"] != DBNull.Value)
                                {
                                    q1.COL_Charged = (string)reader["COL_Charged"];
                                }
                                if (reader["COL_Client"] != DBNull.Value)
                                {
                                    q1.COL_Client = (reader["COL_Client"].ToString());
                                }
                                if (reader["COL_Client_number"] != DBNull.Value)
                                {
                                    q1.COL_Client_number = ((int)reader["COL_Client_number"]);
                                }
                                if (reader["COL_Owing"] != DBNull.Value)
                                {
                                    q1.COL_Owing = ((decimal)reader["COL_Owing"]);
                                }
                                if (reader["COL_ZipCode"] != DBNull.Value)
                                {
                                    q1.COL_ZipCode = (reader["COL_ZipCode"].ToString());
                                }
                                if (reader["COL_Type"] != DBNull.Value)
                                {
                                    q1.COL_Type = (reader["COL_Type"].ToString());
                                }
                                if (reader["COL_Status"] != DBNull.Value)
                                {
                                    q1.COL_Status = (reader["COL_Status"].ToString());
                                }
                                if (reader["COL_Listed"] != DBNull.Value)
                                {
                                    q1.COL_Listed = (string)reader["COL_Listed"];
                                }
                                if (reader["de_country"] != DBNull.Value)
                                {
                                    q1.de_country = ((string)reader["de_country"]);
                                }
                                if (reader["COL_WorkedDate"] != DBNull.Value)
                                {
                                    q1.COL_WorkedDate = (string)reader["COL_WorkedDate"];
                                }

                                Listq1.Add(q1);
                            }


                        }
                    }
                }
            }
            return Listq1.Take(100).ToList();
        }

        public async Task<List<dynamic>> CosignerEmail(CUL_Report_Parameters col, string constrr)
        {

            List<EmailReport> Listq1 = new List<EmailReport>();
            List<EmailReport2> Listq2 = new List<EmailReport2>();
            if (col.Page == 0 && col.PageSize == 0)
            {
                col.Page = 1;
                col.PageSize = 1000000000;
            }
            var skip = col.PageSize * (col.Page - 1);
            if (col != null)
            {

                using (SqlConnection con = new SqlConnection(constrr))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_CosignerEmail", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 900000;

                        cmd.Parameters.AddWithValue("@MyHiddenId", col.MyHiddenId);
                        cmd.Parameters.AddWithValue("@st_in", col.st_in); // Set NULL if needed
                        cmd.Parameters.AddWithValue("@cl_num_in", col.cl_num_in);
                        cmd.Parameters.AddWithValue("@score_in", col.score_in);
                        cmd.Parameters.AddWithValue("@coun_in", col.coun_in);
                        cmd.Parameters.AddWithValue("@cd_in", col.cd_in);
                        cmd.Parameters.AddWithValue("@ld_in", col.ld_in);
                        cmd.Parameters.AddWithValue("@op_in", col.op_in);
                        cmd.Parameters.AddWithValue("@ld", col.ld);
                        cmd.Parameters.AddWithValue("@cd", col.cd);
                        cmd.Parameters.AddWithValue("@op", col.op);
                        cmd.Parameters.AddWithValue("@st", col.st);
                        cmd.Parameters.AddWithValue("@cl_num", col.cl_num);
                        cmd.Parameters.AddWithValue("@state", col.state);
                        cmd.Parameters.AddWithValue("@ld_1", col.ld_1);
                        cmd.Parameters.AddWithValue("@cd_1", col.cd_1);
                        cmd.Parameters.AddWithValue("@cl_num_1", col.cl_num_1);
                        cmd.Parameters.AddWithValue("@score", col.score);
                        cmd.Parameters.AddWithValue("@score_1", col.score_1);
                        cmd.Parameters.AddWithValue("@coun", col.coun);
                        cmd.Parameters.AddWithValue("@wd", col.wd);
                        cmd.Parameters.AddWithValue("@wd_1", col.wd_1);
                        cmd.Parameters.AddWithValue("@wd_in", col.wd_in);
                        cmd.Parameters.AddWithValue("@zip_in", col.zip_in);
                        cmd.Parameters.AddWithValue("@file_number", col.file_number);
                        cmd.Parameters.AddWithValue("@file_number_in", col.file_number_in);
                        cmd.Parameters.AddWithValue("@Orignal_Creditor", col.Orignal_Creditor);
                        cmd.Parameters.AddWithValue("@Orignal_Creditor_In", col.Orignal_Creditor_In);
                        string result = null;
                        if (col.ty != null)
                        {
                            string[] typeValues = col.ty.Split(',');
                            List<object> mappedValues = new List<object>();

                            foreach (string value in typeValues)
                            {
                                if (value.Trim() == "CON")
                                {
                                    mappedValues.Add(1);
                                }
                                else if (value.Trim() == "COM")
                                {
                                    mappedValues.Add(2);
                                }
                                else if (value.Trim() == "BAS")
                                {
                                    mappedValues.Add(3);
                                }
                                else if (value.Trim() == "COR")
                                {
                                    mappedValues.Add(4);
                                }
                                else if (value.Trim() == "INT")
                                {
                                    mappedValues.Add(5);
                                }
                                else if (value.Trim() == "GRAD")
                                {
                                    mappedValues.Add(6);
                                }
                                else if (value.Trim() == "DROP")
                                {
                                    mappedValues.Add(7);
                                }
                                else if (value.Trim() == "DISR")
                                {
                                    mappedValues.Add(8);
                                }
                                else if (value.Trim() == "MED")
                                {
                                    mappedValues.Add(9);
                                }
                                else if (value.Trim() == "EDU")
                                {
                                    mappedValues.Add(10);
                                }
                                else
                                {
                                    mappedValues.Add(value);
                                }
                            }

                            result = string.Join(",", mappedValues);
                        }

                        cmd.Parameters.AddWithValue("@ty", result);
                        cmd.Parameters.AddWithValue("@ty_in", col.ty_in);
                        cmd.Parameters.AddWithValue("@Channel", col.Channel);
                        cmd.Parameters.AddWithValue("@Ch_check", col.Ch_check);
                        cmd.Parameters.AddWithValue("@val", DBNull.Value);
                        cmd.Parameters.AddWithValue("@oos", col.oos);
                        cmd.Parameters.AddWithValue("@oos1", col.oos1);
                        cmd.Parameters.AddWithValue("@NeuStar", col.NeuStar);
                        cmd.Parameters.AddWithValue("@co_cd", col.co_cd);
                        cmd.Parameters.AddWithValue("@co_cd1", col.co_cd1);
                        cmd.Parameters.AddWithValue("@co_cdin", col.co_cdin);
                        cmd.Parameters.AddWithValue("@co_completed", col.Co_Completed);
                        cmd.Parameters.AddWithValue("@co_who", col.Co_Who);
                        cmd.Parameters.AddWithValue("@co_description", col.co_description);
                        cmd.Parameters.AddWithValue("@co_description_in", col.co_description_in);
                        cmd.Parameters.AddWithValue("@CollectorIn", col.CollectorIn);
                        cmd.Parameters.AddWithValue("@Collector", col.Collector);
                        cmd.Parameters.AddWithValue("@owing", col.owing);
                        cmd.Parameters.AddWithValue("@owing_1", col.owing_1);
                        cmd.Parameters.AddWithValue("@owing_in", col.owing_in);



                        con.Open();

                        var uniqueEmailTokens = new Dictionary<(string OurFile, string Email), string>();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            try
                            {
                                //var spamEmails = _context2.SpamEmails.Select(e => e.SeEmail).ToList();

                                while (reader.Read())
                                {
                                    // string email1 = reader["email"].ToString();

                                    // if (!spamEmails.Contains(email1))
                                    {
                                        EmailReport q1 = new EmailReport();

                                        if (reader["debtor_country"].ToString().ToUpper().Contains("UNITED STATES") && (reader["debtor_type"].ToString().Contains("EDU") || reader["debtor_type"].ToString().Contains("MED"))
                                       && !reader["Client_num"].ToString().Contains("2206") && !reader["Client_num"].ToString().Contains("22062") && !reader["Client_num"].ToString().Contains("22060") && !reader["Client_num"].ToString().Contains("22063") && !reader["Client_num"].ToString().Contains("22064") && !reader["email"].ToString().ToUpper().EndsWith(".ORG") && !reader["email"].ToString().ToUpper().EndsWith(".EDU")
                                       && (reader["email"].ToString().ToUpper().Contains("@GMAIL") || reader["email"].ToString().ToUpper().Contains("@YMAIL") || reader["email"].ToString().ToUpper().Contains("@HOTMAIL") || reader["email"].ToString().ToUpper().Contains("@NVBELL")
                                       || reader["email"].ToString().ToUpper().Contains("@YAHOO") || reader["email"].ToString().ToUpper().Contains("@OUTLOOK") || reader["email"].ToString().ToUpper().Contains("@MSN") || reader["email"].ToString().ToUpper().Contains("@AOL")
                                       || reader["email"].ToString().ToUpper().Contains("@ICLOUD") || reader["email"].ToString().ToUpper().Contains("@MAIL") || reader["email"].ToString().ToUpper().Contains("@ME") || reader["email"].ToString().ToUpper().Contains("@MAC")
                                       || reader["email"].ToString().ToUpper().Contains("@LIVE") || reader["email"].ToString().ToUpper().Contains("@ROCKETMAIL") || reader["email"].ToString().ToUpper().Contains("@QQ") || reader["email"].ToString().ToUpper().Contains("@MY")
                                       || reader["email"].ToString().ToUpper().Contains("@GOOGLE") || reader["email"].ToString().ToUpper().Contains("@EMAIL") || reader["email"].ToString().ToUpper().Contains("@JUNO") || reader["email"].ToString().ToUpper().Contains("@GOOGLEMAIL")
                                       || reader["email"].ToString().ToUpper().Contains("@FOXMAIL") || reader["email"].ToString().ToUpper().Contains("@AMERITECH") || reader["email"].ToString().ToUpper().Contains("@ATT") || reader["email"].ToString().ToUpper().Contains("@BELLSOUTH")
                                       || reader["email"].ToString().ToUpper().Contains("@PACBELL") || reader["email"].ToString().ToUpper().Contains("@PRODIGY") || reader["email"].ToString().ToUpper().Contains("@SBCGLOBAL") || reader["email"].ToString().ToUpper().Contains("@SNET")
                                       || reader["email"].ToString().ToUpper().Contains("@SWBELL") || reader["email"].ToString().ToUpper().Contains("@WANS") || reader["email"].ToString().ToUpper().Contains("@COMCAST") || reader["email"].ToString().ToUpper().Contains("@FLASH")))
                                        {
                                            if ((reader["email"].ToString().Contains("@") && !reader["DeContact"].ToString().Contains("!@#$%^&/*()?") && !reader["contact"].ToString().Contains(")") && !reader["DeContact"].ToString().Contains("/") && reader["Account_Num"] != DBNull.Value
                                            && (reader["debtor_type"].ToString().Contains("COM") || reader["DeContact"].ToString().Contains(",") || reader["DeContact"].ToString().Contains(" "))))

                                            {
                                                if (reader["email"] != DBNull.Value)
                                                {
                                                    string email = ((string)reader["email"]).Trim();
                                                    q1.Email = email;
                                                    q1.ResponsibleParty_Email = "0";
                                                }

                                                if (reader["DeContact"] != DBNull.Value)
                                                {
                                                    q1.de_contact = reader["DeContact"].ToString();
                                                    string[] name = q1.de_contact.Split(' ');

                                                    if (name.Length > 0)
                                                    {
                                                        q1.First_Name = name[0].Trim();

                                                        if (name.Length > 1)
                                                        {
                                                            q1.Last_Name = string.Join(" ", name.Skip(1)).Trim();
                                                        }
                                                    }
                                                }
                                                if (reader["LastEmailSentDate"] != DBNull.Value)
                                                {
                                                    q1.LastEmailSentDate = ((Int32)reader["LastEmailSentDate"]);
                                                }

                                                if (reader["Original_Creditor"] != DBNull.Value)
                                                {
                                                    string originalCreditor = ((string)reader["Original_Creditor"]).Trim();
                                                    CultureInfo cultureInfo = CultureInfo.InvariantCulture; // You can specify a specific culture if needed
                                                    TextInfo textInfo = cultureInfo.TextInfo;
                                                    string formattedCreditor = textInfo.ToTitleCase(originalCreditor.ToLower());
                                                    q1.Original_Creditor = formattedCreditor.Replace("Llc", "LLC");
                                                }
                                                if (reader["Account_Num"] != DBNull.Value)
                                                {
                                                    q1.Account_Num = ((string)reader["Account_Num"]).Trim();
                                                }
                                                if (reader["Fees"] != DBNull.Value)
                                                {
                                                    decimal fees = (decimal)reader["Fees"];
                                                    q1.Fees = "$" + fees.ToString("0.00").Trim();
                                                }
                                                if (reader["Interest"] != DBNull.Value)
                                                {
                                                    decimal interest = (decimal)reader["Interest"];
                                                    q1.Interest = "$" + interest.ToString("0.00").Trim();
                                                }
                                                if (reader["Payments"] != DBNull.Value)
                                                {
                                                    decimal payments = (decimal)reader["Payments"];
                                                    q1.Payments = "$" + payments.ToString("0.00").Trim();
                                                }
                                                if (reader["Outstanding_Balance"] != DBNull.Value)
                                                {
                                                    decimal outstanding_Balance = (decimal)reader["Outstanding_Balance"];
                                                    q1.Outstanding_Balance = "$" + outstanding_Balance.ToString("0.00").Trim();
                                                }
                                                if (reader["Principal"] != DBNull.Value)
                                                {
                                                    decimal principal = (decimal)reader["Principal"];
                                                    q1.Principal = "$" + principal.ToString("0.00").Trim();
                                                }
                                                if (reader["Setc_Amunt"] != DBNull.Value)
                                                {
                                                    decimal setc_Amunt = (decimal)reader["Setc_Amunt"];
                                                    q1.Setc_Amunt = "$" + setc_Amunt.ToString("0.00").Trim();
                                                }
                                                if (reader["Savings"] != DBNull.Value)
                                                {
                                                    decimal savings = (decimal)reader["Savings"];
                                                    q1.Savings = "$" + savings.ToString("0.00").Trim();
                                                }
                                                if (reader["Perc"] != DBNull.Value)
                                                {
                                                    q1.Perc = reader["Perc"].ToString().Trim() + "%";
                                                }
                                               
                                                if (reader["Our_File"] != DBNull.Value)
                                                {
                                                    q1.Our_File = ((int)reader["Our_File"]);
                                                }
                                                q1.Reg_Link = GetPortalToken(q1.Our_File.ToString(), q1.Email);

                                                if (reader["group_count"] != DBNull.Value)
                                                {
                                                    q1.group_count = ((Int16)reader["group_count"]);
                                                }
                                                if (reader["Charged"] != DBNull.Value)
                                                {
                                                    q1.Charged = ((string)reader["Charged"]).Trim();
                                                }
                                                if (reader["delinquency_date"] != DBNull.Value)
                                                {
                                                    q1.delinquency_date = reader["delinquency_date"].ToString();
                                                }
                                                if (reader["Settlement"] != DBNull.Value)
                                                {
                                                    q1.Settlement = ((string)reader["Settlement"]).Trim();
                                                }
                                                if (reader["address"] != DBNull.Value)
                                                {
                                                    string address = ((string)reader["address"]).Trim();
                                                    q1.address = address;

                                                }
                                                if (reader["Summary"] != DBNull.Value)
                                                {
                                                    string Summary = ((string)reader["Summary"]).Trim();
                                                    q1.Summary = Summary;

                                                }
                                                if (reader["city"] != DBNull.Value)
                                                {
                                                    string city = ((string)reader["city"]).Trim();
                                                    q1.city = city;
                                                }
                                                if (reader["state"] != DBNull.Value)
                                                {
                                                    q1.state = ((string)reader["state"]).Trim();
                                                }
                                                if (reader["OOS"] != DBNull.Value)
                                                {
                                                    q1.OOS = (int)reader["OOS"];
                                                }
                                                if (reader["zip"] != DBNull.Value)
                                                {
                                                    q1.zip = ((string)reader["zip"]).Trim();
                                                }
                                                if (reader["Itemization_Date"] != DBNull.Value)
                                                {
                                                    q1.Itemization_Date = ((string)reader["Itemization_Date"]).Trim();
                                                }
                                                if (reader["listed_date"] != DBNull.Value)
                                                {
                                                    q1.listed_date = ((string)reader["listed_date"]).Trim();
                                                }
                                                if (reader["Client"] != DBNull.Value)
                                                {
                                                    q1.Client = ((string)reader["Client"]).Trim();
                                                }
                                                if (reader["Client_num"] != DBNull.Value)
                                                {
                                                    q1.Client_num = (int)reader["Client_num"];
                                                }
                                                if (reader["mode"] != DBNull.Value)
                                                {
                                                    q1.mode = ((string)reader["mode"]).Trim();
                                                }
                                                if (reader["debtor_status"] != DBNull.Value)
                                                {
                                                    q1.debtor_status = ((string)reader["debtor_status"]).Trim();
                                                }
                                                if (reader["Operator"] != DBNull.Value)
                                                {
                                                    q1.Operator = ((string)reader["Operator"]).Trim();
                                                }
                                                if (reader["co_description"] != DBNull.Value)
                                                {
                                                    q1.co_description = ((string)reader["co_description"]).Trim();
                                                }

                                                if (reader["debtor_type"] != DBNull.Value)
                                                {
                                                    string debtor_type = ((string)reader["debtor_type"]).Trim();
                                                    q1.debtor_type = debtor_type;

                                                }
                                                if (reader["contact"] != DBNull.Value)
                                                {
                                                    q1.contact = ((string)reader["contact"]).Trim();
                                                }
                                                if (reader["validation_date"] != DBNull.Value)
                                                {
                                                    q1.validation_date = ((string)reader["validation_date"]).Trim();
                                                }
                                                if (reader["debtor_Name"] != DBNull.Value)
                                                {
                                                    q1.debtor_Name = ((string)reader["debtor_Name"]).Trim();
                                                }
                                                if (reader["debtor_closed"] != DBNull.Value)
                                                {
                                                    q1.debtor_closed = ((string)reader["debtor_closed"]).Trim();
                                                }
                                                if (reader["debtor_legal"] != DBNull.Value)
                                                {
                                                    q1.debtor_legal = (decimal)reader["debtor_legal"];
                                                }
                                                if (reader["home_extension"] != DBNull.Value)
                                                {
                                                    q1.home_extension = ((string)reader["home_extension"]).Trim();
                                                }
                                                if (reader["work_extension"] != DBNull.Value)
                                                {
                                                    q1.work_extension = ((string)reader["work_extension"]).Trim();
                                                }
                                                if (reader["cell_extension"] != DBNull.Value)
                                                {
                                                    q1.cell_extension = ((string)reader["cell_extension"]).Trim();
                                                }
                                                if (reader["other_extension"] != DBNull.Value)
                                                {
                                                    q1.other_extension = ((string)reader["other_extension"]).Trim();
                                                }
                                                if (reader["group_filenumber"] != DBNull.Value)
                                                {
                                                    q1.group_filenumber = (int)reader["group_filenumber"];
                                                }
                                                if (reader["debtor_country"] != DBNull.Value)
                                                {
                                                    q1.debtor_country = ((string)reader["debtor_country"]).Trim();
                                                }
                                                if (reader["RowNum"] != DBNull.Value)
                                                {
                                                    q1.RowNum = ((Int64)reader["RowNum"]);
                                                }
                                                if (reader["Score"] != DBNull.Value)
                                                {
                                                    q1.Score = (int)reader["Score"];
                                                }
                                                if (reader["InterestRecal"] != DBNull.Value)
                                                {
                                                    q1.InterestRecal = ((string)reader["InterestRecal"]).Trim();
                                                }

                                                Listq1.Add(q1);
                                            }
                                        }

                                        else
                                        {
                                            if ((reader["email"].ToString().Contains("@") && !reader["DeContact"].ToString().Contains("!@#$%^&/*()?") && !reader["contact"].ToString().Contains(")") && !reader["DeContact"].ToString().Contains("/")
                                              && reader["Account_Num"] != DBNull.Value
                                              && ((reader["debtor_type"].ToString().Contains("COM") || reader["DeContact"].ToString().Contains(",") || reader["DeContact"].ToString().Contains(" "))
                                              && (!reader["debtor_country"].ToString().ToUpper().Contains("UNITED STATES") || (!reader["debtor_type"].ToString().Contains("EDU") || reader["Client_num"].ToString().Contains("2206") || reader["Client_num"].ToString().Contains("22062") || reader["Client_num"].ToString().Contains("22060") || reader["Client_num"].ToString().Contains("22063") || reader["Client_num"].ToString().Contains("22064"))
                                              && (!reader["debtor_country"].ToString().ToUpper().Contains("UNITED STATES") || (!reader["debtor_type"].ToString().Contains("MED")

                                              ))))))
                                            {
                                                if (reader["email"] != DBNull.Value)
                                                {
                                                    string email = ((string)reader["email"]).Trim();
                                                    q1.Email = email;
                                                    q1.ResponsibleParty_Email = "0";
                                                }
                                                if (reader["debtor_type"].ToString().Contains("COM"))
                                                {
                                                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                                    q1.First_Name = textInfo.ToTitleCase(((string)reader["debtor_Name"]).ToLower().Trim());
                                                    q1.Last_Name = ((string)reader["contact"]).Trim();
                                                }
                                                if (reader["LastEmailSentDate"] != DBNull.Value)
                                                {
                                                    q1.LastEmailSentDate = ((Int32)reader["LastEmailSentDate"]);
                                                }
                                                if (reader["debtor_type"] != DBNull.Value)
                                                {
                                                    string type = (string)reader["debtor_type"];

                                                    if (type == "COM" || type == "2")
                                                    {
                                                        string debtorName = (string)reader["debtor_Name"];
                                                        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                                        string properCaseDebtorName = textInfo.ToTitleCase(debtorName.ToLower());

                                                        q1.First_Name = (string)reader["contact"];
                                                        q1.Last_Name = properCaseDebtorName;

                                                    }
                                                    else
                                                    {
                                                        if (reader["DeContact"] != DBNull.Value)
                                                        {
                                                            q1.de_contact = reader["DeContact"].ToString();
                                                            string[] name = q1.de_contact.Split(' ');

                                                            if (name.Length > 0)
                                                            {
                                                                q1.First_Name = name[0].Trim();

                                                                if (name.Length > 1)
                                                                {
                                                                    q1.Last_Name = string.Join(" ", name.Skip(1)).Trim();
                                                                }
                                                            }
                                                        }

                                                    }

                                                }

                                                if (reader["debtor_Name"] != DBNull.Value)
                                                {
                                                    q1.debtor_Name = ((string)reader["debtor_Name"]).Trim();
                                                }
                                                if (reader["Original_Creditor"] != DBNull.Value)
                                                {
                                                    string originalCreditor = ((string)reader["Original_Creditor"]).Trim();
                                                    CultureInfo cultureInfo = CultureInfo.InvariantCulture; // You can specify a specific culture if needed
                                                    TextInfo textInfo = cultureInfo.TextInfo;
                                                    string formattedCreditor = textInfo.ToTitleCase(originalCreditor.ToLower());
                                                    q1.Original_Creditor = formattedCreditor.Replace("Llc", "LLC");
                                                }
                                                if (reader["Account_Num"] != DBNull.Value)
                                                {
                                                    q1.Account_Num = ((string)reader["Account_Num"]).Trim();
                                                }
                                                if (reader["Summary"] != DBNull.Value)
                                                {
                                                    string Summary = ((string)reader["Summary"]).Trim();
                                                    q1.Summary = Summary;

                                                }
                                                if (reader["Fees"] != DBNull.Value)
                                                {
                                                    decimal fees = (decimal)reader["Fees"];
                                                    q1.Fees = "$" + fees.ToString("0.00").Trim();
                                                }
                                                if (reader["Interest"] != DBNull.Value)
                                                {
                                                    decimal interest = (decimal)reader["Interest"];
                                                    q1.Interest = "$" + interest.ToString("0.00").Trim();
                                                }
                                                if (reader["Payments"] != DBNull.Value)
                                                {
                                                    decimal payments = (decimal)reader["Payments"];
                                                    q1.Payments = "$" + payments.ToString("0.00").Trim();
                                                }
                                                if (reader["Outstanding_Balance"] != DBNull.Value)
                                                {
                                                    decimal outstanding_Balance = (decimal)reader["Outstanding_Balance"];
                                                    q1.Outstanding_Balance = "$" + outstanding_Balance.ToString("0.00").Trim();
                                                }
                                                if (reader["Principal"] != DBNull.Value)
                                                {
                                                    decimal principal = (decimal)reader["Principal"];
                                                    q1.Principal = "$" + principal.ToString("0.00").Trim();
                                                }
                                                if (reader["Setc_Amunt"] != DBNull.Value)
                                                {
                                                    decimal setc_Amunt = (decimal)reader["Setc_Amunt"];
                                                    q1.Setc_Amunt = "$" + setc_Amunt.ToString("0.00").Trim();
                                                }
                                                if (reader["Savings"] != DBNull.Value)
                                                {
                                                    decimal savings = (decimal)reader["Savings"];
                                                    q1.Savings = "$" + savings.ToString("0.00").Trim();
                                                }
                                                if (reader["Perc"] != DBNull.Value)
                                                {
                                                    q1.Perc = reader["Perc"].ToString().Trim() + "%";
                                                }
                                                if (reader["Our_File"] != DBNull.Value)
                                                {
                                                    q1.Our_File = ((int)reader["Our_File"]);
                                                }

                                                q1.Reg_Link = GetPortalToken(q1.Our_File.ToString(), q1.Email);

                                                if (reader["group_count"] != DBNull.Value)
                                                {
                                                    q1.group_count = ((Int16)reader["group_count"]);
                                                }
                                                if (reader["Charged"] != DBNull.Value)
                                                {
                                                    q1.Charged = ((string)reader["Charged"]).Trim();
                                                }
                                                if (reader["delinquency_date"] != DBNull.Value)
                                                {
                                                    q1.delinquency_date = reader["delinquency_date"].ToString();
                                                }
                                                if (reader["Settlement"] != DBNull.Value)
                                                {
                                                    q1.Settlement = ((string)reader["Settlement"]).Trim();
                                                }
                                                if (reader["address"] != DBNull.Value)
                                                {
                                                    string address = ((string)reader["address"]).Trim();
                                                    q1.address = address;

                                                }
                                                if (reader["city"] != DBNull.Value)
                                                {
                                                    string city = ((string)reader["city"]).Trim();
                                                    q1.city = city;
                                                }
                                                if (reader["state"] != DBNull.Value)
                                                {
                                                    q1.state = ((string)reader["state"]).Trim();
                                                }
                                                if (reader["OOS"] != DBNull.Value)
                                                {
                                                    q1.OOS = (int)reader["OOS"];
                                                }
                                                if (reader["zip"] != DBNull.Value)
                                                {
                                                    q1.zip = ((string)reader["zip"]).Trim();
                                                }
                                                if (reader["Itemization_Date"] != DBNull.Value)
                                                {
                                                    q1.Itemization_Date = ((string)reader["Itemization_Date"]).Trim();
                                                }
                                                if (reader["listed_date"] != DBNull.Value)
                                                {
                                                    q1.listed_date = ((string)reader["listed_date"]).Trim();
                                                }
                                                if (reader["Client"] != DBNull.Value)
                                                {
                                                    q1.Client = ((string)reader["Client"]).Trim();
                                                }
                                                if (reader["Client_num"] != DBNull.Value)
                                                {
                                                    q1.Client_num = (int)reader["Client_num"];
                                                }
                                                if (reader["mode"] != DBNull.Value)
                                                {
                                                    q1.mode = ((string)reader["mode"]).Trim();
                                                }
                                                if (reader["debtor_status"] != DBNull.Value)
                                                {
                                                    q1.debtor_status = ((string)reader["debtor_status"]).Trim();
                                                }
                                                if (reader["co_description"] != DBNull.Value)
                                                {
                                                    q1.co_description = ((string)reader["co_description"]).Trim();
                                                }
                                                if (reader["Operator"] != DBNull.Value)
                                                {
                                                    q1.Operator = ((string)reader["Operator"]).Trim();
                                                }

                                                if (reader["debtor_type"] != DBNull.Value)
                                                {
                                                    string debtor_type = ((string)reader["debtor_type"]).Trim();
                                                    q1.debtor_type = debtor_type;

                                                }
                                                if (reader["contact"] != DBNull.Value)
                                                {
                                                    q1.contact = ((string)reader["contact"]).Trim();
                                                }
                                                if (reader["validation_date"] != DBNull.Value)
                                                {
                                                    q1.validation_date = ((string)reader["validation_date"]).Trim();
                                                }
                                                if (reader["debtor_Name"] != DBNull.Value)
                                                {
                                                    q1.debtor_Name = ((string)reader["debtor_Name"]).Trim();
                                                }
                                                if (reader["debtor_closed"] != DBNull.Value)
                                                {
                                                    q1.debtor_closed = ((string)reader["debtor_closed"]).Trim();
                                                }
                                                if (reader["debtor_legal"] != DBNull.Value)
                                                {
                                                    q1.debtor_legal = (decimal)reader["debtor_legal"];
                                                }
                                                if (reader["home_extension"] != DBNull.Value)
                                                {
                                                    q1.home_extension = ((string)reader["home_extension"]).Trim();
                                                }
                                                if (reader["work_extension"] != DBNull.Value)
                                                {
                                                    q1.work_extension = ((string)reader["work_extension"]).Trim();
                                                }
                                                if (reader["cell_extension"] != DBNull.Value)
                                                {
                                                    q1.cell_extension = ((string)reader["cell_extension"]).Trim();
                                                }
                                                if (reader["other_extension"] != DBNull.Value)
                                                {
                                                    q1.other_extension = ((string)reader["other_extension"]).Trim();
                                                }
                                                if (reader["group_filenumber"] != DBNull.Value)
                                                {
                                                    q1.group_filenumber = (int)reader["group_filenumber"];
                                                }
                                                if (reader["debtor_country"] != DBNull.Value)
                                                {
                                                    q1.debtor_country = ((string)reader["debtor_country"]).Trim();
                                                }

                                                if (reader["RowNum"] != DBNull.Value)
                                                {
                                                    q1.RowNum = ((Int64)reader["RowNum"]);
                                                }
                                                if (reader["Score"] != DBNull.Value)
                                                {
                                                    q1.Score = (int)reader["Score"];
                                                }
                                                if (reader["InterestRecal"] != DBNull.Value)
                                                {
                                                    q1.InterestRecal = ((string)reader["InterestRecal"]).Trim();
                                                }
                                                q1.Reg_Link = GetPortalToken(q1.Our_File.ToString(), q1.Email, q1.co_description);

                                                Listq1.Add(q1);


                                            }

                                        }
                                        ///Responsible Party part 
                                        EmailReport2 q2 = new EmailReport2();
                                        if (reader["Responsible_party"] != DBNull.Value && reader["Responsible_party"] != "")
                                        {
                                            if (reader["Responsible_party"] != DBNull.Value)
                                            {
                                                string email = ((string)reader["Responsible_party"]).Trim();
                                                q2.Email = email;
                                                q2.ResponsibleParty_Email = "1";
                                            }
                                            if (reader["debtor_type"].ToString().Contains("COM"))
                                            {
                                                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                                q2.First_Name = textInfo.ToTitleCase(((string)reader["debtor_Name"]).ToLower().Trim());
                                                q2.Last_Name = ((string)reader["contact"]).Trim();
                                            }
                                            if (reader["LastEmailSentDate"] != DBNull.Value)
                                            {
                                                q2.LastEmailSentDate = ((Int32)reader["LastEmailSentDate"]);
                                            }
                                            if (reader["debtor_type"] != DBNull.Value)
                                            {
                                                string type = (string)reader["debtor_type"];

                                                if (type == "COM" || type == "2")
                                                {
                                                    string debtorName = (string)reader["debtor_Name"];
                                                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                                    string properCaseDebtorName = textInfo.ToTitleCase(debtorName.ToLower());

                                                    q2.First_Name = (string)reader["contact"];
                                                    q2.Last_Name = properCaseDebtorName;

                                                }
                                                else
                                                {
                                                    if (reader["Responsible_party_Name"] != DBNull.Value)
                                                    {
                                                        q2.de_contact = reader["Responsible_party_Name"].ToString();
                                                        string[] name = q2.de_contact.Split(' ');

                                                        if (name.Length > 0)
                                                        {
                                                            q2.First_Name = name[0].Trim();

                                                            if (name.Length > 1)
                                                            {
                                                                q2.Last_Name = string.Join(" ", name.Skip(1)).Trim();
                                                            }
                                                        }
                                                    }

                                                }

                                            }

                                            if (reader["debtor_Name"] != DBNull.Value)
                                            {
                                                q2.debtor_Name = ((string)reader["debtor_Name"]).Trim();
                                            }
                                            if (reader["Original_Creditor"] != DBNull.Value)
                                            {
                                                string originalCreditor = ((string)reader["Original_Creditor"]).Trim();
                                                CultureInfo cultureInfo = CultureInfo.InvariantCulture; // You can specify a specific culture if needed
                                                TextInfo textInfo = cultureInfo.TextInfo;
                                                string formattedCreditor = textInfo.ToTitleCase(originalCreditor.ToLower());
                                                q2.Original_Creditor = formattedCreditor.Replace("Llc", "LLC");
                                            }
                                            if (reader["Account_Num"] != DBNull.Value)
                                            {
                                                q2.Account_Num = ((string)reader["Account_Num"]).Trim();
                                            }
                                            if (reader["Fees"] != DBNull.Value)
                                            {
                                                decimal fees = (decimal)reader["Fees"];
                                                q2.Fees = "$" + fees.ToString("0.00").Trim();
                                            }
                                            if (reader["Summary"] != DBNull.Value)
                                            {
                                                string Summary = ((string)reader["Summary"]).Trim();
                                                q1.Summary = Summary;

                                            }
                                            if (reader["Interest"] != DBNull.Value)
                                            {
                                                decimal interest = (decimal)reader["Interest"];
                                                q2.Interest = "$" + interest.ToString("0.00").Trim();
                                            }
                                            if (reader["Payments"] != DBNull.Value)
                                            {
                                                decimal payments = (decimal)reader["Payments"];
                                                q2.Payments = "$" + payments.ToString("0.00").Trim();
                                            }
                                            if (reader["Outstanding_Balance"] != DBNull.Value)
                                            {
                                                decimal outstanding_Balance = (decimal)reader["Outstanding_Balance"];
                                                q2.Outstanding_Balance = "$" + outstanding_Balance.ToString("0.00").Trim();
                                            }
                                            if (reader["Principal"] != DBNull.Value)
                                            {
                                                decimal principal = (decimal)reader["Principal"];
                                                q2.Principal = "$" + principal.ToString("0.00").Trim();
                                            }
                                            if (reader["Setc_Amunt"] != DBNull.Value)
                                            {
                                                decimal setc_Amunt = (decimal)reader["Setc_Amunt"];
                                                q2.Setc_Amunt = "$" + setc_Amunt.ToString("0.00").Trim();
                                            }
                                            if (reader["Savings"] != DBNull.Value)
                                            {
                                                decimal savings = (decimal)reader["Savings"];
                                                q2.Savings = "$" + savings.ToString("0.00").Trim();
                                            }
                                            if (reader["Perc"] != DBNull.Value)
                                            {
                                                q2.Perc = reader["Perc"].ToString().Trim() + "%";
                                            }
                                            if (reader["Our_File"] != DBNull.Value)
                                            {
                                                q2.Our_File = ((int)reader["Our_File"]);
                                            }

                                            q2.Reg_Link = GetPortalToken(q2.Our_File.ToString(), q2.Email, q2.co_description);

                                            if (reader["group_count"] != DBNull.Value)
                                            {
                                                q2.group_count = ((Int16)reader["group_count"]);
                                            }
                                            if (reader["Charged"] != DBNull.Value)
                                            {
                                                q2.Charged = ((string)reader["Charged"]).Trim();
                                            }
                                            if (reader["delinquency_date"] != DBNull.Value)
                                            {
                                                q2.delinquency_date = reader["delinquency_date"].ToString();
                                            }
                                            if (reader["Settlement"] != DBNull.Value)
                                            {
                                                q2.Settlement = ((string)reader["Settlement"]).Trim();
                                            }
                                            if (reader["address"] != DBNull.Value)
                                            {
                                                string address = ((string)reader["address"]).Trim();
                                                q2.address = address;

                                            }
                                            if (reader["city"] != DBNull.Value)
                                            {
                                                string city = ((string)reader["city"]).Trim();
                                                q2.city = city;
                                            }
                                            if (reader["state"] != DBNull.Value)
                                            {
                                                q2.state = ((string)reader["state"]).Trim();
                                            }
                                            if (reader["OOS"] != DBNull.Value)
                                            {
                                                q2.OOS = (int)reader["OOS"];
                                            }
                                            if (reader["zip"] != DBNull.Value)
                                            {
                                                q2.zip = ((string)reader["zip"]).Trim();
                                            }
                                            if (reader["Itemization_Date"] != DBNull.Value)
                                            {
                                                q2.Itemization_Date = ((string)reader["Itemization_Date"]).Trim();
                                            }
                                            if (reader["listed_date"] != DBNull.Value)
                                            {
                                                q2.listed_date = ((string)reader["listed_date"]).Trim();
                                            }
                                            if (reader["Client"] != DBNull.Value)
                                            {
                                                q2.Client = ((string)reader["Client"]).Trim();
                                            }
                                            if (reader["Client_num"] != DBNull.Value)
                                            {
                                                q2.Client_num = (int)reader["Client_num"];
                                            }
                                            if (reader["mode"] != DBNull.Value)
                                            {
                                                q2.mode = ((string)reader["mode"]).Trim();
                                            }
                                            if (reader["debtor_status"] != DBNull.Value)
                                            {
                                                q2.debtor_status = ((string)reader["debtor_status"]).Trim();
                                            }
                                            if (reader["co_description"] != DBNull.Value)
                                            {
                                                q2.co_description = ((string)reader["co_description"]).Trim();
                                            }
                                            if (reader["Operator"] != DBNull.Value)
                                            {
                                                q2.Operator = ((string)reader["Operator"]).Trim();
                                            }

                                            if (reader["debtor_type"] != DBNull.Value)
                                            {
                                                string debtor_type = ((string)reader["debtor_type"]).Trim();
                                                q2.debtor_type = debtor_type;

                                            }
                                            if (reader["contact"] != DBNull.Value)
                                            {
                                                q2.contact = ((string)reader["contact"]).Trim();
                                            }
                                            if (reader["validation_date"] != DBNull.Value)
                                            {
                                                q2.validation_date = ((string)reader["validation_date"]).Trim();
                                            }
                                            if (reader["debtor_Name"] != DBNull.Value)
                                            {
                                                q2.debtor_Name = ((string)reader["debtor_Name"]).Trim();
                                            }
                                            if (reader["debtor_closed"] != DBNull.Value)
                                            {
                                                q2.debtor_closed = ((string)reader["debtor_closed"]).Trim();
                                            }
                                            if (reader["debtor_legal"] != DBNull.Value)
                                            {
                                                q2.debtor_legal = (decimal)reader["debtor_legal"];
                                            }
                                            if (reader["home_extension"] != DBNull.Value)
                                            {
                                                q2.home_extension = ((string)reader["home_extension"]).Trim();
                                            }
                                            if (reader["work_extension"] != DBNull.Value)
                                            {
                                                q2.work_extension = ((string)reader["work_extension"]).Trim();
                                            }
                                            if (reader["cell_extension"] != DBNull.Value)
                                            {
                                                q2.cell_extension = ((string)reader["cell_extension"]).Trim();
                                            }
                                            if (reader["other_extension"] != DBNull.Value)
                                            {
                                                q2.other_extension = ((string)reader["other_extension"]).Trim();
                                            }
                                            if (reader["group_filenumber"] != DBNull.Value)
                                            {
                                                q2.group_filenumber = (int)reader["group_filenumber"];
                                            }
                                            if (reader["debtor_country"] != DBNull.Value)
                                            {
                                                q2.debtor_country = ((string)reader["debtor_country"]).Trim();
                                            }

                                            if (reader["RowNum"] != DBNull.Value)
                                            {
                                                q2.RowNum = ((Int64)reader["RowNum"]);
                                            }
                                            if (reader["Score"] != DBNull.Value)
                                            {
                                                q2.Score = (int)reader["Score"];
                                            }
                                            if (reader["InterestRecal"] != DBNull.Value)
                                            {
                                                q2.InterestRecal = ((string)reader["InterestRecal"]).Trim();
                                            }

                                            Listq2.Add(q2);

                                        }
                                    }



                                }
                            }

                            catch (Exception ex)
                            {
                                // Handle the exception here (e.g., logging, displaying an error message)
                                Console.WriteLine("An error occurred: " + ex.Message);
                            }


                        }
                    }
                }
            }
            var combinedList = new List<dynamic>();
            combinedList.AddRange(Listq1.Cast<dynamic>());
            combinedList.AddRange(Listq2.Cast<dynamic>());
            var paginatedList = combinedList.Skip((int)skip).Take((int)col.PageSize).ToList();
            //return Listq1.Skip((int)skip)
            //       .Take((int)col.PageSize)
            //       .ToList();
            return paginatedList;
        }

        public Task<List<dynamic>> WIPEmailCampaign(WipEmail col, string constrr)
        {
            List<EmailReport> Listq1 = new List<EmailReport>();
            List<EmailReport2> Listq2 = new List<EmailReport2>();

            using (SqlConnection con = new SqlConnection(constrr))
            {
                using (SqlCommand cmd = new SqlCommand("SP_WIP_Emial_Campaign", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 10000000;

                    cmd.Parameters.AddWithValue("@coun", col.coun);
                    cmd.Parameters.AddWithValue("@per", col.per);
                    cmd.Parameters.AddWithValue("@per1", col.per1);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                EmailReport q1 = new EmailReport();
                                if ((!reader["DeContact"].ToString().Contains("!@#$%^&/*()?") && !reader["contact"].ToString().Contains(")") && !reader["DeContact"].ToString().Contains("/") && (reader["DeContact"].ToString().Contains(",") || reader["DeContact"].ToString().Contains(" "))))
                                {
                                    if (reader["email"] != DBNull.Value)
                                    {
                                        string email = ((string)reader["email"]).Trim().Replace("\r", "").Replace("\n", " ");
                                        q1.Email = email;
                                    }
                                  
                                    if (reader["CosEmail"] != DBNull.Value)
                                    {
                                        string CosEmail = ((string)reader["CosEmail"]).Trim().Replace("\r", "").Replace("\n", " ");
                                        q1.CosEmail = CosEmail;
                                        q1.ResponsibleParty_Email = "0";
                                    }
                                    if (reader["debtor_type"] != DBNull.Value)
                                    {
                                        string type = (string)reader["debtor_type"];

                                        if (type == "COM" || type == "2")
                                        {
                                            string debtorName = (string)reader["debtor_Name"];
                                            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                            string properCaseDebtorName = textInfo.ToTitleCase(debtorName.ToLower());

                                            q1.First_Name = (string)reader["contact"];
                                            q1.Last_Name = properCaseDebtorName;

                                        }
                                        else
                                        {
                                            if (reader["DeContact"] != DBNull.Value)
                                            {
                                                q1.de_contact = reader["DeContact"].ToString();
                                                string[] name = q1.de_contact.Split(' ');

                                                if (name.Length > 0)
                                                {
                                                    q1.First_Name = name[0].Trim();

                                                    if (name.Length > 1)
                                                    {
                                                        q1.Last_Name = string.Join(" ", name.Skip(1)).Trim();
                                                    }
                                                }
                                            }

                                        }

                                    }
                                    if (reader["Original_Creditor"] != DBNull.Value)
                                    {
                                        string originalCreditor = ((string)reader["Original_Creditor"]).Trim();
                                        CultureInfo cultureInfo = CultureInfo.InvariantCulture; // You can specify a specific culture if needed
                                        TextInfo textInfo = cultureInfo.TextInfo;
                                        string formattedCreditor = textInfo.ToTitleCase(originalCreditor.ToLower());
                                        q1.Original_Creditor = formattedCreditor.Replace("Llc", "LLC");
                                    }
                                    if (reader["Account_Num"] != DBNull.Value)
                                    {
                                        q1.Account_Num = ((string)reader["Account_Num"]).Trim();
                                    }
                                    if (reader["delinquency_date"] != DBNull.Value)
                                    {
                                        q1.delinquency_date = reader["delinquency_date"].ToString();
                                    }
                                    if (reader["Fees"] != DBNull.Value)
                                    {
                                        decimal fees = (decimal)reader["Fees"];
                                        q1.Fees = "$" + fees.ToString("0.0000").Trim();
                                    }
                                    if (reader["Interest"] != DBNull.Value)
                                    {
                                        decimal interest = (decimal)reader["Interest"];
                                        q1.Interest = "$" + interest.ToString("0.0000").Trim();
                                    }
                                    if (reader["Payments"] != DBNull.Value)
                                    {
                                        decimal payments = (decimal)reader["Payments"];
                                        q1.Payments = "$" + payments.ToString("0.0000").Trim();
                                    }
                                    if (reader["Outstanding_Balance"] != DBNull.Value)
                                    {
                                        decimal outstanding_Balance = (decimal)reader["Outstanding_Balance"];
                                        q1.Outstanding_Balance = "$" + outstanding_Balance.ToString("0.0000").Trim();
                                    }
                                    if (reader["Principal"] != DBNull.Value)
                                    {
                                        decimal principal = (decimal)reader["Principal"];
                                        q1.Principal = "$" + principal.ToString("0.0000").Trim();
                                    }
                                    if (reader["Setc_Amunt"] != DBNull.Value)
                                    {
                                        decimal setc_Amunt = (decimal)reader["Setc_Amunt"];
                                        q1.Setc_Amunt = "$" + setc_Amunt.ToString("0.0000").Trim();
                                    }
                                    if (reader["Savings"] != DBNull.Value)
                                    {
                                        decimal savings = (decimal)reader["Savings"];
                                        q1.Savings = "$" + savings.ToString("0.0000").Trim();
                                    }
                                    if (reader["Perc"] != DBNull.Value)
                                    {
                                        q1.Perc = reader["Perc"].ToString().Trim() + "%";
                                    }
                                    if (reader["Our_File"] != DBNull.Value)
                                    {
                                        q1.Our_File = ((int)reader["Our_File"]);

                                    }
                                    if (reader["co_description"] != DBNull.Value)
                                    {
                                        q1.co_description = ((string)reader["co_description"]).Trim();
                                    }
                                    if (reader["email"] != DBNull.Value)
                                    {
                                        q1.Reg_Link = GetPortalToken(q1.Our_File.ToString(), q1.Email, col.coun, q1.co_description);
                                    }
                                    else if (reader["CosEmail"] != DBNull.Value)
                                    {
                                        q1.Reg_Link = GetPortalToken(q1.Our_File.ToString(), q1.CosEmail, col.coun, q1.co_description);

                                    }
                                    if (reader["group_count"] != DBNull.Value)
                                    {
                                        q1.group_count = ((Int16)reader["group_count"]);
                                    }
                                    if (reader["Charged"] != DBNull.Value)
                                    {
                                        q1.Charged = ((string)reader["Charged"]).Trim();
                                    }
                                    if (reader["Settlement"] != DBNull.Value)
                                    {
                                        q1.Settlement = ((string)reader["Settlement"]).Trim();
                                    }
                                    if (reader["address"] != DBNull.Value)
                                    {
                                        string address = ((string)reader["address"]).Trim();
                                        q1.address = address;

                                    }
                                    if (reader["city"] != DBNull.Value)
                                    {
                                        string city = ((string)reader["city"]).Trim();
                                        q1.city = city;
                                    }
                                    if (reader["state"] != DBNull.Value)
                                    {
                                        q1.state = ((string)reader["state"]).Trim();
                                    }
                                    if (reader["zip"] != DBNull.Value)
                                    {
                                        q1.zip = ((string)reader["zip"]).Trim();
                                    }
                                    if (reader["Itemization_Date"] != DBNull.Value)
                                    {
                                        q1.Itemization_Date = ((string)reader["Itemization_Date"]).Trim();
                                    }
                                    if (reader["listed_date"] != DBNull.Value)
                                    {
                                        q1.listed_date = ((string)reader["listed_date"]).Trim();
                                    }
                                    if (reader["Client"] != DBNull.Value)
                                    {
                                        q1.Client = ((string)reader["Client"]).Trim();
                                    }
                                    if (reader["Client_num"] != DBNull.Value)
                                    {
                                        q1.Client_num = (int)reader["Client_num"];
                                    }
                                    if (reader["mode"] != DBNull.Value)
                                    {
                                        q1.mode = ((string)reader["mode"]).Trim();
                                    }
                                    if (reader["debtor_status"] != DBNull.Value)
                                    {
                                        q1.debtor_status = ((string)reader["debtor_status"]).Trim();
                                    }
                                    if (reader["Operator"] != DBNull.Value)
                                    {
                                        q1.Operator = ((string)reader["Operator"]).Trim();
                                    }
                                    if (reader["debtor_type"] != DBNull.Value)
                                    {
                                        string debtor_type = ((string)reader["debtor_type"]).Trim();
                                        q1.debtor_type = debtor_type;

                                    }
                                    if (reader["contact"] != DBNull.Value)
                                    {
                                        q1.contact = ((string)reader["contact"]).Trim();
                                    }
                                    if (reader["validation_date"] != DBNull.Value)
                                    {
                                        q1.validation_date = ((string)reader["validation_date"]).Trim();
                                    }
                                    if (reader["debtor_Name"] != DBNull.Value)
                                    {
                                        q1.debtor_Name = ((string)reader["debtor_Name"]).Trim();
                                    }
                                    if (reader["debtor_closed"] != DBNull.Value)
                                    {
                                        q1.debtor_closed = ((string)reader["debtor_closed"]).Trim();
                                    }
                                    if (reader["debtor_legal"] != DBNull.Value)
                                    {
                                        q1.debtor_legal = (decimal)reader["debtor_legal"];
                                    }
                                    if (reader["home_extension"] != DBNull.Value)
                                    {
                                        q1.home_extension = ((string)reader["home_extension"]).Trim();
                                    }
                                    if (reader["work_extension"] != DBNull.Value)
                                    {
                                        q1.work_extension = ((string)reader["work_extension"]).Trim();
                                    }
                                    if (reader["cell_extension"] != DBNull.Value)
                                    {
                                        q1.cell_extension = ((string)reader["cell_extension"]).Trim();
                                    }
                                    if (reader["other_extension"] != DBNull.Value)
                                    {
                                        q1.other_extension = ((string)reader["other_extension"]).Trim();
                                    }
                                    if (reader["group_filenumber"] != DBNull.Value)
                                    {
                                        q1.group_filenumber = (int)reader["group_filenumber"];
                                    }
                                    if (reader["debtor_country"] != DBNull.Value)
                                    {
                                        q1.debtor_country = ((string)reader["debtor_country"]).Trim();
                                    }
                                    
                                    if (reader["User1"] != DBNull.Value)
                                    {
                                        q1.User1 = ((string)reader["User1"]).Trim();
                                    }
                                    if (reader["User2"] != DBNull.Value)
                                    {
                                        q1.User2 = ((string)reader["User2"]).Trim();
                                    }
                                    if (reader["User3"] != DBNull.Value)
                                    {
                                        q1.User3 = ((string)reader["User3"]).Trim();
                                    }
                                    if (reader["Percentage"] != DBNull.Value)
                                    {
                                        decimal Percentage = (decimal)reader["Percentage"];
                                        q1.Percentage = Percentage.ToString("0.00").Trim();
                                    }
                                    if (reader["OOS"] != DBNull.Value)
                                    {
                                        q1.OOS = (int)reader["OOS"];
                                    }
                                    if (reader["Score"] != DBNull.Value)
                                    {
                                        q1.Score = (int)reader["Score"];
                                    }
                                    if (reader["InterestRecal"] != DBNull.Value)
                                    {
                                        q1.InterestRecal = ((string)reader["InterestRecal"]).Trim();
                                    }

                                    Listq1.Add(q1);
                                }
                                EmailReport2 q2 = new EmailReport2();
                                if (reader["Responsible_party"] != DBNull.Value && reader["Responsible_party"] != "")
                                {

                                    if (reader["Responsible_party"] != DBNull.Value)
                                    {
                                        string email = ((string)reader["Responsible_party"]).Trim();
                                        q2.Email = email;
                                        q2.ResponsibleParty_Email = "1";
                                    }
                                    if (reader["Responsible_party"] != DBNull.Value)
                                    {
                                        string email = ((string)reader["Responsible_party"]).Trim();
                                        q2.CosEmail = email;
                                    }
                                    if (reader["debtor_type"] != DBNull.Value)
                                    {
                                        string type = (string)reader["debtor_type"];

                                        if (type == "COM" || type == "2")
                                        {
                                            string debtorName = (string)reader["debtor_Name"];
                                            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                            string properCaseDebtorName = textInfo.ToTitleCase(debtorName.ToLower());

                                            q2.First_Name = (string)reader["contact"];
                                            q2.Last_Name = properCaseDebtorName;

                                        }
                                        else
                                        {
                                            if (reader["Responsible_party_Name"] != DBNull.Value)
                                            {
                                                q2.de_contact = reader["Responsible_party_Name"].ToString();
                                                string[] name = q2.de_contact.Split(' ');

                                                if (name.Length > 0)
                                                {
                                                    q2.First_Name = name[0].Trim();

                                                    if (name.Length > 1)
                                                    {
                                                        q2.Last_Name = string.Join(" ", name.Skip(1)).Trim();
                                                    }
                                                }
                                            }

                                        }

                                    }
                                    if (reader["Original_Creditor"] != DBNull.Value)
                                    {
                                        string originalCreditor = ((string)reader["Original_Creditor"]).Trim();
                                        CultureInfo cultureInfo = CultureInfo.InvariantCulture; // You can specify a specific culture if needed
                                        TextInfo textInfo = cultureInfo.TextInfo;
                                        q2.Original_Creditor = textInfo.ToTitleCase(originalCreditor);
                                    }
                                    if (reader["Account_Num"] != DBNull.Value)
                                    {
                                        q2.Account_Num = ((string)reader["Account_Num"]).Trim();
                                    }
                                    if (reader["delinquency_date"] != DBNull.Value)
                                    {
                                        q2.delinquency_date = reader["delinquency_date"].ToString();
                                    }
                                    if (reader["Fees"] != DBNull.Value)
                                    {
                                        decimal fees = (decimal)reader["Fees"];
                                        q2.Fees = "$" + fees.ToString("0.0000").Trim();
                                    }
                                    if (reader["Interest"] != DBNull.Value)
                                    {
                                        decimal interest = (decimal)reader["Interest"];
                                        q2.Interest = "$" + interest.ToString("0.0000").Trim();
                                    }
                                    if (reader["Payments"] != DBNull.Value)
                                    {
                                        decimal payments = (decimal)reader["Payments"];
                                        q2.Payments = "$" + payments.ToString("0.0000").Trim();
                                    }
                                    if (reader["Outstanding_Balance"] != DBNull.Value)
                                    {
                                        decimal outstanding_Balance = (decimal)reader["Outstanding_Balance"];
                                        q2.Outstanding_Balance = "$" + outstanding_Balance.ToString("0.0000").Trim();
                                    }
                                    if (reader["Principal"] != DBNull.Value)
                                    {
                                        decimal principal = (decimal)reader["Principal"];
                                        q2.Principal = "$" + principal.ToString("0.0000").Trim();
                                    }
                                    if (reader["Setc_Amunt"] != DBNull.Value)
                                    {
                                        decimal setc_Amunt = (decimal)reader["Setc_Amunt"];
                                        q2.Setc_Amunt = "$" + setc_Amunt.ToString("0.0000").Trim();
                                    }
                                    if (reader["Savings"] != DBNull.Value)
                                    {
                                        decimal savings = (decimal)reader["Savings"];
                                        q2.Savings = "$" + savings.ToString("0.0000").Trim();
                                    }
                                    if (reader["Perc"] != DBNull.Value)
                                    {
                                        q2.Perc = reader["Perc"].ToString().Trim() + "%";
                                    }
                                    if (reader["Our_File"] != DBNull.Value)
                                    {
                                        q2.Our_File = ((int)reader["Our_File"]);

                                    }
                                    if (reader["co_description"] != DBNull.Value)
                                    {
                                        q2.co_description = ((string)reader["co_description"]).Trim();
                                    }
                                    if (reader["email"] != DBNull.Value)
                                    {
                                        q2.Reg_Link = GetPortalToken(q2.Our_File.ToString(), q2.Email, q2.co_description);
                                    }
                                    else if (reader["CosEmail"] != DBNull.Value)
                                    {
                                        q2.Reg_Link = GetPortalToken(q2.Our_File.ToString(), q2.CosEmail, q2.co_description);

                                    }
                                    if (reader["group_count"] != DBNull.Value)
                                    {
                                        q2.group_count = ((Int16)reader["group_count"]);
                                    }
                                    if (reader["Charged"] != DBNull.Value)
                                    {
                                        q2.Charged = ((string)reader["Charged"]).Trim();
                                    }
                                    if (reader["Settlement"] != DBNull.Value)
                                    {
                                        q2.Settlement = ((string)reader["Settlement"]).Trim();
                                    }
                                    if (reader["Responsible_party_Address"] != DBNull.Value)
                                    {
                                        string address = ((string)reader["Responsible_party_Address"]).Trim();
                                        q2.address = address;

                                    }
                                    if (reader["Responsible_party_City"] != DBNull.Value)
                                    {
                                        string city = ((string)reader["Responsible_party_City"]).Trim();
                                        q2.city = city;
                                    }
                                    if (reader["Responsible_party_state"] != DBNull.Value)
                                    {
                                        q2.state = ((string)reader["Responsible_party_state"]).Trim();
                                    }
                                    if (reader["Responsible_party_zip"] != DBNull.Value)
                                    {
                                        q2.zip = ((string)reader["Responsible_party_zip"]).Trim();
                                    }
                                    if (reader["Itemization_Date"] != DBNull.Value)
                                    {
                                        q2.Itemization_Date = ((string)reader["Itemization_Date"]).Trim();
                                    }
                                    if (reader["listed_date"] != DBNull.Value)
                                    {
                                        q2.listed_date = ((string)reader["listed_date"]).Trim();
                                    }
                                    if (reader["Client"] != DBNull.Value)
                                    {
                                        q2.Client = ((string)reader["Client"]).Trim();
                                    }
                                    if (reader["Client_num"] != DBNull.Value)
                                    {
                                        q2.Client_num = (int)reader["Client_num"];
                                    }
                                    if (reader["mode"] != DBNull.Value)
                                    {
                                        q2.mode = ((string)reader["mode"]).Trim();
                                    }
                                    if (reader["debtor_status"] != DBNull.Value)
                                    {
                                        q2.debtor_status = ((string)reader["debtor_status"]).Trim();
                                    }
                                    if (reader["Operator"] != DBNull.Value)
                                    {
                                        q2.Operator = ((string)reader["Operator"]).Trim();
                                    }
                                    if (reader["debtor_type"] != DBNull.Value)
                                    {
                                        string debtor_type = ((string)reader["debtor_type"]).Trim();
                                        q2.debtor_type = debtor_type;

                                    }
                                    if (reader["contact"] != DBNull.Value)
                                    {
                                        q2.contact = ((string)reader["contact"]).Trim();
                                    }
                                    if (reader["validation_date"] != DBNull.Value)
                                    {
                                        q2.validation_date = ((string)reader["validation_date"]).Trim();
                                    }
                                    if (reader["debtor_Name"] != DBNull.Value)
                                    {
                                        q2.debtor_Name = ((string)reader["debtor_Name"]).Trim();
                                    }
                                    if (reader["debtor_closed"] != DBNull.Value)
                                    {
                                        q2.debtor_closed = ((string)reader["debtor_closed"]).Trim();
                                    }
                                    if (reader["debtor_legal"] != DBNull.Value)
                                    {
                                        q2.debtor_legal = (decimal)reader["debtor_legal"];
                                    }
                                    if (reader["home_extension"] != DBNull.Value)
                                    {
                                        q2.home_extension = ((string)reader["home_extension"]).Trim();
                                    }
                                    if (reader["work_extension"] != DBNull.Value)
                                    {
                                        q2.work_extension = ((string)reader["work_extension"]).Trim();
                                    }
                                    if (reader["cell_extension"] != DBNull.Value)
                                    {
                                        q2.cell_extension = ((string)reader["cell_extension"]).Trim();
                                    }
                                    if (reader["other_extension"] != DBNull.Value)
                                    {
                                        q2.other_extension = ((string)reader["other_extension"]).Trim();
                                    }
                                    if (reader["group_filenumber"] != DBNull.Value)
                                    {
                                        q2.group_filenumber = (int)reader["group_filenumber"];
                                    }
                                    if (reader["debtor_country"] != DBNull.Value)
                                    {
                                        q2.debtor_country = ((string)reader["debtor_country"]).Trim();
                                    }
                                    
                                    if (reader["User1"] != DBNull.Value)
                                    {
                                        q2.User1 = ((string)reader["User1"]).Trim();
                                    }
                                    if (reader["User2"] != DBNull.Value)
                                    {
                                        q2.User2 = ((string)reader["User2"]).Trim();
                                    }
                                    if (reader["User3"] != DBNull.Value)
                                    {
                                        q2.User3 = ((string)reader["User3"]).Trim();
                                    }
                                    if (reader["Percentage"] != DBNull.Value)
                                    {
                                        decimal Percentage = (decimal)reader["Percentage"];
                                        q2.Percentage = Percentage.ToString("0.00").Trim();
                                    }
                                    if (reader["OOS"] != DBNull.Value)
                                    {
                                        q2.OOS = (int)reader["OOS"];
                                    }
                                    if (reader["Score"] != DBNull.Value)
                                    {
                                        q2.Score = (int)reader["Score"];
                                    }
                                    if (reader["InterestRecal"] != DBNull.Value)
                                    {
                                        q2.InterestRecal = ((string)reader["InterestRecal"]).Trim();
                                    }

                                    Listq2.Add(q2);


                                }
                            }
                        }

                        catch (Exception ex)
                        {
                            // Handle the exception here (e.g., logging, displaying an error message)
                            Console.WriteLine("An error occurred: " + ex.Message);
                        }
                    }
                }
            }
            var combinedList = new List<dynamic>();
            combinedList.AddRange(Listq1.Cast<dynamic>());
            combinedList.AddRange(Listq2.Cast<dynamic>());

            return Task.FromResult(combinedList);
        }
        public string GetPortalToken(string fileNumber, string debtorEmail, string country=null,string coDescription=null)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
        new Claim("sub", "registration-link-token"),
        new Claim("iss", "https://connect.cedarsbiz.com"),
        new Claim("tenantId", "cedar"),
        new Claim("exp", ToUnixEpochDate(DateTime.UtcNow.AddMinutes(150)).ToString(), ClaimValueTypes.Integer),
        new Claim("iat", ToUnixEpochDate(DateTime.UtcNow).ToString(), ClaimValueTypes.Integer),
        new Claim("email", debtorEmail),
        new Claim("jti", Guid.NewGuid().ToString()),
        new Claim("fileId", fileNumber),
    };

            var token = new JwtSecurityToken(
                issuer: "https://connect.cedarsbiz.com",
                audience: "YourAudience",
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(15),
                signingCredentials: creds
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            // Build campaign date: MM-DD-YYYY (today's date)
            string campaignDate = DateTime.UtcNow.ToString("MM-dd-yyyy");

            string monthAbbr = DateTime.UtcNow.ToString("MMM").ToUpper();
            string day = DateTime.UtcNow.ToString("dd");

            bool isMVN = !string.IsNullOrEmpty(coDescription) &&
                         coDescription.ToUpper().Contains("MVN");

            string campaignId;

            if (country?.Equals("International", StringComparison.OrdinalIgnoreCase) == true)
            {
                campaignId = $"INT{monthAbbr}{day}";
            }
            else
            {
                campaignId = isMVN
                    ? $"MVN{monthAbbr}{day}"
                    : $"RGLR{monthAbbr}{day}";
            }

            string urlTemplate = "https://connect.cedarsbiz.com/register?refNum={0}&token={1}&campaignDate={2}&campaignId={3}&utm_source=collection_notice&utm_medium=email";

            string registrationLink = string.Format(urlTemplate, fileNumber, tokenString, campaignDate, campaignId);

            return registrationLink;
        }

        private readonly string secretKey = "YourStrongSecretKeyHere";
        private long ToUnixEpochDate(DateTime date)
        {
            return (long)Math.Round((date.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds);
        }

        public async Task<List<SMSCreport>> SMSCWipCampaign(SMSCWip col, string constrr)
        {
            List<SMSCreport> q1List = new List<SMSCreport>();

            if (col != null)
            {
                using (SqlConnection con = new SqlConnection(constrr))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_WIP_SMSC_Campaign", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 60000;

                        cmd.Parameters.AddWithValue("@wip_name", col.wip_name);
                        cmd.Parameters.AddWithValue("@cdate", col.cdate);
                        cmd.Parameters.AddWithValue("@cdate1", col.cdate1);

                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            try
                            {
                                while (reader.Read())
                                {
                                    SMSCreport q1 = new SMSCreport();
                                    try
                                    {
                                        if (reader["Name"] != DBNull.Value)
                                        {
                                            q1.Name = SafeString(reader, "Name");
                                        }
                                        if (reader["Contact"] != DBNull.Value)
                                        {
                                            q1.Contact = SafeString(reader, "Contact");
                                        }
                                        if (reader["Address"] != DBNull.Value)
                                        {
                                            q1.Address = SafeString(reader, "Address");
                                        }
                                        if (reader["City"] != DBNull.Value)
                                        {
                                            q1.City = SafeString(reader, "City");
                                        }
                                        if (reader["State"] != DBNull.Value)
                                        {
                                            var stateValue = reader["State"].ToString().Trim().Replace("\r", "").Replace("\n", " ");

                                            if (stateValue.Length == 2)
                                            {
                                                q1.State = stateValue.ToUpper();
                                            }
                                            else if (StateAbbreviations.TryGetValue(stateValue, out var abbreviation))
                                            {
                                                q1.State = abbreviation;
                                            }
                                        }
                                        if (reader["Zip"] != DBNull.Value)
                                        {
                                            q1.Zip = SafeString(reader, "Zip");
                                        }
                                        if (reader["Country"] != DBNull.Value)
                                        {
                                            q1.Country = SafeString(reader, "Country");
                                        }
                                        if (reader["Cell"] != DBNull.Value)
                                        {
                                            q1.Cell = reader["Cell"].ToString().Replace("-", "");
                                        }
                                        if (reader["CellExtension"] != DBNull.Value)
                                        {
                                            q1.Cell_extension = SafeString(reader, "CellExtension");
                                        }
                                        if (reader["Email"] != DBNull.Value)
                                        {
                                            q1.Email = SafeString(reader, "Email");
                                        }
                                        if (reader["Orig_Cr"] != DBNull.Value)
                                        {
                                            q1.Orig_Cr = SafeString(reader, "Orig_Cr");
                                        }
                                        if (reader["Client"] != DBNull.Value)
                                        {
                                            q1.Client = SafeString(reader, "Client");
                                        }
                                        if (reader["Client_Number"] != DBNull.Value)
                                        {
                                            q1.Client_number = SafeString(reader, "Client_Number");
                                        }
                                        if (reader["Acct"] != DBNull.Value)
                                        {
                                            q1.Acct = SafeString(reader, "Acct");
                                        }
                                        if (reader["Legal"] != DBNull.Value)
                                        {
                                            q1.Legal = SafeString(reader, "Legal");
                                        }
                                        if (reader["Charged"] != DBNull.Value)
                                        {
                                            q1.Charged = SafeString(reader, "Charged");
                                        }
                                        if (reader["Listed"] != DBNull.Value)
                                        {
                                            q1.Listed = SafeString(reader, "Listed");
                                        }
                                        if (reader["Closed"] != DBNull.Value)
                                        {
                                            q1.Closed = SafeString(reader, "Closed");
                                        }
                                        if (reader["COL_Type"] != DBNull.Value)
                                        {
                                            q1.Type = SafeString(reader, "COL_Type");
                                        }
                                        if (reader["Delnqnt"] != DBNull.Value)
                                        {
                                            q1.Delnqnt = SafeString(reader, "Delnqnt");
                                        }
                                        if (reader["Status"] != DBNull.Value)
                                        {
                                            q1.Status = SafeString(reader, "Status");
                                        }
                                        if (reader["Operator"] != DBNull.Value)
                                        {
                                            q1.Operator = SafeString(reader, "Operator");
                                        }
                                        if (reader["Principal"] != DBNull.Value)
                                        {
                                            q1.Principal = "$" + SafeString(reader, "Principal");
                                        }
                                        if (reader["Interest"] != DBNull.Value)
                                        {
                                            q1.Interest = "$" + SafeString(reader, "Interest");
                                        }
                                        if (reader["Fees"] != DBNull.Value)
                                        {
                                            q1.Fees = "$" + SafeString(reader, "Fees");
                                        }
                                        if (reader["Paid"] != DBNull.Value)
                                        {
                                            q1.Paid = "$" + SafeString(reader, "Paid");
                                        }
                                        if (reader["Owing"] != DBNull.Value)
                                        {
                                            q1.Owing = "$" + SafeString(reader, "Owing");
                                        }
                                        if (reader["Discount"] != DBNull.Value)
                                        {
                                            q1.Discount = "$" + SafeString(reader, "Discount");
                                        }
                                        if (reader["DiscountDate"] != DBNull.Value)
                                        {
                                            q1.Discount1 = SafeString(reader, "DiscountDate");
                                        }
                                        if (reader["Summary"] != DBNull.Value)
                                        {
                                            q1.Summary = SafeString(reader, "Summary");
                                        }
                                        if (reader["File"] != DBNull.Value)
                                        {
                                            q1.File = SafeString(reader, "File");
                                        }
                                        if (reader["Group"] != DBNull.Value)
                                        {
                                            q1.Group = SafeString(reader, "Group");
                                        }
                                        if (reader["Group_member"] != DBNull.Value)
                                        {
                                            q1.Group_member = SafeString(reader, "Group_member");
                                        }
                                        if (reader["Mode"] != DBNull.Value)
                                        {
                                            q1.Mode = SafeString(reader, "Mode");
                                        }
                                        if (reader["SMS"] != DBNull.Value)
                                        {
                                            q1.SMS = SafeString(reader, "SMS");
                                        }

                                        q1List.Add(q1);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("An error occurred: " + ex.Message);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("An error occurred: " + ex.Message);
                            }
                        }
                    }
                }
            }

            return q1List.ToList();
        }

        // Helper method — place this inside the same class
        private string SafeString(SqlDataReader reader, string column, string dateFormat = "MM/dd/yyyy")
        {
            if (reader[column] == DBNull.Value) return string.Empty;

            var val = reader[column];

            if (val is DateTime dt)
                return dt.ToString(dateFormat);

            return val.ToString()
                      .Replace("\r", "")
                      .Replace("\n", " ");
        }

        private static readonly Dictionary<string, string> StateAbbreviations = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"Alabama", "AL"}, {"Alaska", "AK"}, {"Arizona", "AZ"}, {"Arkansas", "AR"},
            {"California", "CA"}, {"Colorado", "CO"}, {"Connecticut", "CT"}, {"Delaware", "DE"},
            {"Florida", "FL"}, {"Georgia", "GA"}, {"Hawaii", "HI"}, {"Idaho", "ID"},
            {"Illinois", "IL"}, {"Indiana", "IN"}, {"Iowa", "IA"}, {"Kansas", "KS"},
            {"Kentucky", "KY"}, {"Louisiana", "LA"}, {"Maine", "ME"}, {"Maryland", "MD"},
            {"Massachusetts", "MA"}, {"Michigan", "MI"}, {"Minnesota", "MN"}, {"Mississippi", "MS"},
            {"Missouri", "MO"}, {"Montana", "MT"}, {"Nebraska", "NE"}, {"Nevada", "NV"},
            {"New Hampshire", "NH"}, {"New Jersey", "NJ"}, {"New Mexico", "NM"}, {"New York", "NY"},
            {"North Carolina", "NC"}, {"North Dakota", "ND"}, {"Ohio", "OH"}, {"Oklahoma", "OK"},
            {"Oregon", "OR"}, {"Pennsylvania", "PA"}, {"Rhode Island", "RI"}, {"South Carolina", "SC"},
            {"South Dakota", "SD"}, {"Tennessee", "TN"}, {"Texas", "TX"}, {"Utah", "UT"},
            {"Vermont", "VT"}, {"Virginia", "VA"}, {"Washington", "WA"}, {"West Virginia", "WV"},
            {"Wisconsin", "WI"}, {"Wyoming", "WY"}
        };

    }
}











