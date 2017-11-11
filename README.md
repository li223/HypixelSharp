# HypixelSharp

Welcome to the waste of time that is the random things I do

Example:
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
            Console.WriteLine($"Display Name: {user.DisplayName} || Last Logged in at: {new DateTime(1970, 1, 1).AddMilliseconds(user.LastLogin)}");
        }
    }
}
```
