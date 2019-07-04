﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Threading;

namespace WebStore.Clients.Base
{
    public abstract class BaseClient : IDisposable
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

        protected T Get<T>(string url) 
        {
            return GetAsync<T>(url).Result;
        }

        protected async Task<T> GetAsync<T>(string url, CancellationToken cancel = default(CancellationToken)) 
        {
            var response = await _Client.GetAsync(url, cancel);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<T>(cancel);
            return default(T);
        }

        protected HttpResponseMessage Post<T>(string url, T value) 
        {
            return PostAsync(url, value).Result;
        }

        protected async Task<HttpResponseMessage> PostAsync<T>(string url, T value, CancellationToken cancel = default(CancellationToken))           
        {
            var response = await _Client.PostAsJsonAsync(url, value, cancel);
            return response.EnsureSuccessStatusCode();
        }

        protected HttpResponseMessage Put<T>(string url, T value)
        {
            return PutAsync(url, value).Result;
        }

        protected async Task<HttpResponseMessage> PutAsync<T>(string url, T value, CancellationToken cancel = default(CancellationToken))
        {
            var response = await _Client.PutAsJsonAsync(url, value, cancel);
            return response.EnsureSuccessStatusCode();
        }

        protected HttpResponseMessage Delete(string url)
        {
            return DeleteAsync(url).Result;
        }

        protected async Task<HttpResponseMessage> DeleteAsync(string url, CancellationToken cancel = default(CancellationToken))
        {
            var response = await _Client.DeleteAsync(url, cancel);
            return response;
        }

        void IDisposable.Dispose()
        {
            _Client.Dispose();
        }
    }
}
