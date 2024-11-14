using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using WebApiBravo.Models;



namespace WEBAPI_Bravo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CmsDataAvayaController : ControllerBase
    {
        private readonly BravoContext _context;
        private readonly IConfiguration _configuration;
        private readonly IHostEnvironment _environment;

        public CmsDataAvayaController(BravoContext context, IConfiguration configuration, IHostEnvironment environment)
        {
            _context = context;
            _configuration = configuration;
            _environment = environment;
        }



        [HttpGet("BawasluGetTodayCallStatus")]
        public async Task<IActionResult> BawasluGetTodayCallStatus()
        {
            var users = new List<dailyHistory>();

            try
            {
                var filePath = Path.Combine(_environment.ContentRootPath, "DataAvaya", "Daily.txt");

                if (!System.IO.File.Exists(filePath))
                {
                    return NotFound("File not found.");
                }

                // Read all lines from the file
                string[] lines = System.IO.File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    return NotFound("File is empty.");
                }

                // Split the first line (header) by semicolon to get the column names
                string[] headers = lines[0].Split(';');

                var records = new List<DailyHistory>();

                foreach (var line in lines.Skip(2))
                {
                    // Skip empty lines
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Split each line by semicolons
                    var fields = line.Split(';');

                    // Create a new CallStats object and populate it from the CSV fields
                    var callStats = new DailyHistory
                    {
                        SplitSkill = fields[0].Trim(),
                        SkillState = fields[1].Trim(),
                        AgentsStaffed = int.Parse(fields[2].Trim()),
                        AvgAbanTime = double.Parse(fields[3].Trim()),
                        AbanCalls = int.Parse(fields[4].Trim()),
                        AvgACDTime = double.Parse(fields[5].Trim()),
                        ACDCalls = int.Parse(fields[6].Trim()),
                        AvgSpeedAns = double.Parse(fields[7].Trim()),
                        //  TotalIACDACW = double.Parse(fields[8].Trim()),
                        //PercentAnsCalls = int.Parse(fields[9].Trim()),
                        //PercentAbanCalls = int.Parse(fields[10].Trim()),
                        PercentACDTime = int.Parse(fields[11].Trim()),
                        AUXINCALLS = int.Parse(fields[12].Trim()),
                        AgentsAvail = int.Parse(fields[13].Trim()),
                        ACCEPTABLE = int.Parse(fields[14].Trim()),
                        RINGTIME = int.Parse(fields[15].Trim()),
                        CallsWaiting = int.Parse(fields[16].Trim()),
                        //PercentAccep = int.Parse(fields[17].Trim()),
                        AvgACWTime = double.Parse(fields[18].Trim()),
                        CallsOffered = int.Parse(fields[19].Trim()),
                       // ACWINCALLS = int.Parse(fields[20].Trim()),
                       // AgentsInAUX = int.Parse(fields[21].Trim()),
                        AgentsOnACDCalls = int.Parse(fields[22].Trim()),
                        INQUEUE = int.Parse(fields[23].Trim()),
                        OldestCallWaiting = int.Parse(fields[24].Trim()),
                        ACDTime = double.Parse(fields[25].Trim()),
                        //ACWTime = double.Parse(fields[26].Trim())
                    };

                    records.Add(callStats);
                }
                // Add the record to the list
                
                

                // Convert the list of records to JSON
                string json = JsonConvert.SerializeObject(records, Formatting.Indented);

                return Ok(json);
            }
            catch (Exception ex)
            {
                // In case of any error, return a 500 status code with the error message
                return StatusCode(500, "Internal server error: " + ex.Message);
            }

        }
        [HttpGet("BawasluGetAgentStatus")]
        public async Task<IActionResult> BawasluGetAgentStatus()
        {
            var users = new List<ListAgent>();

            try
            {
                var filePath = Path.Combine(_environment.ContentRootPath, "DataAvaya", "Agent_Activity.txt");

                if (!System.IO.File.Exists(filePath))
                {
                    return NotFound("File not found.");
                }

                // Read all lines from the file
                string[] lines = System.IO.File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    return NotFound("File is empty.");
                }

                // Split the first line (header) by semicolon to get the column names
                string[] headers = lines[0].Split(';');

                var records = new List<ListAgent>();

                foreach (var line in lines.Skip(2))
                {
                    // Skip empty lines
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Split each line by semicolons
                    var fields = line.Split(';');


                   // ; Agent Name; Login ID; Extn; AUX Reason; State; Split /
                    // Create a new CallStats object and populate it from the CSV fields
                    var callStats = new ListAgent
                    {
                        AgentName = fields[1].Trim(),
                        LoginID = fields[2].Trim(),
                        Extn = fields[3].Trim(),
                        AUXReason = fields[4].Trim(),
                        Status = fields[5].Trim(),
                        Time = fields[7].Trim(),
                       
                    };

                    records.Add(callStats);
                }
                // Add the record to the list



                // Convert the list of records to JSON
                string json = JsonConvert.SerializeObject(records, Formatting.Indented);

                return Ok(json);
            }
            catch (Exception ex)
            {
                // In case of any error, return a 500 status code with the error message
                return StatusCode(500, "Internal server error: " + ex.Message);
            }

        }
        [HttpGet("BawasluGetIncomingCall")]
        public async Task<IActionResult> BawasluGetIncomingCall()
        {
            var users = new List<InComingCall>();

            try
            {
                var filePath = Path.Combine(_environment.ContentRootPath, "DataAvaya", "Daily.txt");

                if (!System.IO.File.Exists(filePath))
                {
                    return NotFound("File not found.");
                }

                // Read all lines from the file
                string[] lines = System.IO.File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    return NotFound("File is empty.");
                }

                // Split the first line (header) by semicolon to get the column names
                string[] headers = lines[0].Split(';');

                var records = new List<InComingCall>();

                foreach (var line in lines.Skip(2))
                {
                    // Skip empty lines
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Split each line by semicolons
                    var fields = line.Split(';');


                    var callStats = new InComingCall
                    {

        //            

                        
                        AnswerCall = fields[6].Trim(),
                       // PercentAnswerCall = fields[9].Trim(),
                        Received = (int.Parse(fields[4].Trim()) + int.Parse(fields[6].Trim())).ToString(),
                        //PercentReceived = (int.Parse(fields[9].Trim()) + int.Parse(fields[10].Trim())).ToString(),
                        Queue = fields[24].Trim(),
                        PercentQueue = "0",
                        onProgress = fields[23].Trim(),
                        Total = (int.Parse(fields[6].Trim()) + int.Parse(fields[4].Trim()) + int.Parse(fields[23].Trim())).ToString()
                      //  Total = (int.Parse(fields[6].Trim()) + int.Parse(fields[4].Trim()) + int.Parse(fields[23].Trim())).ToString()


                    };

                    records.Add(callStats);
                }
                // Add the record to the list



                // Convert the list of records to JSON
                string json = JsonConvert.SerializeObject(records, Formatting.Indented);

                return Ok(json);
            }
            catch (Exception ex)
            {
                // In case of any error, return a 500 status code with the error message
                return StatusCode(500, "Internal server error: " + ex.Message);
            }

        }

        [HttpGet("BawasluGetTotalAnswerStatistik")]
        public async Task<IActionResult> BawasluGetTotalAnswerStatistik()
        {
            var users = new List<dtoCallStatistik>();

            try
            {
                var filePath = Path.Combine(_environment.ContentRootPath, "DataAvaya", "Daily.txt");

                if (!System.IO.File.Exists(filePath))
                {
                    return NotFound("File not found.");
                }

                // Read all lines from the file
                string[] lines = System.IO.File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    return NotFound("File is empty.");
                }

                // Split the first line (header) by semicolon to get the column names
                string[] headers = lines[0].Split(';');

                var records = new List<dtoCallStatistik>();

                foreach (var line in lines.Skip(2))
                {
                    // Skip empty lines
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Split each line by semicolons
                    var fields = line.Split(';');


                    var callStats = new dtoCallStatistik
                    {

                       
                        Answer = fields[26].Trim().Replace(".",":"),
                        Abandon = fields[28].Trim().Replace(".", ":"),
                        //Recieve = datetime.strptime(fields[28].Trim(), "%H:%M:%S")
                        Recieve = fields[28].Trim().Replace(".", ":"),
                        // PercentAnswerCall = fields[9].Trim(),
                        //Received = (int.Parse(fields[4].Trim()) + int.Parse(fields[6].Trim())).ToString(),
                        ////PercentReceived = (int.Parse(fields[9].Trim()) + int.Parse(fields[10].Trim())).ToString(),
                        //Queue = fields[24].Trim(),
                        //PercentQueue = "0",
                        //onProgress = fields[23].Trim(),
                        //Total = (int.Parse(fields[6].Trim()) + int.Parse(fields[4].Trim()) + int.Parse(fields[23].Trim())).ToString()
                        ////  Total = (int.Parse(fields[6].Trim()) + int.Parse(fields[4].Trim()) + int.Parse(fields[23].Trim())).ToString()


                    };

                    records.Add(callStats);
                }
                // Add the record to the list



                // Convert the list of records to JSON
                string json = JsonConvert.SerializeObject(records, Formatting.Indented);

                return Ok(json);
            }
            catch (Exception ex)
            {
                // In case of any error, return a 500 status code with the error message
                return StatusCode(500, "Internal server error: " + ex.Message);
            }

        }

        [HttpGet("BawasluGetCallPerpormance")]
        public async Task<IActionResult> BawasluGetCallPerpormance()
        {
            var users = new List<AvgAgentStatus>();

            try
            {
                var filePath = Path.Combine(_environment.ContentRootPath, "DataAvaya", "Daily.txt");

                if (!System.IO.File.Exists(filePath))
                {
                    return NotFound("File not found.");
                }

                // Read all lines from the file
                string[] lines = System.IO.File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    return NotFound("File is empty.");
                }

                // Split the first line (header) by semicolon to get the column names
                string[] headers = lines[0].Split(';');

                var records = new List<AvgAgentStatus>();

                foreach (var line in lines.Skip(2))
                {
                    // Skip empty lines
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Split each line by semicolons
                    var fields = line.Split(';');


                    var callStats = new AvgAgentStatus
                    {


                        avgTalkTime = fields[7].Trim(),
                        avgWaitTime = fields[19].Trim().Replace(".", ":"),
                        LogestTalkTime = fields[25].Trim().Replace(".", ":"),
                        LogestWaitTime = fields[28].Trim().Replace(".", ":"),
                      

                    };

                    records.Add(callStats);
                }
                // Add the record to the list



                // Convert the list of records to JSON
                string json = JsonConvert.SerializeObject(records, Formatting.Indented);

                return Ok(json);
            }
            catch (Exception ex)
            {
                // In case of any error, return a 500 status code with the error message
                return StatusCode(500, "Internal server error: " + ex.Message);
            }

        }

        [HttpGet("BawasluGetLiveAgentStatus")]
        public async Task<IActionResult> BawasluGetLiveAgentStatus()
        {
           

            var users = new List<ListAgent>();

            try
            {
                var filePath = Path.Combine(_environment.ContentRootPath, "DataAvaya", "Agent_Activity.txt");

                if (!System.IO.File.Exists(filePath))
                {
                    return NotFound("File not found.");
                }

                // Read all lines from the file
                string[] lines = System.IO.File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    return NotFound("File is empty.");
                }

                // Split the first line (header) by semicolon to get the column names
                string[] headers = lines[0].Split(';');

                var records = new List<ListAgent>();

                foreach (var line in lines.Skip(2))
                {
                    // Skip empty lines
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Split each line by semicolons
                    var fields = line.Split(';');


                    // ; Agent Name; Login ID; Extn; AUX Reason; State; Split /
                    // Create a new CallStats object and populate it from the CSV fields
                    var callStats = new ListAgent
                    {
                        AgentName = fields[1].Trim(),
                        LoginID = fields[2].Trim(),
                        Extn = fields[3].Trim(),
                        AUXReason = fields[4].Trim(),
                        Status = fields[5].Trim(),
                        Time = fields[7].Trim(),

                    };

                    records.Add(callStats);
                }
                // Add the record to the list

                var callStatsCount = new LiveListAgent
                {
                    TotalAgent = records.ToList().Count().ToString(),
                    TotalAvalibale = records.ToList().Where(x => x.Status == "AVAIL").Count().ToString(),
                    TotalBusy = records.ToList().Where(x => x.Status != "AVAIL").Count().ToString(),
                   

                };

                // Convert the list of records to JSON
                string json = JsonConvert.SerializeObject(callStatsCount, Formatting.Indented);

                return Ok(json);
            }
            catch (Exception ex)
            {
                // In case of any error, return a 500 status code with the error message
                return StatusCode(500, "Internal server error: " + ex.Message);
            }

        }
        [HttpGet("BawasluGetDailyCallHistory")]
        public async Task<List<dailyHistory>> GetDailyCallHistory()
        {
            var users = new List<dailyHistory>();
            var connectionString = _configuration.GetConnectionString("DefaultConnection2");

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "EXEC DailyHistory"; // Your stored procedure or query
                        command.CommandType = CommandType.Text;

                        using (var result = await command.ExecuteReaderAsync())
                        {
                            while (await result.ReadAsync())
                            {
                                users.Add(new dailyHistory
                                {
                                    Hari = result.GetString(0),
                                    Answer = result.GetDecimal(2),
                                    Abandon = result.GetDecimal(3),
                                    Resolved = result.GetDecimal(4)

                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"An error occurred: {sqlEx.Message}");
                return new List<dailyHistory>(); // Or throw
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<dailyHistory>(); // Or throw
            }

            return users;
        }
        [HttpGet("BawasluGetWeeklylHistory")]
        public async Task<List<dailyHistory>> GetWeeklylHistory()
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection2");
            var users = new List<dailyHistory>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "EXEC WeeklyHistory"; // Your stored procedure or query
                        command.CommandType = CommandType.Text;

                        using (var result = await command.ExecuteReaderAsync())
                        {
                            while (await result.ReadAsync())
                            {
                                users.Add(new dailyHistory
                                {
                                    Hari = result.GetString(0),
                                    Answer = result.GetDecimal(2),
                                    Abandon = result.GetDecimal(3),
                                    Resolved = result.GetDecimal(4)

                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"An error occurred: {sqlEx.Message}");
                return new List<dailyHistory>(); // Or throw
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<dailyHistory>(); // Or throw
            }

            return users;
        }
    

        [HttpGet("BawasluGetmontlylHistory")]
        public async Task<List<dailyHistory>> GetmontlylHistory()
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection2");
            var users = new List<dailyHistory>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "EXEC montly5History"; // Your stored procedure or query
                        command.CommandType = CommandType.Text;

                        using (var result = await command.ExecuteReaderAsync())
                        {
                            while (await result.ReadAsync())
                            {
                                users.Add(new dailyHistory
                                {
                                    Hari = result.GetString(2),
                                    Answer = result.GetDecimal(3),
                                    Abandon = result.GetDecimal(4),
                                    Resolved = result.GetDecimal(5)

                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"An error occurred: {sqlEx.Message}");
                return new List<dailyHistory>(); // Or throw
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<dailyHistory>(); // Or throw
            }

            return users;
        }


    }

   



 
    
    public class dailyHistory
    {
        public string Hari { get; set; }
        public Decimal Answer { get; set; }
        public Decimal Abandon { get; set; }
        public Decimal Resolved { get; set; }
        
    }

    public class dtoCallStatistik
    {
        public string Recieve { get; set; }
        public string Answer { get; set; }
        public string Abandon { get; set; }
       

    }

    public class AvgAgentStatus
    {
        public string avgTalkTime { get; set; }
        public string avgWaitTime { get; set; }
        public string LogestTalkTime { get; set; }
        public string LogestWaitTime { get; set; }


    }
    public class InComingCall
    {
        public string Total { get; set; }
        public string AnswerCall { get; set; }
        public string PercentAnswerCall { get; set; }
        public string Received { get; set; }
        public string PercentReceived { get; set; }
        public string Queue { get; set; }
        public string PercentQueue { get; set; }
        public string onProgress { get; set; }
        public string PercentonProgress { get; set; }

    }


    //  // ; ; Login ID; Extn; AUX Reason; State; Split /
    public class LiveListAgent
    {
        public string TotalAgent { get; set; }
        public string TotalAvalibale { get; set; }
        public string TotalBusy { get; set; }
      

    }
    public class ListAgent
    {
        public string AgentName { get; set; }
        public string LoginID { get; set; }
        public string Extn { get; set; }
        public string AUXReason { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }

    }
    public class DailyHistory
    {
        public string SplitSkill { get; set; }
        public string SkillState { get; set; }
        public int AgentsStaffed { get; set; }
        public double AvgAbanTime { get; set; }
        public int AbanCalls { get; set; }
        public double AvgACDTime { get; set; }
        public int ACDCalls { get; set; }
        public double AvgSpeedAns { get; set; }
        public double TotalIACDACW { get; set; }
        public int PercentAnsCalls { get; set; }
        public int PercentAbanCalls { get; set; }
        public int PercentACDTime { get; set; }
        public int AUXINCALLS { get; set; }
        public int AgentsAvail { get; set; }
        public int ACCEPTABLE { get; set; }
        public double RINGTIME { get; set; }
        public int CallsWaiting { get; set; }
        public double PercentAccep { get; set; }
        public double AvgACWTime { get; set; }
        public int CallsOffered { get; set; }
        public int ACWINCALLS { get; set; }
        public int AgentsInAUX { get; set; }
        public int AgentsOnACDCalls { get; set; }
        public int INQUEUE { get; set; }
        public int OldestCallWaiting { get; set; }
        public double ACDTime { get; set; }
        public double ACWTime { get; set; }
    }

}




