class Program
{
    static void Main(string[] args)
    {
        // Passo 1
        List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

        // Passo 2
        Stack<int> pilha = new Stack<int>();
        while (lista.Count > 0)
        {
            pilha.Push(lista[0]);
            lista.RemoveAt(0);
        }

        // Passo 3
        Queue<int> fila = new Queue<int>(pilha);

        // Passo 4
        lista.AddRange(new List<int> { 6, 7, 8, 9, 10 });

        // Passo 5
        pilha.Clear();
        while (lista.Count > 0)
        {
            pilha.Push(lista[0]);
            lista.RemoveAt(0);
        }
        while (pilha.Count > 0)
        {
            fila.Enqueue(pilha.Pop());
        }

        // Passo 6
        foreach (int num in fila)
        {
            Console.Write(num + " ");
        }
    }
}
