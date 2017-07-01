using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WingTipToysBatel.Models;

namespace WingTipToysBatel.DAL
{
    public class ItemVendaDAO
    {
        private static Context ctx = Singleton.Instance.Context;
       
        public static string retornarCarrrinhoId()
        {
            if (HttpContext.Current.Session["CarrinhoId"] == null)
            {
                Guid novoGuid = Guid.NewGuid();
                HttpContext.Current.Session["CarrinhoId"] = novoGuid.ToString();
            }
            return HttpContext.Current.Session["CarrinhoId"].ToString();
        }

        public static List<ItemVenda> ListaCarrinho()
        {
            var carrinhoid = retornarCarrrinhoId();
            return ctx.itensVenda.Where(c => c.carrinhoId.Equals(carrinhoid)).ToList();
        }

        public static void CriarCarrinho(int Id)
        {
            string carrinhoid = retornarCarrrinhoId();

            ItemVenda itens = ctx.itensVenda.FirstOrDefault(c => c.carrinhoId.Equals(carrinhoid) && c.produtoId == Id);

            if (itens == null)
            {
                itens = new ItemVenda {
                    produtoId = Id,
                    produto = ProdutoDAO.InfoProduto(Id),
                    Quantidade = 1,
                    Data = DateTime.Now,
                    carrinhoId = retornarCarrrinhoId()
                };
                ctx.itensVenda.Add(itens);
            }
            else
            {
                itens.Quantidade++;
                itens.Data = DateTime.Now;
            }
           
            ctx.SaveChanges();
        }

        public static void RemoverDoCarrinho(int Id)
        {
            string carrinhoid = retornarCarrrinhoId();

            ItemVenda itens = ctx.itensVenda.FirstOrDefault(c => c.carrinhoId.Equals(carrinhoid) && c.produtoId == Id);

            if (itens != null)
            {
                ctx.itensVenda.Remove(itens);
            }
            ctx.SaveChanges();

        }
    }
}