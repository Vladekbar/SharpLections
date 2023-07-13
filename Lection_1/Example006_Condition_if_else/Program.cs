Console.Write("Kakije vashy dokazatelstva, ");
string?username = Console.ReadLine();

if (username?.ToLower() == "dania?")
{
    Console.WriteLine("- Aluminium!");
}
else
{
    Console.WriteLine(" - Cocainum!");
    Console.WriteLine(username);
}