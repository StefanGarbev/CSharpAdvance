﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Tuple
{
    internal class CustomTuple<T1,T2>
    {
        public CustomTuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public T1 Item1 { get; }
        public T2 Item2 { get; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }

    }
}
