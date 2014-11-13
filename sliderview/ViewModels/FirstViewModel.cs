using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore.Platform;
using System.Windows.Input;

namespace sliderview.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        public ICommand Next
        {
            get { return new MvxCommand(() => ShowViewModel<SecondViewModel>()); }
        }
    }

    public class SecondViewModel 
        : MvxViewModel
    {
        public ICommand Next
        {
            get { return new MvxCommand(() => ShowViewModel<ThirdViewModel>()); }
        }

        public ICommand Back
        {
            get { return new MvxCommand(() => ShowViewModel<FirstViewModel>()); }
        }
    }

    public class ThirdViewModel 
        : MvxViewModel
    {
        public ICommand Back
        {
            get { return new MvxCommand(() => ShowViewModel<SecondViewModel>()); }
        }
    }
}
