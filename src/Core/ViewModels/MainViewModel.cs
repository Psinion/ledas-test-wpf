using Core.Data;

namespace Core
{
    public class MainViewModel : BaseViewModel
    {
        #region Fields

        private SquareEntity squareModel;

        private IFileDialog fileDialog;
        private IFile<SquareEntity> file;

        #endregion

        #region Properties

        public SquareEntity SquareModel
        {
            get { return squareModel; }
            set
            {
                squareModel = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands

        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }

        private RelayCommand openCommand;
        public RelayCommand OpenCommand
        {
            get { return openCommand; }
        }

        #endregion

        #region Constructor

        public MainViewModel()
        {
            squareModel = new SquareEntity();
            fileDialog = new MainViewModelFileDialog();
            file = new SquareEntityFile();

            saveCommand = new RelayCommand(obj =>
            {
                try
                {
                    if(fileDialog.SaveFileDialog() == true)
                    {
                        file.Save(fileDialog.FilePath, SquareModel);
                    }
                }
                catch(Exception ex)
                {
                    fileDialog.ShowMessage("Ошибка:\n" + ex.Message);
                }
            });

            openCommand = new RelayCommand(obj =>
            {
                try
                {
                    if (fileDialog.OpenFileDialog() == true)
                    {
                        SquareModel = file.Open(fileDialog.FilePath);
                        SquareModel.CheckSquareCondition();
                    }
                }
                catch (Exception ex)
                {
                    fileDialog.ShowMessage("Ошибка:\n" + ex.Message);
                }
            });
        }

        #endregion

        #region Public Methods 

        #endregion
    }
}
