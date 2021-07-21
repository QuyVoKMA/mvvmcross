using MvvmCross.ViewModels;
using mvvmCross1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmCross1.ViewModels
{
   public class GuestBookViewModel: MvxViewModel
    {
        // ObservableCollection nó mô tả một tập hợp các dữ liệu có thể thay đổi
        private ObservableCollection<PersonModel> _people = new ObservableCollection<PersonModel>();

        public ObservableCollection<PersonModel> People
        {
            get { return _people; }
            set { SetProperty(ref _people , value); }
        }


        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }
    }
}
