using System;

namespace TempleFSAssessment
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to the Owl Dictionary, Please enter a word you'd like to search then hit Enter");
            var word = Console.ReadLine();

            var result = DictionaryService.SearchWord(word);

            Console.WriteLine(result);
        }
    }
}