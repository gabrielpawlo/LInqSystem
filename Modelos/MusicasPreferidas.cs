using System.Text.Json;
namespace SoundX_API.Modelos;


internal class MusicasPreferidas
{
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }
    public string Nome {  get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; set; }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }
    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Musicas favoritas de {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas) 
        {
            Console.WriteLine($" - {musica.Nome} - {musica.Artista} - {musica.NotaTexto}");
        }
        Console.WriteLine("");
    }
    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"Musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Json foi criado em {Path.GetFullPath(nomeDoArquivo)}");
    }
}
