using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToyzBatel.DAL;

namespace WingTipToyzBatel.Views
{
    public partial class CadastrarCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Models.Categoria c = new Models.Categoria();
            c.CategoriaNome = txtNome.Text;

            CategoriaDAO cDao = new CategoriaDAO();
            cDao.AdicionarCategoria(c);
            Response.Redirect("CadastrarCategoria.aspx");
        }
    }
}