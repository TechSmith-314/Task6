using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int imagesInRow = 3;
            int allUserImages = 52;
            int numberOfImagesRows = allUserImages / imagesInRow;
            int remainsImages = allUserImages % imagesInRow;

            Console.WriteLine($"Полностью заполненых рядов: {numberOfImagesRows}\nКоличество картинок неполного ряда: {remainsImages}");
        }
    }
}