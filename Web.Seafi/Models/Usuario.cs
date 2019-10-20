using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Seafi.Models
{
    public class Usuario
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public string Nome { get; set; }

        public DateTime DataUltimoLogin { get; set; } = DateTime.Now;

    }
}
