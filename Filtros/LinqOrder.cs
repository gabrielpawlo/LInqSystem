using SoundX_API.Modelos;
namespace SoundX_API.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas");
        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($" - {artista}");
        }
    }
}
