using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDesignDataDemo.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        public BaseViewModel SelectedViewModel { get; set; }

        public ShellViewModel()
        {
            SelectedViewModel = new CustomersViewModel();
        }
    }
}
