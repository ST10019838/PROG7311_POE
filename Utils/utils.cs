using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ST10019838_DamianDare_PROG7311_POE.Utils
{
    public class Utils
    {
        public static string ShortenString(string s)
        {
            return s.Length < 8 ? s : $"{s.Substring(0, 8)} ...";
        }


        // The following json reader was adapted from stackoverflow
        // Author: Nathan Nainggolan
        // Link: https://stackoverflow.com/questions/58535285/how-to-parse-this-json-result-without-making-class-in-c-sharp
        public static async Task<JObject?> ReadJsonFromHttpResponseAsync(HttpResponseMessage request)
        {
            var result = await request.Content.ReadAsStringAsync();
            return (JObject)JsonConvert.DeserializeObject(result);
        }
    }
}
