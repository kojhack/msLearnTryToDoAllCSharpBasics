// string pangram = "The quick brown fox jumps over the lazy dog";
// string result = "";

// string[] items = pangram.Split(' ');
// foreach (string item in items)
// {
//     char[] itemArray = item.ToCharArray();
//     Array.Reverse(itemArray);
//     //result = String.Join(" ", itemArray);
//     //itemArray = String.Join(" ", itemArray);
//     foreach (char i in itemArray)
//     {
//         Console.Write(i);
//     }
//     //Console.Write(itemArray);
// }

// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}