// series = 7 + 14 + 21 + .........+ 49
int n = 0 ;
int sum = 0;
while (n<50)
{
    sum = sum + n ;
    n = n + 7;
}
Console.WriteLine(sum);