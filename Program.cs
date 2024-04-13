namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCatalogsCount(); //   Вызов метода получения директорий
        }

        static void GetCatalogsCount()
        {
            string dirName = @"/"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога
                Console.WriteLine(dirs.Length);

                DirectoryInfo newDirectory = new DirectoryInfo(@"/newDirectory");
                if (!newDirectory.Exists)
                    newDirectory.Create();

                Console.WriteLine("Папки:");
                dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога
                Console.WriteLine(dirs.Length);

                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(@"/newDirectory");
                    dirInfo.Delete(true); // Удаление со всем содержимым
                    Console.WriteLine("Каталог удален");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Папки:");
                dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога
                Console.WriteLine(dirs.Length);

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога
                Console.WriteLine(files.Length);

                
            }
        }
    }
}