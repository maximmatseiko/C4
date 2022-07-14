// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите число :");
int NumA = Convert.ToInt32(Console.ReadLine());

void week(int NumA)
{
    switch (NumA)
    {
        case 6:
        case 7:
            System.Console.WriteLine("Этот день выходной");
            break;
        case < 1:
        case > 7:
            System.Console.WriteLine("Это вообще не день недели");
            break; 
        default :
            System.Console.WriteLine("Этот день будний");
            break;

    }
    

 } week(NumA);


