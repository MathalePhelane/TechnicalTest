using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace TS.TechnicalTest
{
    public class PitFinder : IPitFinder
    {
        public int FindDeepestPit (int[] A)
        
        {
              int deepestPt = -1;
              int n = A.Length;

              for(int i = 0; i < n -1 ; i++){
                if(A[i] <= A[i +1]){
                    continue;// this is mainly not a decreasing sequence so we can skipp it
                }
                

              }

        }
    }
}