
class ReprodutordeMusica
{

    public ReprodutordeMusica()
    {
        Estado = "Tocando";
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
        Console.WriteLine($"avançou a música {MusicaAtual} 10 seg");
    }
    public void Voltar()
    {
        Console.WriteLine($"Voltou a música {MusicaAtual} 10 seg");
    }

    public void VolumeM(int volume)
    {
        Volume = volume;
        Console.WriteLine($"alterou o volume para: {Volume}%");
    }
}
