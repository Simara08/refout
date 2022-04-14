using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine
{
    class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private static int  _count;
        public int Count { get; set; }

        
        public bool IsDeleted { get; internal set; }

        public void Sell()
        {
            Count = _count--;
        }
        public string ShowInfo()
        {
            var result = IsDeleted ? "Ehtiyatda var" : "Ehtiyatda yoxdur";
            return $"Id:{Id}\nName:{Name}\nPrice{Price}\nCount:{Count}\nIsdeleted{IsDeleted}";
        }
        public Medicine(int count)
        {
            Count = count;
        }

        public Medicine(string name, int id, double price, int count)
        {
            Name = name;
            Id = id;
            Price = price;
            Count = count;
            

        }
        public Medicine()
        {

        }
    }
}
