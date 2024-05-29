class Program
{
    static void Main(string[] args)

    {
        int[] lista = { 15, 86, 22, 38, 93, 23, 64, 95,25, 69, 45, 16 };
        int elemento = 25;

        int achar = BuscarNumero(lista, elemento);

        if (achar != -1)
        {
            Console.WriteLine($"{elemento} encontrado no indice {achar}");
        }
        else
        {
            Console.WriteLine($"{elemento} não encontrado na lista");
        }
    }

    public static int BuscarNumero(int[] lista, int elemento)
    {
        for (int i = 0; i < lista.Length; i++)
        {
            if (lista[i] == elemento)
            {

                return i;

            }


        }
        return -1;
    }
}
