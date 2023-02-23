using System.ComponentModel.DataAnnotations;

namespace GeekShop.React.Models
{
    public class ProductViewModel
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
        public string categoryName { get; set; }
        public string imageURL { get; set; }

        [Range(1, 100)]
        public int Count { get; set; } = 1;

        public string SubstringName()
        {
            if (name.Length < 24) return name;
            return $"{name.Substring(0, 21) } ...";
        }

        public string SubstringDescription()
        {
            if (description.Length < 355) return description;
            return $"{description.Substring(0, 352) } ...";
        }
    }
}
