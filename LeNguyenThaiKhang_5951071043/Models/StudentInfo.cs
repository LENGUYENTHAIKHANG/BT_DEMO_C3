using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace LeNguyenThaiKhang_5951071043.Models
{
    [DataContract]
    public class StudentInfo
    {
        
            [DataMember(Name = "id")]
            public string id { get; set; }
            [DataMember(Name = "msv")]
            public string msv { get; set; }
            [DataMember(Name = "sdt")]
            public string sdt { get; set; }
        
    }
}