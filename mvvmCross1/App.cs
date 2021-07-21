using MvvmCross.ViewModels;
using mvvmCross1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmCross1
{
   public class App: MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<GuestBookViewModel>();
        }
    }
}
