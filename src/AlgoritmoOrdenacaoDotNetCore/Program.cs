using System;
using System.Diagnostics;

namespace AlgoritmoOrdenacaoDotNetCore
{
    static class Program
    {
        private static int MaxWidth
        {
            get => Console.BufferWidth - 1;
        }

        private static int MaxHeight
        {
            get => Console.BufferHeight - 1;
        }

        private static int[] _vetor = new[] { 12, 34, 890, 1000, 54, 112, 53, 450, 99, 652, 45, 96, 71, 69, 72, 23, 83, 63, 100 };
        
        static void Main()
        {
            InicializaAplicacao();
        }

        static void InicializaAplicacao()
        {
            CriaJanela();
            CriaMenu();
            InicializaPrompt();   
        }
        
        private static void CriaJanela()
        {
            Console.Title = "Algoritmos de ordenação";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.CancelKeyPress += (_, _) => EncerrarExecucao();
            
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("╔");
            Console.SetCursorPosition(MaxWidth, 0);
            Console.Write("╗");
            Console.SetCursorPosition(0, MaxHeight);
            Console.Write("╚");
            Console.SetCursorPosition(MaxWidth, MaxHeight);
            Console.Write("╝");

            for (int i = 1; i < MaxWidth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("═");
            }

            for (int i = 1; i < MaxHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("║");
            }

            for (int i = 1; i < MaxHeight; i++)
            {
                Console.SetCursorPosition(MaxWidth, i);
                Console.Write("║");
            }

            for (int i = 1; i < MaxWidth; i++)
            {
                Console.SetCursorPosition(i, MaxHeight);
                Console.Write("═");
            }
            
            ExibeTitulo("ALGORITMOS DE ORDENAÇÃO");

            Console.SetCursorPosition(0, 2);
            Console.Write("╠");
            Console.SetCursorPosition(MaxWidth, 2);
            Console.Write("╣");

            for (int i = 1; i < MaxWidth; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("═");
            }

            ExibeCreditos("╣ C# BRASIL - csharpbrasil.com.br ╠");
        }

        private static void ExibeTitulo(string titulo)
        {
            Console.SetCursorPosition((MaxWidth / 2) - (titulo.Length / 2), 1);
            Console.Write(titulo);
        }

        private static void ExibeCreditos(string creditos)
        {
            Console.SetCursorPosition(MaxWidth-creditos.Length-1, MaxHeight);
            Console.Write(creditos);
        }
        
        private static void ExibeSubTitulo(string subTitulo)
        {
            Console.SetCursorPosition(2, 3);
            Console.Write(subTitulo);
        }

        private static void ExibeTempo(TimeSpan tempo)
        {
            Console.SetCursorPosition(2, 8);
            Console.Write("TEMPO:");
            Console.SetCursorPosition(15, 8);
            Console.Write(tempo);
        }

        private static void ExibeVetor(int[] vetor)
        {
            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:");
            Console.SetCursorPosition(15, 5);
            Console.Write(ConverteVetor(vetor));
        }

        private static void ExibeResultado(int[] vetor)
        {
            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO:");
            Console.SetCursorPosition(15, 6);
            Console.Write(ConverteVetor(vetor));
        }

        private static void CriaMenu()
        {
            ExibeSubTitulo("MENU");

            var opcoes = new []
            { 
                "Insertion Sort",
                "Shell Sort",
                "Selection Sort",
                "Heap Sort",
                "Bubble Sort",
                "Cocktail Sort",
                "Comb Sort",
                "Gnome Sort",
                "Odd-even Sort",
                "Quick Sort",
                "Merge Sort"
            };

            for (int i = 0; i < opcoes.Length; i++)
            {
                Console.SetCursorPosition(2, i+6);
                Console.Write("{0}) {1}", i+1, opcoes[i]);
            }
        }

        private static void ExecutaAlgoritmoOrdenacao(string titulo, Func<int[], int[]> funcaoAlgoritmoOrdenacao)
        {
            CriaJanela();
            ExibeSubTitulo(titulo);
            ExibeVetor(_vetor);
            
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            int[] novoVetor = funcaoAlgoritmoOrdenacao(_vetor);
            stopWatch.Stop();
            
            ExibeResultado(novoVetor);
            ExibeTempo(stopWatch.Elapsed);
            
            Console.SetCursorPosition(2, MaxHeight-1);
            Console.Write("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            
            InicializaAplicacao();
        }

        private static void InicializaPrompt()
        {
            Console.SetCursorPosition(2, MaxHeight-1);
            Console.Write("Ou pressione qualquer tecla para finalizar...");
            
            Console.SetCursorPosition(2, MaxHeight-2);
            Console.Write("Escolha uma opção: ");
            
            int.TryParse(Console.ReadLine(), out int opcao);
            switch (opcao)
            {
                case 1: // Insertion Sort
                    ExecutaAlgoritmoOrdenacao("INSERTION SORT", Ordenacoes.InsertionSort);
                    break;
                case 2: // Shell Sort
                    ExecutaAlgoritmoOrdenacao("SHELL SORT", Ordenacoes.ShellSort);
                    break;
                case 3: // Selection Sort
                    ExecutaAlgoritmoOrdenacao("SELECTION SORT", Ordenacoes.SelectionSort);
                    break;
                case 4: // Heap Sort
                    ExecutaAlgoritmoOrdenacao("HEAP SORT", Ordenacoes.HeapSort);
                    break;
                case 5: // Bubble Sort
                    ExecutaAlgoritmoOrdenacao("BUBBLE SORT", Ordenacoes.BubbleSort);
                    break;
                case 6: // Cocktail Sort
                    ExecutaAlgoritmoOrdenacao("COCKTAIL SORT", Ordenacoes.CocktailSort);
                    break;
                case 7: // Comb Sort
                    ExecutaAlgoritmoOrdenacao("COMB SORT", Ordenacoes.CombSort);
                    break;
                case 8: // Gnome Sort
                    ExecutaAlgoritmoOrdenacao("GNOME SORT", Ordenacoes.GnomeSort);
                    break;
                case 9: // Odd-Even Sort
                    ExecutaAlgoritmoOrdenacao("ODD-EVEN SORT", Ordenacoes.OddEvenSort);
                    break;
                case 10: // Quick Sort
                    ExecutaAlgoritmoOrdenacao("QUICK SORT", Ordenacoes.QuickSort);
                    break;
                case 11: // Merge Sort
                    ExecutaAlgoritmoOrdenacao("MERGE SORT", Ordenacoes.MergeSort);
                    break;
                default: // SAIR
                    EncerrarExecucao();
                    break;
            }
        }

        private static void EncerrarExecucao()
        {
            Console.ResetColor();
            Console.Clear();
            Environment.Exit(0);
        }

        private static string ConverteVetor(int[] vetor) => string.Join(',', vetor);
    }
}
