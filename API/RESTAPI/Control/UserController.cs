using System;
using System.Net.Http;
using System.Collections.Generic;
using RESTAPI.Model;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;


namespace RESTAPI.Control
{
    public class UserController
    {
        static readonly HttpClient client = new HttpClient {BaseAddress = new Uri("http://localhost/")};
        static readonly string url = "users";


        public async Task<User> Create(User user)
        {
            var userJson = JsonSerializer.Serialize(user);
            var userContent = new StringContent(userJson, Encoding.UTF8, "application/json");
            var responseUser = await client.PostAsync(url,userContent);
            if (!responseUser.IsSuccessStatusCode)
            {
                return null;
            }

            return user;
        }

        public async Task<List<User>> getAllUsers()
        {
            var getUsersResponse = await client.GetAsync(url);
            if (!getUsersResponse.IsSuccessStatusCode) return null;
            var usersJson = await getUsersResponse.Content.ReadAsStringAsync();
            var users = JsonSerializer.Deserialize<List<User>>(usersJson);
            return users;
        }



        public UserController()
        {

        }
    }
}
