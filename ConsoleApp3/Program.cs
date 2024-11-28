using System.ComponentModel.DataAnnotations;

int[] a = new int[11];
Random rnd = new Random();

a[0] = 7;
for (int i = 1; i < a.Length; i++)
{
    a[i] = rnd.Next(0, 9);
}
Console.Write('+');
Console.Write(a[0] + " (");
Console.Write(a[1]);
Console.Write(a[2]);
Console.Write(a[3] + ") ");
Console.Write(a[4]);
Console.Write(a[5]);
Console.Write(a[6] + " - ");
Console.Write(a[7]);
Console.Write(a[8]);
Console.Write(" ");
Console.Write(a[9]);
Console.Write(a[10] + "\n" + "\n");




Console.Write("Введите строку: ");
string c = Console.ReadLine();
if (c.Length <= 3)
{
    Console.WriteLine(c[0] + "...");
}
else if(14 >= c.Length)
{
    Console.WriteLine(c);
}
else
{
    String str = "";
    for (int i = 0; 14 > i; i++)
    {
        str += c[i];
    }
    Console.WriteLine(str + "..." + "\n");
}
Console.WriteLine();



Console.Write("Введите число: ");
string b = Console.ReadLine();

for (int i = 0; i < b.Length; i++)
{
    int n = (int)b[i];
    Console.WriteLine(n * n);
}





Console.Write("Ввод: ");
string f = Console.ReadLine();
int s = f.Length;

if (s == 0)
{
    Console.Write("нет");
}
else if (s == 1)
{
    Console.Write("лайк есть");
}
else if (s == 2)
{
    Console.Write("два лайка");
}
else
{
    Console.Write("лайков нет");
}
