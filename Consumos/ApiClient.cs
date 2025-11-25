using System.Net.Http;
using System.Threading.Tasks;

public class ApiClient
{
    private readonly HttpClient _httpClient;

    public ApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Método para consumir el endpoint "GET /api/Campania"
    public async Task GetCampaniaData()
    {
        string apiUrl = "https://sucursalsc-production.up.railway.app/api/Campania"; // URL de la API de tu compañero

        try
        {
            var response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                // Mostrar los datos o procesarlos según sea necesario
                Console.WriteLine($"Datos obtenidos: {responseData}");
            }
            else
            {
                Console.WriteLine($"Error al obtener los datos. Código de estado: {response.StatusCode}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al consumir la API: {ex.Message}");
        }
    }
}
