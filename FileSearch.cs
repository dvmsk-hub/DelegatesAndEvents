namespace DelegatesAndEvents;
/// <summary>
/// Поиск файлов класс
/// </summary>
public sealed class FileSearch
{
    /// <summary>
    /// Поиск файлов метод
    /// </summary>
    /// <param name="targetDirectory"></param>
    public void Search(string targetDirectory)
    {
        var fileEntries = Directory.GetFiles(targetDirectory);
        foreach (var file in fileEntries)
        {
            var args = new FileArgs
            {
                FileName = file
            };
            OnFileFound(args);
        }
    }
    
    /// <summary>
    /// Событие при нахождения файла
    /// </summary>
    public event EventHandler<FileArgs>? FileFound;

    private void OnFileFound(FileArgs e)
    {
        FileFound?.Invoke(this, e);
    }
}