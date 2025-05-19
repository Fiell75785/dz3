using System;

namespace MoneyProductExample
{

    public class Money
    {

        private int mainPart;

        private int subPart;

        public Money()
        {
            mainPart = 0;
            subPart = 0;
        }

        public Money(int mainPart, int subPart)
        {
            SetValues(mainPart, subPart);
        }

        public void SetValues(int mainPart, int subPart)
        {
            if (subPart >= 100)
            {
                mainPart += subPart / 100;
                subPart = subPart % 100;
            }
            else if (subPart < 0)
            {
                int borrow = (Math.Abs(subPart) + 99) / 100;
                mainPart -= borrow;
                subPart += borrow * 100;
            }

            this.mainPart = mainPart;
            this.subPart = subPart;
        }

        public void Display()
        {
            Console.WriteLine($"{mainPart}.{subPart:D2}");
        }

        public void Decrease(int decreaseSubPart)
        {
            int totalSubParts = mainPart * 100 + subPart - decreaseSubPart;
            if (totalSubParts < 0)
            {
                totalSubParts = 0;
            }
            SetValues(totalSubParts / 100, totalSubParts % 100);
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void ReducePrice(int decreaseCents)
        {
            Price.Decrease(decreaseCents);
        }

        public void Display()
        {
            Console.WriteLine($"Товар: {Name}");
            Console.Write("Цена: ");
            Price.Display();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Money money = new Money(10, 50);
            Console.WriteLine("Исходная сумма:");
            money.Display();

            money.Decrease(125);
            Console.WriteLine("После уменьшения на 1.25:");
            money.Display();

            Product product = new Product("Книга", new Money(15, 75));
            product.Display();

            product.ReducePrice(200);
            Console.WriteLine("После уменьшения цены на 2.00:");
            product.Display();
        }
    }
}
