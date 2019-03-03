using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;

namespace WebStore.Clients.Base
{
    public abstract class BaseClient
    {
        protected readonly HttpClient _Client;
        protected string ServiceAddress { get; set;}

        protected BaseClient(IConfiguration configuration)
        {
            _Client = new HttpClient
            {
                BaseAddress = new Uri(configuration["ClientAddress"])
            };
            _Client.DefaultRequestHeaders.Accept.Clear();
            _Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
