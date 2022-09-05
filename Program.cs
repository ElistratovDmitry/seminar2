// !!! На семинаре присутствовать не смог. Записи семинара на GB нет. Поэтому сдела ДЗ ьез использования материалов семинара

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. //


Console.WriteLine("введите  число");
int number=Math.Abs(int.Parse(Console.ReadLine()));
System.Console.WriteLine( "Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа."  );

//System.Console.WriteLine( "вторая цифра справа, она же вторая цифра слева у ТРЕХЗНАЧНОГО числа  " + ( number / 10 ) % 10 ) ;

string stringNumber = number.ToString();
if (number <10 & number >-10 ) System.Console.WriteLine( "в введенном числе 2-го символа не существует");
else System.Console.WriteLine( "второй символ слева  " +  stringNumber[1] );
System.Console.WriteLine();


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/
// используем число и его перевод в строку из первой задачи
System.Console.WriteLine( "Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет."  );
if(stringNumber.Length < 3)  System.Console.WriteLine( "третьей цифры нет");
else System.Console.WriteLine( stringNumber[2] ); 
System.Console.WriteLine();


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/
System.Console.WriteLine( "Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным."  );
Console.WriteLine( "введите день недели" );
int [] week = new int [7] {1,2,3,4,5,6,7} ; // просто, чтобы использовать массив

int dayOfWeek = int.Parse( Console.ReadLine() ); 

 
// нерационально, для тренировки
if ( (dayOfWeek == week[5]) | (dayOfWeek==week[6]) ) System.Console.WriteLine("выходной"); // с использованием массива
if ( (dayOfWeek >= 1) & (dayOfWeek <=5) ) System.Console.WriteLine("рабочий");
if ( (dayOfWeek <1) | (dayOfWeek >7) ) System.Console.WriteLine("это не номер дня недели");

void WorkDay(int day) // c использованием метода
{  
    if ( (day >= 6 ) & (day <=7 ) ) System.Console.WriteLine ("выходной  (функция)");
    if ( (day >= 1) & (day <= 5) ) System.Console.WriteLine ("рабочий  (функция)");
    if ( (day < 1) | (day > 7) ) System.Console.WriteLine (" вне диапазона дней недели  (функция)");
}

WorkDay(dayOfWeek);

