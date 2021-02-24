using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace matrixCalc
{
    public partial class MainWindow : Form
    {
        public bool MatrixUnsavedChangesDone;
        public int z = 0;
        public string CurrentOpenFileName = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        #region Base Functions
        public bool TableCreate(int RowNumber, int ColumnNumber)
        {
            if ((RowNumber >= 1 & RowNumber <= 75) && (ColumnNumber >= 1 & ColumnNumber <= 75))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Wrong matrix elements quantity. Quantity must be [1; 75]", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public object SaveFileStream(double[,] Matrix1, double[,] Matrix2, StreamWriter File)
        {
            string MatrixRow = "";
            this.Cursor = Cursors.WaitCursor;
            for (int i = 0; i <= Matrix1.GetUpperBound(0); i++)
            {
                MatrixRow = "";
                for (int j = 0; j <= Matrix1.GetUpperBound(1); j++)
                {
                    MatrixRow += Matrix1[i, j].ToString() + " ";
                }
                MatrixRow = MatrixRow.TrimEnd();
                File.WriteLine(MatrixRow);
            }

            File.WriteLine("");
            for (int i = 0; i <= Matrix2.GetUpperBound(0); i++)
            {
                MatrixRow = "";
                for (int j = 0; j <= Matrix2.GetUpperBound(1); j++)
                {
                    MatrixRow += Matrix2[i, j].ToString() + " ";
                }
                MatrixRow = MatrixRow.TrimEnd();
                File.WriteLine(MatrixRow);
            }
            File.Flush();
            this.Cursor = Cursors.Arrow;
            return null;
        }

        public object OpenFileStream(StreamReader File)
        {
            double[,] A = { };
            double[,] B = { };
            string[] MatrixRows = { };
            string[] RowCells = { };
            string str = "";
            int RowNumber = 0;

            this.Cursor = Cursors.WaitCursor;
            do
            {
                Array.Resize(ref MatrixRows, RowNumber + 1);
                str = File.ReadLine();
                MatrixRows[RowNumber] = str;
                RowNumber += 1;
            } while (!(str == ""));

            for (int i = 0; i < MatrixRows.Length - 1; i++)
            {
                RowCells = MatrixRows[i].ToString().Split(' ');
                if (i == 0)
                {
                    A = new double[MatrixRows.Length - 1, RowCells.Length];
                }

                for (int j = 0; j < RowCells.Length; j++)
                {
                    Double.TryParse(RowCells[j], out A[i, j]);
                }
            }
            WriteToDGV(ref this.DGV1, A);

            MatrixRows = null;
            RowNumber = 0;
            do
            {
                Array.Resize(ref MatrixRows, RowNumber + 1);
                MatrixRows[RowNumber] = File.ReadLine();
                RowNumber += 1;
            } while (!(File.Peek() == -1));
            for (int i = 0; i < MatrixRows.Length; i++)
            {
                RowCells = MatrixRows[i].Split(' ');
                if (i == 0)
                {
                    B = new double[MatrixRows.Length, RowCells.Length];
                }
                for (int j = 0; j < RowCells.Length; j++)
                {
                    Double.TryParse(RowCells[j], out B[i, j]); ;
                }
            }
            WriteToDGV(ref this.DGV2, B);
            this.Cursor = Cursors.Arrow;
            return null;
        }

        public object WriteToDGV(ref DataGridView DataGridViewName, double[,] Matrix)
        {
            DataGridViewName.RowCount = Matrix.GetLength(0);
            DataGridViewName.ColumnCount = Matrix.GetLength(1);

            for (int i = 0; i <= Matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Matrix.GetUpperBound(1); j++)
                {
                    DataGridViewName.Rows[i].Cells[j].Value = Matrix[i, j];
                }
            }

            if (object.ReferenceEquals(DataGridViewName, this.DGV1))
            { this.txtRowCount1.Text = this.DGV1.RowCount.ToString(); this.txtColumnCount1.Text = this.DGV1.ColumnCount.ToString(); }

            if (object.ReferenceEquals(DataGridViewName, this.DGV2))
            { this.txtRowCount2.Text = this.DGV2.RowCount.ToString(); this.txtColumnCount2.Text = this.DGV2.ColumnCount.ToString(); }
            return null;
        }

        public double[,] ReadFromDGV(ref DataGridView DataGridViewName)
        {
            double[,] ResultMatrix = new double[DataGridViewName.RowCount, DataGridViewName.ColumnCount];

            for (int i = 0; i <= DataGridViewName.RowCount - 1; i++)
            {
                for (int j = 0; j <= DataGridViewName.ColumnCount - 1; j++)
                {
                    ResultMatrix[i, j] = Convert.ToDouble(DataGridViewName.Rows[i].Cells[j].Value);
                }
            }
            return ResultMatrix;
        }

        public void CopyDGV(ref DataGridView DataGridViewName1, ref DataGridView DataGridViewName2)
        {
            DataGridViewName2.RowCount = DataGridViewName1.RowCount;
            DataGridViewName2.ColumnCount = DataGridViewName1.ColumnCount;
            for (var i = 0; i <= DataGridViewName1.RowCount - 1; i++)
            {
                for (var j = 0; j <= DataGridViewName1.ColumnCount - 1; j++)
                    DataGridViewName2.Rows[i].Cells[j].Value = DataGridViewName1.Rows[i].Cells[j].Value;
            }
            if (DataGridViewName2 == this.DGV1)
            {
                this.txtRowCount1.Text = this.DGV1.RowCount.ToString(); this.txtColumnCount1.Text = this.DGV1.ColumnCount.ToString();
            }
            if (DataGridViewName2 == this.DGV2)
            {
                this.txtRowCount2.Text = this.DGV2.RowCount.ToString(); this.txtColumnCount2.Text = this.DGV2.ColumnCount.ToString();
            }
            return;
        }

        public double[,] MatrixMultiplication(double[,] LeftMatrix, double[,] RightMatrix)
        {
            double[,] ResultMatrix;
            double[] Q;
            double[] R;
            int m;
            int n;
            int k;
            int l;
            m = LeftMatrix.GetLength(0);
            n = LeftMatrix.GetLength(1);
            k = RightMatrix.GetLength(0);
            l = RightMatrix.GetLength(1);
            ResultMatrix = new double[m, l];
            Q = new double[n];
            R = new double[k];
            if (n != k)
            {
                MessageBox.Show("Check the dimensions of matrices.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            else
            {
                for (int h = 0; h <= m - 1; h++)
                {
                    for (int i = 0; i <= l - 1; i++)
                    {
                        for (int j = 0; j <= n - 1; j++)
                        {
                            Q[j] = LeftMatrix[h, j];
                            R[j] = RightMatrix[j, i];
                            ResultMatrix[h, i] = ResultMatrix[h, i] + Q[j] * R[j];
                        }
                    }
                }
            }
            return ResultMatrix;
        }

        public double MatrixDeterminant(double[,] Matrix)
        {
            double d = 1;
            double[,] TriAngularMatrix;
            TriAngularMatrix = MatrixTriangularForm(Matrix);
            if (TriAngularMatrix != null)
            {
                for (int i = 0; i <= TriAngularMatrix.GetUpperBound(0); i++)
                {
                    d = d * TriAngularMatrix[i, i];
                }
            }
            d = d * z;
            return d;
        }

        public double[,] MatrixTriangularForm(double[,] Matrix)
        {
            int m;
            int n;
            int b = 0;
            int c = 0;
            double max;
            double g;
            double s;
            double[,] ResultMatrix;
            m = Matrix.GetLength(0);
            n = Matrix.GetLength(1);
            ResultMatrix = new double[m, n];
            if (m != n)
            {
                MessageBox.Show("Check the dimension of the matrix. ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            else if (m == n ^ (m == 1 & n == 1 & Matrix[0, 0] == 0))
            {
                z = 1;
                for (int k = 0; k <= m - 2; k++)
                {
                    max = 0;
                    for (int i = k; i <= m - 1; i++)
                    {
                        for (int j = k; j <= m - 1; j++)
                        {
                            if (Math.Abs(Matrix[i, j]) >= Math.Abs(max))
                            {
                                max = Matrix[i, j];
                                b = i;
                                c = j;
                            }
                        }
                    }
                    if (k != b)
                    {
                        for (int j = k; j <= m - 1; j++)
                        {
                            s = Matrix[k, j];
                            Matrix[k, j] = Matrix[b, j];
                            Matrix[b, j] = s;
                        }
                        z = -z;
                    }
                    if (k != c)
                    {
                        for (int i = k; i <= m - 1; i++)
                        {
                            s = Matrix[i, k];
                            Matrix[i, k] = Matrix[i, c];
                            Matrix[i, c] = s;
                        }
                        z = -z;
                    }
                    if (Matrix[k, k] != 0)
                    {
                        for (int i = k + 1; i <= m - 1; i++)
                        {
                            g = Matrix[i, k] / Matrix[k, k];
                            for (int j = k; j <= n - 1; j++)
                            {
                                Matrix[i, j] = Matrix[i, j] - g * Matrix[k, j];
                            }
                        }
                    }
                }
                for (int i = 0; i <= m - 1; i++)
                {
                    for (int j = 0; j <= n - 1; j++)
                    {
                        ResultMatrix[i, j] = Matrix[i, j];
                    }
                }
            }
            return ResultMatrix;
        }

        public double[,] MatrixTriangularForm(double[,] Matrix, int MinimalSize)
        {
            int m;
            int n;
            int b = 0;
            int c = 0;
            double max;
            double g;
            double s;
            double[,] ResultMatrix;
            m = Matrix.GetLength(0);
            n = Matrix.GetLength(1);
            ResultMatrix = new double[m, n];
            for (int k = 0; k <= MinimalSize; k++)
            {
                max = 0;
                for (int i = k; i <= m - 1; i++)
                {
                    for (int j = k; j <= n - 1; j++)
                    {
                        if (Math.Abs(Matrix[i, j]) >= Math.Abs(max))
                        {
                            max = Matrix[i, j];
                            b = i;
                            c = j;
                        }
                    }
                }
                if (k != b)
                {
                    for (int j = k; j <= n - 1; j++)
                    {
                        s = Matrix[k, j];
                        Matrix[k, j] = Matrix[b, j];
                        Matrix[b, j] = s;
                    }
                }
                if (k != c)
                {
                    for (int i = k; i <= m - 1; i++)
                    {
                        s = Matrix[i, k];
                        Matrix[i, k] = Matrix[i, c];
                        Matrix[i, c] = s;
                    }
                }
                if (Matrix[k, k] != 0)
                {
                    for (int i = k + 1; i <= m - 1; i++)
                    {
                        g = Matrix[i, k] / Matrix[k, k];
                        for (int j = k; j <= n - 1; j++)
                        {
                            Matrix[i, j] = Matrix[i, j] - g * Matrix[k, j];
                        }
                    }
                }
            }
            for (int i = 0; i <= m - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    ResultMatrix[i, j] = Matrix[i, j];
                }
            }
            return ResultMatrix;
        }

        public int MatrixRank(double[,] Matrix)
        {
            int m;
            int n;
            int r = 0;
            int EndRow;
            bool IsRowNotNull = false;
            double[,] TriangularMatrix;
            m = Matrix.GetLength(0);
            n = Matrix.GetLength(1);
            if (m < n)
            {
                EndRow = m - 2;
            }
            else
            {
                EndRow = n - 1;
            }
            TriangularMatrix = MatrixTriangularForm(Matrix, EndRow);
            OutputWindow otpWin = new OutputWindow();
            otpWin.Show();
            WriteToDGV(ref otpWin.otpDGV, TriangularMatrix);
            for (int i = m - 1; i >= 0; i += -1)
            {
                for (int j = n - 1; j >= 0; j += -1)
                {
                    if (Matrix[i, j] != 0)
                    {
                        IsRowNotNull = true;
                        break;
                    }
                }
                if (IsRowNotNull)
                {
                    r++;
                }
            }
            return r;
        }

        public double[,] MatrixTransposition(double[,] Matrix)
        {
            double[,] ResultMatrix;

            ResultMatrix = new double[Matrix.GetLength(1), Matrix.GetLength(0)];

            for (int i = 0; i <= Matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Matrix.GetUpperBound(1); j++)
                {
                    ResultMatrix[j, i] = Matrix[i, j];
                }
            }
            return ResultMatrix;
        }

        public double[,] InverseMatrix(double[,] Matrix)
        {
            double[,] A;
            double[,] B;
            double[,] C;
            double[] F;
            double[] G;
            double[] H;
            double[,] ResultMatrix;
            int m;
            int n;
            double o;
            double p;
            int q;
            m = Matrix.GetLength(0);
            n = Matrix.GetLength(1);

            A = new double[m, n];
            ResultMatrix = new double[m, n];

            for (int i = 0; i <= m - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    A[i, j] = Matrix[i, j];
                }
            }
            if (m != n)
            {
                MessageBox.Show("Unable to find inverse matrix. Check the dimension of the matrix.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            else if (MatrixDeterminant(A) == 0)
            {
                MessageBox.Show("Cannot find inverse matrix. The determinant is zero.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            else if (m == n ^ (m == 1 & n == 1 & A[0, 0] != 0))
            {
                // ERROR: Not supported in C#: ReDimStatement
                B = new double[m, n];
                C = new double[m, n];
                F = new double[m];
                G = new double[m];
                H = new double[m];

                for (int l = 0; l <= m - 1; l++)
                {
                    for (int i = 0; i <= m - 1; i++)
                    {
                        for (int j = 0; j <= m - 1; j++)
                        {
                            A[i, j] = Matrix[i, j];
                        }
                    }
                    for (int i = 0; i <= m - 1; i++)
                    {
                        if (i != l)
                            F[i] = 0;
                        else
                            F[i] = 1;
                    }
                    for (int k = 0; k <= m - 2; k++)
                    {
                        if (A[k, k] == 0)
                        {
                            for (int i = k + 1; i <= m - 1; i++)
                            {
                                if (A[i, k] != 0)
                                {
                                    for (int j = 0; j <= m - 1; j++)
                                    {
                                        p = A[k, j];
                                        A[k, j] = A[i, j];
                                        A[i, j] = p;
                                    }
                                    p = F[k];
                                    F[k] = F[i];
                                    F[i] = p;
                                }
                            }
                        }
                        G[k] = F[k] / A[k, k];
                        for (int i = k + 1; i <= m - 1; i++)
                        {
                            F[i] = F[i] - A[i, k] * G[k];
                            for (int j = m - 1; j >= k; j += -1)
                            {
                                B[k, j] = A[k, j] / A[k, k];
                                A[i, j] = A[i, j] - A[i, k] * B[k, j];
                            }
                        }
                    }
                    q = m - 1;
                    H[q] = F[q] / A[q, q];
                    do
                    {
                        q = q - 1;
                        o = 0;
                        for (int j = q; j <= m - 2; j++)
                        {
                            o = o + B[q, j + 1] * H[j + 1];
                        }
                        H[q] = G[q] - o;
                    } while (q > 0);
                    for (int i = 0; i <= m - 1; i++)
                    {
                        C[i, l] = H[i];
                    }
                }
                for (int i = 0; i <= m - 1; i++)
                {
                    for (int j = 0; j <= n - 1; j++)
                    {
                        ResultMatrix[i, j] = C[i, j];
                    }
                }
            }
            else
            {
                ResultMatrix[0, 0] = Math.Pow(A[0, 0], (-1));
            }
            return ResultMatrix;
        }

        public double[,] MultiplicationByNumber(double[,] Matrix, double Number)
        {
            int m;
            int n;
            double[,] ResultMatrix;
            m = Matrix.GetLength(0);
            n = Matrix.GetLength(1);

            ResultMatrix = new double[m, n];
            for (int i = 0; i <= m - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    ResultMatrix[i, j] = Matrix[i, j] * Number;
                }
            }
            return ResultMatrix;
        }

        public double[,] MatrixExponentiation(double[,] Matrix, int Exponent)
        {
            double[,] A;
            double[,] B;
            int m;
            int n;
            m = Matrix.GetLength(0);
            n = Matrix.GetLength(1);
            A = new double[m, n];
            B = new double[m, n];
            if (m != n)
            {
                MessageBox.Show("The matrix must be square.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            else if (m == 1 & n == 1)
            {
                A[0, 0] = Math.Pow(Matrix[0, 0], Exponent);
            }
            else
            {
                if (Exponent >= 1)
                {
                    for (int i = 0; i <= m - 1; i++)
                    {
                        for (int j = 0; j <= m - 1; j++)
                        {
                            if (i == j)
                            {
                                A[i, j] = 1;
                            }
                            else
                            {
                                A[i, j] = 0;
                            }
                        }
                    }
                    for (int i = 0; i <= m - 1; i++)
                    {
                        for (int j = 0; j <= m - 1; j++)
                        {
                            B[i, j] = Matrix[i, j];
                        }
                    }
                    for (int l = 1; l <= Exponent; l++)
                    {
                        A = MatrixMultiplication(A, B);
                    }
                }
                else if (Exponent <= 0)
                {
                    for (int i = 0; i <= m - 1; i++)
                    {
                        for (int j = 0; j <= m - 1; j++)
                        {
                            A[i, j] = Matrix[i, j];
                        }
                    }
                    B = InverseMatrix(A);
                    if (B != null)
                    {
                        for (int l = 0; l >= Exponent; l += -1)
                        {
                            A = MatrixMultiplication(A, B);
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return A;
        }
        #endregion

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DGV1.RowCount = 1;
            DGV1.ColumnCount = 1;
            DGV2.RowCount = 1;
            DGV2.ColumnCount = 1;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            DGV1.EndEdit();
            try
            {
                Result = OFD.ShowDialog();
                if (Result == DialogResult.OK)
                {
                    StreamReader FileToOpen = new StreamReader(OFD.FileName);
                    OpenFileStream(FileToOpen);
                    CurrentOpenFileName = OFD.FileName;
                    txtRowCount1.Text = DGV1.RowCount.ToString();
                    txtColumnCount1.Text = DGV1.ColumnCount.ToString();
                    this.saveAsBtn.Enabled = true;
                    this.saveBtn.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Cursor = Cursors.Arrow;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            double[,] A, B;
            DGV1.EndEdit();
            DGV2.EndEdit();
            A = ReadFromDGV(ref DGV1);
            B = ReadFromDGV(ref DGV2);
            if (CurrentOpenFileName == "")
            {
                SFD.ShowDialog();
                CurrentOpenFileName = SFD.FileName;
            }
            try
            {
                File.Delete(CurrentOpenFileName);
                StreamWriter FileFromTable = new StreamWriter(CurrentOpenFileName);
                SaveFileStream(A, B, FileFromTable);
                MatrixUnsavedChangesDone = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Cursor = Cursors.Arrow;
            } // : DGV1.BackgroundColor = Color.LightGreen
        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            double[,] A;
            double[,] B;
            DialogResult Result;
            DGV1.EndEdit();
            DGV2.EndEdit();
            A = ReadFromDGV(ref DGV1);
            B = ReadFromDGV(ref DGV2);
            Result = SFD.ShowDialog();
            try
            {
                if (Result == DialogResult.OK)
                {
                    File.Delete(SFD.FileName);
                    StreamWriter FileFromTable = new StreamWriter(SFD.FileName);
                    SaveFileStream(A, B, FileFromTable);
                    CurrentOpenFileName = SFD.FileName;
                    this.saveBtn.Enabled = true;
                    MatrixUnsavedChangesDone = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Cursor = Cursors.Arrow;
            }
        }

        private void createTable_Click(object sender, EventArgs e)
        {
            int m = 0;
            int n = 0;

            this.Cursor = Cursors.WaitCursor;
            if (((Button)sender).Name == "createTableA")
            {
                Int32.TryParse(txtRowCount1.Text, out m);
                Int32.TryParse(txtColumnCount1.Text, out n);
                if (TableCreate(m, n) == true)
                {
                    DGV1.RowCount = m;
                    DGV1.ColumnCount = n;
                    txtDetA.Text = "";
                    txtRankA.Text = "";
                }
            }
            if (((Button)sender).Name == "createTableB")
            {
                Int32.TryParse(txtRowCount2.Text, out m);
                Int32.TryParse(txtColumnCount2.Text, out n);
                if (TableCreate(m, n) == true)
                {
                    DGV2.RowCount = m;
                    DGV2.ColumnCount = n;
                    txtDetB.Text = "";
                    txtRankB.Text = "";
                }
            }
            this.Cursor = Cursors.Arrow;
            this.saveAsBtn.Enabled = true;
            MatrixUnsavedChangesDone = true;

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            double[,] A;
            DGV1.EndEdit();
            DGV2.EndEdit();
            A = ReadFromDGV(ref this.DGV1);
            CopyDGV(ref DGV2, ref DGV1);
            WriteToDGV(ref DGV2, A);
            MatrixUnsavedChangesDone = true;
        }

        private void additionBtn_Click(object sender, EventArgs e)
        {
            int m;
            int n;
            int k;
            int l;
            double[,] A;
            double[,] B;
            double[,] C;
            DGV1.EndEdit();
            DGV2.EndEdit();
            m = DGV1.RowCount;
            n = DGV1.ColumnCount;
            k = DGV2.RowCount;
            l = DGV2.ColumnCount;

            if (m != k & n != l)
            {
                MessageBox.Show("The dimensions of the matrices do not match. ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (m == k & n == l)
            {
                A = new double[m, n];
                B = new double[m, n];
                C = new double[m, n];

                A = ReadFromDGV(ref DGV1);
                B = ReadFromDGV(ref DGV2);
                for (int i = 0; i <= m - 1; i++)
                {
                    for (int j = 0; j <= n - 1; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                    }
                }
                OutputWindow otpWin = new OutputWindow();
                otpWin.Show();
                WriteToDGV(ref otpWin.otpDGV, C);
            }
        }

        private void substractBtn_Click(object sender, EventArgs e)
        {
            int m;
            int n;
            int k;
            int l;
            double[,] A;
            double[,] B;
            double[,] C;
            DGV1.EndEdit();
            DGV2.EndEdit();
            m = DGV1.RowCount;
            n = DGV1.ColumnCount;
            k = DGV2.RowCount;
            l = DGV2.ColumnCount;

            if (m != k & n != l)
            {
                MessageBox.Show("The dimensions of the matrices do not match. ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (m == k & n == l)
            {
                A = new double[m, n];
                B = new double[m, n];
                C = new double[m, n];

                A = ReadFromDGV(ref DGV1);
                B = ReadFromDGV(ref DGV2);
                for (int i = 0; i <= m - 1; i++)
                {
                    for (int j = 0; j <= n - 1; j++)
                    {
                        C[i, j] = A[i, j] - B[i, j];
                    }
                }
                OutputWindow otpWin = new OutputWindow();
                otpWin.Show();
                WriteToDGV(ref otpWin.otpDGV, C);
            }
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            double[,] A;
            double[,] B;
            double[,] C;
            DGV1.EndEdit();
            DGV2.EndEdit();
            A = ReadFromDGV(ref DGV1);
            B = ReadFromDGV(ref DGV2);
            C = MatrixMultiplication(A, B);
            if (C != null)
            {
                OutputWindow otpWin = new OutputWindow();
                otpWin.Show();
                WriteToDGV(ref otpWin.otpDGV, C);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to erase all data from tables A and B.\nAre you sure you want to continue?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DGV1.RowCount = 1;
                DGV1.ColumnCount = 1;
                DGV1.Rows[0].Cells[0].Value = null;
                DGV2.RowCount = 1;
                DGV2.ColumnCount = 1;
                DGV2.Rows[0].Cells[0].Value = null;
                txtRowCount1.Text = "";
                txtColumnCount1.Text = "";
                txtDetA.Text = "";
                txtRankA.Text = "";
                txtMultiplyA.Text = "";
                txtPowA.Text = "";
                txtRowCount2.Text = "";
                txtColumnCount2.Text = "";
                txtDetB.Text = "";
                txtRankB.Text = "";
                txtMultiplyB.Text = "";
                txtPowB.Text = "";
                this.saveBtn.Enabled = false;
                this.saveAsBtn.Enabled = false;
                CurrentOpenFileName = "";
                MatrixUnsavedChangesDone = false;
            }
        }

        private void detBtn_Click(object sender, EventArgs e)
        {
            double[,] A;
            DGV1.EndEdit();

            if (((Button)sender).Name == "detABtn")
            {
                A = ReadFromDGV(ref DGV1);
                if (A != null)
                {
                    txtDetA.Text = ((int)MatrixDeterminant(A)).ToString();
                }
            }
            else if (((Button)sender).Name == "detBBtn")
            {
                A = ReadFromDGV(ref DGV2);
                if (A != null)
                {
                    txtDetB.Text = ((int)MatrixDeterminant(A)).ToString();
                }
            }
        }

        private void RankBtn_Click(object sender, EventArgs e)
        {
            double[,] A;
            DGV2.EndEdit();
            switch (((Button)sender).Name)
            {
                case "RankABtn":
                    A = ReadFromDGV(ref DGV1);
                    txtRankA.Text = ((int)MatrixRank(A)).ToString();
                    break;
                case "RankBBtn":
                    A = ReadFromDGV(ref DGV2);
                    txtRankB.Text = ((int)MatrixRank(A)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void triangular_Click(object sender, EventArgs e)
        {
            double[,] A;
            double[,] B;
            if (((Button)sender).Name == "triangularA")
            {
                DGV1.EndEdit();
                A = ReadFromDGV(ref DGV1);
                B = MatrixTriangularForm(A);
                if (B != null)
                {
                    OutputWindow otpWin = new OutputWindow();
                    otpWin.Show();
                    WriteToDGV(ref otpWin.otpDGV, B);
                }
            }
            else if (((Button)sender).Name == "triangularB")
            {
                DGV2.EndEdit();
                A = ReadFromDGV(ref DGV2);
                B = MatrixTriangularForm(A);
                if (B != null)
                {
                    OutputWindow otpWin = new OutputWindow();
                    otpWin.Show();
                    WriteToDGV(ref otpWin.otpDGV, B);
                }
            }
        }

        private void transposed_Click(object sender, EventArgs e)
        {
            double[,] A;
            double[,] B;
            if (((Button)sender).Name == "transposedA")
            {
                DGV1.EndEdit();
                A = ReadFromDGV(ref DGV1);
                B = MatrixTransposition(A);
                WriteToDGV(ref DGV1, B);
            }
            else if (((Button)sender).Name == "transposedB")
            {
                DGV2.EndEdit();
                A = ReadFromDGV(ref DGV2);
                B = MatrixTransposition(A);
                WriteToDGV(ref DGV2, B);
            }
            MatrixUnsavedChangesDone = true;
        }

        private void reverse_Click(object sender, EventArgs e)
        {
            double[,] A;
            double[,] B;

            if (((Button)sender).Name == "reverseA")
            {
                DGV1.EndEdit();
                A = ReadFromDGV(ref DGV1);
                B = InverseMatrix(A);
                if (B != null)
                {
                    OutputWindow otpWin = new OutputWindow();
                    otpWin.Show();
                    WriteToDGV(ref otpWin.otpDGV, B);
                }
            }
            else if (((Button)sender).Name == "reverseB")
            {
                DGV2.EndEdit();
                A = ReadFromDGV(ref DGV2);
                B = InverseMatrix(A);
                if (B != null)
                {
                    OutputWindow otpWin = new OutputWindow();
                    otpWin.Show();
                    WriteToDGV(ref otpWin.otpDGV, B);
                }
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double x;
            double[,] A;
            double[,] B;


            if (((Button)sender).Name == "btnMultiplyA")
            {
                DGV1.EndEdit();
                A = ReadFromDGV(ref DGV1);
                if (txtMultiplyA.Text == "")
                {
                    MessageBox.Show("Enter the value for the number 'x'.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtMultiplyA.Text == "-")
                {
                    MessageBox.Show("Incorrect value. Field 'x' contains an invalid character.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    x = Convert.ToDouble(txtMultiplyA.Text);
                    B = MultiplicationByNumber(A, x);
                    OutputWindow otpWin = new OutputWindow();
                    otpWin.Show();
                    WriteToDGV(ref otpWin.otpDGV, B);
                }
            }
            else if (((Button)sender).Name == "btnMultiplyB")
            {
                DGV2.EndEdit();
                A = ReadFromDGV(ref DGV2);
                if (txtMultiplyA.Text == "")
                {
                    MessageBox.Show("Enter the value for the number 'x'.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtMultiplyA.Text == "-")
                {
                    MessageBox.Show("Incorrect value. Field 'x' contains an invalid character.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    x = Convert.ToDouble(txtMultiplyB.Text);
                    B = MultiplicationByNumber(A, x);
                    OutputWindow otpWin = new OutputWindow();
                    otpWin.Show();
                    WriteToDGV(ref otpWin.otpDGV, B);
                }
            }



        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            double[,] A;
            double[,] B;
            int x;
            if (((Button)sender).Name == "btnPowA")
            {
                if (txtPowA.Text == "")
                {
                    MessageBox.Show("Enter the value for the number 'x'.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtPowA.Text == "-")
                {
                    MessageBox.Show("Incorrect value. Field 'x' contains an invalid character.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Int32.TryParse(txtPowA.Text, out x))
                    {
                        A = ReadFromDGV(ref DGV1);
                        B = MatrixExponentiation(A, x);
                        if (B != null)
                        {
                            OutputWindow otpWin = new OutputWindow();
                            otpWin.Show();
                            WriteToDGV(ref otpWin.otpDGV, B);
                        }
                    }
                }
            }
            else if (((Button)sender).Name == "btnPowB")
            {
                if (txtPowB.Text == "")
                {
                    MessageBox.Show("Enter the value for the number 'x'.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtPowB.Text == "-")
                {
                    MessageBox.Show("Incorrect value. Field 'x' contains an invalid character.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Int32.TryParse(txtPowB.Text, out x))
                    {
                        A = ReadFromDGV(ref DGV2);
                        B = MatrixExponentiation(A, x);
                        if (B != null)
                        {
                            OutputWindow otpWin = new OutputWindow();
                            otpWin.Show();
                            WriteToDGV(ref otpWin.otpDGV, B);
                        }
                    }
                }
            }
        }

        private void associateMtrxExtensionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FileAssociation.IsAssociated)
                {
                    //MessageBox.Show(Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.Length - "matrixCalc.exe".Length));
                    //FileAssociation.Associate("Matrix File", Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.Length - "matrixCalc.exe".Length) + "matrix.ico");
                    FileAssociation.Associate("Matrix File", Application.ExecutablePath + ",-0");
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType().ToString() == "System.UnauthorizedAccessException")
                {
                    MessageBox.Show("Please, run the applicaion as administrator.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
    }
}