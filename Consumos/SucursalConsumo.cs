using System.Net.Http;
using System.Threading.Tasks;

public class SucursalConsumo
{
    private static readonly HttpClient client = new HttpClient();

    public async Task<string> GetDashboardData(string codigoSucursal)
    {
        try
        {
            // Asegúrate de que la URL sea correcta
            string url = $"https://miapp.railway.app/api/Dashboard/{codigoSucursal}";
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                return responseData;
            }
            else
            {
                return "Error al consumir el endpoint";
            }
        }
        catch (Exception ex)
        {
            return $"Error al realizar la solicitud: {ex.Message}";
        }
    }
}
