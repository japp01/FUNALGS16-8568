// hagan el ejemplo anterior pero con bidimensional
//el ingreso de datos aleatorios, pedir min y max al usuario
//mostrar la suma de las filas y de las columnas
//4 x 3
Random r = new Random();
int fil = 4;
int col = 3;
int[,] mat2 = new int[fil,col];

Console.WriteLine("Minimo:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Maximo:");
int max = Convert.ToInt32(Console.ReadLine());
//ingreso
for (int f = 0; f < mat2.GetLength(0); f++) {
    for (int c = 0; c < mat2.GetLength(1); c++) {
        mat2[f, c] = r.Next(min, max + 1);
    }
}

//salida
for (int f = 0; f < mat2.GetLength(0); f++) {
    for (int c = 0; c < mat2.GetLength(1); c++) {
        Console.Write($"{mat2[f,c]}, ");
    }
    Console.WriteLine();
}
Console.WriteLine();


//suma filas
for (int f = 0; f < mat2.GetLength(0); f++) {
    int sum = 0;
    for (int c = 0; c < mat2.GetLength(1); c++) {
        sum += mat2[f, c];
    }
    Console.WriteLine($"Suma de fila {f} es {sum}");
}
Console.WriteLine();

//suma columnas
for (int c = 0; c < mat2.GetLength(1); c++) {
    int sum = 0;
    for (int f = 0; f < mat2.GetLength(0); f++) {
        sum += mat2[f, c];
    }
    Console.WriteLine($"Suma de columa {c} es {sum}");
}
Console.WriteLine();