using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldClient
{
    class Program
    {
        static HelloWorldServiceClient client = new HelloWorldServiceClient();

        static void Main(string[] args)
        {
            Console.WriteLine(client.GetMessage("DIIIIMMMMAAA!"));
        }

        static async Task<string> GetStrAsync()
        {
            var s = await client.GetMessageAsync("Dimmmma!");

            return s;
        }
    }
}
