string pangram = "The quick brown fox jumps over the lazy dog";
string result = "";

string[] items = pangram.Split(' ');
foreach (string item in items)
{
    char[] itemArray = item.ToCharArray();
    Array.Reverse(itemArray);
    result = String.Join(" ", itemArray);
    //itemArray = String.Join(" ", itemArray);
    
    Console.Write(itemArray);


}

