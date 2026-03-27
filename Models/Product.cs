using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }

        [Display(Name = "Urun Adı")]
        public string? Name { get; set; }

        [Display(Name = "Urun Ücreti")]
        public decimal Price { get; set; }

        [Display(Name = "Urun Resmi")]
        public string Image { get; set; } = string.Empty;

        public bool IsActive { get; set; }


        [Display(Name = "Category")]
        public int CategoryId { get; set; }
    }
}