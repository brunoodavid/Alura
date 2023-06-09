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

            foreach(var filme in contexto.Filmes){
                Console.WriteLine(filme);
            }
            }
        }

        static void recuperarValoresShadowProperties(){
            using (var contexto = new AluraFilmesContexto())
            {
                var atores = contexto.Atores
                    .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                    .Take(10);
                
                foreach(var ator in atores){
                    Console.WriteLine(ator + " - " + contexto.Entry(ator).Property("last_update").CurrentValue);
                }
            }
        }
    }
}
