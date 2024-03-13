using System;
/*
Console.WriteLine("");
Console.WriteLine("Zadanie 6");
Console.WriteLine("");

static double Ulamek(double n)
{
    double a = 0;
    while(n > 0.001)
    {
        a = a + n;
        n = n / 2;
    }
    return n;
}

for(int i = 1; i <= 20;i++)
{
    Console.WriteLine(Ulamek(i));   
}


Console.WriteLine("");
Console.WriteLine("Zadanie 7");
Console.WriteLine("");

Console.WriteLine("Podaj liczbę gwiazdek które mają stanowić mniejszą przekątną rombu: ");
string insert = Console.ReadLine();
int answer;
int.TryParse(insert, out answer);
int answer2 = answer;
int answer3 = answer;
string empty = " ";
string star = "*";
int d = 1;
int e = 1;

for (int a = 0; a < answer2 / 2; a++) //rysuje górną część rąbu
{
    int b = answer / 2;
    Console.WriteLine();

    for (int x = 0; x < b; x++)
    {
        Console.Write(empty);
    }

    for (int x = 0; x < d; x++)
    {
        Console.Write(star);
    }

    d = d + 2;
    answer -= 2;
}

Console.WriteLine();
for (int a = 0; a < answer2; a++)//Rysuje krótszą przekątną rombu
{
    Console.Write(star);
}

for(int a = 0; a <= answer2 / 2; a++)//Rysuje dolną część rombu
{
    int c = answer3 - 2;
    Console.WriteLine();

    for(int x = 0; x < e; x++)
    {
        Console.Write(empty);
    }

    for (int x = 0; x < c;x++)
    {
        Console.Write(star);
    }

    e ++;
    answer3 -= 2;
}


Console.WriteLine("");
Console.WriteLine("Zadanie 8");
Console.WriteLine("");

Console.WriteLine("wypisz ciąg znaków a ja go odwróce: ");
string Sequence = Console.ReadLine();

char[] charArray = Sequence.ToCharArray();
Array.Reverse(charArray);
string ReversedSequence = new string(charArray);

Console.WriteLine("Orginal sequence: " + Sequence);
Console.WriteLine("Reversed sequence: " + ReversedSequence);

Console.WriteLine("");
Console.WriteLine("Zadanie 9");
Console.WriteLine("");

Console.WriteLine("Wypisz liczbę dziesiętną a ja ją przekształce na binarną: ");
string inser = Console.ReadLine();
int answer;
int.TryParse(inser, out answer);
List<int> lista = new List<int>();
int answer2;

for(int answer1 = answer; answer1 > 0;)
{
    answer2 = answer1 % 2;
    lista.Add(answer2);
    //Console.WriteLine(answer2);
    answer1 = answer1 / 2;
}
lista.Reverse(); 
foreach(int list in lista)
{
    Console.Write(list);
}


Console.WriteLine("");
Console.WriteLine("Zadanie 10");
Console.WriteLine("");

Console.WriteLine("Insert first number: ");
int a;
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Insert second number: ");
int b;
int.TryParse(Console.ReadLine(), out b);

int c = a;
int d = b;

do
{
    a = b;
    b = a % b;
    if(b == 0)
    {
        Console.WriteLine("NWW:");
        Console.WriteLine(c * d / a);
    }
}
while (b != 0);
*/