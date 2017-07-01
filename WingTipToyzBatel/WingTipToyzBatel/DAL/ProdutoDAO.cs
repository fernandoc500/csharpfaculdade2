using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WingTipToysBatel.Models;

namespace WingTipToysBatel.DAL
{
    public class ProdutoDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static List<Produto> ListaProduto()
        {
            return ctx.Produtos.ToList();
        }

        public static List<Produto> ListaProduto(String idCategoria)
        {
            int id = Convert.ToInt32(idCategoria);
           return ctx.Produtos.Where(x => x.CategoriaId == id).ToList();
            //var list = from Prod in ctx.Produtos
            //           where Prod.CategoriaId == id
            //           select Prod;
            //return list.ToList();

        }

        public static Produto InfoProduto(int id)
        {
            return ctx.Produtos.Find(id);
        }

        public static void CadastrarProduto(Produto p)
        {
            ctx.Produtos.Add(p);
            ctx.SaveChanges();
        }
    }
}