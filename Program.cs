Console.WriteLine("Εισάγετε 5 αριθμούς από το 1 έως το 45:");
int num1 = Convert.ToInt32(Console.ReadLine());
num1 = Bounds(num1);
int num2 = Convert.ToInt32(Console.ReadLine());
while (num2 == num1)
{
    Console.WriteLine("Έχεις ήδη επιλέξει τον αριθμό " + num2);
    num2 = Convert.ToInt32(Console.ReadLine());
}
num2 = Bounds(num2);
int num3 = Convert.ToInt32(Console.ReadLine());
while (num3 == num1 || num3 == num2)
{
    Console.WriteLine("Έχεις ήδη επιλέξει τον αριθμό " + num3);
    num3 = Convert.ToInt32(Console.ReadLine());
}
num3 = Bounds(num3);
int num4 = Convert.ToInt32(Console.ReadLine());
while (num4 == num1 || num4 == num2 || num4 == num3)
{
    Console.WriteLine("Έχεις ήδη επιλέξει τον αριθμό " + num4);
    num4 = Convert.ToInt32(Console.ReadLine());
}
num4 = Bounds(num4);
int num5 = Convert.ToInt32(Console.ReadLine());
while (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4)
{
    Console.WriteLine("Έχεις ήδη επιλέξει τον αριθμό " + num5);
    num5 = Convert.ToInt32(Console.ReadLine());
}
num5 = Bounds(num5);
Console.WriteLine("Εισάγετε τον αριθμό Joker (1-20): ");
int numJoker = Convert.ToInt32(Console.ReadLine());
numJoker =Jbounds(numJoker);
int Joker;
var rand = new Random();
List<int> listNumbers = new List<int>();
int number;
for (int i = 0; i < 5; i++)                        //Loop 5 times to get 5 random numbers
{
    do
    {
        number = rand.Next(1, 46);                 //pick a random number between 1 and 45
    } while (listNumbers.Contains(number));        //check to see if the random number is already added to the list and pick a new one
    listNumbers.Add(number);                       //add the random number to the list
}
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Οι 5 τυχεροί αριθμοί είναι οι: ");
Console.ForegroundColor = ConsoleColor.Red;
listNumbers.Sort();                                //sort the list in ascending order
Console.WriteLine(String.Join(", ", listNumbers)); //Print listNumbers list items with a "," between each item
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Ο αριθμός Joker είναι ο: ");
Console.ForegroundColor = ConsoleColor.Red;

Random r = new Random();
Joker = r.Next(1, 21);
Console.WriteLine(Joker);
Console.ForegroundColor = ConsoleColor.Red;
int correctGuesses = 0;
if (listNumbers.Contains(num1))
{
    correctGuesses++;
}
if (listNumbers.Contains(num2))
{
    correctGuesses++;
}
if (listNumbers.Contains(num3))
{
    correctGuesses++;
}
if (listNumbers.Contains(num4))
{
    correctGuesses++;
}
if (listNumbers.Contains(num5))
{
    correctGuesses++;
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine( "Πέτυχες " + correctGuesses + " αριθμούς");
if (numJoker == Joker)
{
    Console.WriteLine("Συγχαρητήρια! Έπιασες τον αριθμό Joker!");
}
Console.ReadLine();

//Ensure guesses are within bounds
static int Bounds(int num)
{
    while (num > 45 || num <1)
    {
        Console.WriteLine("Επιλέξτε έναν έγκυρο αριθμό μεταξύ του 1 και του 45");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

static int Jbounds(int numJoker)
{
    while (numJoker < 1 || numJoker > 20)
    {
        Console.WriteLine("Ο αριθμός Joker πρέπει να είναι μεταξύ 1 και 20!");
        numJoker = Convert.ToInt32(Console.ReadLine());
    }
    return numJoker;
}