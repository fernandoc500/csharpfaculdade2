using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToyzBatel.DAL;

namespace WingTipToyzBatel.Views
{
    public partial class CadastrarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CategoriaDAO cDao = new CategoriaDAO();
                drpCategorias.DataSource = cDao.ListAll();
                drpCategorias.DataTextField = "CategoriaNome";
                drpCategorias.DataValueField = "CategoriaId";
                drpCategorias.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Models.Produto p = new Models.Produto();
            CategoriaDAO cDao = new CategoriaDAO();

            p.ProdutoNome = txtNome.Text;
            p.ProdutoDescricao = txtDesc.Text;
            p.ProdutoPreco = Convert.ToDouble(txtPreco.Text);
            p.ProdutoQuantidade = Convert.ToInt32(txtQtd.Text);
            p.CategoriaId = Convert.ToInt32(drpCategorias.SelectedValue);
            p.Categoria = cDao.BuscarPorID(p.CategoriaId);

            if (fupImagem.HasFile)
            {
                //Salvar
                fupImagem.SaveAs(Server.MapPath("../Images/" + fupImagem.FileName));
                fupImagem.SaveAs(Server.MapPath("../Images/Thumbs/" + fupImagem.FileName));
                p.ProdutoImagem = fupImagem.FileName;
            }
            else
            {
                //Salva padrão
                p.ProdutoImagem = "imagem-nao-encontrada.png";
            }

            ProdutoDAO pDao = new ProdutoDAO();
            pDao.AdicionarProduto(p);
            Response.Redirect("CadastrarProduto.aspx");
        }
    }
}