using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЖАБРАИЛОВ_Азизхан_27_ИС
{
    public class Box
    {
        public float width;
        public float height;
        public float length;

        public void Show()
        {
            Console.WriteLine("Ширина = " + width + ", Высота = " + height + ", Длина = " + length);
        }

        public float Volume()
        {
            return width * height * length;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект и задаем размеры
            Box myBox = new Box();
            myBox.width = 2;
            myBox.height = 3;
            myBox.length = 5;

            // Выводим данные и объём 
            myBox.Show();
            Console.WriteLine("Объём коробки: " + myBox.Volume());
            Console.ReadKey();
        }
    }
}