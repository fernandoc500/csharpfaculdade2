using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToysBatel.DAL;

namespace WingTipToysBatel.Views
{
    public partial class AdicionarAoCarrinho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int produtoId = Convert.ToInt32(Request.QueryString["produtoId"]);

            if (Convert.ToBoolean(Request.QueryString["remover"]) == true)
            {
                ItemVendaDAO.RemoverDoCarrinho(produtoId);
            }
            else
            {
                ItemVendaDAO.CriarCarrinho(produtoId);
            }
            //redirecionar para outra pagina
            Response.Redirect("Carrinho.aspx");

        }
    }
}