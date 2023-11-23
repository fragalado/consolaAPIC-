using ConsolaAPI;
using System.Text.Json;

// Url de usuario
var urlUsuario = "https://localhost:7125/api/Usuario";

// Url de acceso
var urlAcceso = "https://localhost:7125/api/Acceso";

// Objeto para poder pasar de json a objeto usuario y acceso
JsonSerializerOptions option = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

using (var httpCliente = new HttpClient())
{
    var responseUsuario = await httpCliente.GetAsync(urlUsuario);
    var responseAcceso = await httpCliente.GetAsync(urlAcceso);

    // Get Usuario
    if (responseUsuario.IsSuccessStatusCode)
    {
        var content = await responseUsuario.Content.ReadAsStringAsync();
        var listaUsuario = JsonSerializer.Deserialize<List<Usuario>>(content, option);
        foreach (var res in listaUsuario)
        {
            res.ToString();
        }
    }

    // Get Acceso
    if (responseAcceso.IsSuccessStatusCode)
    {
        var content = await responseAcceso.Content.ReadAsStringAsync();
        var listaAcceso = JsonSerializer.Deserialize<List<Acceso>>(content, option);
        foreach (var res in listaAcceso)
        {
            res.ToString();
        }
    }
}