class Album
{
    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; set; }
    public int Duracao { get; set; }

    public void AddMusica(Musica musica)
    {
        musicas.Add(musica);
    }
}