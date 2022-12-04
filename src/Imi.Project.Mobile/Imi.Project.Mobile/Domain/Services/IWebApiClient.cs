using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services
{
    public interface IWebApiClient
    {
        Task<T> GetApiResult<T>(string uri);

        Task<TOut> PutCallApi<TOut, TIn>(string uri, TIn entity);

        Task<TOut> PostCallApi<TOut, TIn>(string uri, TIn entity);

        Task<TOut> DeleteCallApi<TOut>(string uri);

        Task<TOut> CallApi<TOut, TIn>(string uri, TIn entity, HttpMethod httpMethod);
    }
}