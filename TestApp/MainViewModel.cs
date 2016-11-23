using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    [ImplementPropertyChanged]
    public class MainViewModel
    {
        public DataViewModel DataViewModel { get; set; } = new DataViewModel();
    }
}
