using System;
using System.Collections.Generic;
using System.Net.Security;
using Microsoft.Identity.Client;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var endpoint = "https://login.microsoftonline.com/common";
            var token = GetToken(endpoint);
            Console.WriteLine(token);
        }

        static AuthenticationResult GetToken(String endpoint)
        {
            var appId = "7285e609-85ba-4404-b369-834d47c150f1";
            var authContext = new PublicClientApplication(appId);
            var scopes = new List<String>();
            var result = authContext.AcquireTokenAsync(scopes);
            var token = result.Result;
            return token;
        }
    }
}