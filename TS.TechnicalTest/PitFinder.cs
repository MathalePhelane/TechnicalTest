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
                int q = i =1;
                while(q < n -1 && A[q] >= A[q +1]){
                    q++; //basically finding the bottom of the pit
                }
                if(q == n -1 || A[q] == A[q +1]){
                    continue; // this is not a pit
                }
                int r = q +1;
                while(r < n -1 && A[r] <= A[r +1]){
                    r++; // finding the right side of the pit
                }
                int maxDepth = Math.Min(A[i] - A[q], A[r] - A[q]);
                deepestPt = Math.Max(deepestPt, maxDepth);
                i = r -1;
              }
                return deepestPt;

        }
    }
}