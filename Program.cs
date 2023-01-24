using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int imagesInRow = 3;
            int allUserImages = 52;
            int numberOfRows = allUserImages / imagesInRow;
            int remainsImages = allUserImages - (numberOfRows * imagesInRow);

            Console.WriteLine($"Полностью заполненых рядов: {numberOfRows}\nКоличество картинок неполного ряда: {remainsImages}");
        }
    }
}
