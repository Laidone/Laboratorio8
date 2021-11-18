using System;
using System.Collections;

public class sortcompare : IComparer
{
        int IComparer.Compare(object a, object b)
        {
            Pessoa p1 = (Pessoa)a;
            Pessoa p2 = (Pessoa)b;

            if(p1.Idade > p2.Idade){
                return 1;
            }
            if(p1.Idade < p2.Idade){
                return -1;
            }
            else{
                return 0;
            }
        }    
}