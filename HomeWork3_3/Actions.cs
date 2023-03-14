using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_3
{
    public class Actions
    {
        public void Run()
        {
            var calculator = new Сalculator();

            calculator.TrySum(calculator.SumCalculate, 2, 2);

            this.ShowLINQ();
        }

        private List<Person> CreateList()
        {
            var list = new List<Person>();
            list.AddRange(
                new Person[]
                {
                new Person("Andrey", 15),
                new Person("Sergey", 14),
                new Person("Dasha", 19),
                new Person("Vasia", 15),
                new Person("Maksim", 1985),
                new Person("Oleh", 155),
                });
            return list;
        }

        private void ShowLINQ()
        {
            var contats = this.CreateList();
            var first = contats.FirstOrDefault();

            var where = contats
                .Where(x => x.GetID() == 15)
                .ToList();

            int i = 0;
            var select = contats
                .Select(x => $"{i++} {x}")
                .ToList();

            var reversFirstTwo = contats
                .Take(2)
                .Reverse() 
                .ToList();

            var countOleh = contats
                .Where(x => x.GetName() == "Oleh")
                .Count();

            var alphabetLastName = contats
                .OrderBy(x => x.GetName())
                .LastOrDefault();
        }
    }
}
