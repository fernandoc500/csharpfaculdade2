﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToysBatel.DAL;

namespace WingTipToysBatel.Views
{
    public partial class Carrinho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public List<WingTipToysBatel.Models.ItemVenda> lstCarrinho_GetData()
        {
            return ItemVendaDAO.ListaCarrinho();
        }
    }
}