namespace ProdAs
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            await PrintAsync();
            Console.WriteLine("Основная надпись");
        }

        static async public Task PrintAsync() {
            await Task.Delay(1000);
            Console.WriteLine("Надпись с задержкой!");
        }
    }
}
