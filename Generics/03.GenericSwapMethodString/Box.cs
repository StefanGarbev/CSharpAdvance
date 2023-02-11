using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericSwapMethodString
{
    internal class Box<T>
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
