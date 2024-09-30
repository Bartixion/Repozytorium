using ConsoleApp1;

String? name1 = Console.ReadLine();
int min = int.Parse(Console.ReadLine());

CutString cutstring = new CutString();

String? result = CutString.CuutString(name1, min);
Console.WriteLine(result);