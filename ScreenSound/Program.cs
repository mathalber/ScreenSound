Episodio ep1 = new(1, "Tecnicas de facilitação", 45);
ep1.AdicionarConvidados("Rebeca");
ep1.AdicionarConvidados("Matheus");

Episodio ep2 = new(2, "Tecnicas de aprendizado", 67);
ep2.AdicionarConvidados("Brunno");
ep2.AdicionarConvidados("Arthur");
ep2.AdicionarConvidados("Vanessa");


Podcast podcast = new("Podpah", "Igão e Mítico");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();