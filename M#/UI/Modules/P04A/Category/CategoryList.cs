using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using MSharp;

namespace Modules
{
    public class CategoryList : ListModule<Category>
    {
        public CategoryList()
        {
            HeaderText("Product Categories");

            Search(x => x.Name)
                .Label("Category Name")
                .WatermarkText("Enter category name for search")
                .ReloadOnChange();

            // Search(x => x.Name)
            //     .NoLabel()
            //     .WatermarkText("Enter Name");

            SearchButton("Search").OnClick(x => x.Reload());

            Column(x => x.Name);

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.Go<P04A.Category.EditPage>()
                    .Send("item", "item.ID")
                    .SendReturnUrl());

            ButtonColumn("Delete").Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("New Category").Icon(FA.Plus)
                .OnClick(x => x.Go<P04A.Category.EnterPage>());
        }
    }
}
