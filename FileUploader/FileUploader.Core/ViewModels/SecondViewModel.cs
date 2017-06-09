using MvvmCross.Core.ViewModels;

namespace FileUploader.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        #region Commands

        IMvxCommand _goBackCommand;
        public IMvxCommand GoBackCommand =>
            _goBackCommand ?? (_goBackCommand = new MvxCommand(() => Close(this)));

        #endregion
    }
}
