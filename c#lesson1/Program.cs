#region task1
using System.ComponentModel.Design;

int number=int.Parse(Console.ReadLine());
while(number>0)
if (number > 999 && number < 10000) 
{
    Console.Write("7");
    Console.Write(number);
    Console.WriteLine("8");
        break;
}
else 
{
        Console.WriteLine("Yalniz 4 reqemli eded daxil ede bilersiniz");
        number = int.Parse(Console.ReadLine());
 
}

#endregion