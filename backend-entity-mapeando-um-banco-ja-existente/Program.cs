using backend_entity_mapeando_um_banco_ja_existente.Dados;

namespace backend_entity_mapeando_um_banco_ja_existente.Negocio{
    class Program{
        static void Main(string[] args){
            using (var contexto = new AluraFilmesContexto()){
                foreach (var ator in contexto.Atores){
                    Console.WriteLine(ator);
                }
            }
        }
    }
}
