using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Modules
{
    public class CategoryAdd : FormModule<Domain.Category>
    {
        public CategoryAdd()
        {
            HeaderText("Add Product Category");

            Field(x => x.Name);
            Field(x => x.Description).Control(ControlType.Textbox);

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
