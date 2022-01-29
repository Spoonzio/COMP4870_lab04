
using lab4.Models;

namespace lab4.Data;

public class SampleData {
  public static List<Province> GetProvinces() {
      
      List<Province> provinces = new List<Province>() {
        new Province() {
            ProvinceCode = "BC",
            ProvinceName = "British Columbia",
        },
        new Province() {
            ProvinceCode = "QC",
            ProvinceName = "Quebec",
        },
        new Province() {
            ProvinceCode = "AB",
            ProvinceName = "Alberta",
        }
      };

      return provinces;
  }

  public static List<City> GetCities() {
      List<City> cities = new List<City>() {
         new City {
             CityId = 1,
             CityName = "Vancouver",
             Population = 10000,
             ProvinceCode = "BC"
         },
         new City {
             CityId = 2,
             CityName = "Richmond",
             Population = 5000,
             ProvinceCode = "BC"
         },
         new City {
             CityId = 3,
             CityName = "Coquitlam",
             Population = 7000,
             ProvinceCode = "BC"
         },
        new City {
             CityId = 4,
             CityName = "Quebec City",
             Population = 10000,
             ProvinceCode = "QC"
         },
         new City {
             CityId = 5,
             CityName = "Montreal",
             Population = 5000,
             ProvinceCode = "QC"
         },
         new City {
             CityId = 6,
             CityName = "Sherbrooke",
             Population = 7000,
             ProvinceCode = "QC"
         },
                 new City {
             CityId = 7,
             CityName = "Ottawa",
             Population = 10000,
             ProvinceCode = "ON"
         },
         new City {
             CityId = 8,
             CityName = "Mississauga",
             Population = 5000,
             ProvinceCode = "ON"
         },
         new City {
             CityId = 9,
             CityName = "Toronto",
             Population = 7000,
             ProvinceCode = "ON"
         }
      };

      return cities;
  }

}