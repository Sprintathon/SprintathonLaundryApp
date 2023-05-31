using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SprintathonLaundryApp.Services
{
	public class AuthServices
	{
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        public User User { get; set; }
        const string Url = "https://gdd3rp3j-7114.euw.devtunnels.ms/api/register";
        public AuthServices()
        {
            _client = new HttpClient();
        }

        public async Task<User> CreateUser(CreateUserDto dto)
        {
            Uri uri = new Uri(string.Format(Url, string.Empty));

            try
            {
                string json = JsonSerializer.Serialize<CreateUserDto>(dto, _serializerOptions);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                response = await _client.PostAsync(uri, content);

                if (response.IsSuccessStatusCode)
                    return dto;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return null;
            //var request = await _client.PostAsJsonAsync<CreateUserDto>($"{Url}register", dto);
            //if (!request.IsSuccessStatusCode) throw new Exception($"Creating user returned {request.StatusCode}");
            //var response = await request.Content.ReadFromJsonAsync<User>();
            //if (response is null) throw new Exception($"Creating user returned is null");
            //User = response;
            //return response;
        }
    }
}

