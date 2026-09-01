var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var livros = new[]
{
   new
   {
      Id = 1,
      Titulo = "O heroi perdido",
      Autor = "Rick Riordan"
   },
   new
   {
      Id = 2,
      Titulo = "O filho de netuno",
      Autor = "Rick Riordan"
   },
   new
   {
      Id = 3,
      Titulo = "A marca de atena",
      Autor = "Rick Riordan"
   }
};

app.MapGet 
(
   "/ola", () =>
 {
   return "Bem-Vindo A Biblioteca API!";
 }
 );
 app.MapGet 
 (
   "/biblioteca", () =>
   {
      return "Biblioteca Cental API";
   }
 );
 app.MapGet
 (
   "/livros/", () =>
   {
      return "A Biblioteca Possui 10 Livros";
   }
 );
 app.MapGet
 (
   "/livros/{id}", (int id) =>
   {
      return $"Voce solicitou o livro de ID {id}.";
   }
 );
 app.MapGet
 (
   "/autor/{id}", (int id) =>
   {
      return $"Voce solicitou o Autor de ID {id}.";
   }
 );
 app.MapGet
 (
   "/livros/{id}/capitulos/{capitulo}", (int id, int capitulo) =>
   {
      return $"Voce solicitou o livro de ID {id} e Capitulo {capitulo}.";
   }
 );
app.Run();