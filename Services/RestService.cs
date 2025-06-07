using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HttpProjeto.Models;

namespace HttpProjeto.Services
{
    public class RestService
    {
        // "_" indica: não pode ser null
        private HttpClient _httpClient; //procura a previsão 
        private PrevisaoModel _previsao; 

        public RestService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<PrevisaoModel> getPrevisao(int codCidade)// toda Api é asssincrona 
        {
            Uri uri = new Uri($"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{codCidade}/6");

            HttpResponseMessage responseMessage = await _httpClient.GetAsync( uri );

            if (responseMessage.IsSuccessStatusCode)
            {
                string content = await responseMessage.Content.ReadAsStringAsync();
                previsao = JsonSerializer.Deserialize<PrevisaoModel>( content );
            }
    }
}
