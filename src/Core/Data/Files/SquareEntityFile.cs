namespace Core.Data
{
    internal class SquareEntityFile : IFile<SquareEntity>
    {
        public SquareEntity Open(string filename)
        {
            using (BinaryReader reader = new BinaryReader(File.OpenRead(filename)))
            {
                string a = reader.ReadString();
                string b = reader.ReadString();
                string c = reader.ReadString();

                return new SquareEntity(a, b, c);
            }
        }

        public void Save(string filename, SquareEntity model)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.Create)))
            {
                writer.Write(model.A);
                writer.Write(model.B);
                writer.Write(model.C);
            }
        }
    }
}
