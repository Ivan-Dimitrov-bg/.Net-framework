using System;

    class DefineMatrix<T>
    {
        private int rows;
        private int cols;
        private T matrica;        

        public DefineMatrix(int rows, int cols, T[,] matrix)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrica = matrix[rows,cols];
        }
    }
