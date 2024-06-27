using System.Security.Cryptography.X509Certificates;

class ReprodutordeMusica
{
    List<Musica> musicas = new List<Musica>();
    public ReprodutordeMusica(Musica musica, string estado, string musicaAtual)
    {
        MusicaAtual = musica;
        Estado = estado;
        MusicaAtual = musicaAtual;
    }

    public string MusicaAtual { get; private set; }
    public string Estado { get; private set; }
};

