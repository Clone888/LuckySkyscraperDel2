
// DEL 2!!!!!!!!!!!

var floor = 5;

if (floor % 10 == 4 || floor % 100 == 13)
{
    Console.WriteLine("Kan ej omvandla till riktigt våningsnummer");
}

else
{
    if (floor == 5)     //Funkar inte på enkel "5" då blir det "4" vill ha det till "3"??
    {              
        Console.WriteLine(floor - 1);
             
        if (floor % 10 == 4)
        {
            Console.WriteLine(floor - 2);
        }

    }
    else if (floor % 10 == 5 || floor % 100 == 15)
    {
        Console.WriteLine(floor - 3);
    }
    else
    {
        Console.WriteLine(floor - 1);
    }
}