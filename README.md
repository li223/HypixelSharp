# HypixelSharp
A .Net wrapper for Hypixel's public API - Welcome to the waste of time that is the random things I do

# How to set up
Clone/Download this repo, then you will need to get an API Key. This is done by using the command `/api` in game

# Example
```cs
namespace Example
{
    public class Program
    {
        public HypixelSharpClient Client = new HypixelSharpClient("YourApiKey");
        public static async Task Main(string[] args)
        {
            var user = await Client.GetPlayerByNameAsync("ABC");
            Console.WriteLine($"Player UUID: {user.UUID} || Display Name: {user.DisplayName}");
            Console.ReadKey();
        }
    }
}
```
