using System;
using System.Collections.Generic;
using System.Linq;

namespace AMOGUS
{
    class Graph
    {
        private int verticesCount;
        private int[,] adjacencyMatrix;
        private const int INF = int.MaxValue;

        public Graph(int verticesCount)
        {
            this.verticesCount = verticesCount;
            adjacencyMatrix = new int[verticesCount, verticesCount];
        }

        public void AddEdge(int source, int destination, int weight)
        {
            adjacencyMatrix[source, destination] = weight;
        }

        public void BellmanFord(int sourceVertex)
        {
            int[] distances = new int[verticesCount];
            for (int i = 0; i < verticesCount; ++i)
            {
                distances[i] = INF;
            }
            distances[sourceVertex] = 0;

            for (int i = 0; i < verticesCount - 1; ++i)
            {
                for (int j = 0; j < verticesCount; ++j)
                {
                    for (int k = 0; k < verticesCount; ++k)
                    {
                        if (adjacencyMatrix[j, k] != 0)
                        {
                            int distance = distances[j] + adjacencyMatrix[j, k];
                            if (distance < distances[k])
                                distances[k] = distance;
                        }
                    }
                }
            }

            for (int i = 0; i < verticesCount; ++i)
            {
                if (distances[i] == INF)
                    Console.WriteLine("Вершина {0} недосягаема из исходной вершины", i);
                else
                    Console.WriteLine("Кратчайший путь к вершине {0} равен {1}", i, distances[i]);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество вершин графа:");
            int number = int.Parse(Console.ReadLine());
            Graph g = new Graph(number);

            Console.WriteLine("Вводите рёбра графа в формате <номер вершины___номер второй вершины___вес ребра>");
            Console.WriteLine("чтобы закончить ввод граней введите слово <stop>");

            while (true)
            {
                string input = Console.ReadLine();
                if (input != "stop")
                {
                    string[] input0 = input.Split(' ');
                    g.AddEdge(int.Parse(input0[0]), int.Parse(input0[1]), int.Parse(input0[2]));
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine("Введите номер исходной вершины:");
            int ver = int.Parse(Console.ReadLine());
            g.BellmanFord(ver);
        }
    }
}
