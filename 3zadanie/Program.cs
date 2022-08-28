Console.WriteLine
("Введите цифру обозначающую день недели: 1 -  понедельник, 2 - вторник. 3 - среда,4 - четверг, 5 - пятница, 6 - суббота, 7 - воскресенье");

int number = Convert.ToInt32(Console.ReadLine());

if(number >= 6)
{     
  Console.WriteLine("Это выходной день");
}

if(number < 6)
{
  Console.WriteLine("Это рабочий день");      
}