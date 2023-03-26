using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace blazorTestApp.Client.Classes_FE
{
    public interface IHttpService
    {
        Task<HttpResponse<object>> POST<T>(string url, T data);
        Task<HttpResponse<object>> PostGeneric<T, TResponse>(string url, T data);
        Task<HttpResponse<T>> GET<T>(string url);
    }
}