internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        System.Console.WriteLine("Введите числа :");
        int NumA = Convert.ToInt32(Console.ReadLine());
        string Num = Convert.ToString(NumA);
        if (Num.Length>2)
        {
            System.Console.WriteLine("Третья цыфра :"+Num[2]);
        }
        else 
        {
            System.Console.WriteLine("Третьей цыфры нет");
        }
    }   
}