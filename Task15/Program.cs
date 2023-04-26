// Напишите программу, которая
// принимает на вход цифру, обозначающую день недели, и
// проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number > 0 && number < 8)
{
   bool result = DayOff( number );
   Console.Write( result ? "Да" : "Нет" );
}
else
{
    Console.WriteLine( "Некорректный ввод!" );
}


bool DayOff( int num )
{
    return num == 6 || num == 7;
}