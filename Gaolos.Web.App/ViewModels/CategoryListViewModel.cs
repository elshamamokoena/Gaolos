﻿
namespace Gaolos.Web.App.ViewModels
{
    public class CategoryListViewModel:ListViewModel
    {

        public ICollection<CategoryViewModel>? Categories { get; set; }
    }
}
