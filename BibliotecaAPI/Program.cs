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

app.MapGet ("/livros/{id}", (int id) =>
 {
   foreach (var livro in livros)
    {
       if (livro.Id == id)
       {
          return Results.Ok(livro);
       }
    }
    return Results.NotFound();
 });
app.Run();