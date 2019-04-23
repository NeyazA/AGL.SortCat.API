using AGL.Sortcat.Utility;
using AGL.SortCat.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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
                string OwnerResultStream;
                Dictionary<string, string> _headerDetails = new Dictionary<string, string>();
                _headerDetails.Add("User-Agent", ConfigurationManager.AppSettings[Constants.ExtApiUserAgent].ToString());
                OwnerResultStream = APIHandler.GetAPIResult(ConfigurationManager.AppSettings[Constants.ApiUrl], _headerDetails);
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };
                return JsonConvert.DeserializeObject<List<PetOwner>>(OwnerResultStream, settings);
            }
            catch (Exception ex)
            {
                Logging.HandleException(ex);
                throw;
            }
        }
    }

    
}
