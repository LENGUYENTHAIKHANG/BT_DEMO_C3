using LeNguyenThaiKhang_5951071043.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Net.Http;





namespace LeNguyenThaiKhang_5951071043.Controllers
{
    public class WeatherController : ApiController
    {
        public IEnumerable<WeatherInfo> Get()
        {
            var weatherInfList = new List<WeatherInfo>();
            for (int i = 0; i < 10; i++)
            {
                var WeatherInfo = new WeatherInfo
                {
                    location = $"Location {i}",
                    degree = i * 23 / 17,
                    datetime = DateTime.Now.ToUniversalTime()
                };
                weatherInfList.Add(WeatherInfo);
            }
            return weatherInfList;
        }
        public WeatherInfo Get(int id)
        {
            return new WeatherInfo
            {
                location = $"Location {id}",
                degree = id * 23 / 17,
                datetime = DateTime.Now.ToUniversalTime()
            }; ;
        }
    }
}
