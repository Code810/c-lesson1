#region task1 metod1

//int number=int.Parse(Console.ReadLine());
//while(number>0)
//if (number > 999 && number < 10000) 
//{
//    Console.Write("7");
//    Console.Write(number);
//    Console.WriteLine("8");
//        break;
//}
//else 
//{
//        Console.WriteLine("Yalniz 4 reqemli eded daxil ede bilersiniz");
//        number = int.Parse(Console.ReadLine());

//}

#endregion

#region task1 metod2


int number = int.Parse(Console.ReadLine());

string result = number switch
{
        _ when number > 999 && number < 10000 => "7" + number + "8",
        _ => "4 reqemli eded daxil edilmelidir"
};
Console.WriteLine(result);
#endregion