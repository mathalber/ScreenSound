Genero rock = new Genero("Rock");

Album albumDoQueen = new Album();
albumDoQueen.Nome = "A Night at the Opera";
albumDoQueen.Genero = rock;

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Artista = "Queen";
musica1.Duracao = 213;
musica1.Disponivel = true;


Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Artista = "Queen";
musica2.Duracao = 354;
musica2.Disponivel = false;


albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

Banda queen = new Banda();
queen.Nome = "Queen";
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();