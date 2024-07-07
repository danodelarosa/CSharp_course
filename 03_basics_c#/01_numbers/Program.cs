int a = 2100000000;
int b = 2100000000;

long r1 = (long)a + (long)b;
Console.WriteLine(r1);

double c = 42.1;
float d = 38.2f; // Floats should have and f at the end
double r2 = checked(c+d);
Console.WriteLine(r2);

// Decimals use more memory space and need to have an M at the end
decimal e = 42.1M;
decimal f = 38.2M;
decimal r3 = e + f;
Console.WriteLine($"The range of decimal type is {decimal.MinValue} to {decimal.MaxValue}");
Console.WriteLine(r3);