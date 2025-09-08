Genero rock = new Genero("Rock");

Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A Night at the Opera");

Musica musica1 = new Musica(queen, "Love of my life");
musica1.Duracao = 213;
musica1.Disponivel = true;


Musica musica2 = new Musica(queen, "Bohemian Rhapsody");
musica2.Duracao = 354;
musica2.Disponivel = false;


albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();