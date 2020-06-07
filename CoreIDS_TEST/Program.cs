using IdentityModel.Client;
using System;
using System.Threading.Tasks;

namespace CoreIDS_TEST
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new System.Net.Http.HttpClient();

            var disco = await client.GetDiscoveryDocumentAsync("https://localhost:44396");
            if (disco.IsError)
            {
                Console.WriteLine(disco.Error);
                return;
            }

            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,
                ClientId = "client",
                ClientSecret = "secret",
                Scope = "api1"
            });

            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);

            }

            Console.WriteLine(disco.Error);


        }
    }
}
