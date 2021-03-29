using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Modules
{
    public class ProductAdd : FormModule<Domain.Product>
    {
        public ProductAdd()
        {
            HeaderText("Add Product");

            Field(x => x.Category).Mandatory();
            Field(x => x.Supplier);
            Field(x => x.Name);

            Button("Cancel").OnClick(x => x.ReturnToPreviousPage());

            Button("Save").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.ReturnToPreviousPage();
                });
        }
    }
}
