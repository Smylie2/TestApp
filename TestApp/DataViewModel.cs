using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    [ImplementPropertyChanged]
    public class DataViewModel
    {
        public ObservableCollection<DataLine> Lines { get; set; } = new ObservableCollection<DataLine>()
        {
            new DataLine() { Variable1 = 1, Variable2 = 2 },
            new DataLine() { Variable1 = 2, Variable2 = 2 },
            new DataLine() { Variable1 = 3, Variable2 = 2 },
            new DataLine() { Variable1 = 4, Variable2 = 2 },
            new DataLine() { Variable1 = 3, Variable2 = 2 },
            new DataLine() { Variable1 = 6, Variable2 = 2 }
        };
    }

    [ImplementPropertyChanged]
    public class DataLine
    {
        public int Variable1 { get; set; }
        public int Variable2 { get; set; }
    }
}
