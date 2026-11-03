using BLL.Interfaces;
using BLL.Services;
using CsvHelper;
using CsvHelper.Configuration;
using DAL.aPortalContext;
using DAL.VM;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Utilities.Net;
using Serilog;
using System.Diagnostics;
using System.Globalization;
using System.IO.Compression;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Web.WebPages;
using Twilio.TwiML.Voice;

namespace PortalApi.Controllers
{
    public class CUL_ReportController : Controller
    {


        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<CUL_ReportController> _logger;
        public readonly aPortalContext _context2;
        private string _coWho;
        private string _coDes;
        private readonly ICUL_ReportService _BLL;
        public CUL_ReportController(ILogger<CUL_ReportController> logger, ICUL_ReportService BLL, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHostEnvironment, aPortalContext context)
        {
            _BLL = BLL;
            _logger = logger;
            httpContextAccessor = httpContextAccessor;
            _webHostEnvironment = webHostEnvironment;
            _context2 = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("ColReportIndex")]
        public async Task<IActionResult> ColReportIndex([FromBody] CUL_Report_Parameters col)
        {
            try
            {
                var constrr = (string)HttpContext.Items["constr"];
                var response = await _BLL.ColReportIndex(col, constrr);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost("CosignerReport")]
        public async Task<IActionResult> CosignerReport([FromBody] CUL_Report_Parameters col)
        {
            try
            {
                var constrr = (string)HttpContext.Items["constr"];
                var response = await _BLL.CosignerReport(col, constrr);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost("CosignerEmail")]
        public async Task<IActionResult> CosignerEmail([FromBody] CUL_Report_Parameters col)
        {
            try
            {
                var constrr = (string)HttpContext.Items["constr"];
                var response = await _BLL.CosignerEmail(col, constrr);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost("WIPEmailCampaign")]
        public async Task<IActionResult> WIPEmailCampaign(WipEmail col)
        {
            try
            {
                var constrr = (string)HttpContext.Items["constr"];
                var response = await _BLL.WIPEmailCampaign(col, constrr);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost("SMSCWipCampaign")]
        public async Task<IActionResult> SMSCWipCampaign(SMSCWip col)
        {
            try
            {
                var constrr = (string)HttpContext.Items["constr"];
                var response = await _BLL.SMSCWipCampaign(col, constrr);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("ColReportcsv")]
        public async Task<IActionResult> GetCULReport([FromBody] CUL_Report_Parameters col)
        {
            try
            {

                var constrr = (string)HttpContext.Items["constr"];
                List<CUL_Report> reportData = await _BLL.ColReportIndex(col, constrr);

                _coWho = col.Collector;
                _coDes = col.co_description;

                // Group the report data by collector
                if (col.CSV == "1")
                {



                    var groupedData = reportData.GroupBy(r => r.Operator);
                    using (var memoryStream = new MemoryStream())
                    {
                        // Create a zip archive
                        using (var zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                        {
                            foreach (var group in groupedData)
                            {
                                string Type = group.Key;
                                List<CUL_Report> groupedData1 = group.ToList();



                                string csvContent = GenerateCSVContent(groupedData1); // Corrected line



                                string fileName = $"{Type}_{Guid.NewGuid()}.csv";



                                // Create a new entry in the zip archive
                                var entry = zipArchive.CreateEntry(fileName, CompressionLevel.Optimal);



                                // Write the CSV content to the entry
                                using (var entryStream = entry.Open())
                                using (var streamWriter = new StreamWriter(entryStream))
                                {
                                    await streamWriter.WriteAsync(csvContent);
                                }
                            }
                        }



                        // Set the position of the memory stream back to the beginning
                        memoryStream.Position = 0;



                        // Send the zip file as a response
                        return File(memoryStream.ToArray(), "application/zip", "reports.zip");
                    }
                }
                if (col.CSV == "2")
                {

                    var groupedData = reportData.GroupBy(r => r.Operator).Select(group => new
                    {
                        Collector = group.Key,
                        YearlyData = group.GroupBy(item => TryParseYear(item.COL_Listed))
                    });
                    using (var memoryStream = new MemoryStream())
                    {
                        // Create a zip archive
                        using (var zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                        {
                            foreach (var collectorGroup in groupedData)
                            {
                                var collector = collectorGroup.Collector;



                                foreach (var yearGroup in collectorGroup.YearlyData)
                                {
                                    var year = yearGroup.Key.ToString();
                                    var groupedData1 = yearGroup.ToList();



                                    string csvContent = GenerateCSVContent(groupedData1);



                                    string fileName = $"{collector}_{year}_{Guid.NewGuid()}.csv";



                                    var entry = zipArchive.CreateEntry(fileName, CompressionLevel.Optimal);



                                    using (var entryStream = entry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(csvContent);
                                    }
                                }
                            }
                        }



                        // Set the position of the memory stream back to the beginning
                        memoryStream.Position = 0;
                        Response.Headers.Add("Content-Disposition", "attachment; filename=reports.zip");
                        // Send the zip file as a response
                        return File(memoryStream.ToArray(), "application/zip", "reports.zip");
                    }
                }
                if (col.CSV == "3")
                {
                    var groupedData = reportData.GroupBy(r =>
                    {
                        if (DateTime.TryParseExact(r.COL_Listed, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                        {
                            return date.Year;
                        }
                        return 0; // Return 0 if parsing fails
                    });
                    using (var memoryStream = new MemoryStream())
                    {
                        // Create a zip archive
                        using (var zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                        {
                            foreach (var group in groupedData)
                            {
                                string Type = group.Key.ToString();
                                List<CUL_Report> groupedData1 = group.ToList();



                                string csvContent = GenerateCSVContent(groupedData1); // Corrected line



                                string fileName = $"{Type}_{Guid.NewGuid()}.csv";



                                // Create a new entry in the zip archive
                                var entry = zipArchive.CreateEntry(fileName, CompressionLevel.Optimal);



                                // Write the CSV content to the entry
                                using (var entryStream = entry.Open())
                                using (var streamWriter = new StreamWriter(entryStream))
                                {
                                    await streamWriter.WriteAsync(csvContent);
                                }
                            }
                        }



                        // Set the position of the memory stream back to the beginning
                        memoryStream.Position = 0;



                        // Send the zip file as a response
                        return File(memoryStream.ToArray(), "application/zip", "reports.zip");
                    }



                }
                if (col.CSV == "4")
                {
                    var presentYear = DateTime.Now.Year;
                    var previousYear = presentYear - 1;

                    var groupedData = reportData.GroupBy(r =>
                    {
                        if (DateTime.TryParseExact(r.COL_Listed, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                        {
                            if (date.Year == presentYear)
                            {
                                return "RecentYear";
                            }
                            else if (date.Year == previousYear)
                            {
                                return "PreviousYear";
                            }
                        }
                        return "Other"; // Default category for other data
                    });

                    using (var memoryStream = new MemoryStream())
                    {
                        // Create a zip archive
                        using (var zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                        {
                            foreach (var group in groupedData)
                            {
                                string category = group.Key;
                                List<CUL_Report> groupedData1 = group.ToList();

                                string col_ty = col.sectorL;

                                // Determine the number to append based on the category
                                int number = 1;
                                if (category == "RecentYear")
                                {
                                    col_ty = $"{col_ty} {number}";
                                }
                                else if (category == "PreviousYear")
                                {
                                    number = 2;
                                    col_ty = $"{col_ty} {number}";
                                }
                                else
                                {
                                    number = 3;
                                    col_ty = $"{col_ty} {number}";
                                }

                                string csvContent = GenerateCSVContent(groupedData1);

                                // Determine the file name based on the category
                                string fileName = $"{col_ty}_{Guid.NewGuid()}.csv";

                                // Create a new entry in the zip archive
                                var entry = zipArchive.CreateEntry(fileName, CompressionLevel.Optimal);

                                // Write the CSV content to the entry
                                using (var entryStream = entry.Open())
                                using (var streamWriter = new StreamWriter(entryStream))
                                {
                                    await streamWriter.WriteAsync(csvContent);
                                }
                            }
                        }

                        // Set the position of the memory stream back to the beginning
                        memoryStream.Position = 0;

                        // Send the zip file as a response
                        return File(memoryStream.ToArray(), "application/zip", "reports.zip");
                    }
                }
                if (col.CSV == "007")
                {
                    var allData = reportData; // Assume reportData contains all the necessary data
                    var lastsixmonth = _context2.LastSixMonthDialCompaigns.Select(a => a.DeNumber).ToList();
                    var TopClient = _context2.TopClientDialCompaigns.Select(a => a.DeNumber).ToList();
                    var RestClient = _context2.RestOffDialCompaigns.Select(a => a.DeNumber).ToList();

                    // Filter data based on whether COL_FileNumber exists in the corresponding lists
                    var Last6Month = allData.Where(data => lastsixmonth.Contains(data.COL_FileNumber)).ToList();
                    var TopClients = allData.Where(data => TopClient.Contains(data.COL_FileNumber)).ToList();
                    var RestClients = allData.Where(data => RestClient.Contains(data.COL_FileNumber)).ToList();

                    // Only proceed if any data exists in any of the filtered lists
                    if (Last6Month.Count > 0 || TopClients.Count > 0 || RestClients.Count > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                            {
                                // Generate CSV content for Last 6 Months and add to ZIP
                                if (Last6Month.Count > 0)
                                {
                                    string last6MonthCsvContent = GenerateCSVContent(Last6Month);
                                    var last6MonthEntry = zipArchive.CreateEntry("Last6Month.csv", CompressionLevel.Optimal);
                                    using (var entryStream = last6MonthEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(last6MonthCsvContent);
                                    }
                                }

                                // Generate CSV content for Top Clients and add to ZIP
                                if (TopClients.Count > 0)
                                {
                                    string topClientsCsvContent = GenerateCSVContent(TopClients);
                                    var topClientsEntry = zipArchive.CreateEntry("TopClients.csv", CompressionLevel.Optimal);
                                    using (var entryStream = topClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(topClientsCsvContent);
                                    }
                                }

                                // Generate CSV content for Rest Clients and add to ZIP
                                if (RestClients.Count > 0)
                                {
                                    string restClientsCsvContent = GenerateCSVContent(RestClients);
                                    var restClientsEntry = zipArchive.CreateEntry("RestClients.csv", CompressionLevel.Optimal);
                                    using (var entryStream = restClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(restClientsCsvContent);
                                    }
                                }
                            }

                            memoryStream.Position = 0; // Reset the stream position for the return

                            // Return the ZIP file containing all CSVs
                            return File(memoryStream.ToArray(), "application/zip", "filtered_report_data.zip");
                        }
                    }
                    else
                    {
                        return NotFound("No data available to create CSV files.");
                    }
                }

                if (col.CSV == "07")
                {
                    var oneYearAgo = DateTime.UtcNow.AddMonths(-12).Date;
                    var twoYearsAgo = DateTime.UtcNow.AddMonths(-24).Date;
                    var allData = reportData; // Assume reportData contains all the necessary data
                    var lastsixmonth = _context2.LastSixMonthDialCompaigns.Select(a => a.DeNumber).ToList();
                    var TopClient = _context2.TopClientDialCompaigns.Select(a => a.DeNumber).ToList();
                    var RestClient = _context2.RestOffDialCompaigns.Select(a => a.DeNumber).ToList();

                    var TopClient612 = _context2.TopClientDialCompaigns
                                       .Where(a => a.DeListedDate.HasValue && a.DeListedDate.Value.Date >= oneYearAgo)
                                       .Select(a => a.DeNumber)
                                       .ToList();

                    var TopClient1224 = _context2.TopClientDialCompaigns
                                       .Where(a => a.DeListedDate.HasValue
                                                   && a.DeListedDate.Value.Date >= twoYearsAgo
                                                   && a.DeListedDate.Value.Date < oneYearAgo)
                                       .Select(a => a.DeNumber)
                                       .ToList();

                    var TopClient24p = _context2.TopClientDialCompaigns
                                       .Where(a => a.DeListedDate.HasValue && a.DeListedDate.Value.Date < twoYearsAgo)
                                       .Select(a => a.DeNumber)
                                       .ToList();
                    var RestClient724 = _context2.RestOffDialCompaigns
                                       .Where(a => a.DeListedDate.HasValue && a.DeListedDate.Value.Date >= twoYearsAgo)
                                       .Select(a => a.DeNumber)
                                       .ToList();
                    var RestClient24p = _context2.RestOffDialCompaigns
                                       .Where(a => a.DeListedDate.HasValue && a.DeListedDate.Value.Date < twoYearsAgo)
                                       .Select(a => a.DeNumber)
                                       .ToList();

                    var Last6Month = allData.Where(data => lastsixmonth.Contains(data.COL_FileNumber)).ToList();
                    var TopClients = allData.Where(data => TopClient.Contains(data.COL_FileNumber)).ToList();
                    var TopClients612 = allData.Where(data => TopClient612.Contains(data.COL_FileNumber)).ToList();
                    var TopClients1224 = allData.Where(data => TopClient1224.Contains(data.COL_FileNumber)).ToList();
                    var TopClients24p = allData.Where(data => TopClient24p.Contains(data.COL_FileNumber)).ToList();
                    var RestClients = allData.Where(data => RestClient.Contains(data.COL_FileNumber)).ToList();
                    var RestClients724 = allData.Where(data => RestClient724.Contains(data.COL_FileNumber)).ToList();
                    var RestClients24p = allData.Where(data => RestClient24p.Contains(data.COL_FileNumber)).ToList();

                    // Only proceed if any data exists in any of the filtered lists
                    if (Last6Month.Count > 0 || TopClients.Count > 0 || RestClients.Count > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                            {
                                // Generate CSV content for Last 6 Months and add to ZIP
                                if (Last6Month.Count > 0)
                                {
                                    string last6MonthCsvContent = GenerateCSVContent(Last6Month);
                                    var last6MonthEntry = zipArchive.CreateEntry("Last6Month.csv", CompressionLevel.Optimal);
                                    using (var entryStream = last6MonthEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(last6MonthCsvContent);
                                    }
                                }

                                // Generate CSV content for Top Clients and add to ZIP
                                if (TopClients.Count > 0)
                                {
                                    string topClientsCsvContent = GenerateCSVContent(TopClients);
                                    var topClientsEntry = zipArchive.CreateEntry("TopClients.csv", CompressionLevel.Optimal);
                                    using (var entryStream = topClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(topClientsCsvContent);
                                    }
                                }
                                if (TopClients612.Count > 0)
                                {
                                    string topClientsCsvContent = GenerateCSVContent(TopClients612);
                                    var topClientsEntry = zipArchive.CreateEntry("TopClients7to12.csv", CompressionLevel.Optimal);
                                    using (var entryStream = topClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(topClientsCsvContent);
                                    }
                                }
                                if (TopClients1224.Count > 0)
                                {
                                    string topClientsCsvContent = GenerateCSVContent(TopClients1224);
                                    var topClientsEntry = zipArchive.CreateEntry("TopClients12to24.csv", CompressionLevel.Optimal);
                                    using (var entryStream = topClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(topClientsCsvContent);
                                    }
                                }
                                if (TopClients24p.Count > 0)
                                {
                                    string topClientsCsvContent = GenerateCSVContent(TopClients24p);
                                    var topClientsEntry = zipArchive.CreateEntry("TopClients24p.csv", CompressionLevel.Optimal);
                                    using (var entryStream = topClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(topClientsCsvContent);
                                    }
                                }

                                // Generate CSV content for Rest Clients and add to ZIP
                                if (RestClients.Count > 0)
                                {
                                    string restClientsCsvContent = GenerateCSVContent(RestClients);
                                    var restClientsEntry = zipArchive.CreateEntry("RestClients.csv", CompressionLevel.Optimal);
                                    using (var entryStream = restClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(restClientsCsvContent);
                                    }
                                }
                                if (RestClients724.Count > 0)
                                {
                                    string restClientsCsvContent = GenerateCSVContent(RestClients724);
                                    var restClientsEntry = zipArchive.CreateEntry("RestClients724.csv", CompressionLevel.Optimal);
                                    using (var entryStream = restClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(restClientsCsvContent);
                                    }
                                }
                                if (RestClients24p.Count > 0)
                                {
                                    string restClientsCsvContent = GenerateCSVContent(RestClients24p);
                                    var restClientsEntry = zipArchive.CreateEntry("RestClients24p.csv", CompressionLevel.Optimal);
                                    using (var entryStream = restClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(restClientsCsvContent);
                                    }
                                }
                            }

                            memoryStream.Position = 0; // Reset the stream position for the return

                            // Return the ZIP file containing all CSVs
                            return File(memoryStream.ToArray(), "application/zip", "filtered_report_data.zip");
                        }
                    }
                    else
                    {
                        return NotFound("No data available to create CSV files.");
                    }
                }
                if (col.CSV == "08")
                {
                    var LateState = new[] { "AK", "AZ", "CA", "CO", "HI", "ID", "MT", "NV", "NM", "OR", "UT", "WA", "WY" };
                    var EarlyState = new[] { "AL", "AR", "CT", "DE", "FL", "GA", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "NE", "NH", "NJ", "NY", "NC", "ND", "OH", "OK", "PA", "RI", "SC", "SD", "TN", "TX", "VT", "VA", "WV", "WI" };
                    var oneYearAgo = DateTime.UtcNow.AddMonths(-12).Date;
                    var twoYearsAgo = DateTime.UtcNow.AddMonths(-24).Date;
                    var allData = reportData; // Assume reportData contains all the necessary data
                    var lastsixmonth = _context2.LastSixMonthDialCompaigns.Select(a => a.DeNumber).ToList();
                    var TopClient = _context2.TopClientDialCompaigns.Select(a => a.DeNumber).ToList();
                    var RestClient = _context2.RestOffDialCompaigns.Select(a => a.DeNumber).ToList();

                    var TopClient612 = _context2.TopClientDialCompaigns
                                       .Where(a => a.DeListedDate.HasValue && a.DeListedDate.Value.Date >= oneYearAgo)
                                       .Select(a => a.DeNumber)
                                       .ToList();

                    var TopClient1224 = _context2.TopClientDialCompaigns
                                       .Where(a => a.DeListedDate.HasValue
                                                   && a.DeListedDate.Value.Date >= twoYearsAgo
                                                   && a.DeListedDate.Value.Date < oneYearAgo)
                                       .Select(a => a.DeNumber)
                                       .ToList();

                    var TopClient24p = _context2.TopClientDialCompaigns
                                       .Where(a => a.DeListedDate.HasValue && a.DeListedDate.Value.Date < twoYearsAgo)
                                       .Select(a => a.DeNumber)
                                       .ToList();
                    var RestClient724 = _context2.RestOffDialCompaigns
                                       .Where(a => a.DeListedDate.HasValue && a.DeListedDate.Value.Date >= twoYearsAgo)
                                       .Select(a => a.DeNumber)
                                       .ToList();
                    var RestClient24p = _context2.RestOffDialCompaigns
                                       .Where(a => a.DeListedDate.HasValue && a.DeListedDate.Value.Date < twoYearsAgo)
                                       .Select(a => a.DeNumber)
                                       .ToList();

                    //var Last6Month = allData.Where(data => lastsixmonth.Contains(data.COL_FileNumber)).ToList();
                    //var TopClients = allData.Where(data => TopClient.Contains(data.COL_FileNumber)).ToList();
                    //var RestClients = allData.Where(data => RestClient.Contains(data.COL_FileNumber)).ToList();

                    var Last6MonthE = allData.Where(data => lastsixmonth.Contains(data.COL_FileNumber) && EarlyState.Contains(data.COL_States)).ToList();
                    var TopClients612E = allData.Where(data => TopClient612.Contains(data.COL_FileNumber) && EarlyState.Contains(data.COL_States)).ToList();
                    var TopClients1224E = allData.Where(data => TopClient1224.Contains(data.COL_FileNumber) && EarlyState.Contains(data.COL_States)).ToList();
                    var TopClients24pE = allData.Where(data => TopClient24p.Contains(data.COL_FileNumber) && EarlyState.Contains(data.COL_States)).ToList();
                    var RestClients724E = allData.Where(data => RestClient724.Contains(data.COL_FileNumber) && EarlyState.Contains(data.COL_States)).ToList();
                    var RestClients24pE = allData.Where(data => RestClient24p.Contains(data.COL_FileNumber) && EarlyState.Contains(data.COL_States)).ToList();


                    var Last6MonthL = allData.Where(data => lastsixmonth.Contains(data.COL_FileNumber) && LateState.Contains(data.COL_States)).ToList();
                    var TopClients612L = allData.Where(data => TopClient612.Contains(data.COL_FileNumber) && LateState.Contains(data.COL_States)).ToList();
                    var TopClients1224L = allData.Where(data => TopClient1224.Contains(data.COL_FileNumber) && LateState.Contains(data.COL_States)).ToList();
                    var TopClients24pL = allData.Where(data => TopClient24p.Contains(data.COL_FileNumber) && LateState.Contains(data.COL_States)).ToList();
                    var RestClients724L = allData.Where(data => RestClient724.Contains(data.COL_FileNumber) && LateState.Contains(data.COL_States)).ToList();
                    var RestClients24pL = allData.Where(data => RestClient24p.Contains(data.COL_FileNumber) && LateState.Contains(data.COL_States)).ToList();


                    // Only proceed if any data exists in any of the filtered lists
                    if (allData is not null)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                            {
                                //Creating Early Files 
                                if (Last6MonthE.Count > 0)
                                {
                                    string last6MonthCsvContent = GenerateCSVContent(Last6MonthE);
                                    var last6MonthEntry = zipArchive.CreateEntry("Last6MonthE.csv", CompressionLevel.Optimal);
                                    using (var entryStream = last6MonthEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(last6MonthCsvContent);
                                    }
                                }

                                if (TopClients612E.Count > 0)
                                {
                                    string topClientsCsvContent = GenerateCSVContent(TopClients612E);
                                    var topClientsEntry = zipArchive.CreateEntry("TopClients7to12E.csv", CompressionLevel.Optimal);
                                    using (var entryStream = topClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(topClientsCsvContent);
                                    }
                                }
                                if (TopClients1224E.Count > 0)
                                {
                                    string topClientsCsvContent = GenerateCSVContent(TopClients1224E);
                                    var topClientsEntry = zipArchive.CreateEntry("TopClients12to24E.csv", CompressionLevel.Optimal);
                                    using (var entryStream = topClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(topClientsCsvContent);
                                    }
                                }
                                if (TopClients24pE.Count > 0)
                                {
                                    string topClientsCsvContent = GenerateCSVContent(TopClients24pE);
                                    var topClientsEntry = zipArchive.CreateEntry("TopClients24pE.csv", CompressionLevel.Optimal);
                                    using (var entryStream = topClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(topClientsCsvContent);
                                    }
                                }
                                if (RestClients724E.Count > 0)
                                {
                                    string restClientsCsvContent = GenerateCSVContent(RestClients724E);
                                    var restClientsEntry = zipArchive.CreateEntry("RestClients724E.csv", CompressionLevel.Optimal);
                                    using (var entryStream = restClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(restClientsCsvContent);
                                    }
                                }
                                if (RestClients24pE.Count > 0)
                                {
                                    string restClientsCsvContent = GenerateCSVContent(RestClients24pE);
                                    var restClientsEntry = zipArchive.CreateEntry("RestClients24pE.csv", CompressionLevel.Optimal);
                                    using (var entryStream = restClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(restClientsCsvContent);
                                    }
                                }

                                //Creating OLD Files
                                if (Last6MonthL.Count > 0)
                                {
                                    string last6MonthCsvContent = GenerateCSVContent(Last6MonthL);
                                    var last6MonthEntry = zipArchive.CreateEntry("Last6MonthL.csv", CompressionLevel.Optimal);
                                    using (var entryStream = last6MonthEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(last6MonthCsvContent);
                                    }
                                }

                                if (TopClients612L.Count > 0)
                                {
                                    string topClientsCsvContent = GenerateCSVContent(TopClients612L);
                                    var topClientsEntry = zipArchive.CreateEntry("TopClients7to12L.csv", CompressionLevel.Optimal);
                                    using (var entryStream = topClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(topClientsCsvContent);
                                    }
                                }
                                if (TopClients1224L.Count > 0)
                                {
                                    string topClientsCsvContent = GenerateCSVContent(TopClients1224L);
                                    var topClientsEntry = zipArchive.CreateEntry("TopClients12to24L.csv", CompressionLevel.Optimal);
                                    using (var entryStream = topClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(topClientsCsvContent);
                                    }
                                }
                                if (TopClients24pE.Count > 0)
                                {
                                    string topClientsCsvContent = GenerateCSVContent(TopClients24pL);
                                    var topClientsEntry = zipArchive.CreateEntry("TopClients24pL.csv", CompressionLevel.Optimal);
                                    using (var entryStream = topClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(topClientsCsvContent);
                                    }
                                }
                                if (RestClients724L.Count > 0)
                                {
                                    string restClientsCsvContent = GenerateCSVContent(RestClients724L);
                                    var restClientsEntry = zipArchive.CreateEntry("RestClients724L.csv", CompressionLevel.Optimal);
                                    using (var entryStream = restClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(restClientsCsvContent);
                                    }
                                }
                                if (RestClients24pL.Count > 0)
                                {
                                    string restClientsCsvContent = GenerateCSVContent(RestClients24pL);
                                    var restClientsEntry = zipArchive.CreateEntry("RestClients24pL.csv", CompressionLevel.Optimal);
                                    using (var entryStream = restClientsEntry.Open())
                                    using (var streamWriter = new StreamWriter(entryStream))
                                    {
                                        await streamWriter.WriteAsync(restClientsCsvContent);
                                    }
                                }


                            }

                            memoryStream.Position = 0; // Reset the stream position for the return

                            // Return the ZIP file containing all CSVs
                            return File(memoryStream.ToArray(), "application/zip", "filtered_report_data.zip");
                        }
                    }
                    else
                    {
                        return NotFound("No data available to create CSV files.");
                    }
                }
                if (col.CSV == "10")
                {
                    var allData = reportData;

                    // Status Groups
                    var group1 = new[] { "NLST", "NW1", "NW2", "BPR", "PRC" };
                    var group2 = new[] { "HOT", "DIS", "DISV", "CPDR" };
                    var group3 = new[] { "ACT" };

                    using (var memoryStream = new MemoryStream())
                    {
                        using (var zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                        {
                            // CASE 1: If Collector contains "DIG"
                            if (!string.IsNullOrEmpty(col.sectorL) && col.sectorL.Contains("DIG", StringComparison.OrdinalIgnoreCase))
                            {
                                // Group A: NLST, NW1, NW2, BPR, HOT, DIS, DISV
                                var digGroupA = allData.Where(d => group1.Contains(d.COL_Status) || group2.Contains(d.COL_Status)).ToList();
                                if (digGroupA.Count > 0)
                                {
                                    string digGroupACsv = GenerateCSVContent(digGroupA);
                                    var entry = zipArchive.CreateEntry("DIG_GroupA.csv", CompressionLevel.Optimal);
                                    using (var entryStream = entry.Open())
                                    using (var writer = new StreamWriter(entryStream))
                                    {
                                        await writer.WriteAsync(digGroupACsv);
                                    }
                                }

                                // Group B: ACT
                                var digGroupB = allData.Where(d => group3.Contains(d.COL_Status)).ToList();
                                if (digGroupB.Count > 0)
                                {
                                    string digGroupBCsv = GenerateCSVContent(digGroupB);
                                    var entry = zipArchive.CreateEntry("DIG_GroupB.csv", CompressionLevel.Optimal);
                                    using (var entryStream = entry.Open())
                                    using (var writer = new StreamWriter(entryStream))
                                    {
                                        await writer.WriteAsync(digGroupBCsv);
                                    }
                                }
                            }
                            else
                            {
                                // CASE 2: Normal Segregation (not DIG)
                                // Group 1 → NLST, NW1, NW2, BPR
                                var normalGroup1 = allData.Where(d => group1.Contains(d.COL_Status)).ToList();
                                if (normalGroup1.Count > 0)
                                {
                                    string csv = GenerateCSVContent(normalGroup1);
                                    var entry = zipArchive.CreateEntry("Group_NLST_NW1_BPR_PRC.csv", CompressionLevel.Optimal);
                                    using (var entryStream = entry.Open())
                                    using (var writer = new StreamWriter(entryStream))
                                    {
                                        await writer.WriteAsync(csv);
                                    }
                                }

                                // Group 2 → HOT, DIS, DISV
                                var normalGroup2 = allData.Where(d => group2.Contains(d.COL_Status)).ToList();
                                if (normalGroup2.Count > 0)
                                {
                                    string csv = GenerateCSVContent(normalGroup2);
                                    var entry = zipArchive.CreateEntry("Group_HOT_DIS_DISV.csv", CompressionLevel.Optimal);
                                    using (var entryStream = entry.Open())
                                    using (var writer = new StreamWriter(entryStream))
                                    {
                                        await writer.WriteAsync(csv);
                                    }
                                }

                                // Group 3 → ACT
                                var normalGroup3 = allData.Where(d => group3.Contains(d.COL_Status)).ToList();
                                if (normalGroup3.Count > 0)
                                {
                                    string csv = GenerateCSVContent(normalGroup3);
                                    var entry = zipArchive.CreateEntry("Group_ACT.csv", CompressionLevel.Optimal);
                                    using (var entryStream = entry.Open())
                                    using (var writer = new StreamWriter(entryStream))
                                    {
                                        await writer.WriteAsync(csv);
                                    }
                                }
                            }
                        }

                        memoryStream.Position = 0;
                        return File(memoryStream.ToArray(), "application/zip", "status_report_data.zip");
                    }
                }


                else
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        using (var zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                        {
                            string csvContent = GenerateCSVContent(reportData); // Generate CSV for the entire dataset

                            string fileName = $"report_data.csv"; // Choose a file name for the CSV

                            var entry = zipArchive.CreateEntry(fileName, CompressionLevel.Optimal);

                            using (var entryStream = entry.Open())
                            using (var streamWriter = new StreamWriter(entryStream))
                            {
                                await streamWriter.WriteAsync(csvContent);
                            }
                        }

                        memoryStream.Position = 0;

                        return File(memoryStream.ToArray(), "application/zip", "report_data.zip");
                    }
                }



            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        private int TryParseYear(string dateString)
        {
            if (DateTime.TryParseExact(dateString, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                return date.Year;
            }
            return 0;
        }

        private string GenerateCSVContent(List<CUL_Report> reportData)
        {
            StringBuilder csvBuilder = new StringBuilder();

            // Add CSV headers
            if (!_coDes.IsNullOrEmpty() || !_coWho.IsNullOrEmpty())
            {
                csvBuilder.AppendLine("COL_Email,COL_FileNumber,COL_NameFirst,COL_NameLast,COL_PhoneHome,Next_Best,Rank,Source,Phone_Type,Last_RPC_Date,Last_Payment_Date,COL_PhoneHome_Ext,COL_Acct,COL_Charged,delinquency_date,COL_States,COL_Client,COL_Client number,COL_ZipCode, COL_Type,COL_Status,COL_Listed,COL_Owing,COL_score,co_description,Operator,Country,Orignal_Creditor,Settlement,group_count,address,city,mode,Contact,debtor_Name,debtor_closed,debtor_legal,home_extension,cell_extension,work_extension,other_extension,group_filenumber,TimeZone,summary");

            }
            else
            {
                csvBuilder.AppendLine("COL_Email,COL_FileNumber,COL_NameFirst,COL_NameLast,COL_PhoneHome,Next_Best,Rank,Source,Phone_Type,Last_RPC_Date,Last_Payment_Date,COL_PhoneHome_Ext,COL_Acct,COL_Charged,delinquency_date,COL_States,COL_Client,COL_Client number,COL_ZipCode,COL_Type,COL_Status,COL_Listed,COL_Owing,COL_score,Operator,Country,Orignal_Creditor,Settlement,group_count,address,city,mode,Contact,debtor_Name,debtor_closed,debtor_legal,home_extension,cell_extension,work_extension,other_extension,group_filenumber,TimeZone,summary");
            }

            // Add data rows
            foreach (CUL_Report report in reportData)
            {
                // Create an array to store the values
                var values = new List<string>();

                // Append data values for each property, handling commas if present
                values.Add(FormatValueCol(report.COL_Email));
                values.Add(FormatValueCol(report.COL_FileNumber));
                values.Add(FormatValueCol(report.COL_NameFirst));
                values.Add(FormatValueCol(report.COL_NameLast));
                values.Add(FormatValueCol(report.COL_PhoneHome));
                values.Add(FormatValueCol(report.Next_Best));
                values.Add(FormatValueCol(report.Rank));
                values.Add(FormatValueCol(report.Source));
                values.Add(FormatValueCol(report.PhoneType));
                values.Add(FormatValueCol(report.Last_RPC_Date));
                values.Add(FormatValueCol(report.Last_Payment_Date));
                values.Add(FormatValueCol(report.COL_PhoneHome_Ext));
                values.Add(FormatValueCol(report.COL_Acct));
                values.Add(FormatValueCol(report.COL_Charged));
                values.Add(FormatValueCol(report.delinquency_date));
                values.Add(FormatValueCol(report.COL_States));
                values.Add(FormatValueCol(report.COL_Client));
                values.Add(FormatValueCol(report.COL_Client_number));
                values.Add(FormatValueCol(report.COL_ZipCode));
                values.Add(FormatValueCol(report.COL_Type));
                values.Add(FormatValueCol(report.COL_Status));
                values.Add(FormatValueCol(report.COL_Listed));
                values.Add(FormatValueCol(report.COL_Owing));
                values.Add(FormatValueCol(report.COL_score));
                if (!string.IsNullOrEmpty(_coWho))
                {
                    values.Add(FormatValueCol(report.co_description));
                }
                values.Add(FormatValueCol(report.Operator));
                values.Add(FormatValueCol(report.Country));
                values.Add(FormatValueCol(report.Original_Creditor));
                values.Add(FormatValueCol(report.Settlement));
                values.Add(FormatValueCol(report.group_count));
                values.Add(FormatValueCol(report.address));
                values.Add(FormatValueCol(report.city));
                values.Add(FormatValueCol(report.mode));
                values.Add(FormatValueCol(report.DeContact));
                values.Add(FormatValueCol(report.debtor_Name));
                values.Add(FormatValueCol(report.debtor_closed));
                values.Add(FormatValueCol(report.Legal));
                values.Add(FormatValueCol(report.home_extension));
                values.Add(FormatValueCol(report.cell_extension));
                values.Add(FormatValueCol(report.work_extension));
                values.Add(FormatValueCol(report.other_extension));
                values.Add(FormatValueCol(report.group_filenumber));
                values.Add(FormatValueCol(report.TimeZone));
                values.Add(FormatValueCol(report.summary));


                // Combine the values using commas and append to the CSV builder
                csvBuilder.AppendLine(string.Join(",", values));
            }

            return csvBuilder.ToString();
        }
        private string FormatValueCol(object value)
        {
            if (value == null || value == "")
            {
                return string.Empty;
            }

            string stringValue = value.ToString();

            // ✅ Force Excel to keep leading zeros
            if (stringValue.Length > 1 && stringValue.StartsWith("0") && stringValue.All(char.IsDigit))
            {
                return $"=\"{stringValue}\"";  // Excel will display leading zeros
            }


            if (stringValue.Contains(",") || stringValue.Contains("-"))
            {
                // If the value contains a comma, wrap it in double quotes
                return $"\"{stringValue}\"";
            }

            // Otherwise, return the value as is
            return stringValue;
        }

        [HttpPost]
        [Route("EmailReportCSV")]

        public async Task<IActionResult> EmailReportCsv([FromBody] CUL_Report_Parameters col)
        {
            try
            {
                _coWho = col.Collector;
                _coDes = col.co_description;
                var constrr = (string)HttpContext.Items["constr"];
                var reportMailcsv = await _BLL.CosignerEmail(col, constrr);

                if (col.CSV == "1")
                {

                    //  var groupedData = reportMailcsv.GroupBy(r => r.debtor_type);
                    var groupedData = ((List<dynamic>)reportMailcsv).GroupBy(r => r.debtor_type);
                    // Create a memory stream to store the zip file
                    using (var memoryStream = new MemoryStream())
                    {
                        // Create a zip archive
                        using (var zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                        {
                            foreach (var group in groupedData)
                            {
                                string Type = group.Key;
                                var collectorData = group.ToList();

                                string csvContent = GenerateEmailCSV(collectorData);

                                string fileName = $"{Type}_{Guid.NewGuid()}.csv";

                                // Create a new entry in the zip archive
                                var entry = zipArchive.CreateEntry(fileName, CompressionLevel.Optimal);

                                // Write the CSV content to the entry
                                using (var entryStream = entry.Open())
                                using (var streamWriter = new StreamWriter(entryStream))
                                {
                                    await streamWriter.WriteAsync(csvContent);
                                }
                            }
                        }

                        // Set the position of the memory stream back to the beginning
                        memoryStream.Position = 0;

                        // Send the zip file as a response
                        return File(memoryStream.ToArray(), "application/zip", "EmailCamapaigns.zip");
                    }

                }
                else
                {
                    string Type = col.ty;

                    string csvContent = GenerateEmailCSV(reportMailcsv); // Generate CSV for the entire dataset
                    var csvBytes = Encoding.UTF8.GetBytes(csvContent);

                    // Return the CSV content as a response with Content-Type "text/csv"
                    // and a Content-Disposition header for downloading
                    var contentDisposition = new ContentDispositionHeaderValue("attachment")
                    {
                        FileName = "EmailCampaign.csv"
                    };
                    Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                    return File(csvBytes, "text/csv");



                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //private string GenerateEmailCSV(List<EmailReport> reportMailcsv)
        private string GenerateEmailCSV(List<dynamic> reportMailcsv)
        {
            StringBuilder csvBuilder = new StringBuilder();
            if (!_coDes.IsNullOrEmpty() || !_coWho.IsNullOrEmpty())
            {
                csvBuilder.AppendLine("Email,RowNum,LastEmailSentDate,co_description,first_name,last_name,Original_Creditor,Account_Num,Fees,Interest,Payments,Outstanding_Balance,principal,Setc_Amunt,Savings,InterestRecal,perc,Our_File,reg_link,group_count,Charged,delinquency_date,Settlement,address,city,state,zip,Itemization_Date,listed_date,Client,Client_num,mode,debtor_status,opertator,debtor_type,contact,validation_date,debtor_Name,debtor_closed,debtor_legal,home_extension,work_extension,cell_extension,other_extension,group_filenumber,debtor_country,Responsible Party,Score,Summary,co_description");

            }
            else
            {
                csvBuilder.AppendLine("Email,RowNum,LastEmailSentDate,first_name,last_name,Original_Creditor,Account_Num,Fees,Interest,Payments,Outstanding_Balance,principal,Setc_Amunt,Savings,InterestRecal,perc,Our_File,reg_link,group_count,Charged,delinquency_date,Settlement,address,city,state,zip,Itemization_Date,listed_date,Client,Client_num,mode,debtor_status,opertator,debtor_type,contact,validation_date,debtor_Name,debtor_closed,debtor_legal,home_extension,work_extension,cell_extension,other_extension,group_filenumber,debtor_country,Responsible Party,Score,Summary,co_description");
            }
            // Add CSV headers
            //csvBuilder.AppendLine("email,RowNum,first_name,last_name,Original_Creditor,Account_Num,Fees,Interest,Payments,Outstanding_Balance,principal,Setc_Amunt,Savings,perc,Our_File,reg_link,group_count,Charged,Settlement,address1,city,state,zip,Itemization_Date,listed_date,Client,Client_num,mode,debtor_status,opertator,debtor_type,contact,validation_date,debtor_Name,debtor_closed,debtor_legal,home_extension,work_extension,cell_extension,other_extension,group_filenumber,debtor_country");

            // Add data rows
            foreach (var report in reportMailcsv)
            {
                if (!string.IsNullOrEmpty(report.Email.Trim()))
                {
                    // Create an array to store the values
                    var values = new List<string>();

                    // Append data values for each property, handling commas if present
                    values.Add(FormatValue(report.Email));
                    values.Add(FormatValue(report.RowNum));
                    values.Add(FormatValue(report.LastEmailSentDate));
                    if (!_coDes.IsNullOrEmpty() || !_coWho.IsNullOrEmpty())
                    {
                        values.Add(FormatValueCol(report.co_description));
                    }
                    values.Add(FormatValue(report.First_Name));
                    values.Add(FormatValue(report.Last_Name));
                    values.Add(FormatValue(report.Original_Creditor));
                    values.Add(FormatValue(report.Account_Num));
                    values.Add(FormatValue(report.Fees));
                    values.Add(FormatValue(report.Interest));
                    values.Add(FormatValue(report.Payments));
                    values.Add(FormatValue(report.Outstanding_Balance));
                    values.Add(FormatValue(report.Principal));
                    values.Add(FormatValue(report.Setc_Amunt));
                    values.Add(FormatValue(report.Savings));
                    values.Add(FormatValue1(report.InterestRecal));
                    values.Add(FormatValue(report.Perc));
                    values.Add(FormatValue(report.Our_File));
                    values.Add(FormatValue(report.Reg_Link));
                    values.Add(FormatValue(report.group_count));
                    values.Add(FormatValue(report.Charged));
                    values.Add(FormatValue(report.delinquency_date));
                    values.Add(FormatValue(report.Settlement));
                    values.Add(FormatValue(report.address));
                    values.Add(FormatValue(report.city));
                    values.Add(FormatValue(report.state));
                    values.Add(FormatValue(report.zip));
                    values.Add(FormatValue(report.Itemization_Date));
                    values.Add(FormatValue(report.listed_date));
                    values.Add(FormatValue(report.Client));
                    values.Add(FormatValue(report.Client_num));
                    values.Add(FormatValue(report.mode));
                    values.Add(FormatValue(report.debtor_status));
                    values.Add(FormatValue(report.Operator));
                    values.Add(FormatValue(report.debtor_type));
                    values.Add(FormatValue(report.contact));
                    values.Add(FormatValue(report.validation_date));
                    values.Add(FormatValue(report.debtor_Name));
                    values.Add(FormatValue(report.debtor_closed));
                    values.Add(FormatValue(report.debtor_legal));
                    values.Add(FormatValue(report.home_extension));
                    values.Add(FormatValue(report.work_extension));
                    values.Add(FormatValue(report.cell_extension));
                    values.Add(FormatValue(report.other_extension));
                    values.Add(FormatValue(report.group_filenumber));
                    values.Add(FormatValue(report.debtor_country));
                    values.Add(FormatValue1(report.ResponsibleParty_Email));
                    values.Add(FormatValue1(report.Score));
                    values.Add(FormatValue1(report.Summary));
                    values.Add(FormatValue1(report.co_description));

                    // Combine the values using commas and append to the CSV builder
                    csvBuilder.AppendLine(string.Join(",", values));
                }
            }
            return csvBuilder.ToString();
        }

        private string FormatValue(object value)
        {
            if (value == null || value == "")
            {
                return string.Empty;
            }

            string stringValue = value.ToString();

            if ((stringValue.Contains(",")) || (stringValue.Contains("-")) || (stringValue.Contains(" ")))
            {
                // If the value contains a comma, wrap it in double quotes
                return $"\"{stringValue}\"";
            }

            // Otherwise, return the value as is
            return stringValue;
        }

        [HttpPost("GetPortalToken")]
        public async Task<IActionResult> GetPortalToken(string FileNumber, string debtorEmail, string country, string coDescription)
        {
            try
            {
                var constrr = (string)HttpContext.Items["constr"];
                var response = await _BLL.GetPortalToken(FileNumber, debtorEmail,country, coDescription);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpPost]
        [Route("EmailWipReport")]

        public async Task<IActionResult> EmailWipReport([FromBody] WipEmail col)
        {
            try
            {
                var constrr = (string)HttpContext.Items["constr"];
                var reportMailcsv = await _BLL.WIPEmailCampaign(col, constrr);
                string csvContent = GenerateWipCampaignDynamic(reportMailcsv); // Updated to handle dynamic list
                var csvBytes = Encoding.UTF8.GetBytes(csvContent);

                // Return the CSV content as a response with Content-Type "text/csv"
                var contentDisposition = new ContentDispositionHeaderValue("attachment")
                {
                    FileName = "EmailCampaign.csv"
                };
                Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                return File(csvBytes, "text/csv");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //private string GenerateWipCampaign(List<EmailReport> reportMailcsv)
        private string GenerateWipCampaignDynamic(List<dynamic> reportMailcsv)
        {
            StringBuilder csvBuilder = new StringBuilder();

            csvBuilder.AppendLine("email,CosEmail,first_name,last_name,Original_Creditor,Account_Num,Fees,Interest,Payments,Outstanding_Balance,principal,Setc_Amunt,Savings,InterestRecal,perc,Our_File,reg_link,group_count,Charged,delinquency_date" +
                ",Settlement,address,city,state,zip,Itemization_Date,listed_date,Client,Client_num,mode,debtor_status,opertator,debtor_type,contact,validation_date,debtor_Name,debtor_closed,debtor_legal,home_extension,work_extension,cell_extension,other_extension,group_filenumber,debtor_country,User1,User2,User3,Percentage,co_description,OOS,Responsible Party,Score");




            foreach (var report in reportMailcsv)
            {

                // Create an array to store the values
                var values = new List<string>();

                // Append data values for each property, handling commas if present

                values.Add(FormatValue1(report.Email));
                values.Add(FormatValue1(report.CosEmail));
                values.Add(FormatValue1(report.First_Name));
                values.Add(FormatValue1(report.Last_Name));
                values.Add(FormatValue1(report.Original_Creditor));
                values.Add(FormatValue1(report.Account_Num));
                values.Add(FormatValue1(report.Fees));
                values.Add(FormatValue1(report.Interest));
                values.Add(FormatValue1(report.Payments));
                values.Add(FormatValue1(report.Outstanding_Balance));
                values.Add(FormatValue1(report.Principal));
                values.Add(FormatValue1(report.Setc_Amunt));
                values.Add(FormatValue1(report.Savings));
                values.Add(FormatValue1(report.InterestRecal));
                values.Add(FormatValue1(report.Perc));
                values.Add(FormatValue1(report.Our_File));
                values.Add(FormatValue1(report.Reg_Link));
                values.Add(FormatValue1(report.group_count));
                values.Add(FormatValue1(report.Charged));
                values.Add(FormatValue1(report.delinquency_date));
                values.Add(FormatValue1(report.Settlement));
                values.Add(FormatValue1(report.address));
                values.Add(FormatValue1(report.city));
                values.Add(FormatValue1(report.state));
                values.Add(FormatValue1(report.zip));
                values.Add(FormatValue1(report.Itemization_Date));
                values.Add(FormatValue1(report.listed_date));
                values.Add(FormatValue1(report.Client));
                values.Add(FormatValue1(report.Client_num));
                values.Add(FormatValue1(report.mode));
                values.Add(FormatValue1(report.debtor_status));
                values.Add(FormatValue1(report.Operator));
                values.Add(FormatValue1(report.debtor_type));
                values.Add(FormatValue1(report.contact));
                values.Add(FormatValue1(report.validation_date));
                values.Add(FormatValue1(report.debtor_Name));
                values.Add(FormatValue1(report.debtor_closed));
                values.Add(FormatValue1(report.debtor_legal));
                values.Add(FormatValue1(report.home_extension));
                values.Add(FormatValue1(report.work_extension));
                values.Add(FormatValue1(report.cell_extension));
                values.Add(FormatValue1(report.other_extension));
                values.Add(FormatValue1(report.group_filenumber));
                values.Add(FormatValue1(report.debtor_country));
                values.Add(FormatValue1(report.User1));
                values.Add(FormatValue1(report.User2));
                values.Add(FormatValue1(report.User3));
                values.Add(FormatValue1(report.Percentage));
                values.Add(FormatValue1(report.co_description));
                values.Add(FormatValue1(report.OOS));
                values.Add(FormatValue1(report.ResponsibleParty_Email));
                values.Add(FormatValue1(report.Score));

                // Combine the values using commas and append to the CSV builder
                csvBuilder.AppendLine(string.Join(",", values));

            }
            return csvBuilder.ToString();
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpPost]
        [Route("SMSCWipReport")]

        public async Task<IActionResult> SMSCWipReport([FromBody] SMSCWip col)
        {
            try
            {

                var constrr = (string)HttpContext.Items["constr"];
                List<SMSCreport> reportSMScsv = await _BLL.SMSCWipCampaign(col, constrr);
                string csvContent = GenerateSMSCWipCamp(reportSMScsv); // Generate CSV for the entire dataset
                var csvBytes = Encoding.UTF8.GetBytes(csvContent);

                // Return the CSV content as a response with Content-Type "text/csv"
                // and a Content-Disposition header for downloading
                var contentDisposition = new ContentDispositionHeaderValue("attachment")
                {
                    FileName = "EmailCampaign.csv"
                };
                Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                return File(csvBytes, "text/csv");


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        private string GenerateSMSCWipCamp(List<SMSCreport> reportSMScsv)
        {
            StringBuilder csvBuilder = new StringBuilder();

            csvBuilder.AppendLine("Name,Legal_entity,Contact,Generation,Address,Street_number,Address_OK,Addr_1,City,State,Zip,Country,Timezone,SSN,DL,DOB,Cell,Cell_extension,Email,POE,Cl.File,Orig.Cr,Client,Client_number,Acct,SKPOP,2nd_st,Legal,Charged,Delnqnt,Listed,Closed,Type,Mode,Status,Street type,Worked,Worked time,Score,Operator,Sales,Rate,Principal,Judgment,Interest,Fees,Legal fees,CF upfront costs,Legal/Atty Fees,Adjustments,Paid,Owing,Discount,Summary,Runplan,File,Group,Group_member,Payment,Next,Promise,Original Interest,Interest Date,Interest Rate,Accrued,Legal Costs,Report Credit,Edit Date,Client User 1,30 Days,60 Days,90 Days,Over 90,UID,discount,SKIP,SummaryFlags,Comm Rate Option,Commission Rate 1,Commission Rate 2,Commission Rate 3,Commission Rate 4,Tax Rate 1,Tax Rate 2,Tax Rate 3,Tax Rate 4,Tax Rate Option,Archive Date,Modified Date,Cl Bill Date,Modified Time,Speech,SMS");




            foreach (SMSCreport report in reportSMScsv)
            {

                // Create an array to store the values
                var values = new List<string>();


                values.Add(FormatValue1(report.Name));
                values.Add(FormatValue1(report.Legal_entity));
                values.Add(FormatValue1(report.Contact));
                values.Add(FormatValue1(report.Generation));
                values.Add(FormatValue1(report.Address));
                values.Add(FormatValue1(report.Street_number));
                values.Add(FormatValue1(report.Address_OK));
                values.Add(FormatValue1(report.Addr_1));
                values.Add(FormatValue1(report.City));
                values.Add(FormatValue1(report.State));
                values.Add(FormatValue1(report.Zip));
                values.Add(FormatValue1(report.Country));
                values.Add(FormatValue1(report.Timezone));
                values.Add(FormatValue1(report.SSN));
                values.Add(FormatValue1(report.DL));
                values.Add(FormatValue1(report.DOB));
                values.Add(FormatValue1(report.Cell));
                values.Add(FormatValue1(report.Cell_extension));
                values.Add(FormatValue1(report.Email));
                values.Add(FormatValue1(report.POE));
                values.Add(FormatValue1(report.Cl_File));
                values.Add(FormatValue1(report.Orig_Cr));
                values.Add(FormatValue1(report.Client));
                values.Add(FormatValue1(report.Client_number));
                values.Add(FormatValue1(report.Acct));
                values.Add(FormatValue1(report.SKPOP));
                values.Add(FormatValue1(report.nd_st));
                values.Add(FormatValue1(report.Legal));
                values.Add(FormatValue1(report.Charged));
                values.Add(FormatValue1(report.Delnqnt));
                values.Add(FormatValue1(report.Listed));
                values.Add(FormatValue1(report.Closed));
                values.Add(FormatValue1(report.Type));
                values.Add(FormatValue1(report.Mode));
                values.Add(FormatValue1(report.Status));
                values.Add(FormatValue1(report.Street_type));
                values.Add(FormatValue1(report.Worked));
                values.Add(FormatValue1(report.Worked_time));
                values.Add(FormatValue1(report.Score));
                values.Add(FormatValue1(report.Operator));
                values.Add(FormatValue1(report.Sales));
                values.Add(FormatValue1(report.Rate));
                values.Add(FormatValue1(report.Principal));
                values.Add(FormatValue1(report.Judgment));
                values.Add(FormatValue1(report.Interest));
                values.Add(FormatValue1(report.Fees));
                values.Add(FormatValue1(report.Legal_fees));
                values.Add(FormatValue1(report.CF_upfront_costs));
                values.Add(FormatValue1(report.Legal_Atty_Fees));
                values.Add(FormatValue1(report.Adjustments));
                values.Add(FormatValue1(report.Paid));
                values.Add(FormatValue1(report.Owing));
                values.Add(FormatValue1(report.Discount));
                values.Add(FormatValue1(report.Summary));
                values.Add(FormatValue1(report.Runplan));
                values.Add(FormatValue1(report.File));
                values.Add(FormatValue1(report.Group));
                values.Add(FormatValue1(report.Group_member));
                values.Add(FormatValue1(report.Payment));
                values.Add(FormatValue1(report.Next));
                values.Add(FormatValue1(report.Promise));
                values.Add(FormatValue1(report.Original_Interest));
                values.Add(FormatValue1(report.Interest_Date));
                values.Add(FormatValue1(report.Interest_Rate));
                values.Add(FormatValue1(report.Accrued));
                values.Add(FormatValue1(report.Legal_Costs));
                values.Add(FormatValue1(report.Report_Credit));
                values.Add(FormatValue1(report.Edit_Date));
                values.Add(FormatValue1(report.Client_User_1));
                values.Add(FormatValue1(report.Days30));
                values.Add(FormatValue1(report.Days60));
                values.Add(FormatValue1(report.Days90));
                values.Add(FormatValue1(report.Over90));
                values.Add(FormatValue1(report.UID));
                values.Add(FormatValue1(report.Discount1));
                values.Add(FormatValue1(report.SKIP));
                values.Add(FormatValue1(report.Summary_Flags));
                values.Add(FormatValue1(report.Comm_Rate_Option));
                values.Add(FormatValue1(report.Commission_Rate_1));
                values.Add(FormatValue1(report.Commission_Rate_2));
                values.Add(FormatValue1(report.Commission_Rate_3));
                values.Add(FormatValue1(report.Commission_Rate_4));
                values.Add(FormatValue1(report.Tax_Rate_1));
                values.Add(FormatValue1(report.Tax_Rate_2));
                values.Add(FormatValue1(report.Tax_Rate_3));
                values.Add(FormatValue1(report.Tax_Rate_4));
                values.Add(FormatValue1(report.Tax_Rate_Option));
                values.Add(FormatValue1(report.Archive_Date));
                values.Add(FormatValue1(report.Modified_Date));
                values.Add(FormatValue1(report.Cl_Bill_Date));
                values.Add(FormatValue1(report.Modified_Time));
                values.Add(FormatValue1(report.Speech));
                values.Add(FormatValue1(report.SMS));


                csvBuilder.AppendLine(string.Join(",", values));

            }
            return csvBuilder.ToString();
        }

        /// ////////////////////////////////////////////////////////////////////////////////

        private string FormatValue1(object value)
        {
            if (value == null || value == "")
            {
                return string.Empty;
            }

            string stringValue = value.ToString();

            if ((stringValue.Contains(",")) || (stringValue.Contains("-")) || (stringValue.Contains(" ")))
            {
                // If the value contains a comma, wrap it in double quotes
                return $"\"{stringValue}\"";
            }

            // Otherwise, return the value as is
            return stringValue;
        }


    }

}


