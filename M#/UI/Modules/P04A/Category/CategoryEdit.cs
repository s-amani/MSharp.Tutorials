using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Modules
{
    public class CategoryEdit : FormModule<Domain.Category>
    {
        public CategoryEdit()
        {
            HeaderText("Edit Product Category");

            Field(x => x.Name);
            Field(x => x.Description);

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
