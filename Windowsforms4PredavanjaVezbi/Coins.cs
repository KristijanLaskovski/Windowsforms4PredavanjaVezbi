using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Windowsforms4PredavanjaVezbi
{
   public  class Coins
    {
       public int numcoins { get; set; }
       public Coins(int n = 1)
       {
           if(n>=0)
           numcoins = n;
       }
       public void AddCoin()
       {
           numcoins++;
       }
       public void RemoveOne()
       {
       if(numcoins >0)
           numcoins--;
       }



    }
}
