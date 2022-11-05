using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Matrix
    {
        private double[,] data;
        private int row;
        private int col;
        
        public Matrix(int rows, int cols)
        {
            row = rows;
            col = cols;
            data = new double[row, col];
        }

        public double GetElem(int i, int j)
        {
            return data[i, j];
        }
        public double GetRows()
        {
            return row;
        }

        public double GetCols()
        {
            return col;
        }


        public void SetData(double[,] d)
        {
            data = d;
        }

        public Matrix Mult(Matrix m)
        {
            var res = new double[row, m.col];
            for (int i = 0; i < row; i++)            
                for (int j = 0; j < m.col; j++)                
                    for (int k = 0; k < m.row; k++)                    
                        res[i,j] += data[i, k] * m.data[k, j];               
            var result = new Matrix(row, m.col);
            result.SetData(res);
            return result;
        }

    }
}
