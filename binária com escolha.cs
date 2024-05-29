﻿class Program
{
    static void Main(string[] args)

    {
        int[] lista = { 15, 86, 22, 38, 93, 23, 64, 95,25, 69, 45, 16 };

        Console.WriteLine("Qual número deseja procurar?");

        int elemento = int.Parse(Console.ReadLine());

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
        int inicio = 0;
        int fim = lista.Length - 1;
        int meio;
        do
        {
            meio = (inicio + fim) / 2;
            if (lista[meio] == elemento) return meio;

            if (lista[meio] > elemento)
                fim = meio - 1;

            else
                inicio = meio + 1;



        } while (inicio <= fim);
        return -1;
    }
}