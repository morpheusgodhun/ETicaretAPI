using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities {
    public class Order : BaseEntities {

        public string Description { get; set; }
        public string Adress { get; set; }
        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }

    }
}