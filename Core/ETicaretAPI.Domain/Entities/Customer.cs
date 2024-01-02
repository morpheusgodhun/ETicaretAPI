using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities {
    public class Customer : BaseEntities {
        public ICollection<Order> Orders { get; set; }
        public string Name { get; set; }
     
       

    }
}
