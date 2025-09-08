class Album
{
    private List<Musica> musicas = new List<Musica>();
    public Album(string nome)
    {
        Nome = nome;
    }
    public string? Nome { get; }
    public Genero? Genero { get; set; } 
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do album {Nome}: \n");
        Console.WriteLine($"Gênero: {Genero?.Nome}\n"); 
        foreach (var musica in musicas)
        {
            Console.WriteLine($"- Música:{musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir esse album inteiro que você precisa de : {DuracaoTotal} segundos");
    }
}