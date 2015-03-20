namespace Core
{
    public class Matrix<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;
        public Matrix(int rowCount,int colCount)
        {
            this.rows = rowCount;
            this.cols = colCount;
            matrix = new T[rowCount, colCount];
        }
       
    }
}
