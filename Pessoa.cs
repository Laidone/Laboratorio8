using System;
using System.Collections;

public class Pessoa : IComparable<Pessoa>
{
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
    public class sortcompare_2 : IComparer
    {
        int IComparer.Compare(object a, object b)
        {
            Pessoa p1 = (Pessoa)a;
            Pessoa p2 = (Pessoa)b;

            if(p1.Nome.CompareTo(p2.Nome) == 0){
                return 0;
            }
            else if (p1.Nome.CompareTo(p2.Nome) > 0){
                return 1;
            }
            else {
                return -1;
            }
        }
    }
    private string meuNome; 
    private int minhaIdade; 
    public Pessoa(string n, int i) 
    { 
        meuNome = n;
        minhaIdade = i; 
    } 
    public string Nome 
    { 
        get { return meuNome; } 
    } 
    public int Idade 
    { 
        get { return minhaIdade; }
        set { minhaIdade = value; }
    }
    public int CompareTo(Pessoa outro) 
    { 
        return meuNome.CompareTo(outro.meuNome); 
    }
    /*public int CompareTo(Pessoa outro){
        return minhaIdade.CompareTo(outro.minhaIdade);
    }*/
}
/*
Você conseguiria criar uma classe Pessoa que permitisse ordenar ora por nome, ora pela idade, utilizando 
a interface IComparable? 
Resposta: Não uma vez que a classe Pessoa não pode ser instanciada mais de uma vez e eu não posso ter dois métodos
CompareTo na classe(Tipo "Pessoa" já define um membro chamado "CompareTo"
com os mesmos tipos de parâmetro [Laboratorio8]csharp(CS0111))
public class Pessoa : IComparable<Pessoa>{

}*/