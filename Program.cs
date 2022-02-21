bool isOpen = true;
string userOption;
while (isOpen)
{
    Console.Clear();
    ShowMenu();
    userOption = Console.ReadLine();
    if (userOption == "1")
    {
        Console.Clear();
        ShowOptionOne();
    }
    else if (userOption == "2")
    {
        Console.Clear();
        RandGame();
    }
    else if (userOption == "3")
    {
        Console.Clear();
        OptionTwo();    
    }
        else if (userOption == "4") isOpen = false;
}
void ShowMenu()
{
    Console.WriteLine("Make your choice:");
    Console.WriteLine("1.ToUpper string");
    Console.WriteLine("2.Guessing game");
    Console.WriteLine("3.Exit");
}
string ToUpperString(string text)
{
    return text.ToUpper();
}
void ShowOptionOne()
{
    string userInputStr;
    Console.WriteLine("Plase enter the text:");
    userInputStr = Console.ReadLine();
    Console.WriteLine(ToUpperString(userInputStr));
    Console.ReadLine();
}
void RandGame()
{
    int randNumber, userInputNum;
    Console.WriteLine("Guess the number between 1 to 3");
    Random random = new Random();
    randNumber = random.Next(1, 4);
    do
    {
        userInputNum = int.Parse(Console.ReadLine());

    } while (randNumber != userInputNum);
    Console.WriteLine("Ura the number was indeed {0}", randNumber);
    Console.ReadLine();
}
void OptionTwo()
{
    Console.WriteLine("Enter a text.It will be reversed and with upper ");
    string inputText=Console.ReadLine(); ;

    inputText = ToUpperString(inputText);
    char[] vs= inputText.ToCharArray();
    Array.Reverse(vs);
    string result = "";

    for (int i = vs.Length-1; i <=0; i--)
    {
      result+=vs[i];
    }
    Console.WriteLine(string.Concat(vs));
    Console.ReadLine();

}

class ParkingSpace
{
    public int UID { get; set; }
    public string Status { get; set; }
    public void GetValues()
    {
        Console.WriteLine("ID: {0} Status: {1}"
            , this.UID
            , this.Status);
    }
    public ParkingSpace()
    {
        UID = 0;
        Status = "Null";
    }
}