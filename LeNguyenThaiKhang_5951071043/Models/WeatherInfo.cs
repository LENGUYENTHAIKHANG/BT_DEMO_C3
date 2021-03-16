using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace LeNguyenThaiKhang_5951071043.Models
{
    [DataContract]
    public class WeatherInfo
    {
        [DataMember(Name = "location")]
        public string location { get; set; }
        [DataMember(Name = "degree")]
        public float degree { get; set; }
        [DataMember(Name = "datetime")]
        public DateTime datetime { get; set; }


    }
   
}