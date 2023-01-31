using OTUS.Delegate.FileSearch;

FileFinder fileFinder = new();

fileFinder.FileFound += (s, e) =>
{
    Console.WriteLine($"Найден файл {e.FileName}");
    Console.WriteLine($"Продолжить поиск? (Y/N)");

    ConsoleKeyInfo input;
    do
    {
        input = Console.ReadKey(true);
    } while (input.Key != ConsoleKey.Y && input.Key != ConsoleKey.N);

    return input.Key == ConsoleKey.Y;
};

string? path;

do
{
    Console.WriteLine("Введите полный путь до каталога в котором необходимо выполнить поиск");
    path = Console.ReadLine();
} while (path == null);

fileFinder.SearhAllFile(path);
