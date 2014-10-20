using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private int row;
        private int col;
        private T[,] matrix;

        //Properties
        public int Row
        {
            get { return this.row; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Row must be positive");
                }
                else
                {
                    this.row = value;
                }
            }
        }

        public int Col
        {
            get { return this.col; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Col must be positive");
                }
                else
                {
                    this.col = value;
                }
            }
            
        }

        public T this[int row,int col]
        {
            get 
            {
                if (row > Row || col > Col || row < 0 || col < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return this.matrix[row, col];
                }
            }
            set
            {
                if (row > Row || col > Col || row < 0 || col < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.matrix[row, col] = value;
                }
            }
        }

        //constructors     
        public Matrix(int row, int col)
        {   
            this.row = row;
            this.col = col;
            matrix = new T[row, col];            
        }

        public Matrix(T[,] someMatrix)
        {
            this.row = someMatrix.GetLength(0);
            this.col = someMatrix.GetLength(1);
            this.matrix = someMatrix;
        }
        
        //task 10 operators
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.row != secondMatrix.row || firstMatrix.col != secondMatrix.col)
            {
                throw new ArgumentException("To use operator + matrixes must be with the same size");
            }
            else
            {
                Matrix<T> matrix = new Matrix<T>(firstMatrix.row, secondMatrix.col);
                for (int row = 0; row < matrix.row; row++)
                {
                    for (int col = 0; col < matrix.col; col++)
                    {
                        matrix[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                    }
                }
                return matrix;
            }
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.row != secondMatrix.row || firstMatrix.col != secondMatrix.col)
            {
                throw new ArgumentException("To use operator - matrixes must be with the same size");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(firstMatrix.row, secondMatrix.col);
                for (int i = 0; i < result.row; i++)
                {
                    for (int j = 0; j < result.col; j++)
                    {
                        result[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                    }
                }
                return result;
            }
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.row != secondMatrix.col)
            {
                throw new ArgumentException("Rows of first matrix should be equal to cals in second matrix");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(firstMatrix.row, secondMatrix.col);
                for (int row = 0; row < result.row; row++)
                {
                    for (int col = 0; col < result.col; col++)
                    {
                        dynamic sum = 0;
                        for (int i = 0; i < firstMatrix.col; i++)
                        {
                            sum += (dynamic)firstMatrix[row, i] * secondMatrix[i, col];
                        }
                        result[row, col] = sum;
                    }
                }
                return result;
            }

        }

        public static Boolean operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
       
        public static Boolean operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
       
        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sb.Append(this.matrix[i, j] + " "); 
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
