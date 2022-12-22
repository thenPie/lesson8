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

void Show2DArray(double[,] arr) {
    for(int i = 0; i < size; i++) {
        for(int o = 0; o < size; o++) {
            Console.Write((o == size - 1) ? $"{arr[i, o]}\n" : $"{arr[i, o]} ");
        }
    }
}

double[,] ShowCountArrays(int[,] arr1, int[,] arr2) {
    Console.WriteLine("Изначальные матрицы");
    for(int i = 0; i < size; i++) {
        for(int o = 0; o < size; o++) {
            Console.Write((o == size - 1) ? $"{arr1[i, o]} | " : $"{arr1[i, o]} ");
        }
        for(int o = 0; o < size; o++) {
            Console.Write((o == size - 1) ? $"{arr2[i, o]}\n" : $"{arr2[i, o]} ");
        }
    }

    double[,] result = new double[size, size];
    result[0, 0] = arr1[0, 0] * arr2[0, 0] + arr1[0, 1] * arr2[1, 0];
    result[0, 1] = arr1[0, 0] * arr2[0, 1] + arr1[0, 1] * arr2[1, 1];
    result[1, 0] = arr1[1, 0] * arr2[0, 0] + arr1[1, 1] * arr2[1, 0];
    result[1, 1] = arr1[1, 0] * arr2[0, 1] + arr1[1, 1] * arr2[1, 1];

    return result;    
}

Show2DArray(ShowCountArrays(CreateSquareArray(), CreateSquareArray()));