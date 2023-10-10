namespace DelegatesAndEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Поиск дороги с макимальной длиной
            var listRoads = new List<Road> { new Road("Road415", 1525.12f), new Road("Road22", 156.35f) };
            var maxLength = listRoads.GetMax(road => road.Length);
            Console.WriteLine($"Максимальная длина: {maxLength}");
            
            // Поиск файлов в каталоге
            var fc = new FileSearch();
            
            // Подписка на событие при нахождении файла
            fc.FileFound += c_FileFound;
            
            fc.Search(@"D:\projects\otus");
        }

        private static void c_FileFound(object? sender, FileArgs e)
        {
            Console.WriteLine($"Файл найден {e.FileName}");
            Console.WriteLine($"Для выхода из поиска нажмите 0");
            if (Console.ReadKey(true).KeyChar == '0')
            {
                Console.WriteLine($"Поиск прерван");
                Environment.Exit(0);
            } 
        }
    }
}