using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work_17_Starov
{
    internal struct Weather
    {
        public string City { get; set; }
        public double? Temperature { get; set; }

        public override string ToString()
        {
            string tempString = Temperature.HasValue
                ? $"{Temperature.Value}°C"
                : "Нет данных";

            return $"{City}: {tempString}";
        }
    }
}
