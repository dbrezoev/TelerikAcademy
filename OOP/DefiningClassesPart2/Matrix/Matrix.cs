using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Matrix<T> where T : struct
{
    private T[,] matrix;
    private int rows;
    private int cols;

    //constructor
    public Matrix(int rows, int cols)
    {
        this.matrix = new T[rows, cols];
        this.Rows = rows;
        this.Cols = cols;
    }

    public int Rows
    {
        get
        {
            return this.rows;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Rows cannot be less than zero");
            }
            this.rows = value;
        }
    }
    public int Cols
    {
        get
        {
            return this.cols;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Cols cannot be less than zero");
            }
            this.cols = value;
        }
    }
    //indexer
    public T this[int row, int col]
    {
        get
        {
            if (!IsPositionValid(row, col))
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            return this.matrix[row, col];
        }
        set
        {
            if (!IsPositionValid(row, col))
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            this.matrix[row, col] = value;
        }
    }

    public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
    {
        if (first.rows != second.rows || first.cols != second.cols)
        {
            throw new ArgumentException("Cannot operate + with matrixes with different sizes");
        }
        Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                result[row, col] = (dynamic)first[row, col] + (dynamic)second[row, col];
            }
        }
        return result;
    }
    public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
    {
        if (first.rows != second.rows || first.cols != second.cols)
        {
            throw new ArgumentException("Cannot operate - with matrixes with different sizes");
        }
        Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                result[row, col] = (dynamic)first[row, col] - (dynamic)second[row, col];
            }
        }
        return result;
    }
    public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
    {
        if (first.rows != second.rows || first.cols != second.cols)
        {
            throw new ArgumentException("Cannot operate * with matrixes with different sizes");
        }
        Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                result[row, col] = (dynamic)first[row, col] * (dynamic)second[row, col];
            }
        }
        return result;
    }
    public static bool operator true(Matrix<T> first)
    {
        Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                if ((dynamic)first[row, col] == default(T))
                {
                    return false;
                    break;
                }
            }
        }
        return true;
    }
    public static bool operator false(Matrix<T> first)
    {
        Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                if ((dynamic)first[row, col] != default(T))
                {
                    return true;
                    break;
                }
            }
        }
        return false;
    }
    private bool IsPositionValid(int row, int col)
    {
        if ((row < 0 || row >= this.matrix.GetLength(0)) || (col < 0 || col >= this.matrix.GetLength(1)))
        {
            return false;
        }
        return true;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < this.rows; i++)
        {
            for (int k = 0; k < this.cols; k++)
            {
                sb.Append(this.matrix[i, k].ToString().PadLeft(2));
                sb.Append(" ");
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}