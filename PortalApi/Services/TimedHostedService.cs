//using Newtonsoft.Json;
//using System.Net.Mail;
//using System.Net.Mime;
//using System.Net;
//using System.Text;
//using CsvHelper;
//using System.Globalization;
//using System.IO.Compression;

//namespace PortalApi.Services
//{
//    public class TimedHostedService : IHostedService, IDisposable
//    {
//        private int executionCount = 0;
//        private readonly ILogger<TimedHostedService> _logger;
//        private Timer? _timer = null;
//        private readonly IHttpClientFactory _httpClientFactory;

//        public TimedHostedService(ILogger<TimedHostedService> logger, IHttpClientFactory httpClientFactory)
//        {
//            _logger = logger;
//            _httpClientFactory = httpClientFactory;
//        }

//        public Task StartAsync(CancellationToken stoppingToken)
//        {
//            _logger.LogInformation("Timed Hosted Service running.");

//            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(600));

//            return Task.CompletedTask;

//            //_logger.LogInformation("Timed Hosted Service running.");

//            //// Calculate the time until the next Monday at 4 am
//            //var now = DateTime.Now;
//            //int daysUntilMonday = ((int)DayOfWeek.Monday - (int)now.DayOfWeek + 7) % 7;
//            //DateTime nextMondayAt4AM = new DateTime(now.Year, now.Month, now.Day, 4, 0, 0).AddDays(daysUntilMonday);

//            //// Calculate the time interval between now and the next Monday at 4 am
//            //var delay = nextMondayAt4AM - now;

//            //_timer = new Timer(DoWork, null, delay, TimeSpan.FromDays(7)); // Repeat every 7 days (1 week)

//            //return Task.CompletedTask;
//        }

//        private async void DoWork(object? state)
//        {
//            string apiEndpoint = "https://portal.collectco.com/CampaignReportApi/ColReportcsv";

//            var parameters = new
//            {
//                ld_in = "true",
//                ld = DateTime.Parse("2013-01-01"),
//                ld_1 = DateTime.Now.Date,
//                sectorL = "MED",
//                st = "ACT,BPR,HOT,NLST,NW1",
//                st_in = "true",
//                state = "WA,MA,NY",
//                cl_num_in = "false",
//                cl_num = "25490",
//                Channel = "HOME",
//                coun = "United States",
//                coun_in = "true",
//                reg_f = "true",
//                csv = "true"

//            };

//            using var client = _httpClientFactory.CreateClient();
//            client.Timeout = TimeSpan.FromMinutes(5);

//            // Create a StringContent with JSON data
//            string jsonParameters = JsonConvert.SerializeObject(parameters);

//            using var content = new StringContent(jsonParameters, Encoding.UTF8, "application/json");
//            try
//            {
//                HttpResponseMessage response = await client.PostAsync(apiEndpoint, content);

//                if (response.IsSuccessStatusCode)
//                {
//                    try
//                    {
//                        var zipFilePath = "C:\\Users\\MMalik\\Drake Malfoy\\Projects\\PortalWebApis\\PortalApi\\report_data.zip";
//                        using var responseStream = await response.Content.ReadAsStreamAsync();
//                        using var fileStream = File.Create(zipFilePath);
//                        using var zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Create);

//                        await responseStream.CopyToAsync(fileStream);
//                        fileStream.Close(); // Ensure all data is written to the file

//                        _logger.LogInformation($"CSV response saved in '{zipFilePath}'");
//                        SendEmailWithAttachment(zipFilePath);
//                    }
//                    catch (Exception ex)
//                    {
//                        _logger.LogError($"An error occurred while saving the file: {ex.Message}");
//                    }
//                }
//                else
//                {
//                    _logger.LogError($"API call failed with status code {response.StatusCode}");
//                }
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex, "Error in DoWork.");
//            }
//        }
//        private void SendEmailWithAttachment(string attachmentFilePath)
//        {
//            using var smtpClient = new SmtpClient("smtp.office365.com")
//            {
//                Port = 587,
//                Credentials = new NetworkCredential("mmalik@cedarfinancial.com", "Cedar@123"),
//                EnableSsl = true,
//            };

//            using var message = new MailMessage
//            {
//                From = new MailAddress("mmalik@cedarfinancial.com"),
//                Subject = "CSV Report",
//                Body = "Please find attached the CSV report.",
//                IsBodyHtml = false,
//            };

//            try
//            {
//                using var attachmentStream = OpenFileWithRetries(attachmentFilePath, FileMode.Open, FileAccess.Read, maxRetries: 5, retryDelayMilliseconds: 1000);
//                if (attachmentStream != null)
//                {
//                    using var attachment = new Attachment(attachmentStream, "CSV Report.csv", MediaTypeNames.Application.Octet);
//                    ContentDisposition disposition = attachment.ContentDisposition;
//                    disposition.CreationDate = File.GetCreationTime(attachmentFilePath);
//                    disposition.ModificationDate = File.GetLastWriteTime(attachmentFilePath);
//                    disposition.ReadDate = File.GetLastAccessTime(attachmentFilePath);
//                    message.Attachments.Add(attachment);

//                    message.To.Add("zshaikh@cedarfinancial.com");

//                    smtpClient.Send(message);
//                    _logger.LogInformation("Email sent with CSV attachment.");
//                }
//                else
//                {
//                    _logger.LogError("Failed to open the CSV file for attachment after retries.");
//                }
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex, "Error sending email with attachment.");
//            }
//        }
//        private FileStream OpenFileWithRetries(string filePath, FileMode mode, FileAccess access, int maxRetries, int retryDelayMilliseconds)
//        {
//            for (int retryCount = 0; retryCount < maxRetries; retryCount++)
//            {
//                try
//                {
//                    return new FileStream(filePath, mode, access);
//                }
//                catch (IOException)
//                {
//                    // File is locked, wait and then retry
//                    Thread.Sleep(retryDelayMilliseconds);
//                }
//            }

//            // If we reach this point, the maximum number of retries has been reached
//            return null; // Indicate that the file couldn't be opened
//        }
//        public Task StopAsync(CancellationToken stoppingToken)
//        {
//            _logger.LogInformation("Timed Hosted Service is stopping.");

//            _timer?.Change(Timeout.Infinite, 0);

//            return Task.CompletedTask;
//        }

//        public void Dispose()
//        {
//            _timer?.Dispose();
//        }

//    }
//}
