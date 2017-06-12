using MvvmCross.Core.ViewModels;
using Plugin.FilePicker;
using Plugin.FilePicker.Abstractions;
using System;
namespace FileUploader.Core
{
    public class MainViewModel : MvxViewModel
    {
        private string _fileChoosed;
        public string FileChoosed
        {
            get
            {
                return _fileChoosed;
            }
            set
            {
                _fileChoosed = value;
                RaisePropertyChanged(() => FileChoosed);
                // take any additional actions here which are required when MyProperty is updated
            }
        }

        public IMvxAsyncCommand ChooseFileCommand { get; set; }
        public MainViewModel()
        {
            ChooseFileCommand = new MvxAsyncCommand(async () =>
            {
                try
                {

                    FileData filedata = await CrossFilePicker.Current.PickFile();
                    FileChoosed = filedata.FileName;
                }
                catch (Exception ex)
                {

                }
            });
        }

        // Init and Start are important parts of MvvmCross' CIRS ViewModel lifecycle
        // Learn how to use Init and Start at https://github.com/MvvmCross/MvvmCross/wiki/view-model-lifecycle
        public void Init()
        {
        }

        public override void Start()
        {
        }
    }
}
