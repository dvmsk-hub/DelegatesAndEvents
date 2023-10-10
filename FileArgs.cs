namespace DelegatesAndEvents;
/// <summary>
/// Пользовательский класс от EventArgs 
/// </summary>
public class FileArgs : EventArgs
{
    public string? FileName { get; set; }
}