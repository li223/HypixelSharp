# HypixelSharp

Welcome to the waste of time that is the random things I do

# How to set up
Clone/Download this repo, then you will need to get an API Key. This is done by using the command `/api` in game

# Example
```cs
namespace Example
{
    public class Program
    {
        public HypixelSharpClient Client = new HypixelSharpClient("YourApiKey");
        static void Main(string[] args)
        {
            new Program().ExampleMethod().GetAwaiter().GetResult();
            Console.ReadKey();
        }
        public async Task ExampleMethod()
        {
            var user = await Client.GetPlayerAsync("UserUUID");
            Console.WriteLine($"Player UUID: {user.UUID} || Display Name: {user.DisplayName}");
        }
    }
}
```
