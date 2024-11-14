using System;

namespace WEBAPI_Bravo.Model
{
    public class SmlCustomerChannel
    {
      
            public int ID { get; set; }
            public string CustomerID { get; set; }
            public string FlagChannel { get; set; }
            public string ValueChannel { get; set; }
            public DateTime? DateCreate { get; set; }
            public string UserCreate { get; set; }
            public DateTime? DateUpdate { get; set; }
            public string UserUpdate { get; set; }
            public string Status { get; set; }
       
    }
}
