using MSharp;

namespace Modules
{
    public class SupplierList : ListModule<Domain.Supplier>
    {
        public SupplierList()
        {
            HeaderText("Suppliers");


            Search(x => x.CompanyName)
                .Label("Company Name")
                .WatermarkText("Enter category name for search")
                .ReloadOnChange();

            SearchButton("Search").OnClick(x => x.Reload());

            Column(x => x.CompanyName);
            Column(x => x.Address);

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.Go<P04A.Supplier.EditPage>()
                    .Send("item", "item.ID")
                    .SendReturnUrl());

            ButtonColumn("Delete").Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("New Supplier").Icon(FA.Plus)
                .OnClick(x => x.Go<P04A.Supplier.EnterPage>());
        }
    }
}
