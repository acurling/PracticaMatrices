// See https://aka.ms/new-console-template for more information


int[] valores = new int[] { 1, 2, 3, 4, 9, 7, 12 };
//                          0  1  2  3  4  5  6
// i = 6 
int[] numeros = new int[10];

int[,] matriz = new int[100,100]; // matriz

int valor = 1;
int suma=0;
Random rand = new Random();
for (int f = 99; f >=0; f--)  // filas
{
	for (int c =99; c>=0; c--) // columnas
	{
        matriz[f, c] =  rand.Next(100);
        if (c==f)
        {
            suma += matriz[f, c];  // acumulador
        }
     
    }
    Console.WriteLine();
}
// tarea  hacer las sumas de las equinas de una matriz nxn
// tarea hacer la suma de las diagonales de una matrices 
for (int i = 0; i < 10; i++)
{
	for (int j = 0; j < 10; j++)
	{
        Console.Write($"   {matriz[i, j]}");
    }
    Console.WriteLine();
}
Console.Write($"Sumatoria columna 1:   {suma}");



//for (int i = 5; i < numeros.Length; i++)
//{
//    numeros[i] = i;
//    Console.WriteLine(numeros[i]);
//}

// contador  i = i +1 = i++
// contador   i= i-1  i--

// total =0
// acumulador  total = salario[i] + total
//             total+=Salario[i]

//int sumatoria = 0;
//for (int i = 6; i >= 0; i--)
//{
//    sumatoria+=valores[i];
//}

//Console.WriteLine( "Sumatoria: " + sumatoria );

// tirar los valores a la inversa
// sumatoria de todos los valores

