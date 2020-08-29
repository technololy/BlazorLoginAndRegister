using System;
using System.Net.Http;
using System.Threading.Tasks;
using Didala.Models.Models;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;


namespace Didala.Web.Services
{
    public class DataServices : IDataServices
    {
        private readonly HttpClient httpClient;
        private readonly IHttpClientFactory _clientFactory;

        private readonly SpinnerService _spinnerService;


        public DataServices(HttpClient httpClient, SpinnerService spinnerService,
        IHttpClientFactory clientFactory)
        {
            this.httpClient = httpClient;
            _spinnerService = spinnerService;
            _clientFactory = clientFactory;

        }

        public async Task<LoginResponse> Login(LoginModel loginModel)
        {
            try
            {
                _spinnerService.Show();
                //var client = _clientFactory.CreateClient();
                //var request = new HttpRequestMessage(HttpMethod.Post,
                //"https://localhost:63785/api/Authenticate/Login");
                //request.Headers.Add("Accept", "application/json");
                var response = await httpClient.PostAsJsonAsync("https://localhost:63785/api/Authenticate/Login", loginModel);
                _spinnerService.Hide();

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var body = Newtonsoft.Json.JsonConvert.DeserializeObject<LoginResponse>(result);
                    return body;
                }
                else
                {
                    return null;
                }

            }
            catch (System.Exception ex)
            {
                _spinnerService.Hide();

            }
            return null;

        }
        public async Task<(bool isSuccess, T obj)> PostData<T>(string url, T Model)
        {
            try
            {
                _spinnerService.Show();

                var response = await httpClient.PostAsJsonAsync(url, Model);
                _spinnerService.Hide();

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var body = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);
                    return (true, body);
                }
                else
                {
                    return (false, default);
                }

            }
            catch (System.Exception ex)
            {
                _spinnerService.Hide();

            }
            return (false, default);


        }

    }
}
