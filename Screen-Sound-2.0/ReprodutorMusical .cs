<<<<<<< HEAD
﻿

class ReprodutordeMusica
{

    public ReprodutordeMusica(Musica musicaAtual)
    {
        Estado = "Despausado";
        MusicaAtual = musicaAtual;
        Volume = 0;
    }

    public Musica MusicaAtual { get; set; }
    public string Estado { get; private set; }

    public int Volume { get; private set; }


    public void Pausado()
    {
        Estado = "Pausado";
    }
    public void Tocando()
    {
        Estado = "Tocando";
    }
    public void Avançar()
    {
        Console.WriteLine("Avançar 10 seg");
    }
    public void Voltar()
    {
        Console.WriteLine("Voltar 10 seg");
    }

    public void VolumeM(int volume)
    {
        Volume = volume;
        Console.WriteLine($"O volume foi alterado para: {Volume}%");
    }
}
=======
﻿using System.Security.Cryptography.X509Certificates;

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

>>>>>>> 69bdf4f677b4b164c6a747ae8099aa3f0ef33a11
