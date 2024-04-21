using System.Collections.ObjectModel;

namespace ERInv
{
    public class Item
    {
        public string Imf { get; set; }
        public string Description { get; set; }
        public string Group { get; set; }
        public string Type_issue { get; set; }
        public string Unit_issue { get; set; }
        public string Par { get; set; }
        public string Emergency { get; set; }
        public string Reorder { get; set; }
        public string Part_num { get; set; }

        public static implicit operator Item(ObservableCollection<Item> v)
        {
            throw new NotImplementedException();
        }
    }
}


