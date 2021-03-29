using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Modules
{
    public class SupplierAdd : FormModule<Domain.Supplier>
    {
        public SupplierAdd()
        {
            HeaderText("Add Supplier");

            Field(x => x.CompanyName).Mandatory();
            Field(x => x.Address);

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
