using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestAPIClient
{
    public class Contract
    {
        public string name { get; set; }
        public string commercial_name { get; set; }
        public string country_code { get; set; }
        public string[] cities { get; set; }

        public Contract(string name, string commercialName, string countryCode, string[] cities)
        {
            this.name = name;
            commercial_name = commercialName;
            country_code = countryCode;
            this.cities = cities;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string CommercialName
        {
            get => commercial_name;
            set => commercial_name = value;
        }

        public string CountryCode
        {
            get => country_code;
            set => country_code = value;
        }

        public string[] Cities
        {
            get => cities;
            set => cities = value;
        }

        public override string ToString()
        {
            string citiesString = "";
            if (cities != null)
            {
                foreach (string city in cities)
                {
                    citiesString += city + "\n";
                }
            }

            return "Name : " + name +
                   "Commercial name : " + commercial_name +
                   "Country code : " + country_code +
                   "Cities : " + citiesString;

        }
    }
}
