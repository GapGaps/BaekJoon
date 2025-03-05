using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5972
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
            int[,] graph = new int[arr[0] + 1, arr[0] + 1]; 
            for(int x=0;x<graph.GetLength(0); x++)
            {
                for (int y = 0; y < graph.GetLength(1); y++)
                {
                    graph[x, y] = int.MaxValue;
                }
            }
            int edge = arr[1];

            for(int i = 0; i < edge; i++)
            {
                int[] data = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
                graph[data[0], data[1]] = data[2];
            }
            


        }

        public static void Dicstraa(int start, int end)
        {
            bool[] visited = new bool[end];
        }
    }

    public class Node
    {
        public int start;
        public int end;
        public int sum;

        public Node(int start, int end, int sum)
        {
            this.start = start;
            this.end = end;
            this.sum = sum;
        }
    }
}
