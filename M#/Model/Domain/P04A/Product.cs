using MSharp;

namespace Domain
{
    public class Product : EntityType
    {
        public Product()
        {
            DatabaseMode(DatabaseOption.Managed);

            String("Name", 64).Mandatory();

            Associate<Supplier>("Supplier").Mandatory();
            Associate<Category>("Category").Mandatory();
        }
    }
}
