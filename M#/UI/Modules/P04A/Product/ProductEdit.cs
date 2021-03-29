using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Modules
{
    public class ProductEdit : FormModule<Domain.Product>
    {
        public ProductEdit()
        {
            HeaderText("Edit Product");

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
