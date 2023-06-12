using Alura.Filmes.App.Extensions;
using backend_entity_mapeando_um_banco_ja_existente.Dados;
using Microsoft.EntityFrameworkCore;

namespace backend_entity_mapeando_um_banco_ja_existente.Negocio
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var contexto = new AluraFilmesContexto()){
                contexto.LogSQLToConsole();

                var idiomas = contexto.Idiomas
                    .Include(i => i.FilmesFalados);

                foreach(var idioma in idiomas){
                    Console.WriteLine(idioma);

                    foreach(var filme in idioma.FilmesFalados){
                        Console.WriteLine(filme);
                    }
                    Console.WriteLine("\n");
                }
            }
        }

        static void recuperarValoresShadowProperties()
        {
            using (var contexto = new AluraFilmesContexto())
            {
                var atores = contexto.Atores
                    .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                    .Take(10);

                foreach (var ator in atores)
                {
                    Console.WriteLine(ator + " - " + contexto.Entry(ator).Property("last_update").CurrentValue);
                }
            }
        }

        static void mostrandoFilmesNaTela()
        {
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                foreach (var filme in contexto.Filmes)
                {
                    Console.WriteLine(filme);
                }
            }
        }

        static void mostrandoIdsEntreFilmeEAtor()
        {
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                foreach (var item in contexto.Elenco)
                {
                    var entidade = contexto.Entry(item);
                    var filmId = entidade.Property("film_id").CurrentValue;
                    var actorId = entidade.Property("actor_id").CurrentValue;
                    var lastUpd = entidade.Property("last_update").CurrentValue;
                    Console.WriteLine($"Filme {filmId}, Ator {actorId}, LastUpdate: {lastUpd}");
                }
            }
        }

        static void mostrandoAtoresDoFilme()
        {
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                var filme = contexto.Filmes
                    .Include(f => f.Atores)
                    .ThenInclude(fa => fa.Ator)
                    .First();

                Console.WriteLine(filme);
                Console.WriteLine("Elenco: ");

                foreach (var ator in filme.Atores)
                {
                    Console.WriteLine(ator.Ator);
                }
            }
        }
    }
}
