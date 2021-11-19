using System;
using System.Threading.Tasks;

namespace TempleFSAssessment
{
    public class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to the Owl Dictionary, Please enter a word you'd like to search then hit Enter");
            var word = Console.ReadLine();

            try
            {
                var result = await DictionaryService.SearchWordAsync(word);

                var success = await DictionaryService.SaveResponseAsync(result);

                if (!success) Console.WriteLine("An error occured while saving the word");

                Console.WriteLine("Your search has been saved. Take a look at the results");

                Console.WriteLine($"Word: {result.Word}");

                Console.WriteLine($"Pronunciation: {result.Pronunciation}");

                Console.WriteLine("Details:");

                foreach (var definition in result.Definitions)
                {
                    Console.WriteLine($"\tType: /{definition.Type}/");
                    Console.WriteLine($"\tDefinition: {definition.Definition}");
                    Console.WriteLine($"\tExample: {definition.Example}");
                    Console.WriteLine($"\tEmoji: {definition.Emoji}");
                }

                Console.WriteLine("\n\n Powered by Owlbot API");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occured. {ex.Message}");
            }
        }
    }
}