using SoundX_API.Modelos;
using SoundX_API.Filtros;
using System.Text.Json;



using (HttpClient client = new HttpClient())
{
    try//criando cliente e try a requisicao
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "metal");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2010);

        LinqFilter.FiltrarPorIndiceUm(musicas, 1);


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");//se nao cosneguir manda a mensagem de erro
    }
}