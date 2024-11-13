namespace BitGetable
{
    internal interface IMatrix<T>
    {
        T this[int row, int colum] {  get; set; }
        void PrintMatrix();
    }
    public class Matrix<T> : IMatrix
    {
        private T[,] arr;
        public Matrix(int rows, int colums)
        {
            arr = new T[rows, colums];
        }
        public T this[int row, int colum]
        {
            get => arr [row, colum];
            set => arr[row, colum] = value;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr [i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
