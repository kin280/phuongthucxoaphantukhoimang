internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 10, 4, 6, 7, 8, 6, 0, 0, 0, 0 };

        Console.Write("Nhập phần tử cần xoá: ");
        int X = int.Parse(Console.ReadLine());

        int iX = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == X)
            {
                iX = i;
                break;
            }
        }
        if (iX != -1)
        {
            for (int i = iX; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1); 
            Console.WriteLine($"Phần tử {X} đã được xoá khỏi mảng.");
        }
        else
        {
            Console.WriteLine($"Phần tử {X} không xuất hiện trong mảng.");
        }

        Console.Write("Mảng sau khi xoá: ");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }





    }
}