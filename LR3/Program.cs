using LR3_Matrix;
namespace LR3;

class Program
{
    static void Main(string[] args)
    {
        Matrix matrix = new Matrix(3, 3);
        Matrix.PrintMatrix(matrix);
        Console.WriteLine( Matrix.GetMin(matrix));
        Matrix.PrintResultMatrix(matrix);
    }
}
