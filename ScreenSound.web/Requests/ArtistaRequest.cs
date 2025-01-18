using System.ComponentModel.DataAnnotations;

namespace ScreenSound.web.Requests;
public record ArtistaRequest([Required] string nome, [Required] string bio, string? fotoPerfil);
