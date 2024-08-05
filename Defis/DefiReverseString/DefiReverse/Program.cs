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

string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);