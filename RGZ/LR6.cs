using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR6
{
    public partial class LR6 : Form
    {
        class GFG
        {
            readonly static int INF = 99999;
            public int V = 9;
            public int[,] graph;
            public int[,] graph_for_floid;
            public string[] Towns;
            public GFG(int a)
            {
                Towns = new string[a];
                V = a; //vertex count
                graph = new int[a, a];
                for(int i =0;i<a;i++)
                {
                    for(int j=0;j<a;j++)
                    {
                        graph[i, j] = 0;
                    }
                }
                graph_for_floid = new int[a, a];
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        graph_for_floid[i, j] = INF;
                    }
                }
                for (int i = 0; i < a; i++) graph_for_floid[i, i] = 0;
            }
            public void Edge_Add(int f, int s, int value,string g)
            {
                graph[f, s] = value;
                graph_for_floid[f, s] = value;
                if (g != null) Towns[s] = g;
            }
            
            public int minDistance(int[] dist,
                            bool[] sptSet)
            {
                // Initialize min value
                int min = int.MaxValue, min_index = -1;

                for (int v = 0; v < V; v++)
                    if (sptSet[v] == false && dist[v] <= min)
                    {
                        min = dist[v];
                        min_index = v;
                    }

                return min_index;
            }

            public string PrintSolution(int[] dist)
            {
                string for_ret = "";
                for_ret += ("Vertex     Distance "
                              + "from Source" + Environment.NewLine);
                for (int i = 0; i < V; i++)
                    for_ret += (i + " - " + dist[i] + Environment.NewLine);
                return for_ret;
            }

            public  string Dijkstra(int src)
            {
                int[] dist = new int[V]; // The output array. dist[i]


                bool[] sptSet = new bool[V];

                for (int i = 0; i < V; i++)
                {
                    dist[i] = int.MaxValue;
                    sptSet[i] = false;
                }

                dist[src] = 0;

                for (int count = 0; count < V - 1; count++)
                {

                    int u = minDistance(dist, sptSet);

                    sptSet[u] = true;


                    for (int v = 0; v < V; v++)


                        if (!sptSet[v] && graph[u, v] != 0 &&
                             dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                            dist[v] = dist[u] + graph[u, v];
                }

                return PrintSolution(dist);
            }

           public string FloydWarshall()
            {
                string for_ret = "";
                int[,] dist = new int[V, V];
                int i, j, k;


                for (i = 0; i < V; i++)
                {
                    for (j = 0; j < V; j++)
                    {
                        dist[i, j] = graph_for_floid[i, j];
                    }
                }


                for (k = 0; k < V; k++)
                {

                    for (i = 0; i < V; i++)
                    {

                        for (j = 0; j < V; j++)
                        {

                            if (dist[i, k] + dist[k, j] < dist[i, j])
                            {
                                dist[i, j] = dist[i, k] + dist[k, j];
                            }
                        }
                    }
                }

               for_ret= PrintMatrixSolution(dist);
                return for_ret;
            }
            public string PrintMatrixSolution(int[,] dist)
            {
                string for_ret = "Following matrix shows the shortest " +
                                "distances between every pair of vertices"+Environment.NewLine;
               
                for (int i = 0; i < V; ++i)
                {
                    for (int j = 0; j < V; ++j)
                    {
                        if (dist[i, j] == INF)
                        {
                            for_ret+="X ";
                        }
                        else
                        {
                            for_ret+=dist[i, j] + " ";
                        }
                    }
                    
                    for_ret += Environment.NewLine;
                }
                return for_ret;
            }

            public string Ford(int start)
            {
                string for_ret = "";
                int a = 0;
                for(int i=0;i<V;i++)
                {
                    for(int j=0;j<V;j++)
                    {
                        if (graph[i, j] != 0) a++;
                    }
                }

                int[,] matrix = new int[a, 3];
               
                int b = 0;
                    for (int j = 0; j < V; j++)
                    {
                        for(int h=0;h<V;h++)
                        {
                            if (graph[j, h] != 0)
                               {
                                matrix[b, 0] = j;
                                matrix[b, 1] = h;
                                matrix[b, 2] = graph[j, h];
                                b++;
                               }
                        }
                    }
                


                int[] dis = new int[V];
                for (int i = 0; i < V; i++)
                    dis[i] = int.MaxValue;
                
                dis[start] = 0;

                for (int i = 0; i < V - 1; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        if (dis[matrix[j, 0]] != int.MaxValue && dis[matrix[j, 0]] + matrix[j, 2] < dis[matrix[j, 1]])
                            dis[matrix[j, 1]] =  dis[matrix[j, 0]] + matrix[j, 2];
                    }
                }
                  for (int i = 0; i < a; i++)
                   {
                       int x = matrix[i, 0];
                       int y = matrix[i, 1];
                       int weight = matrix[i, 2];
                       if (dis[x] != int.MaxValue &&
                               dis[x] + weight < dis[y])
                           for_ret+= "Graph contains negative weight cycle";

                   }
                   for_ret+="Vertex Distance from Source"+Environment.NewLine;
                   for (int i = 0; i < V; i++)
                       for_ret+=(i + " | " + dis[i])+Environment.NewLine;
                return for_ret;
            }

            public string Work1()
            {
                string for_ret = "";

                int[] dist = new int[V]; // The output array. dist[i]


                bool[] sptSet = new bool[V];

                for (int i = 0; i < V; i++)
                {
                    dist[i] = int.MaxValue;
                    sptSet[i] = false;
                }

                dist[0] = 0;
                int end_vertex=0;
                int h = 0;
                for (int count = 0; count < V - 1; count++)
                {

                    int u = minDistance(dist, sptSet);

                    sptSet[u] = true;


                    for (int v = 0; v < V; v++)


                        if (!sptSet[v] && graph[u, v] != 0 &&
                             dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                            dist[v] = dist[u] + graph[u, v];
                }
                for(int i=0;i<V;i++)
                {
                    h = 0;
                    for(int j=0;j<V;j++)
                    {
                        if (graph[i, j] == 0) h++;
                        if (h == V) end_vertex = i;
                    }
                   
                }
                int end = 0;

                for(int i=0;i<V;i++)
                {
                    if (graph[i, end_vertex] != 0) end += dist[i] + graph[i, end_vertex];
                }
                for_ret ="Minimal time = "+ end.ToString();
                return for_ret;
            }
            public string Work3(int a , int b)
            {
                string for_ret = "";
                int[,] dist = new int[V, V];
                int i, j, k;


                for (i = 0; i < V; i++)
                {
                    for (j = 0; j < V; j++)
                    {
                        dist[i, j] = graph_for_floid[i, j];
                    }
                }


                for (k = 0; k < V; k++)
                {

                    for (i = 0; i < V; i++)
                    {

                        for (j = 0; j < V; j++)
                        {

                            if (dist[i, k] + dist[k, j] < dist[i, j])
                            {
                                dist[i, j] = dist[i, k] + dist[k, j];
                            }
                        }
                    }
                }
                for (i = 0; i < V; i++)
                {
                    if (dist[i, b] >= dist[a, b]&&a!=i) graph_for_floid[a, i] = INF;
                }
                dist = new int[V, V];
                for (i = 0; i < V; i++)
                {
                    for (j = 0; j < V; j++)
                    {
                        dist[i, j] = graph_for_floid[i, j];
                    }
                }


                for (k = 0; k < V; k++)
                {

                    for (i = 0; i < V; i++)
                    {

                        for (j = 0; j < V; j++)
                        {

                            if (dist[i, k] + dist[k, j] < dist[i, j])
                            {
                                dist[i, j] = dist[i, k] + dist[k, j];
                            }
                        }
                    }
                }
                for_ret = dist[a, b].ToString() + Environment.NewLine;
                int s = dist[a, b];
                for_ret += "For finish we must visit next towns:" + Environment.NewLine;
                for_ret += "Start-" + Towns[a] + Environment.NewLine;
               
                for (i=1;i<s;i++)
                {
                    for(j=0;j<V;j++)
                    {
                       if (dist[a, j] == i) for_ret +="Next "+ Towns[j] + Environment.NewLine;
                  }
              }
                for_ret += Environment.NewLine +"End "+Towns[b];
                return for_ret;
            }
            public string Work2()
            {
                string for_ret = "";
                int[,] dist = new int[V, V];
                int i, j, k;


                for (i = 0; i < V; i++)
                {
                    for (j = 0; j < V; j++)
                    {
                        dist[i, j] = graph_for_floid[i, j];
                    }
                }


                for (k = 0; k < V; k++)
                {

                    for (i = 0; i < V; i++)
                    {

                        for (j = 0; j < V; j++)
                        {

                            if (dist[i, k] + dist[k, j] < dist[i, j])
                            {
                                dist[i, j] = dist[i, k] + dist[k, j];
                            }
                        }
                    }
                }
                int a = 0;
                int b = 0;
                for(i=0;i<Towns.Length;i++)
                {
                    if (Towns[i] == "Kyiv") a = i;
                    if (Towns[i] == "Stockholm") b = i;
                }
                for (i = 0; i < V; i++)
                {
                    if (dist[i, b] >= dist[a, b] && a != i) graph_for_floid[a, i] = INF;
                }
                dist = new int[V, V];
                for (i = 0; i < V; i++)
                {
                    for (j = 0; j < V; j++)
                    {
                        dist[i, j] = graph_for_floid[i, j];
                    }
                }


                for (k = 0; k < V; k++)
                {

                    for (i = 0; i < V; i++)
                    {

                        for (j = 0; j < V; j++)
                        {

                            if (dist[i, k] + dist[k, j] < dist[i, j])
                            {
                                dist[i, j] = dist[i, k] + dist[k, j];
                            }
                        }
                    }
                }
                for_ret = dist[a, b].ToString() + Environment.NewLine;
                int s = dist[a, b];
                for_ret += "For finish we must visit next towns:" + Environment.NewLine;
                for_ret += "Start-" + Towns[a] + Environment.NewLine;
                for (i = 1; i < s; i++)
                {
                    for (j = 0; j < V; j++)
                    {
                        if (dist[a, j] == i) for_ret += "Next " + Towns[j] + Environment.NewLine;
                    }
                }
                for_ret += Environment.NewLine + "End " + Towns[b];
                return for_ret;
            }

        }





        public LR6()
        {
            InitializeComponent();
        }
        GFG t = new GFG(0);
        private void DIJ_Click(object sender, EventArgs e)
            {
               
             if(Int32.Parse(In_vertex.Text)>=0) textBox1.Text =  t.Dijkstra(Int32.Parse(In_vertex.Text));
            }

        private void g_create_Click(object sender, EventArgs e)
        {
            t = new GFG(Int32.Parse(vertex_count.Text));

        }

        private void Adder_Click(object sender, EventArgs e)
        {
           if(checkBox1.Checked==false) t.Edge_Add(Int32.Parse(f_e.Text), Int32.Parse(s_e.Text), Int32.Parse(value_e.Text),null);
            if (checkBox1.Checked == true) t.Edge_Add(Int32.Parse(f_e.Text), Int32.Parse(s_e.Text), Int32.Parse(value_e.Text), Town.Text);
        }

        private void F_USH_Click(object sender, EventArgs e)
        {
            textBox1.Text = t.FloydWarshall();
        }

        private void Ford_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(start_ford.Text);
           textBox1.Text= t.Ford(a);
        }

        private void First_quest_Click(object sender, EventArgs e)
        {
            textBox1.Text=t.Work1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = t.Work3(Int32.Parse(Ex2_1.Text),Int32.Parse(Ex2_2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = t.Work2();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            for (int i = 0; i < t.Towns.Length; i++) textBox1.Text += i + " - " + t.Towns[i] + Environment.NewLine;
        }
    }
}