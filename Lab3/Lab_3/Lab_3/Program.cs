using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




class Program
{
    static void Main(string[] args)


    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("1");
        Console.WriteLine("Using Console Logger:");
        var consoleLogger = new Logger();
        consoleLogger.Log("This is a log message");
        consoleLogger.Error("This is an error message");
        consoleLogger.Warn("This is a warning message");

       
        Console.WriteLine("\nUsing File Logger:");
        var fileLogger = new FileLoggerAdapter("log.txt");
        fileLogger.Log("This is a log message");
        fileLogger.Error("This is an error message");
        fileLogger.Warn("This is a warning message");

        Console.WriteLine("\nCheck 'log.txt' file for logged messages.");

        Console.WriteLine("2");
        Console.WriteLine("RPG Heroes with Equipment (Decorator Pattern)");
        Console.WriteLine("==============================================");

        
        Hero warrior = new Warrior("Egil");
        Hero mage = new Mage("Megumin");
        Hero paladin = new Paladin("Elizabet");

        
        Console.WriteLine("\nBase heroes:");
        warrior.DisplayStats();
        mage.DisplayStats();
        paladin.DisplayStats();

       
        Console.WriteLine("\nEquipping Warrior:");
        Hero equippedWarrior = new Sword(warrior);
        equippedWarrior = new Shield(equippedWarrior);
        equippedWarrior = new LeatherArmor(equippedWarrior);
        equippedWarrior.DisplayStats();

     
        Console.WriteLine("\nEquipping Mage:");
        Hero equippedMage = new MagicAmulet(mage);
        equippedMage = new LeatherArmor(equippedMage);
        equippedMage.DisplayStats();

       
        Console.WriteLine("\nEquipping Paladin:");
        Hero equippedPaladin = new Sword(paladin);
        equippedPaladin = new Shield(equippedPaladin);
        equippedPaladin = new MagicAmulet(equippedPaladin);
        equippedPaladin.DisplayStats();

        Console.WriteLine("3");
        var raster = new RasterRenderer();
        var vector = new VectorRenderer();

        new Square(raster).Draw();
        new Circle(raster).Draw();
        new Triangle(vector).Draw();


        Console.WriteLine("4");
        var baseReader = new SmartTextReader();

       
        var checker = new SmartTextChecker(baseReader);
        Console.WriteLine("=== Testing with logging ===");
        checker.ReadText("document.txt");

       
        var locker = new SmartTextLocker(baseReader, @"restricted");
        Console.WriteLine("=== Testing with access restriction ===");
        locker.ReadText("restricted_document.txt");
        locker.ReadText("allowed_document.txt");


        Console.WriteLine("5");
        var table = new LightElementNode("table", "block", "pair", new List<string> { "student-table" });

        var header = new LightElementNode("thead", "block", "pair");
        var headerRow = new LightElementNode("tr", "block", "pair");

        var headers = new List<string> { "№", "Ім'я", "Оцінка" };
        foreach (var headerText in headers)
        {
            var headerCell = new LightElementNode("th", "inline", "pair");
            headerCell.AddChild(new LightTextNode(headerText));
            headerRow.AddChild(headerCell);
        }

        header.AddChild(headerRow);
        table.AddChild(header);

        
        var body = new LightElementNode("tbody", "block", "pair");

        var students = new List<(int, string, string)>
        {
            (1, "Нагапетян Олександ", "A"),
            (2, "Дашкевич Вікторія", "B+"),
            (3, "Лізунов Артем", "A-")
        };

        foreach (var student in students)
        {
            var row = new LightElementNode("tr", "block", "pair");
            row.AddChild(new LightTextNode(student.Item1.ToString()));
            row.AddChild(new LightTextNode(student.Item2));
            row.AddChild(new LightTextNode(student.Item3));
            body.AddChild(row);
        }

        table.AddChild(body);

        
        var title = new LightElementNode("h1", "block", "pair", new List<string> { "title" });
        title.AddChild(new LightTextNode("Оцінки студентів"));

        
        var container = new LightElementNode("div", "block", "pair", new List<string> { "container" });
        container.AddChild(title);
        container.AddChild(table);

        Console.WriteLine("Зовнішній HTML контейнера:");
        Console.WriteLine(container.OuterHTML);

        Console.WriteLine("\nВнутрішній HTML таблиці:");
        Console.WriteLine(table.InnerHTML);

        Console.WriteLine("\nПовний HTML вивід:");
        Console.WriteLine(container);

    }
}