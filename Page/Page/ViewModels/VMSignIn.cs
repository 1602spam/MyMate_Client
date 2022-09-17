using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Page.ViewModels
{
    public class VMSignIn : VMBase
    {
        public ICommand SignInCommand => new Command(
        () =>
        {
            
        });
    }
}
