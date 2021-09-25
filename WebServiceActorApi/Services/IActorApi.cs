using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebServiceActorApi.Models;

namespace WebServiceActorApi.Services
{
    public interface IActorApi
    {
     
        [Get("/en/API/SearchName/k_tyhzd992/{title}")]
        Task<HttpResponseMessage> GetActorsAsync(string title);
    }
}
