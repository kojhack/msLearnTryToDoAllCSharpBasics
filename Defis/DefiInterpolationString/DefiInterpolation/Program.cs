string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName}, \nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine();
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
Console.WriteLine();
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.");
Console.WriteLine();

Console.WriteLine("Here's a quick comparison:\n");
Console.WriteLine();

string comparisonMessage = $"{currentProduct.PadRight(20)} {currentReturn:P2}   {currentProfit:C}\n";

// Your logic here
comparisonMessage += $"{newProduct.PadRight(20)} {newReturn:P2}   {newProfit:C}";
Console.WriteLine(comparisonMessage);