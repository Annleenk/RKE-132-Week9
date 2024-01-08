
string folderPath = @"C:\Users\annle\Desktop\data";
string fileName = "ShoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string> ();

if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath,myShoppingList);
}



static List<string> GetItemsFromUser()
{

    List<string> myShoppingList = new List<string>();

    while (true)
    {
        Console.WriteLine("add an item (add)/ exit console (exit)");
        string userCHoice = Console.ReadLine();

        if (userCHoice == "add")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();
            myShoppingList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }
    }
    return myShoppingList;
}

static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"You have added {listLength} to your shopping list");

    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}