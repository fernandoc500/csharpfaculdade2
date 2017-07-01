using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WingTipToysBatel.Models;

namespace WingTipToysBatel.DAL
{
    public class CategoriaDAO
    {
        private static Context ctx = Singleton.Instance.Context;
        
        public static List<Categoria> ListaCategoria()
        {
            return ctx.Categorias.ToList();
        }

        public static Categoria ListaCategoria(int id)
        {
            return ctx.Categorias.Find(id);
        }

        public static void CadastrarCategoria(Categoria c)
        {
            ctx.Categorias.Add(c);
            ctx.SaveChanges();
        }
    }

}