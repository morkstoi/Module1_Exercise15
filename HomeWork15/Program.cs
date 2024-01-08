using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создадим арифметическую прогрессию.");
            Console.WriteLine("Введите начальное значение прогрессии.");
            int arProgrStart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("А теперь введите шаг прогрессии.");
            int arProgrStep = Convert.ToInt32(Console.ReadLine());

            ArithProgression arProgr = new ArithProgression(arProgrStart, arProgrStep);

            Console.WriteLine("Следующий член арифметической прогрессии равен: {0}", arProgr.getNext());
            Console.WriteLine("А следующий после него: {0}", arProgr.getNext());
            Console.WriteLine("А после их обоих: {0}", arProgr.getNext());
            arProgr.reset();
            Console.WriteLine("А теперь сбросим к начальному значению и теперь следующее в прогрессии снова: {0}", arProgr.getNext());
            
            
            Console.WriteLine();

            Console.WriteLine("Теперь создадим геометрическую прогрессию.");
            Console.WriteLine("Введите начальное значение геометричской прогрессии.");
            int geoProgrStart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("А теперь введите шаг прогрессии.");
            int geoProgrStep = Convert.ToInt32(Console.ReadLine());
            
            GeomProgression geoProgr = new GeomProgression(geoProgrStart, geoProgrStep);

            Console.WriteLine("Следующий член геометрической прогрессии равен: {0}", geoProgr.getNext());
            Console.WriteLine("А следующий после него: {0}", geoProgr.getNext());
            Console.WriteLine("А после их обоих: {0}", geoProgr.getNext());
            geoProgr.reset();
            Console.WriteLine("А теперь сбросим к начальному значению и теперь следующее в прогрессии снова: {0}", geoProgr.getNext());

            
            Console.ReadKey();
        }


       interface ISeries
        {
            void setStart(int x);
            int getNext();
            void reset();
        }


        class ArithProgression : ISeries
        {
            int value = 0;
            int firstValueDefault = 0;
            int step = 0;
            
            public void setStart(int x)
            {
                value = x;
                firstValueDefault = x;
            }
            public void setStep(int s)
            {
                step = s;
            }

            public int getNext()
            {
                value = value + step;
                return value;
            }

            public void reset()
            {
                value = firstValueDefault;
            }
            public ArithProgression(int x, int s)
            {
                value = x;
                firstValueDefault = x;
                step = s;
            }
        }


        class GeomProgression : ISeries
        {
            int value = 0;
            int firstValueDefault = 0;
            int step = 0;

            public void setStart(int x)
            {
                value = x;
                firstValueDefault = x;
            }
            public void setStep(int s)
            {
                step = s;
            }

            public int getNext()
            {
                value = value * step;
                return value;
            }

            public void reset()
            {
                value = firstValueDefault;
            }
            public GeomProgression(int x, int s)
            {
                value = x;
                firstValueDefault = x;
                step = s;
            }
        }

    }
}