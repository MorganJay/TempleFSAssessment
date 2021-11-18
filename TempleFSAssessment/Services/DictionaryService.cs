using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace TempleFSAssessment
{
    public static class DictionaryService
    {
        public static async Task<SearchResponse> SearchWord(string word)
        {
            var client = new RestClient($"https://owlbot.info/api/v4/dictionary/{word}")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Token 1d0d4f757e2d5c82980a05dbd46d0d684649e5bc");
            IRestResponse response = await client.ExecuteAsync(request);
            var result = JsonConvert.DeserializeObject<SearchResponse>(response.Content);
            return result;
        }

        public static bool SaveResponse(SearchResponse response)
        {
            return false;
        }
    }
}