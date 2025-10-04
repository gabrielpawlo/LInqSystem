using SoundX_API.Modelos;
namespace SoundX_API.Filtros;

internal class LinqFilter 
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($" - {genero}");
        }
    }
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Filtrando artista pelo genero: {genero}");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($" - {artista}");
        }
    }
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($" - {musica.Nome}");
        }
    }
    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musicas => musicas.Nome).Select(musicas => musicas.Nome).Distinct().ToList();
        foreach(var musicaAno in musicasDoAno)
        {
            Console.WriteLine($" - {musicaAno}");
        }
    }

    public static void FiltrarPorIndiceUm(List<Musica> musicas, int indice)
    {
        var musicasDoIndice = musicas.Where(musica => musica.Nota == indice).OrderBy(musicas => musicas.Nome).Select(musica => musica.Nome).Distinct().ToList();
        foreach (var musicaIndice in musicasDoIndice) 
        {
            Console.WriteLine(musicaIndice);
        }
    }
}
