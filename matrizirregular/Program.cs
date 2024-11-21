//4 x 3
int fil = 4;
int col = 3;
int[][] mat = new int[fil][];

//creo columnas en cada fila
for (int f = 0; f < mat.Length; f++) {
    mat[f] = new int[col];
}
//ingreso
for (int f = 0; f < mat.Length; f++) {
    for (int c = 0; c < mat[f].Length; c++) {
        Console.WriteLine($"En fila {f}, Ingrese numero {c}");
        mat[f][c] = Convert.ToInt32(Console.ReadLine());    
    }
}

//salida
for (int f = 0; f < mat.Length; f++) {
    for (int c = 0; c < mat[0].Length; c++) {
        Console.Write($"{mat[f][c]}, ");
    }
    Console.WriteLine();
}
Console.WriteLine();