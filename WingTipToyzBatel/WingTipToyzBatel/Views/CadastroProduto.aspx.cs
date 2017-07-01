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
    public partial class CadastroProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCategoria.DataSource = CategoriaDAO.ListaCategoria();
                ddlCategoria.DataTextField = "CategoriaNome";
                ddlCategoria.DataValueField = "CategoriaId";
                ddlCategoria.DataBind();
            }
         
        }

        protected void btnLimparProduto_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDesc.Text = "";
            txtPreco.Text = "";
            txtQuant.Text = "";
        }

        //goo.gl/Ny1haq
        protected void btnGravarProduto_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.ProdutoNome = txtNome.Text;
            p.ProdutoDescricao = txtDesc.Text;
            p.ProdutoQuantidade = Convert.ToInt32(txtQuant.Text);
            p.ProdutoPreco = Convert.ToDouble(txtPreco.Text);
            p.CategoriaId = Convert.ToInt32(ddlCategoria.SelectedValue);
            p.Categoria = CategoriaDAO.ListaCategoria(p.CategoriaId);

            if (fupImagem.HasFile)
            {
                //salva imagem
                fupImagem.SaveAs(Server.MapPath("../images/" + fupImagem.FileName));
                fupImagem.SaveAs(Server.MapPath("../images/Thumbs/" + fupImagem.FileName));
                p.ProdutoImagem = fupImagem.FileName;
            }
            else
            {
                //salvar imagem padrao
                p.ProdutoImagem = "produto-sem-imagem.jpg";
            }

            ProdutoDAO.CadastrarProduto(p);
            Response.Redirect("ListaProdutos.aspx?CategoriaId="+p.CategoriaId);

        }
    }
}