Console.WriteLine("Enter the Digit: ");
int digit = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Interest: ");
int interest = int.Parse(Console.ReadLine());
double result = (digit * interest) / 100;

Console.WriteLine($"Interest {interest}% from digit {digit} = {result}");   