int size = 2;

int[,] CreateSquareArray() {
    Random rnd = new Random();
    int[,] arr = new int[size, size];
    for(int i = 0; i < size; i++) {
        for(int o = 0; o < size; o++) {
            arr[i, o] = rnd.Next(1, 10);
        }
    }
    return arr;
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB) {
    int[,] matrixC = new int[size, size];

    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            matrixC[i, j] = 0;

            for (int k = 0; k < size; k++) {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    // Проверка
    for(int i = 0; i < size; i++) {
        for(int o = 0; o < size; o++) {
            Console.Write((o == size - 1) ? $"{matrixA[i, o]} | " : $"{matrixA[i, o]} ");
        }
        for(int o = 0; o < size; o++) {
            Console.Write((o == size - 1) ? $"{matrixB[i, o]}\n" : $"{matrixB[i, o]} ");
        }
    }     

    return matrixC;
}

void Show2DArray(int[,] arr) {
    for(int i = 0; i < size; i++) {
        for(int o = 0; o < size; o++) {
            Console.Write((o == size - 1) ? $"{arr[i, o]}\n" : $"{arr[i, o]} ");
        }
    }
}

Show2DArray(MatrixMultiplication(CreateSquareArray(), CreateSquareArray()));