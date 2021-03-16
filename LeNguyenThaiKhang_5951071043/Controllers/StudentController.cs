using LeNguyenThaiKhang_5951071043.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Net.Http;

namespace LeNguyenThaiKhang_5951071043.Controllers
{
    public class StudentController : ApiController
    {

        public IEnumerable<StudentInfo> Get()
        {
            var StudentList = new List<StudentInfo>();
            for (int i = 1; i <9; i++)
            {
                
                var Student = new StudentInfo
                {
                    id = i.ToString(),
                    msv = $"595107104{ i +1}",
                    sdt = $"0" + $"{ i + 5}" + $"{ i + 7}" + $"{ i + 3}" + $"{ i + 7}" + $"{ i + 1}" + $"{ i + 4}" + $"{ i + 1}" + $"{ i + 3}" + $"{ i + 2}"

                };
                StudentList.Add(Student);

            }
            return StudentList; ;
        }
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                id = $"số thứ tự: {id.ToString()}",
                msv = $"595107104{id+1}",
                sdt = $"0" + $"{ id + 5}" + $"{ id + 7}" + $"{ id + 3}" + $"{ id + 7}" + $"{ id + 1}" + $"{ id + 4}" + $"{ id + 1}" + $"{ id + 3}" + $"{ id + 2}"
            };
        }
    
    }
   
}
