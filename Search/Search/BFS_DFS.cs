using System;
using System.Collections.Generic;

public class Graph
{
    private int V; // 그래프의 정점 개수
    private List<int>[] adj; // 인접 리스트

    public Graph(int v)                  // 배열 생성 후 배열마다 리스트를 연결
    {
        V = v;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w) // v번째 정점에서 W 로 가는 간선 연결 // 한쪽만 이어주기에 방향 그래프
    {
        adj[v].Add(w);
    }

    public void DFS(int v)               // DFS 재귀
    {
        bool[] visited = new bool[V]; // 방문했는지 여부 검사용 , 선언만 하는 이유는 선언 시 C# 은 False 값으로 되기에 
        DFSUtil(v, visited);
    }

    private void DFSUtil(int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write($"{v} ");   // 방문한 정점 출력

        foreach (int n in adj[v])
        {
            if (!visited[n])
            {
                DFSUtil(n, visited);
            }
        }
    }

    public void BFS(int v)              // 큐
    {
        bool[] visited = new bool[V];     // 선언만 하는 이유는 선언 시 C# 은 False 값으로 되기에 
        Queue<int> queue = new Queue<int>();

        visited[v] = true;
        queue.Enqueue(v); // v를 queue 에 담음 Enqueue = push 와 동일

        while (queue.Count > 0)
        {
            int n = queue.Dequeue(); // Dequeue = pop 과 동일
            Console.Write($"{n} ");

            foreach (int m in adj[n])
            {
                if (!visited[m])
                {
                    visited[m] = true;
                    queue.Enqueue(m);
                }
            }
        }
    }
}

public class BFS_DFS
{
    public static void Main()
    {
        Graph graph = new Graph(6);

        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 4);
        graph.AddEdge(3, 5);
        graph.AddEdge(4, 5);

        Console.WriteLine("DFS traversal:");
        graph.DFS(0);
        Console.WriteLine();

        Console.WriteLine("BFS traversal:");
        graph.BFS(0);
        Console.WriteLine();
    }
}