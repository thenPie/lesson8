Console.Write("Сначала введите количество строк и затем количество столбиков через пробел: ");
var input = Console.ReadLine();
var space = input.Split(" ");
int rows = int.Parse(space[0]);
int columns = int.Parse(space[1]);

int[,] CreateArray(int rows, int columns) {
    Console.WriteLine("Изначальный массив");
    Random rnd = new Random();
    int[,] arr = new int [rows, columns];
    for(int i = 0; i < rows; i++) {
        for(int o = 0; o < columns; o++) {
            arr[i, o] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void Show1DArray(int[] arr) {
    Console.Write("[");
    for(int i = 0; i < columns; i++) {
        Console.Write((i == columns - 1) ? $"{arr[i]}]\n" : $"{arr[i]}, ");
    }
}

void Show2DArray(int[,] arr) {
    for(int i = 0; i < rows; i++) {
        Console.Write("[");
        for(int o = 0; o < columns; o++) {
            Console.Write((o == columns - 1) ? $"{arr[i, o]}]\n" : $"{arr[i, o]}, ");
        }
    }
}

void SortShowAndDifference(int[,] n)
{
    Show2DArray(n);

    for(int o = 0; o < rows; o++) {

        List<int> list = new List<int>();
        for(int i = 0; i < columns; i++) {
            list.Add(n[o, i]);
        }

        int[] arr = list.ToArray();
        for(int i = 0; i < columns; i++) {
            Array.Sort(arr, (x, y) => y.CompareTo(x));
        }

        Console.WriteLine($"Упорядоченный {o + 1} массив");

        Show1DArray(arr);

        list.Clear();
    }
}

SortShowAndDifference(CreateArray(rows, columns));