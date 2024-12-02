// Робота з масивами

int price1 = 1200;
int price2 = 1200;
int price3 = 1200;
int price4 = 1200;
int price5 = 1200;

int[] prices = [1200, 340, 99, 145000];

Console.WriteLine("Products: " + prices.Length);
Console.WriteLine("Total price: " + prices.Sum());

// масив кольорів
string[] colors = ["red", "blue", "green", "yellow", "orange", "purple" ];

Console.WriteLine("3th color: " + colors[2]);
Console.WriteLine("3th color: " + colors[1]);
Console.WriteLine("3th color: " + colors[0]);

// index - 0...
for (int i = 0; i < prices.Length; ++i)
{
    Console.WriteLine("Color: " + colors[i]);
}

// two-dimension array
const int rows = 4;
const int columns = 5;
int[,] map = new int[rows, columns]
{
    { 1, 2, 4, 2, 5 },
    { 3, 4, 4, 2, 5 },
    { 5, 6, 4, 2, 5 },
    { 7, 8, 4, 2, 5 }
};

Console.WriteLine(map[3, 1]); // 8

for (int r = 0; r < rows; r++)
{
    for (int c = 0; c < columns; c++)
    {
        Console.Write(map[r, c] + " ");
    }
    Console.WriteLine();
}
