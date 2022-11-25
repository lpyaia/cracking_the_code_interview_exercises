int n = 1024;
int m = 19;
int j = 6;
int i = 2;

n = int.Parse(Console.ReadLine()!);
m = int.Parse(Console.ReadLine()!);
j = int.Parse(Console.ReadLine()!);
i = int.Parse(Console.ReadLine()!);

m <<= i;
n |= m;

Console.WriteLine(n);