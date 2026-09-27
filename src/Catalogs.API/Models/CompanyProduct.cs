using EShopCore.Core;

namespace Catalogs.API.Models
{
    public class CompanyProduct : BaseClass
    {
        public string? Name { get; set; }
        public IList<string> Category { get; set; } = new List<string>();
        public string? Description { get; set; }
        public string? ImageFile { get; set; }
        public decimal Property { get; set; }
    }
}
