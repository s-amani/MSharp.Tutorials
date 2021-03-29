using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Modules
{
    public class ProductView : ViewModule<Domain.Product>
    {
        public ProductView()
        {
            HeaderText("Product view");

            Field(x => x.Category);

            Field(x => x.Supplier);

            Field(x => x.Name);

            Button("Back").Icon(FA.ChevronLeft)
                .OnClick(x => x.ReturnToPreviousPage());
        }
    }
}
