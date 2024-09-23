using System;

namespace PranishDotNetLab
{
   
        class Money
        {
            int rupee, paisa;
            public Money(int rupee, int paisa)
            {
                this.rupee = rupee;
                this.paisa = paisa;
            }
            public void Display()
            {
                Console.WriteLine("Rs." + rupee + " " + paisa + " Paisa");
            }
            public Money Bigger(Money m)
            {
                int amount1 = m.rupee * 100 + m.paisa;
                int amount2 = this.rupee * 100 + this.paisa;
                if (amount1 > amount2)
                    return m;
                else
                    return this;
            }
        }
        internal class ThisKeywordThirdDemo
        {
            static void Main(string[] args)
            {
                Money m1 = new Money(23, 89);
                Money m2 = new Money(70, 20);
                Money m = m2.Bigger(m1);
                m.Display();
            Console.WriteLine("Lab_work 11(c)/Pranish Bajracharya/Roll no.: 13");

        }
    }
    }

