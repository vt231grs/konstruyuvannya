using Lab_2.Factory;
using Lab_2.Prototype;
using Lab2.Alone;
using Lab2.TechFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Console.OutputEncoding = Encoding.UTF8;

            TotSubscription domestic = new DomesticSubscription();
            TotSubscription educational = new EducationalSubscription();
            TotSubscription premium = new PremiumSubscription();

            Console.WriteLine(domestic.GetSubscriptionInfo());
            Console.WriteLine(educational.GetSubscriptionInfo());
            Console.WriteLine(premium.GetSubscriptionInfo());
            Console.WriteLine();

            Console.WriteLine("2");
            {
                TestFactory(new IProneFactory());
                TestFactory(new KiaomiFactory());
                TestFactory(new BalaxyFactory());
            }

             void TestFactory(IDeviceFactory factory)
            {
                var laptop = factory.CreateLaptop();
                var netbook = factory.CreateNetbook();
                var ebook = factory.CreateEBook();
                var phone = factory.CreateSmartphone();

                laptop.ShowInfo();
                netbook.ShowInfo();
                ebook.ShowInfo();
                phone.ShowInfo();

                Console.WriteLine(new string('-', 30));
            }

            Console.WriteLine("3");
            var success = Authenticator.Instance.Login("admin", "root");
            Console.WriteLine($"Login with 'admin/root': {(success ? "SUCCESS" : "FAIL")}");



            Console.WriteLine("4");
            var parent = new Virus(3.4, 15, "ParentVirus", "A");

            var child1 = new Virus(0.7, 3, "ChildVirus1", "B");
            var child2 = new Virus(0.9, 12, "ChildVirus2", "C");

            parent.Children.Add(child1);
            parent.Children.Add(child2);

            parent.Info();


            Console.WriteLine("5");
            var heroBuilder = new HeroBuilder();
            var enemyBuilder = new EnemyBuilder();
            var director = new CharacterDirector();

            director.ConstructHero(heroBuilder);
            director.ConstructEnemy(enemyBuilder);

            Character hero = heroBuilder.Build();
            Character enemy = enemyBuilder.Build();

            Console.WriteLine("=== Hero ===");
            Console.WriteLine(hero);
            Console.WriteLine("\n=== Enemy ===");
            Console.WriteLine(enemy);


        }
    }
}
