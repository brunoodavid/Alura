using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_entity_mapeando_um_banco_ja_existente.Negocio
{
    [Table("actor")]
    public class Ator
    {
        [Column("actor_id")]
        public int Id { get; set; }
        [Column("first_name", TypeName = "varchar(45)")]
        public string PrimeiroNome { get; set; }
        [Column("last_name", TypeName = "varchar(45)")]
        public string UltimoNome { get; set; }

        public override string ToString(){
            return $"Ator ({Id}: {PrimeiroNome} {UltimoNome})";
        }
    }
}