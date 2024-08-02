
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// string message = "";
// float total = 0;


// foreach(var val in values)
// {
//     float result = 0;
//     if (!(float.TryParse(val, out result)))
//     {
       
//        message += val;
//     }
//     else
//     {
//         total += result;
//     }
// }
// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = Convert.ToInt32( (value1 / value2));

Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = (value2 / Convert.ToDecimal(value3));
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = (value3 / (float)(value1));
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");