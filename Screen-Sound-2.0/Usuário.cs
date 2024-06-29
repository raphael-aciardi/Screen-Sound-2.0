
class Usuario
{
    public Usuario(string nomedeusuário)
    {
        NomedoUsuario = nomedeusuário;
        ReprodutordoUsuario = new ReprodutordeMusica();

    }

    public string NomedoUsuario { get; set; }
    public ReprodutordeMusica ReprodutordoUsuario { get; private set; }
    public void Pausado()
    {
        ReprodutordoUsuario.Pausado();
        Console.WriteLine($"O usuário {NomedoUsuario} pausou a música");
    }
    public void Tocando()
    {
        Console.WriteLine($"O usuário {NomedoUsuario} colocou a música para tocar");
        ReprodutordoUsuario.Tocando();
    }
    public void Avançar()
    {
        Console.Write($"O usuário {NomedoUsuario} ");
        ReprodutordoUsuario.Avançar();
    }
    public void Voltar()
    {
        Console.Write($"O usuário {NomedoUsuario} ");
        ReprodutordoUsuario.Voltar();
        
    }

    public void Volume(int volume)
    {
        Console.Write($"O usuário {NomedoUsuario} ");
        ReprodutordoUsuario.VolumeM(10);
        
    }

    public void VerificarEstado()
    {

    }


}