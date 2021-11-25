using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{

    public class algorithm
    {

        public static void insertSort(string[] A)
        {

            for (int i = 1; i < A.Length; i++)
            {

                for( int j = i-1; j > 0; j--)
                {
                    if (A[j].Length > A[i].Length)
                    {
                        // 入れ替える
                        A[j+1] = A[j];
                    }
                    else
                    {

                        A[j] = A[i];
                        // なにもしない
                    }

                }
            }

            foreach(string a in A)
            {

            }



        }

        public void mergeSort()
        {

        }


    }
}
