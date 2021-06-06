using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Matrix1.Program;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class quadmatrixTest
        {
            [TestMethod]
            public void QuadTest()
            {
                //arrange
                int n = 3;
                int expected = 9;
                //act
                RMatrix A = new RMatrix(n);

                int actual = A.GetnCols * A.GetnRows;
                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void ToStringTest()
            {
                //arrange

                //act
                RMatrix A = new RMatrix(3);
                //assert
                Assert.IsNotNull(A.ToString());
            }

            [TestMethod]
            public void OperatorPlusTest()
            {
                //arrange
                int n = 3;
                RMatrix A = new RMatrix(n);
                RMatrix B = new RMatrix(n);
                double expected = 18;


                //act
                double tmp = 0;
                for (int i = 0; i < A.GetnRows; i++)
                {
                    for (int j = 0; j < B.GetnRows; j++)
                    {
                            tmp += A[i, j] + B[i, j];
                    }
                }
                //assert
                Assert.AreEqual(expected, tmp);
            }

            [TestMethod]
            public void IncrementTest()
            {
                //arrange
                int n = 3;
                RMatrix A = new RMatrix(n);
                RMatrix B = new RMatrix(n);
                double expected = 0;


                //act
                double actual = 0;
                for (int i = 0; i < A.GetnRows; i++)
                {
                    for (int j = 0; j < B.GetnRows; j++)
                    {
                        actual = A[i,j] - B[i, j];
                    }
                }
                //assert
                Assert.AreEqual(expected, actual);
            }


            [TestMethod]
            public void UmnTest()
            {
                //arrange
                int n = 3;
                RMatrix A = new RMatrix(n);
                RMatrix B = new RMatrix(n);
                double expected = 9;

                //act
                double actual = 0;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        actual += A[i, j] * B[i,j];
                    }
                //assert
                Assert.AreEqual(expected,actual);
            }

            [TestMethod]
            public void UmnNumberTest()
            {
                //arrange
                int n = 3;
                RMatrix A = new RMatrix(n);
                double expected = 27;


                //act
                double actual = 0;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        actual += A[i, j] * 3;
                    }
                //assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void GetHashCodeTest()
            {
                //arrange
                int n = 3;
                RMatrix A = new RMatrix(n);
                RMatrix B = new RMatrix(n);
                //act
                RMatrix.Determinant(A);
                RMatrix.Determinant(B);
                double actual = 0;
                double actual1 = 1;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        actual += A[i, j] - 1;
                    }
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        actual1 += B[i, j] + 1;
                    }
                //assert
                Assert.AreNotEqual(actual1, actual);
            }
        }
    }
}
