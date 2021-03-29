using MSharp;

namespace Modules
{
    public class ProductList : ListModule<Domain.Product>
    {
        public ProductList()
        {
            HeaderText("Products");

            Search(x => x.Category)
                .Control(ControlType.DropdownList)
                .Label("Category")
                .WatermarkText("Enter category name for search")
                .ReloadOnChange();

            Search(x => x.Supplier)
                .Control(ControlType.DropdownList)
                .Label("Supplier")
                .ReloadOnChange();

            SearchButton("Search").OnClick(x => x.Reload());

            ShowFooterRow()
                .ShowHeaderRow()
                .UseDatabasePaging(false)
                .HeaderText("Tasks")
                .PageSize(10);

            LinkColumn("View").HeaderText("View")
                .OnClick(x => x.PopUp<P04A.Product.ViewPage>()
                    .Send("item", "item.ID"));

            Column(x => x.Category);
            Column(x => x.Supplier);
            Column(x => x.Name);

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.Go<P04A.Product.EditPage>()
                    .Send("item", "item.ID")
                    .SendReturnUrl());

            ButtonColumn("Delete").Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("New Product").Icon(FA.Plus)
                .OnClick(x => x.Go<P04A.Product.EnterPage>());
        }
    }
}
