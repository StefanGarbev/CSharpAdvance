using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GenericBoxOfInteger
{
    internal class Box<T>
    {
        private List<T> listInt;

        public Box()
        {
            ListInt = new List<T>();
        }

        public List<T> ListInt { get; set; }

        public void Add(T index)
        { 
            ListInt.Add(index);
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            foreach (T item in ListInt)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString();
        }
    }
}
