using System;
 
static class StringHelper
{
    public static string ReverseString(string myStr)
    {
        char[] myArr = myStr.ToCharArray();
        Array.Reverse(myArr);
        return new string(myArr);
    }
}
 
class myProgram
{
    static void Main()
    {
        Console.WriteLine(StringHelper.ReverseString("Skriv ord här::::::::"));
   

    }
 

}
