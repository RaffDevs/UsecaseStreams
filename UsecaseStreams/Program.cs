// See https://aka.ms/new-console-template for more information

using System;

namespace UsecaseStreams
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintSequenciaNumerica().Wait();
        }
        
        public static async IAsyncEnumerable<int> GeraSequenciaNumerica()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
        
        public static async Task PrintSequenciaNumerica()
        {
            await foreach (var numero in GeraSequenciaNumerica())
            {
                Console.WriteLine($"{numero}");
            }
        }
        
        public static async IAsyncEnumerable<int> GetNumbersAsync()
        {
            await Task.Delay(1000); // Simulando uma operação assíncrona
            yield return 1;
        
            await Task.Delay(1000);
            yield return 2;
        
            await Task.Delay(1000);
            yield return 3;
        }
        
        public static async Task Main(string[] args)
        {
            await foreach (var number in GetNumbersAsync())
            {
                Console.WriteLine(number);
            }
        }
        
        public static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
        
        public static void Main(string[] args)
        {
            foreach (var number in GetNumbers())
            {
                Console.WriteLine(number);
            }
        }
    }
};

