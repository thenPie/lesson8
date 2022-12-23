int size = 4;
int[,] matrix = new int[size, size];

void Show2DArray(int[,] arr) {
    for(int i = 0; i < size; i++) {
        for(int o = 0; o < size; o++) {
            Console.Write(arr[i, o] < 10 ? $"0{arr[i, o]} " : $"{arr[i, o]} ");
        }
        Console.WriteLine();
    }
}

int iterator = 0;
int row = 0;
int col = 0;
int step = 1;
for (int num = 1; num <= size * size; num++) {
    matrix[row, col] = num;

    switch (step) {
        case 1:
            if (col == (size - iterator - 1)) {
                row++;
                step++;
            } else {
                col++;
            }
            break;

        case 2:
            if (row == (size - iterator - 1)) {
                col--;
                step++;
            } else {
                row++;
            }
        break;

        case 3:
            if (col == (0 + iterator)) {
                row--;
                step++;
            } else {
                col--;
            }
            break;

            case 4:
            if (row == (1 + iterator)) {
                col++;
                step = 1;
                iterator++;
            } else {
                row--;
            }
            break;
    }
}

Show2DArray(matrix);