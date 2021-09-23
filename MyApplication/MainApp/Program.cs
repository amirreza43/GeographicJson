using System;
using System.Collections.Generic;
using AppLibrary;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var positions = Class1.GetDataFromHttp().GetAwaiter().GetResult();

            foreach (var item in positions)
            {
            }
            try
            {
                var x = searchByName(positions, "Disneyland");
                var y = searchByLatitude(positions, 25.1212);
                Console.WriteLine(x);
                Console.WriteLine(y);
                    
            }
            catch (ArgumentException ex)
            {
                
                Console.WriteLine(ex.Message);
            }
            
        }

        static GeoData searchByName(List<GeoData> geoData, string name1) => name1 switch
                {
                    "Grocery Store" => geoData[0],
                    "Gas Station" => geoData[1],
                    "Disneyland" => geoData[2],
                    _ => throw new ArgumentException("Name not found"),
                };
        static GeoData searchByLatitude(List<GeoData> geoData, double lat) => lat switch
                {
                    25.1212 => geoData[0],
                    12.3456 => geoData[1],
                    4.8765 => geoData[2],
                    _ => throw new ArgumentException("lat not found"),
                };
    }
}
