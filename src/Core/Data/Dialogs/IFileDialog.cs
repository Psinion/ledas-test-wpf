namespace Core.Data
{
    internal interface IFileDialog
    {
        string FilePath { get; }
        bool OpenFileDialog();
        bool SaveFileDialog();

        void ShowMessage(string message);
    }
}
