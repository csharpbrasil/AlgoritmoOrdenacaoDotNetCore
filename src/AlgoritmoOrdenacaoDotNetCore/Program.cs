using System;
using System.Diagnostics;

namespace AlgoritmoOrdenacaoDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            InicializaAplicacao();
        }

        private static void InicializaAplicacao()
        {
            CriaJanela();
            CriaMenu();
            InicializaPrompt();
        }

        private static void CriaJanela()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.SetCursorPosition(0, 0);
            Console.Write("╔");
            Console.SetCursorPosition(79, 0);
            Console.Write("╗");
            Console.SetCursorPosition(0, 24);
            Console.Write("╚");
            Console.SetCursorPosition(79, 24);
            Console.Write("╝");

            for (int i = 1; i < 79; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("═");
            }

            for (int i = 1; i < 24; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("║");
            }

            for (int i = 1; i < 24; i++)
            {
                Console.SetCursorPosition(79, i);
                Console.Write("║");
            }

            for (int i = 1; i < 79; i++)
            {
                Console.SetCursorPosition(i, 24);
                Console.Write("═");
            }

            Console.SetCursorPosition(2, 1);
            Console.Write("ALGORITMOS DE ORDENAÇÃO");

            Console.SetCursorPosition(0, 2);
            Console.Write("╠");
            Console.SetCursorPosition(79, 2);
            Console.Write("╣");

            for (int i = 1; i < 79; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("═");
            }

            Console.SetCursorPosition(30, 24);
            Console.Write("╣ RAPHAEL CARDOSO - www.raphaelcardoso.com.br ╠");
        }

        private static void CriaMenu()
        {
            Console.SetCursorPosition(2, 3);
            Console.Write(" MENU");
            Console.SetCursorPosition(2, 5);
            Console.Write("1)  Insertion Sort");
            Console.SetCursorPosition(2, 6);
            Console.Write("2)  Shell Sort");
            Console.SetCursorPosition(2, 7);
            Console.Write("3)  Selection Sort");
            Console.SetCursorPosition(2, 8);
            Console.Write("4)  Heap Sort");
            Console.SetCursorPosition(2, 9);
            Console.Write("5)  Bubble Sort");
            Console.SetCursorPosition(2, 10);
            Console.Write("6)  Cocktail Sort");
            Console.SetCursorPosition(2, 11);
            Console.Write("7)  Comb Sort");
            Console.SetCursorPosition(2, 12);
            Console.Write("8)  Gnome Sort");
            Console.SetCursorPosition(2, 13);
            Console.Write("9)  Odd-even Sort");
            Console.SetCursorPosition(2, 14);
            Console.Write("10) Quick Sort");
            Console.SetCursorPosition(2, 15);
            Console.Write("11) Sair");
        }

        private static void InicializaPrompt()
        {
            var stopWatch = new Stopwatch();

            Console.SetCursorPosition(2, 23);
            Console.Write("Escolha uma opção: ");
            string valor = Console.ReadLine();
            int opcao;
            int.TryParse(valor, out opcao);

            switch (opcao)
            {
                case 1: // Insertion Sort
                    stopWatch.Start();
                    OpcaoInsertionSort();
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();

                    break;
                case 2: // Shell Sort
                    stopWatch.Start();
                    OpcaoShellSort();
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 3: // Selection Sort
                    stopWatch.Start();
                    OpcaoSelectionSort();
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 4: // Heap Sort
                    stopWatch.Start();
                    OpcaoHeapSort();
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 5: // Bubble Sort
                    stopWatch.Start();
                    OpcaoBubbleSort();
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 6: // Cocktail Sort
                    stopWatch.Start();
                    OpcaoCocktailSort();
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 7: // Comb Sort
                    stopWatch.Start();
                    OpcaoCombSort();
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 8: // Gnome Sort
                    stopWatch.Start();
                    OpcaoGnomeSort();
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 9: // Odd-Even Sort
                    stopWatch.Start();
                    OpcaoOddEvenSort();
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 10: // Quick Sort
                    stopWatch.Start();
                    OpcaoQuickSort();
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 11: // SAIR
                    Environment.Exit(0);
                    break;
                default: // VOLTA PARA O MENU
                    InicializaAplicacao();
                    break;
            }

            InicializaAplicacao();
        }

        private static string ConverteVetor(int[] vetor)
        {
            string virgula = string.Empty;
            string valores = string.Empty;
            for (int i = 0; i < vetor.Length; i++)
            {
                valores += virgula + vetor[i];
                virgula = ",";
            }

            return valores;
        }

        private static void OpcaoInsertionSort()
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" INSERTION SORT");

            int[] vetor = new int[] { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + ConverteVetor(vetor));

            int[] novoVetor = Ordenacoes.insertionSort(vetor);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + ConverteVetor(novoVetor));
        }

        private static void OpcaoShellSort()
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" SHELL SORT");

            int[] vetor = new int[] { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + ConverteVetor(vetor));

            int[] novoVetor = Ordenacoes.shellSort(vetor);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + ConverteVetor(novoVetor));
        }

        private static void OpcaoSelectionSort()
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" SELECTION SORT");

            int[] vetor = new int[] { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + ConverteVetor(vetor));

            int[] novoVetor = Ordenacoes.selectionSort(vetor);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + ConverteVetor(novoVetor));
        }

        private static void OpcaoHeapSort()
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" HEAP SORT");

            int[] vetor = new int[] { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + ConverteVetor(vetor));

            int[] novoVetor = Ordenacoes.heapSort(vetor);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + ConverteVetor(novoVetor));
        }

        private static void OpcaoBubbleSort()
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" BUBBLE SORT");

            int[] vetor = new int[] { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + ConverteVetor(vetor));

            int[] novoVetor = Ordenacoes.bubbleSort(vetor);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + ConverteVetor(novoVetor));
        }

        private static void OpcaoCocktailSort()
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" COCKTAIL SORT");

            int[] vetor = new int[] { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + ConverteVetor(vetor));

            int[] novoVetor = Ordenacoes.cocktailSort(vetor);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + ConverteVetor(novoVetor));
        }

        private static void OpcaoCombSort()
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" COMB SORT");

            int[] vetor = new int[] { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + ConverteVetor(vetor));

            int[] novoVetor = Ordenacoes.combSort(vetor);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + ConverteVetor(novoVetor));
        }

        private static void OpcaoGnomeSort()
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" GNOME SORT");

            int[] vetor = new int[] { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + ConverteVetor(vetor));

            int[] novoVetor = Ordenacoes.gnomeSort(vetor);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + ConverteVetor(novoVetor));
        }

        private static void OpcaoOddEvenSort()
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" ODD-EVEN SORT");

            int[] vetor = new int[] { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + ConverteVetor(vetor));

            int[] novoVetor = Ordenacoes.oddEvenSort(vetor);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + ConverteVetor(novoVetor));
        }

        private static void OpcaoQuickSort()
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" QUICK SORT");

            int[] vetor = new int[] { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + ConverteVetor(vetor));

            int[] novoVetor = Ordenacoes.quickSort(vetor);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + ConverteVetor(novoVetor));
        }
    }
}
