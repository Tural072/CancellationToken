using CancellationToken.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancellationToken.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        public RelayCommand MyProperty { get; set; }
        public MainViewModel()
        {

        }
    }
}
