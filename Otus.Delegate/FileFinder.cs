namespace OTUS.Delegate.FileSearch
{
    public class FileFinder
    {
        public delegate bool FileFoundEvenHandler(object sender, FileArgs args);

        public event FileFoundEvenHandler? FileFound;

        public void SearhAllFile(string catalogPath)
        {
            DirectoryInfo dir = new DirectoryInfo(catalogPath);
            foreach (FileInfo file in dir.GetFiles())
            {
                var args = new FileArgs() { FileName = file.Name };
                if (FileFound?.Invoke(this, args) == false)
                    break; 
            }
        }
    }
}
