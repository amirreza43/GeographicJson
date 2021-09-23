using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AppLibrary
{
    public record GeoData(string name, double[] position);
    public class Class1
    {
        
        public static async Task<List<GeoData>> GetDataFromHttp(){

            var client = new HttpClient();
            var positions = await client.GetFromJsonAsync<List<GeoData>>("https://raw.githubusercontent.com/chyld/datasets/main/markers.json");

            // if( positions != TaskStatus.RanToCompletion) throw new Exception("Json Error");

            return positions;
        }


    }
}
