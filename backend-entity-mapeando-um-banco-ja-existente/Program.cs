using backend_entity_mapeando_um_banco_ja_existente.Dados;

namespace backend_entity_mapeando_um_banco_ja_existente.Negocio
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContexto())
            {
                var ator = new Ator();
                ator.PrimeiroNome = "Tom";
                ator.UltimoNome = "Hanks";
                contexto.Entry(ator).Property("last_update").CurrentValue = DateTime.Now;

                contexto.Atores.Add(ator);
                contexto.SaveChanges();

            }
        }
    }
}
