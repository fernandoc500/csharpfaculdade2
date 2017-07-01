using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToysBatel.DAL;
using WingTipToysBatel.Models;

namespace WingTipToysBatel.Views
{
    public partial class CadastroCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria();
            c.CategoriaNome = txtNome.Text;
            CategoriaDAO.CadastrarCategoria(c);
            txtNome.Text = "";
            Response.Redirect("Index.aspx");
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

    }
}