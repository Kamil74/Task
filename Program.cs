/* Create a console application that reads numeric values ​​from the user until the user enters a value of 0.
While reading, the app should:
- calculate the sum of all elements
- find the largest element
After reading the value 0, these two values ​​should be entered in the console.*/


/*Console.WriteLine("Insert Nambers:");

int userImput = int.Parse(Console.ReadLine());


int sum = 0;
int? maxValue = null;

while (userImput != 0)
{
    if (maxValue == null || userImput > maxValue)
    {
        maxValue = userImput;
    }
    sum += userImput;
    userImput = int.Parse(Console.ReadLine());

}
Console.WriteLine($"Sum of numbers = {sum}");
if (maxValue != null)
{
Console.WriteLine($"Max value = {maxValue}");

}
else
{
    Console.WriteLine("NO values inserted");
}
*/

using System;

int sum = 0;

int? max = null;

while (true)
{
    Console.WriteLine("Enter a number (0 to exit): ");
    int n = int.Parse(Console.ReadLine());

    if (n == 0)
    {
        break;
    }

    sum += n;
  
}

Console.WriteLine($"Sum: {sum}");
if (max != null)
{
    Console.WriteLine($"Max: {max}");
}
else
{
    Console.WriteLine("No values inserted");
}
