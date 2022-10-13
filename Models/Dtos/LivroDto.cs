namespace BibliotecaJoiaMvc.Models.Dtos
{
    public class LivroDto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Editora { get; set; }
        public string  Autor   { get; set; }

        public LivroDto(string  id, string nome,string editora,string autor)
        {
            Id = id;
            Nome = nome;
            Editora = editora;
            Autor = autor;
        }
        public LivroDto(string nome,string editora,string autor)
        {
            Nome = nome;
            Editora=editora;    
            Autor=autor;    

        }
    }
}
