Album album = new Album();
album.Nome = "Nome do Álbum";

Musica musica1 = new Musica();
musica1.Nome = "Música 1";
musica1.Duracao = 360;
musica1.Artista = "Artista";

Musica musica2 = new Musica();
musica2.Nome = "Música 2";
musica2.Duracao = 394;
musica2.Artista = "Artista";

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);

album.ExibirAlbum();