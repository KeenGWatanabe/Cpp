public class MyFirstApp
{
    public static void Main()
    {
        int a = 1;    // initialise a as 1 in definition
        int b = 2;

        a = 5;  // chg a to 5, assigning value to definition
        int c = a + b;
        Console.WriteLine("Result is : " + c);

        string username = "Default";
        username = "whatever user has typed"; //practical use of var assignment
        Console.WriteLine(username);

    }
}