using System.Collections.ObjectModel;

namespace ERInv.Model
{

    public class Product

    {
        public string Imf { get; set; }
        public string Description { get; set; }
        public string Type_issue { get; set; }
        public string Vend_num { get; set; }
        public string Man_num { get; set; }
        public string Location { get; set; }
       
        public static implicit operator Product(List<Product> v)
            { 
                throw new NotImplementedException();
            }
       }

}

