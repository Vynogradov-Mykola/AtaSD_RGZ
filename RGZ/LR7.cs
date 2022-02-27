using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7
{
    public partial class LR7 : Form
    {
        class GFG
        {
            public int V;
            public int[,] Matrix;
            public GFG(int Count)
            {
                Matrix = new int[Count, Count];
                for (int i = 0; i < Count; i++)
                {
                    for (int j = 0; j < Count; j++) Matrix[i, j] = 0;
                }
                V = Count;
            }
            public void Edge_Add(int start, int end, int value)
            {
                Matrix[start, end] = value;
            }
            public string Show_Matrix()
            {
                string for_ret = "";
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++) for_ret += Matrix[i, j] + " ";
                    for_ret += Environment.NewLine;
                }

                return for_ret;
            }
            public bool BFS(int[,] rGraph, int s, int t, int[] parent)
            {
                bool[] visited = new bool[V];
                for (int i = 0; i < V; ++i)
                    visited[i] = false;

                // Create a queue, enqueue source vertex and mark
                List<int> queue = new List<int>();
                queue.Add(s);
                visited[s] = true;
                parent[s] = -1;

                while (queue.Count != 0)
                {
                    int u = queue[0];
                    queue.RemoveAt(0);

                    for (int v = 0; v < V; v++)
                    {
                        if (visited[v] == false && rGraph[u, v] > 0)
                        {
                            if (v == t)
                            {
                                parent[v] = u;
                                return true;
                            }
                            queue.Add(v);
                            parent[v] = u;
                            visited[v] = true;
                        }
                    }
                }

                return false;
            }
            //A little another BFS for minimal cut
            private static bool bfs(int[,] rGraph, int s, int t, int[] parent)
            {

                bool[] visited = new bool[rGraph.Length];

                Queue<int> q = new Queue<int>();
                q.Enqueue(s);
                visited[s] = true;
                parent[s] = -1;

                while (q.Count != 0)
                {
                    int v = q.Dequeue();
                    for (int i = 0; i < rGraph.GetLength(0); i++)
                    {
                        if (rGraph[v, i] > 0 && !visited[i])
                        {
                            q.Enqueue(i);
                            visited[i] = true;
                            parent[i] = v;
                        }
                    }
                }

                return (visited[t] == true);
            }

            public static void dfs(int[,] rGraph, int s, bool[] visited)
            {
                visited[s] = true;
                for (int i = 0; i < rGraph.GetLength(0); i++)
                {
                    if (rGraph[s, i] > 0 && !visited[i])
                    {
                        dfs(rGraph, i, visited);
                    }
                }
            }

            // Prints the minimum s-t cut
            public string minCut(int s, int t)
            {
                int u, v;
                string for_ret = "";
                int[,] rGraph = new int[V, V];
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j <V; j++)
                    {
                        rGraph[i, j] = Matrix[i, j];
                    }
                }

                int[] parent = new int[V];

                while (bfs(rGraph, s, t, parent))
                {

                    int pathFlow = int.MaxValue;
                    for (v = t; v != s; v = parent[v])
                    {
                        u = parent[v];
                        pathFlow = Math.Min(pathFlow, rGraph[u, v]);
                    }

                    for (v = t; v != s; v = parent[v])
                    {
                        u = parent[v];
                        rGraph[u, v] = rGraph[u, v] - pathFlow;
                        rGraph[v, u] = rGraph[v, u] + pathFlow;
                    }
                }

                // Flow is maximum now, find vertices reachable from s     
                bool[] isVisited = new bool[V];
                dfs(rGraph, s, isVisited);

                // Add to string array     
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                        if (Matrix[i, j] > 0 &&
                            isVisited[i] && !isVisited[j])
                        {
                            for_ret+=(i + " - " + j)+Environment.NewLine;
                        }
                    }

                }
                return for_ret;
            }
        
                // Returns tne maximum flow from s to t in the given graph
                public int fordFulkerson( int s, int t)
            {
                int u, v;

                int[,] rGraph = new int[V, V];

                for (u = 0; u < V; u++)
                    for (v = 0; v < V; v++)
                        rGraph[u, v] = Matrix[u, v];
                
                int[] parent = new int[V];

                int max_flow = 0; // There is no flow initially

                // Augment the flow while there is path from source to sink
                while (BFS(rGraph, s, t, parent))
                {
                    
                    int path_flow = int.MaxValue;
                    for (v = t; v != s; v = parent[v])
                    {
                        u = parent[v];
                        path_flow
                            = Math.Min(path_flow, rGraph[u, v]);
                    }

                    // update residual capacities of the edges and reverse edges along the path
                    for (v = t; v != s; v = parent[v])
                    {
                        u = parent[v];
                        rGraph[u, v] -= path_flow;
                        rGraph[v, u] += path_flow;
                    }

                    // Add path flow to overall flow
                    max_flow += path_flow;
                }

                // Return the overall flow
                return max_flow;
            }
        }
            public LR7()
        {
            InitializeComponent();
        }
        GFG graph;
        private void Graph_create_Click(object sender, EventArgs e)
        {
            graph = new GFG(Int32.Parse(count_v.Text));
        }

        private void Edge_add_Click(object sender, EventArgs e)
        {
            graph.Edge_Add(Int32.Parse(first_vertex.Text), Int32.Parse(second_vertex.Text), Int32.Parse(value_edge.Text));
        }

        private void showMatrix_Click(object sender, EventArgs e)
        {
            out_text.Text = graph.Show_Matrix();
        }

        private void Ford_btn_Click(object sender, EventArgs e)
        {
            out_text.Text = "The maximum possible flow is " + graph.fordFulkerson(Int32.Parse(Ford_1.Text), Int32.Parse(Ford_2.Text));
        }

        private void Graph_min_Click(object sender, EventArgs e)
        {
            out_text.Text = "Minmal cut: "+ Environment.NewLine + graph.minCut(Int32.Parse(Ford_1.Text), Int32.Parse(Ford_2.Text));
        }
    }
}
