using MSharp;

namespace Modules
{
    public class AdminSettingsMenu : MenuModule
    {
        public AdminSettingsMenu()
        {
            SubItemBehaviour(MenuSubItemBehaviour.ExpandCollapse);
            WrapInForm(false);
            AjaxRedirect();
            IsViewComponent();
            RootCssClass("sidebar-menu");
            UlCssClass("nav flex-column");
            Using("Olive.Security");


            Item("General settings")
                .OnClick(x => x.Go<Admin.Settings.GeneralPage>());

            Item("Administrators")
                .OnClick(x => x.Go<Admin.Settings.AdministratorsPage>());

            Item("Content blocks")
                .OnClick(x => x.Go<Admin.Settings.ContentBlocksPage>());

            var p04a = Item("P04A CRUD Operations")
                .Icon("FA.list");

            Item("Categories")
                .Parent(p04a)
                .Icon("FA.list")
                .OnClick(x => x.Go<P04A.Category.CategoriesPage>());

            Item("Supplier")
                .Parent(p04a)
                .Icon("FA.user")
                .OnClick(x => x.Go<P04A.Supplier.SuppliersPage>());

            Item("Products")
                .Parent(p04a)
                .Icon("FA.box")
                .OnClick(x => x.Go<P04A.Product.ProductsPage>());
        }
    }
}