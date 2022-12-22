Console.Clear();

Console.Write("Сначала введите количество строк и затем количество столбиков через пробел: ");
var input = Console.ReadLine();
var space = input.Split(" ");
int rows = int.Parse(space[0]);
int columns = int.Parse(space[1]);

int[,] CreateArray(int rows, int columns) {
    Random rnd = new Random();
    int[,] arr = new int [rows, columns];
    for(int i = 0; i < rows; i++) {
        for(int o = 0; o < columns; o++) {
            arr[i, o] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void ShowArray(int[,] arr) {
    for(int i = 0; i < rows; i++) {
        Console.Write("[");
        for(int o = 0; o < columns; o++) {
            if(o == columns - 1) {
                Console.WriteLine($"{arr[i, o]}]");
            } else {
                Console.Write($"{arr[i, o]}, ");
            }
        }
    }
}

ShowArray(CreateArray(rows, columns));