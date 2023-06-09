using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_entity_mapeando_um_banco_ja_existente.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set;}
        public string Descricao { get; set;}
        public string AnoLancamento { get; set;}
        public short Duracao { get; set;}

        public override string ToString()
        {
            return $"Filme ({Id}: {Titulo} - {AnoLancamento})";
        }
    }
}