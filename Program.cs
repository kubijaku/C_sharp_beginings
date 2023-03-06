// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int jakas_liczba_szesnastkowa = 0x12f;
Console.WriteLine(jakas_liczba_szesnastkowa);

double d1 = 0.1;

float f1 = 0.1f;

// ### DECIMAL ###

decimal dec1 = 0.1m;

Console.WriteLine( d1 + d1 + d1 );
Console.WriteLine( f1 + f1 + f1 );
Console.WriteLine( dec1 + dec1 + dec1 );

Console.WriteLine(( d1 + d1 + d1 ) == 0.3);
Console.WriteLine(( f1 + f1 + f1 ) == 0.3);
Console.WriteLine(( dec1 + dec1 + dec1 ) == 0.3m);

// ### DYNAMIC ###
dynamic dyn;
dyn = 1234;
Console.WriteLine(dyn);

dyn = "ala ma kota";
Console.WriteLine(dyn.Substring(0,3));

// ### VAR ###

var war = 12345;
// war = "ala"; WRONG

// ### RANDOM ###

Random rand  = new Random(Environment.TickCount);  // Gets the number of milliseconds elapsed since the system started.
Console.WriteLine(Environment.TickCount);

// ### NULL ###

string ?napis = null;
int ?dl = napis?.Length;
Console.WriteLine(dl);
Console.WriteLine(dl ?? 0);
Console.WriteLine(dl == null ? 0 : napis?.Length);


