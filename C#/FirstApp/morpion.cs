using System;
using System.Net.Http.Headers;

Console.Write("entrer un nombre : ");
int n = int.Parse(Console.ReadLine());
Console.Write("entrer un nombre : ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("la somme est : " + (n + m));

Console.Write("OK trop maintenant dit moi la temperature en celsius: ");
int celsius = int.Parse(Console.ReadLine());
int fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine("la temperature en fahrenheit est : " + fahrenheit);


Console.Write("entrer un nombre : ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("le nombre est pair");

}
else
{
    Console.WriteLine("le nombre est impair");
}


Random random = new Random();
int randomNumber = random.Next(1, 101);

while (true)
{
Console.Write("devinez le nombre entre 1 et 100: ");
int guess = int.Parse(Console.ReadLine());

if (guess == randomNumber)
{
    Console.WriteLine( "bravo c'est le bo nombre");
    break;
}
else if (guess > randomNumber)
{
    Console.WriteLine("le nombre est trop grand");
}
else
{
    Console.WriteLine("le nombre est trop petit");
    
}
}

Console.Write("entrer un nombre negative entier: ");
int number = int.Parse(Console.ReadLine());
int fact = 1;
for (int i = 1; i <= number; i++)
{
    fact *= i;
}
Console.WriteLine("le factoriel de " + number + " est " + fact);

Console.Write("entrer une chaine de charactere séparer par un espace : ");
string[] words = Console.ReadLine().Split(' ');
Array.Sort(words);
foreach (string word in words)
{
    Console.WriteLine(word);
}

    
    Console.Write("entrer un nombre entier : ");
    int number2 = int.Parse(Console.ReadLine());
    int sum = 0;
    while (number2 != 0)
    {
        sum += number2 % 10;
        number2 /= 10;
    }
    Console.WriteLine("la somme des chiffres est : " + sum);

    Console.Write("entrer le nombre total de seconde  : ");
    int totalSeconds = int.Parse(Console.ReadLine());
    int hours = totalSeconds / 3600;
    int minutes = (totalSeconds % 3600) / 60;
    int seconds = totalSeconds % 60;
    Console.WriteLine("le temps est : " + hours + "h " + minutes + "m " + seconds + "s");


    Console.Write("entrer un mots: ");
    string word2 = Console.ReadLine();
    string reverseWord = "";
    for (int i = word2.Length - 1; i >= 0; i--)
    {
        reverseWord += word2[i];
    }
    Console.WriteLine("le mots inverser est : " + reverseWord);