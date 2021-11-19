using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using TempleFSAssessment.Data;
using TempleFSAssessment.Data.Entities;

namespace TempleFSAssessment
{
    public static class DictionaryService
    {
        public static async Task<SearchResponse> SearchWordAsync(string word)
        {
            var client = new RestClient($"https://owlbot.info/api/v4/dictionary/{word}")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Token 1d0d4f757e2d5c82980a05dbd46d0d684649e5bc");
            IRestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode != HttpStatusCode.OK || !response.IsSuccessful) throw new System.Exception("Unable to reach dictionary service.");

            var result = JsonConvert.DeserializeObject<SearchResponse>(response.Content);
            return result;
        }

        public static async Task<bool> SaveResponseAsync(SearchResponse response)
        {
            var context = new DictionaryDbContext();

            var word = new WordModel
            {
                Pronunciation = response.Pronunciation,
                Word = response.Word,
                Definitions = response.Definitions.Count
            };

            foreach (var item in response.Definitions)
            {
                var wordDefinition = new WordDefinition
                {
                    Definition = item.Definition,
                    Emoji = item.Emoji,
                    Example = item.Example,
                    Image_url = item.Image_url,
                    Type = item.Type,
                    Word = response.Word
                };

                word.WordDefinitions.Add(wordDefinition);
            }

            context.Words.Add(word);
            return await context.SaveChangesAsync() > 0;
        }
    }
}