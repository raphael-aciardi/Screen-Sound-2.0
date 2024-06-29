internal class Program
{
    private static void Main(string[] args)
    {
        Banda queen = new Banda("Queen");

        Usuario Usuario1 = new Usuario("Raphael");
        Usuario Usuario2 = new Usuario("Inácio");

        Album albumDoQueen = new Album("A night at the opera");

        Musica musica1 = new Musica(queen, "Love of my life")
        {
            Duracao = 213,
            Disponivel = true,
        };

        Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
        {
            Duracao = 315,
            Disponivel = false
        };

        albumDoQueen.AdicionarMusica(musica1);
        albumDoQueen.AdicionarMusica(musica2);

        queen.AdicionarAlbum(albumDoQueen);

        musica1.ExibirFichaTecnica();
        musica2.ExibirFichaTecnica();

        queen.ExibirDiscografia();
        albumDoQueen.ExibirMusicasDoAlbum();

        Usuario1.Avançar();
        Usuario2.Pausado();

        Usuario1.Volume(10);

        Console.WriteLine($"Verificar estado da música de Raphael: { Usuario1.ReprodutordoUsuario.Estado}");
    }
}