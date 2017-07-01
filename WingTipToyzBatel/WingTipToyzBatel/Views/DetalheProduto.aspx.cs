using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToysBatel.DAL;

namespace WingTipToysBatel.Views
{
    public partial class DetalheProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public WingTipToysBatel.Models.Produto frvProduto_GetItem()
        {
            int Produtoid = Convert.ToInt32(Request.QueryString["ProdutoId"]);

            return ProdutoDAO.InfoProduto(Produtoid);
        }
    }
}