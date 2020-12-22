using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVCDIO.Models
{
    public class Categoria
    {
       public int id { get; set; }
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        public List<Produto> Produtos { get; set; }

    }
}
