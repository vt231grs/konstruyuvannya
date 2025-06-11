using System;
using System.Collections.Generic;
using Components;
using Components.Strategies;
using Mediator;
using TextEditor.Models; // Добавляем using для TextEditor

namespace SupportSystemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Меню завдань:");
                Console.WriteLine("1 - Запустити систему підтримки");
                Console.WriteLine("2 - Запустити систему диспетчеризації (Посередник)");
                Console.WriteLine("3 - Демонстрація HTML з подіями (Спостерігач)");
                Console.WriteLine("4 - Демонстрація завантаження зображень (Стратегія)");
                Console.WriteLine("5 - Текстовий редактор (Мементо)");
                Console.WriteLine("0 - Вийти");

                Console.Write("\nВаш вибір: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var supportSystem = new SupportSystem();
                        supportSystem.Start();
                        Pause();
                        break;

                    case "2":
                        RunMediatorExample();
                        Pause();
                        break;

                    case "3":
                        RunObserverExample();
                        Pause();
                        break;

                    case "4":
                        RunStrategyExample();
                        Pause();
                        break;

                    case "5":
                        RunMementoExample();
                        Pause();
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        Pause();
                        break;
                }
            }
        }

        static void RunMediatorExample()
        {
            var commandCentre = new CommandCentre();
            var runway = new Runway(commandCentre);
            var aircraft1 = new Aircraft(commandCentre, "Рейс A123");
            var aircraft2 = new Aircraft(commandCentre, "Рейс B456");

            aircraft1.RequestLanding();
            aircraft2.RequestLanding();
        }

        static void RunObserverExample()
        {
            Console.WriteLine("\n=== Демонстрація HTML з подіями ===");

            var div = new LightElementNode("div", isBlock: true, isSelfClosing: false);
            div.AddChild(new LightTextNode("Натисніть мене!"));

            div.AddEventListener("click", () => {
                Console.WriteLine("Подія: Клік на div елементі!");
            });

            div.AddEventListener("mouseover", () => {
                Console.WriteLine("Подія: Миша над елементом!");
            });

            Console.WriteLine("\nІмітація подій:");
            div.TriggerEvent("click");
            div.TriggerEvent("mouseover");
        }

        static void RunStrategyExample()
        {
            Console.WriteLine("\n=== Демонстрація стратегій завантаження зображень ===");

            string testImagePath = "test.jpg";
            string testImageUrl = "https://example.com/test.jpg";

            Console.WriteLine("\n1. Тестування завантаження з файлової системи:");
            var fileImage = new LightImageNode(testImagePath, "Тестове зображення");
            try
            {
                var imageData = fileImage.LoadImage();
                Console.WriteLine(imageData != null
                    ? $"Успішно завантажено {imageData.Length} байт"
                    : "Не вдалося завантажити зображення");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            Console.WriteLine("\n2. Тестування завантаження з мережі:");
            var webImage = new LightImageNode(testImageUrl, "Мережеве зображення");
            try
            {
                var imageData = webImage.LoadImage();
                Console.WriteLine(imageData != null
                    ? $"Успішно завантажено {imageData.Length} байт"
                    : "Не вдалося завантажити зображення");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        static void RunMementoExample()
        {
            Console.WriteLine("\n=== Текстовий редактор (Мементо) ===");

            var editor = new TextEditor.Models.TextEditor("Початковий текст");
            bool runningEditor = true;

            while (runningEditor)
            {
                Console.WriteLine("\nПоточний текст: " + editor.GetContent());
                Console.WriteLine($"Історія змін ({editor.GetHistoryCount()}):");
                Console.WriteLine("1 - Редагувати текст");
                Console.WriteLine("2 - Скасувати останню зміну");
                Console.WriteLine("0 - Повернутися в головне меню");

                Console.Write("\nВаш вибір: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введіть новий текст: ");
                        var newText = Console.ReadLine();
                        editor.Edit(newText);
                        break;

                    case "2":
                        editor.Undo();
                        Console.WriteLine("Останню зміну скасовано");
                        break;

                    case "0":
                        runningEditor = false;
                        break;

                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }

        static void Pause()
        {
            Console.WriteLine("\nНатисніть будь-яку клавішу, щоб повернутися в меню...");
            Console.ReadKey();
        }
    }
}