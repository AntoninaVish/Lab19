using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class PC
    {
        public int Id { get; set; } //код
        public string Name { get; set; } // название компьютера
        public string CPU { get; set; } // тип процессора
        public double Ghz { get; set; } // частота процессора
        public int Ram { get; set; } // объем оперативной памяти
        public int Hard { get; set; } // объем жесткого диска
        public int GraphicsCard { get; set; } //объем видеокарты
        public double Price { get; set; } //цена компьютера
        public int Quantity { get; set; } // количество шт.

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> listPС = new List<PC>()
            {
                new PC(){Id=1, Name="Samsung", CPU="AMD", Ghz=2.5, Ram=4, Hard=250, GraphicsCard=2, Price=25000, Quantity=5},
                new PC(){Id=2, Name="Asus", CPU="Intel", Ghz=3.2, Ram=16, Hard=500, GraphicsCard=6, Price=85000, Quantity=1},
                new PC(){Id=3, Name="Lenovo", CPU="Intel", Ghz=2.6, Ram=4, Hard=250, GraphicsCard=2, Price=45000, Quantity=3},
                new PC(){Id=4, Name="Acer", CPU="Intel", Ghz=4.0, Ram=6, Hard=350, GraphicsCard=4, Price=40000, Quantity=2},
                new PC(){Id=5, Name="MSI", CPU="AMD", Ghz=4.0, Ram=32, Hard=1000, GraphicsCard=8, Price=125000, Quantity=4},
                new PC(){Id=6, Name="HP", CPU="AMD", Ghz=2.6, Ram=12, Hard=750, GraphicsCard=8, Price=60000, Quantity=3},
                new PC(){Id=7, Name="Dell", CPU="AMD", Ghz=2.5, Ram=4, Hard=250, GraphicsCard=2, Price=30000, Quantity=9},
                new PC(){Id=8, Name="Asus", CPU="AMD", Ghz=4.0, Ram=32, Hard=800, GraphicsCard=8, Price=90000, Quantity=2},
            };
            Console.WriteLine("Укажите название процессора:");
            string cpu = Console.ReadLine();
            List<PC> computers1 = listPС
            .Where(x => x.CPU == cpu)
            .ToList();
            Print(computers1);

            Console.WriteLine("Укажите объем оперативной памяти:");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<PC> computers2 = listPС
            .Where(x => x.Ram >= ram)
            .ToList();
            Print(computers2);

            List<PC> computers3 = listPС
            .OrderBy(x => x.Price)
            .ToList();
            Print(computers3);

            IEnumerable<IGrouping<string, PC>> computers4 = listPС.GroupBy(x => x.CPU);
            foreach (IGrouping<string, PC> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (PC l in gr)
                {
                    Console.WriteLine($"Код: {l.Id}; Название: {l.Name}; Тип CPU: {l.CPU}; Чаcтота CPU: {l.Ghz}; Объем RAM: {l.Ram}; Объем HARD: {l.Hard}; Объем памяти видеокарты: {l.GraphicsCard}; Стоимость: {l.Price}; Количество(шт.): {l.Quantity}.");
                }
            }

            PC computers5 = listPС.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"Код: {computers5.Id}; Название: {computers5.Name}; Тип CPU: {computers5.CPU}; Чаcтота CPU: {computers5.Ghz}; Объем RAM: {computers5.Ram}; Объем HARD: {computers5.Hard}; Объем памяти видеокарты: {computers5.GraphicsCard}; Стоимость: {computers5.Price}; Количество(шт.): {computers5.Quantity}.");


            PC computers6 = listPС.OrderByDescending(x => x.Price).LastOrDefault();
            Console.WriteLine($"Код: {computers6.Id}; Название: {computers6.Name}; Тип CPU: {computers6.CPU}; Чаcтота CPU: {computers6.Ghz}; Объем RAM: {computers6.Ram}; Объем HARD: {computers6.Hard}; Объем памяти видеокарты: {computers6.GraphicsCard}; Стоимость: {computers6.Price}; Количество(шт.): {computers6.Quantity}.");

            Console.WriteLine(listPС.Any(x => x.Quantity > 30));

            Console.ReadKey();


        }
        static void Print(List<PC> listPС)
        {
            foreach (PC l in listPС)
            {
                Console.WriteLine($"Код: {l.Id}; Название: {l.Name}; Тип CPU: {l.CPU}; Чаcтота CPU: {l.Ghz}; Объем RAM: {l.Ram}; Объем HARD: {l.Hard}; Объем памяти видеокарты: {l.GraphicsCard}; Стоимость: {l.Price}; Количество(шт.): {l.Quantity}.");
            }

        }
    }
}
