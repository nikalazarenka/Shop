using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ClothesId { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [ForeignKey("ClothesId")]
        public virtual Clothes Clothes { get; set; }
    }
}
