using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Domain
{
    public class Supplier : EntityType
    {
        public Supplier()
        {
            DatabaseMode(DatabaseOption.Managed);

            String("CompanyName").Mandatory();
            String("Address", 512).Mandatory();
        }
    }
}
