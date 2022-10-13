using BibliotecaJoiaMvc.Models.Dtos;

namespace BibliotecaJoiaMvc.Models.Contracts.Repositories
{
    public interface ILivrosServices
    {
        List<LivroDto> Listar();
    }
}
