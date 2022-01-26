int number = 5;
string numberString = number.ToString();
float numbersingel;

Console.WriteLine(numberString);

numberString = "56,3";
numbersingel = Convert.ToSingle(numberString);
number = Convert.ToInt32(numbersingel);
Console.WriteLine(number);
