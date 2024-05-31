using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ST10019838_DamianDare_PROG7311_POE.Utils
{
    public class Utils
    {
        public static string? ShortenString(string? s, int maxLength)
        {
            return s.Length <= maxLength ? s : $"{s.Substring(0, maxLength)} ...";
        }


        // The following json reader was adapted from stackoverflow
        // Author: Nathan Nainggolan
        // Link: https://stackoverflow.com/questions/58535285/how-to-parse-this-json-result-without-making-class-in-c-sharp
        public static async Task<JObject?> ReadJsonFromHttpResponseAsync(HttpResponseMessage request, bool fromJArray = false)
        {
            var result = await request.Content.ReadAsStringAsync();
            // the following line of code was adapted from reddit
            // Author: SikhGamer
            // Link: https://www.reddit.com/r/csharp/comments/6k3e51/converting_jarray_to_objectnewtonsoft/
            var test = fromJArray ? JArray.Parse(result) : null;

            return (JObject)JsonConvert.DeserializeObject(fromJArray ? test[0].ToString() : result);
        }
    }
}
