Console.Clear();

int Rand() {
    Random rnd = new Random();
    int num = rnd.Next(1, 10);
    return num;
}

// void ShowArray(int[] arr) {
//     for(int i = 0; i < 3; i++) {
//         Console.Write("[");
//         for(int o = 0; o < 4; o++) {
//             if(o == 4 - 1) {
//                 Console.WriteLine($"{arr[i, o]}]");
//             } else {
//                 Console.Write($"{arr[i, o]}, ");
//             }
//         }
//     }
// }

int[,] CreateArray(int rows, int columns) {
    // rows = int.Parse(Console.ReadLine());
    // columns = int.Parse(Console.ReadLine());
    int[,] arr = new int [rows, columns];

    // var input = Console.ReadLine();
    // var split = input.Split(" ");
    // int rows = int.Parse(split[0]);
    // int columns = int.Parse(split[1]);

    for(int i = 0; i < rows; i++) {
        // Console.Write("[");
        for(int o = 0; o < columns; o++) {
            arr[i, o] = Rand();
            // if(o == columns - 1) {
            //     Console.WriteLine($"{arr[i, o]}]");
            // } else {
            //     Console.Write($"{arr[i, o]}, ");
            // }
        }
    }

    return arr;
}

Console.Write(CreateArray(3, 4));

// int[,] twoDarr = {{Rand(), Rand(), Rand(), Rand()},
//                   {Rand(), Rand(), Rand(), Rand()},
//                   {Rand(), Rand(), Rand(), Rand()}};

// for(int i = 0; i < 3; i++) {
//     for(int o = 0; o < 4; o++) {
        
//     }
// }