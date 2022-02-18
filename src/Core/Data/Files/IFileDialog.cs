namespace Core.Data
{
    internal interface IFile<T>
    {
        T Open(string filename);

        void Save(string filename, T model);
    }
}
