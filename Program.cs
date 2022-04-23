Console.Write("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());
int i = 1;

while(a>=i)
{
    double b = Math.Pow(i,3);
    Console.Write($"{b} ");
    i++;
}
