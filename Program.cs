using System;

// Lista<int> list = new Lista<int>();

// list.Add(1);
// list.Add(2);
// list.Add(3);
// list.Add(4);

// foreach(var val in list.lista){
//     Console.WriteLine(val);
// }

// public class Lista<T>
// {
//     public T[] lista = new T[10];
//     private int index {get; set;} = 0;

//     public void Add(T item)
//     {
//         lista[index] = item;
//         index++;
//     }
// }

// Stack<string> stack = new Stack<string>();

// stack.Push("assad");
// stack.Push("dsfdsf");
// stack.Push("ewqew");

// Console.WriteLine(stack);

// stack.Pop();

// Console.WriteLine(stack);

// stack.Clear();

// Console.WriteLine(stack);
// Console.WriteLine(stack.isEmpty());
// Console.WriteLine(stack.Size());


// public class Stack<T>
// {
//     private T[] stack = new T[10];
//     private int size = 0;

//     public void Push(T value)
//     {
//         stack[size] = value;
//         size++;
//     }
//     public void Pop()
//     {
//         stack[size] = default(T);
//         size--;
//     } 
//     public bool isEmpty()
//     {
//         if(size <= 0)
//             return true;
//         return false;
//     }
//     public int Size()
//     {
//         return size;
//     }
//     public void Clear()
//     {
//         for (int i = 0; i < size; i++){
//             stack[i] = default(T);
//         }
//         size = 0;
//     }
//     public override string ToString()
//     {
//         string saida = "";
//         for (int i = size; i > 0; i--){
//             saida += i-1 + " - " + "[" + stack[i-1] + "]" + "\n";
//         }
//         return saida;
//     }

// }

List<string> teste = new List<string>{"oi", "galerinha", "bonita!"};

formataString(teste, CaixaAlta);


List<string> formataString(List<string> strlist, formata format){
    List<string> result = new List<string>();

    foreach(var s in strlist){
        result.Add(format(s));
    }

    return result;
}

string CaixaAlta(string valor){
    return valor.ToUpper();
}

string Capitalize(string valor){
    List<string> lista = valor.Split(" ").ToList();
    string saida = "";

    saida += char.ToUpper(lista[0].ElementAt(0));

    for (int i = 1; i < lista[0].Count(); i++)
    {
        saida += lista[0].ElementAt(i);
    }
    
    saida += " ";

    for (int i = 1; i < lista.Count(); i++)
    {
        saida += lista[i] + " ";
    }

    return saida;
}

string CapitalizeAll(string valor){
    List<string> lista = valor.Split(" ").ToList();
    string saida = "";

    for (int i = 0; i < lista.Count(); i++)
    {
        saida += char.ToUpper(lista[i].ElementAt(0));

        for (int j = 1; j < lista[i].Count(); j++)
        {
            saida += lista[i].ElementAt(i);
        }
        saida += " ";
    }

    return saida;
}

delegate string formata(string valor);