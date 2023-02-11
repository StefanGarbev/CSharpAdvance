using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GenericCountMethodDouble
{
    internal class Box<T> where T : IComparable<T>
    {
        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        public void Add(T index)
        { 
            list.Add(index);
        }

        public void Swap( int index1, int index2)
        {
            T temporaryVarialbe = list[index1];
            list[index1] = list[index2];
            list[index2] = temporaryVarialbe;

        }

        public int Count(T input)
        {
            int count = 0;

            foreach (T index in list)
            { 
                input.CompareTo(index);
                if (input.CompareTo(index) < 0)
                {
                    count++;
                }
            }

            return count;
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            foreach (T item in list)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString();
        }
    }
}
