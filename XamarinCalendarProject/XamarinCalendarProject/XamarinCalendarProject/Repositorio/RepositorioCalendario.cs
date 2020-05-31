using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using XamarinCalendarProject.Models;

namespace XamarinCalendarProject.Repositorio
{
    public class RepositorioCalendario
    {
        private String url;
        private MediaTypeWithQualityHeaderValue header;

        public RepositorioCalendario()
        {
            this.url = "https://projectclasecoregpp.azurewebsites.net/";
            this.header = new MediaTypeWithQualityHeaderValue("application/json");
        }
        private async Task<T> CallApiAsync<T>(String request)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);
                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    String json = await response.Content.ReadAsStringAsync();
                    T data = JsonConvert.DeserializeObject<T>(json);
                    return (T)Convert.ChangeType(data, typeof(T));
                }
                else
                {
                    return default(T);
                }
            }
        }
        public async Task<List<Eventos>> EventoUsuario(int idusuario)
        {
            String request = "api/Project/EventoUsuarioSinToken/" + idusuario;
            List<Eventos> eventos = await CallApiAsync<List<Eventos>>(request);
            return eventos;
        }
    }
}
