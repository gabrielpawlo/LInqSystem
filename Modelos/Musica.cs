using System.Text.Json.Serialization;
namespace SoundX_API.Modelos;

internal class Musica
{



    [JsonPropertyName("song")]//pegando arquivo com nome song do json link no program.cs
    public string Nome { get; set; }
    [JsonPropertyName("year")]
    public string? AnoString { get; set; }
    public int Ano { get { return int.Parse(AnoString!); } }
    [JsonPropertyName("artist")]
    public string Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string Genero { get; set; }
    [JsonPropertyName("key")]
    public int Nota { get; set; }//so pega propriedade se for publica

    public static readonly Dictionary<int, string> notas = new Dictionary<int, string>//transformando int em string
        {
            {0,"C" },{1, "C#"}, {2,"D" }, {3,"D#" }, {4,"E" }, {5,"F" }, {6,"F#" },
            {7,"G" },{8,"G#"}, {9,"A" }, {10,"A#" }, {11,"B" }
        };

    public string NotaTexto
    {
        get
        {
            return notas.ContainsKey(Nota) ? notas[Nota] : "Desconhecido";
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artistas: {Artista}\nMusica: {Nome}" +
            $"\nDuracao: {Duracao / 1000}\nGenero: {Genero}\nTonalidade: {NotaTexto}");
    }
}
