Console.Clear();

Random rnd = new Random();
int size = 2;
int[,,] arr3D = new int [size, size, size];

// create array
for(int i = 0; i < size; i++) {
    for(int j = 0; j < size; j++) {
        for(int u = 0; u < size; u++) {
            // Random rnd = new Random();
            arr3D[i, j, u] = rnd.Next(10, 100);
        }
    }
}

bool isSame(int num) {
    for(int q = 0; q < size; q++) {
        for(int w = 0; w < size; w++) {
            for(int e = 0; e < size; e++) {
                if(arr3D[q, w, e] == num) {
                    return true;
                }
            }
        }
    }
    return false;
}
for(int i = 0; i < size; i++) {
    for(int j = 0; j < size; j++) {
        for(int u = 0; u < size; u++) {
            int num;
            do {
                num = rnd.Next(10, 100);
            } while (isSame(num));
            arr3D[i, j, u] = num;
        }
    }
}

// print array
for(int i = 0; i < size; i++) {
    for(int j = 0; j < size; j++) {
        for(int u = 0; u < size; u++) {
            Console.WriteLine($"{arr3D[i, j, u]} ({i}, {j}, {u})");
        }
    }
}

// // check end results
// Check(arr3D);
// void Check(int[,,] arr) {
//     var d = new Dictionary < int, int > ();

//     foreach(var res in arr) {
//         if (d.ContainsKey(res))
//         d[res]++;
//         else
//         d[res] = 1;
//     }

//     foreach(var val in d)
//     Console.WriteLine("{0} occurred {1} times", val.Key, val.Value);
// }