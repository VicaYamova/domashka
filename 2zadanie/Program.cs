Console.WriteLine ("Введите число ");
int userNumber = Convert.ToInt32(Console.ReadLine());
string userNumberText = Convert.ToString(userNumber);

if(userNumberText.Length > 2)

{
    Console.WriteLine(userNumberText[2]);

}

else
{
Console.WriteLine("Третьей цифры нет");
}
