using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairClasses
{
    abstract class Pair
    {
       
        abstract public Pair Add(Object obj);
        abstract public Pair Sub(Object obj);
        abstract public Pair Mult(double v);
        abstract public bool CompareTo(Object obj);
       
        
    
        
    }
}