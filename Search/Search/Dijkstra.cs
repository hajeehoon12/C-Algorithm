using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Search
{


    internal class Dijkstra
    {
        class DijkstraExample
        {
            static int V = 6; // 정점의 수

            // 주어진 그래프의 최단 경로를 찾는 다익스트라 알고리즘
            static void Dijkstra(int[,] graph, int start)
            {
                //Console.WriteLine(graph.GetLength(0)); // 2차원 배열 길이가져오기 (0) : 길이 (1) : 나중에 너비 V대신 넣으면 좋음
                int[] distance = new int[V]; // 시작 정점으로부터의 거리 배열
                bool[] visited = new bool[V]; // 방문 여부 배열

                // 거리 배열 초기화
                for (int i = 0; i < V; i++)
                {
                    distance[i] = int.MaxValue; // 배열에 무한대 값을 넣고 대기
                }

                distance[start] = 0; // 자기 자신은 당연히 0

                // 모든 정점을 방문할 때까지 반복
                for (int count = 0; count < V - 1; count++) // 정점은 V개니까 v-1번만 실행, 0에서 시작했으므로
                {
                    // 현재 방문하지 않은 정점들 중에서 최소 거리를 가진 정점을 찾음
                    int minDistance = int.MaxValue; // 젤 작은값 미리 초기화
                    int minIndex = -1;

                    for (int v = 0; v < V; v++) // 모든 정점 순회
                    {
                        if (!visited[v] && distance[v] <= minDistance) // 아직 방문하지 않았고 and 해당 정점의 거리가 가장 작은값이라면 
                        {
                            minDistance = distance[v]; // 작은값 넣고
                            minIndex = v;             // 해당 정점 인덱스 투입
                        }
                    }

                    // 최소 거리를 가진 정점을 방문 처리
                    visited[minIndex] = true;

                    // 최소 거리를 가진 정점과 인접한 정점들의 거리 업데이트
                    for (int v = 0; v < V; v++)
                    {
                        if (!visited[v] && graph[minIndex, v] != 0 && distance[minIndex] != int.MaxValue // 방문하지않음 and 연결됨 and 값넣어짐
                             && distance[minIndex] + graph[minIndex, v] < distance[v]) // and  dist(start,b) + dist(b,c) < dist(start,c) 일떄 

                        {
                            distance[v] = distance[minIndex] + graph[minIndex, v]; // 값 업데이트
                        }
                    }
                }

                // 최단 경로 출력
                Console.WriteLine("정점\t거리");
                for (int i = 0; i < V; i++)
                {
                    Console.WriteLine($"{i}\t{distance[i]}");
                }
            }

            static void Main(string[] args)
            {
                int[,] graph = {
                    { 0, 4, 0, 0, 0, 0 },
                    { 4, 0, 8, 0, 0, 0 },
                    { 0, 8, 0, 7, 0, 4 },
                    { 0, 0, 7, 0, 9, 14 },
                    { 0, 0, 0, 9, 0, 10 },
                    { 0, 0, 4, 14, 10, 0 }
                    
                };

                int start = 0; // 0 번 정점에서 시작

                Dijkstra(graph, start);
            }
        }

    }
}
