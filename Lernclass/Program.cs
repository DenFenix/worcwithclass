﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class Program
    {
        static void Main(string[] args)
        {
            //управление доступом осуществляется  public, private, protected, internal
            //public  разрешает доступ разрешает доступ к члену откуда угодно
            //private разрешает доступ к члену только для методов внури этого класса
            //первый пример set, ger к приватной переменной

            /* MyClass firsttime = new MyClass();
             //не видит переменнойальфа
             firsttime.SetAlpha(6);
             Console.WriteLine(firsttime.GetAlpha());
             Console.ReadKey();*/

            //Создание стека
            Stack stk1 = new Stack(10);
            Stack stk2 = new Stack(10);
            Stack stk3 = new Stack(10);
            char ch; int i;
            for (i = 0; !stk1.full(); i++)
            {
                stk1.push((char)('A'+i));
            }
            if (stk1.full())
                Console.WriteLine("Стек stk1 полон.");
            Console.Write("Содержимое стека stk1");
            while (!stk1.empty())
            {
                ch = stk1.pop();
                Console.Write(ch);
            }
            Console.WriteLine();
            if (stk1.empty()) Console.WriteLine("Стек stk1 пуст.\n");
            Console.ReadKey();

        }
    }
}
