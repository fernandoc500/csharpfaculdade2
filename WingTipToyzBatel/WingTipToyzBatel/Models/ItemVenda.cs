using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WingTipToysBatel.Models
{
    public class ItemVenda
    {
        [Key]
        public int itemVendaId { get; set; }

        public string carrinhoId { get; set; }

        public int Quantidade { get; set; }

        public DateTime Data { get; set; }

        public int produtoId { get; set; }

        public virtual Produto produto { get; set; }

    }
}