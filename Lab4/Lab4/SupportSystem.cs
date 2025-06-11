using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SupportSystemApp
{
    abstract class SupportHandler
    {
        protected SupportHandler nextHandler;

        public void SetNext(SupportHandler handler)
        {
            nextHandler = handler;
        }

        public abstract bool Handle();
    }

    class Level1Support : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("1.Чи маєте загальне питання про тарифи?");
            Console.WriteLine("1 - Так");
            Console.WriteLine("2 - Ні");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Ваш запит буде оброблений Підтримкою 1 рівня.");
                return true;
            }

            return nextHandler?.Handle() ?? false;
        }
    }

    class Level2Support : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("2.Ви маєте технічні проблеми з інтернетом?");
            Console.WriteLine("1 - Так");
            Console.WriteLine("2 - Ні");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Ваш запит буде оброблений Підтримкою 2 рівня.");
                return true;
            }

            return nextHandler?.Handle() ?? false;
        }
    }

    class Level3Support : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("3.Ви хочете змінити SIM-карту або отримати нову?");
            Console.WriteLine("1 - Так");
            Console.WriteLine("2 - Ні");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Ваш запит буде оброблений Підтримкою 3 рівня.");
                return true;
            }

            return nextHandler?.Handle() ?? false;
        }
    }

    class Level4Support : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("4.Чи маєте питання до адміністрації або скарги?");
            Console.WriteLine("1 - Так");
            Console.WriteLine("2 - Ні");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Ваш запит буде оброблений Підтримкою 4 рівня.");
                return true;
            }

            return false;
        }
    }

    class SupportSystem
    {
        private SupportHandler chain;

        public SupportSystem()
        {
            var level1 = new Level1Support();
            var level2 = new Level2Support();
            var level3 = new Level3Support();
            var level4 = new Level4Support();

            level1.SetNext(level2);
            level2.SetNext(level3);
            level3.SetNext(level4);

            chain = level1;
        }

        public void Start()
        {
            bool handled = false;
            while (!handled)
            {
                Console.WriteLine("\nВітаємо в системі підтримки. Виберіть ваш запит:");
                handled = chain.Handle();

                if (!handled)
                {
                    Console.WriteLine("Ваш запит не було розпізнано. Спробуйте ще раз.");
                }
            }
        }
    }
}
