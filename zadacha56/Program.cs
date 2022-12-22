Console.Write("Введите размер квадрата: ");
int input = int.Parse(Console.ReadLine());

int[,] CreateSquareArray(int size) {
    Random rnd = new Random();
    int[,] arr = new int [size, size];
    for(int i = 0; i < size; i++) {
        for(int o = 0; o < size; o++) {
            arr[i, o] = rnd.Next(1, 10);
        }
    }

    Show2DArray(arr);

    return arr;
}

void Show2DArray(int[,] arr) {
    for(int i = 0; i < input; i++) {
        Console.Write("[");
        for(int o = 0; o < input; o++) {
            Console.Write((o == input - 1) ? $"{arr[i, o]}]\n" : $"{arr[i, o]}, ");
        }
    }
}

/*
int CountMax(int[,] n) {
    int sum = 0;
    int max = 0;
    int index = 0;
    for(int o = 0; o < input; o++) {
        for(int i = 0; i < input; i++) {
            sum = sum + n[o, i];
        }
        if(max < sum) {
            max = sum;
            index = o;
        }
        sum = 0;
    }
    return index + 1;
}
*/

int CountMin(int[,] n) {
    int sum = 0;
    int max = 2147483647;
    int index = 0;
    for(int o = 0; o < input; o++) {
        for(int i = 0; i < input; i++) {
            sum = sum + n[o, i];
        }
        if(sum < max) {
            max = sum;
            index = o;
        }
        sum = 0;
    }
    return index + 1;
}

Console.WriteLine($"Номер строки с наименьшей суммой: {CountMin(CreateSquareArray(input))}");