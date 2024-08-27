using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using UserRandomAPI.Entity;
using UserRandomAPI.Models;
using UserRandomAPI.Repository;
using UserRandomAPI.Services;

public class UsuarioServico : IUserService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IUserRepository _userRepository;

    public UsuarioServico(IHttpClientFactory httpClientFactory, IUserRepository userRepository)
    {
        _httpClientFactory = httpClientFactory;
        _userRepository = userRepository;
    }

    public async Task ImportRandomUserAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetStringAsync("https://randomuser.me/api/");

        try
        {
            var randomUserResponse = JsonConvert.DeserializeObject<RandomUserResponse>(response);
            var randomUser = randomUserResponse.results[0];
            var userEntity = new Usuario
            {
                gender = randomUser.gender,
                name = new Name
                {
                    title = randomUser.name.title,
                    first = randomUser.name.first,
                    last = randomUser.name.last
                },
                location = new Location
                {
                    street = randomUser.location.street,
                    city = randomUser.location.city,
                    state = randomUser.location.state,
                    country = randomUser.location.country,
                    postcode = randomUser.location.postcode
                },
                email = randomUser.email,
                login = new Login
                {
                    uuid = randomUser.login.uuid,
                    username = randomUser.login.username,
                    password = randomUser.login.password
                },
                phone = randomUser.phone,
                cell = randomUser.cell,
                id = new Uid
                {
                    name = randomUser.id.name,
                    value = randomUser.id.value
                },
                nat = randomUser.nat,
            };


            await _userRepository.AddUsuarioAsync(userEntity);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task ImportRandomUserQtdAsync(int quantidade)
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetStringAsync($"https://randomuser.me/api/?results={quantidade}");

        var randomUserResponse = JsonConvert.DeserializeObject<RandomUserResponse>(response);

        foreach (var randomUser in randomUserResponse.results)
        {
            var userEntity = new Usuario
            {
                gender = randomUser.gender,
                name = new Name
                {
                    title = randomUser.name.title,
                    first = randomUser.name.first,
                    last = randomUser.name.last
                },
                location = new Location
                {
                    street = randomUser.location.street,
                    city = randomUser.location.city,
                    state = randomUser.location.state,
                    country = randomUser.location.country,
                    postcode = randomUser.location.postcode
                },
                email = randomUser.email,
                login = new Login
                {
                    uuid = randomUser.login.uuid,
                    username = randomUser.login.username,
                    password = randomUser.login.password
                },
                phone = randomUser.phone,
                cell = randomUser.cell,
                id = new Uid
                {
                    name = randomUser.id.name,
                    value = randomUser.id.value
                },
                nat = randomUser.nat,
            };

            await _userRepository.AddUsuarioAsync(userEntity);
        }
    }

}
