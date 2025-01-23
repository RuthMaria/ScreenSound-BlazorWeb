namespace ScreenSound.web.Response;

public record ArtistaResponse(int Id, string Nome, string Bio, string? FotoPerfil)
{
    public override string ToString()
    {
        return $"{Nome}";
    }
}