﻿// Ввести любой символ и определить его порядковый номер, а также указать предыдущий и последующий символы.

Console.WriteLine("Введите символ: ");
char x = Console.ReadLine()[0];
Console.WriteLine("Предыдущий символ: {0}", (char)(x-1));
Console.WriteLine("Следующее символ: {0}", (char)(x+1));