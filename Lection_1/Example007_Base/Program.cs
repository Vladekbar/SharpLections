int a = 1;
int b = 2;
int c = 8;
int d = 8;
double e = 9.6;

double max = a; // При наличии исключительно целочисленных значений можно стаить int вместо double

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);