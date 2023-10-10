namespace DelegatesAndEvents;
/// <summary>
/// Класс дорога
/// </summary>
public class Road
{
    public string Name { get; set; }
    public float Length { get; set; }

    public Road(string name, float length)
    {
        Name = name;
        Length = length;
    }   
}