using System;
using RestSharp;

class Program
{
    static void Main()
    {
        // URL da API
        var apiUrl = "https://pokeapi.co/api/v2/pokemon/";

        // Criar o cliente RestSharp
        var client = new RestClient(apiUrl);

        // Criar a requisição GET
        var request = new RestRequest("", Method.GET);

        try
        {
            // Executar a requisição e obter a resposta
            IRestResponse response = client.Execute(request);

            // Verificar se a requisição foi bem-sucedida (código de status 200)
            if (response.IsSuccessful)
            {
                // Imprimir o conteúdo da resposta (JSON) no console
                Console.WriteLine("Resposta da API:");
                Console.WriteLine(response.Content);
            }
            else
            {
                Console.WriteLine($"Erro na requisição: {response.StatusCode}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
