string [] Array = {"а" ,"ввф" ,"ddd2" , "a102" , "ad", ".акаы", "ввв"};
Console.Write("[");
foreach (string Value in Array)
{
if (Value.Length<=3)
{
    Console.Write($"{Value}" );
    if (Value != Array[Array.Length-1])
    Console.Write(",");
    if (Value == Array[Array.Length-1])
    {
        Console.Write("]");
    }
}
}
