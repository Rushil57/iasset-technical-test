using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iasset_technical_test.Services
{
    public interface IWeatherData
    {
        List<string> GetCitiesData(string country);
    }
}
