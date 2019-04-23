using AGL.Sortcat.Utility;
using AGL.SortCat.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AGL.SortCat.Service
{
    public class OwnerService: IOwnerService
    {
        public IEnumerable<PetOwner> GetAllOwners()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
                    var response = httpClient.GetStringAsync(new Uri(ConfigurationManager.AppSettings[Constants.ApiUrl])).Result;
                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
                    return JsonConvert.DeserializeObject<List<PetOwner>>(response, settings);
                }
            }
           
            catch (Exception ex)
            {
                Logging.HandleException(ex);
                throw;
            }
        }
    }

    
}
