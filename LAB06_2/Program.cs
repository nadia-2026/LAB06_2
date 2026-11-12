using LAB06_2;

try
{
    CustomString str1 = new CustomString("Hello");
    CustomString str2 = new CustomString("World");

    Console.WriteLine(str1);
    Console.WriteLine(str2);

    CustomString sum = str1 + str2;
    Console.WriteLine(sum); 
    CustomString repeated = str1 * 3;
    Console.WriteLine(repeated); 
    Console.WriteLine($"str1 == str2: {str1 == str2}"); 
    Console.WriteLine($"str1 != sum: {str1 != sum}"); 
    CustomString bad = new CustomString(null);
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}