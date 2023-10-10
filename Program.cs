int ReadInt(string msg)
{
    Console.WriteLine(msg); 
    string numb = Console.ReadLine();
    int number; 
    number = int.Parse(numb);
    return number; 
} 
int number= ReadInt("введите трехзначное число");
if (number < 1000 & number > 99)
{
    int mediumDigit = (number %100-number%10)/10 ; 
    Console.WriteLine("mediumDigit=" + mediumDigit); 

}
else Console.WriteLine("mediumDigit not three digits");