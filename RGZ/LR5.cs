using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR5
{

    public partial class LR5 : Form
    {
        public class MyQueue
        {
            private int[] _array;
            private int _head;
            private int _tail;

            public MyQueue()
            {
                _array = new int[4];
            }

            public int Count { get; private set; }

            public void Clear()
            {
            
                _array = new int[4];
                _head = 0;
                _tail = 0;
                Count = 0;
            }

            public int Dequeue()
            {
                if (Count == 0)
                    throw new InvalidOperationException();
                int local = _array[_head];
                _array[_head] = 0;
                // Змінюємо індекс початку елементів у масиві.
                _head = (_head + 1) % _array.Length;
                Count--;
                return local;
            }


            public void Enqueue(int item)
            {
                if (Count == _array.Length)
                {
                    var capacity = _array.Length * 2;
                    SetCapacity(capacity);
                }
                _array[_tail] = item;
                _tail = (_tail + 1) % _array.Length;
                Count++;
            }

            public int Peek()
            {
                if (Count == 0)
                    throw new InvalidOperationException();
                return _array[_head];
            }
            private void SetCapacity(int capacity)
            {
                int[] destinationArray = new int[capacity];
                if (Count > 0)
                {
                    if (_head < _tail)
                        Array.Copy(_array, _head, destinationArray, 0, Count);
                    else
                    {
                        Array.Copy(_array, _head, destinationArray, 0, _array.Length - _head);
                        Array.Copy(_array, 0, destinationArray, _array.Length - _head, _tail);
                    }
                }
                _array = destinationArray;
                _head = 0;
                if (Count == capacity)
                    _tail = 0;
                else
                    _tail = Count;
            }
        }

        public class FixedStack<T>
        {
            private T[] items; // елементи стека
            private int count;  // кілкість
            const int n = 10;   // кількість за замовчуванням
            public FixedStack()
            {
                items = new T[n];
            }
            public FixedStack(int length)
            {
                items = new T[length];
            }
            public bool IsEmpty
            {
                get { return count == 0; }
            }
            public int Count
            {
                get { return count; }
            }
            public void Push(T item)
            {
                if (count == items.Length)
                    throw new InvalidOperationException("Переполнение стека");
                items[count++] = item;
            }
            public T Pop()
            {
                if (IsEmpty)
                    throw new InvalidOperationException("Стек пуст");
                T item = items[--count];
                items[count] = default(T); 
                return item;
            }
            public T Peek()
            {
                if (IsEmpty)
                    throw new InvalidOperationException("Стек пуст");
                return items[count - 1];
            }
        }
        public class Graph
        {
            public int initial = 1;
            public int visited = 2;
            public int finished = 3;
            public int time = 0;

            public int[] d;
            public int[] f;
            public int[] state;
            public int V; // Number of Vertices
            public LinkedList<int>[] adj; // adjacency lists
            public int[,] matrix;

            public Graph(int V)
            {

                d = new int[V];
                f = new int[V];
                state = new int[V];



                this.V = V;
                adj = new LinkedList<int>[V];
                for (int i = 0; i < adj.Length; i++)
                    adj[i] = new LinkedList<int>();
                matrix = new int[V, V];
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            public void addEdge(int v, int w)
            {
                adj[v].AddLast(w); // Add w to v’s list.
                matrix[v, w] = 1;
            }
            public string DFS(int s)
            {
                Boolean[] visited = new Boolean[V];
                FixedStack<int> stack = new FixedStack<int>();
                stack.Push(s);
                string for_ret = "";
                while (stack.Count > 0)
                {
                    s = stack.Peek();
                    stack.Pop();
                    if (visited[s] == false)
                    {
                        for_ret += (s + " ");
                        visited[s] = true;
                    }
                    foreach (int v in adj[s])
                    {
                        if (!visited[v])
                            stack.Push(v);
                    }
                }
                return for_ret;
            }
            public string BFS(int s)
            {
                string for_ret = "";
                bool[] visited = new bool[V];
                for (int i = 0; i < V; i++)
                    visited[i] = false;

                MyQueue queue = new MyQueue();

                visited[s] = true;
                queue.Enqueue(s);

                while (queue.Count > 0)
                {

                    s = queue.Peek();
                    for_ret += s + " ";
                    queue.Dequeue();

                    LinkedList<int> list = adj[s];

                    foreach (var val in list)
                    {
                        if (!visited[val])
                        {
                            visited[val] = true;
                            queue.Enqueue(val);
                        }
                    }
                }
                return for_ret;
            }

            public string short_path(int start, int end)
            {
                string pather = "";
                int[] edgeTo = new int[V];
                int[] distTo = new int[V];
                int s;
                for (int i = 0; i < V; i++)
                {
                    distTo[i] = -1;
                    edgeTo[i] = -1;
                }

                s = start;
                var queue = new Queue<int>();
                queue.Enqueue(s);
                distTo[s] = 0;
                pather += end.ToString() + " <- ";
                while (queue.Count != 0)
                {
                    int v = queue.Dequeue();

                    foreach (var w in adj[v])
                    {
                        if (distTo[w] == -1)
                        {
                            queue.Enqueue(w);
                            distTo[w] = distTo[v] + 1;
                            edgeTo[w] = v;
                        }
                    }
                }

                int a = distTo[end];
                int b = end;
                while (b != start)
                {

                    if (edgeTo[b] != start) pather += edgeTo[b] + " <- ";
                    else pather += edgeTo[b];
                    b = edgeTo[b];
                }
                pather += Environment.NewLine + "Distance - " + distTo[end];
                pather += Environment.NewLine;
                return pather;
            }


            public string Type_Edges(int Vertex)
            {
                string for_ret = "";


                int iter;
                time++;
                d[Vertex] = time;
                state[Vertex] = visited;

                for (iter = 0; iter < V; iter++)
                {
                    if (matrix[Vertex, iter] == 1)
                    {
                        if (state[iter] == 1)
                        {
                            for_ret += Vertex + " " + iter + " - Tree edge" + Environment.NewLine;

                        }
                        else if (state[iter] == 2)
                        {
                            for_ret += Vertex + " " + iter + " - Back edge" + Environment.NewLine;
                            
                        }
                        else if (d[Vertex] < d[iter])
                        {
                            for_ret += Vertex + " " + iter + " - Forward edge" + Environment.NewLine;
                         
                        }
                        else
                        {
                            for_ret += Vertex + " " + iter + " - Cross edge" + Environment.NewLine;
                        }

                    }
                }
                state[Vertex] = finished;
                f[Vertex] = ++time;

                return for_ret;
            }

            public bool isCycle()
            {
                
                int[] in_degree = new int[V];
                
                for (int u = 0; u < V; u++)
                {
                    foreach (int v in adj[u])
                        in_degree[v]++;
                }
                
                MyQueue q = new MyQueue();
                for (int i = 0; i < V; i++)
                    if (in_degree[i] == 0)
                        q.Enqueue(i);

                int cnt = 0;

                
                List<int> top_order = new List<int>();
                
                while (q.Count != 0)
                {

               
                    int u = q.Peek();
                    q.Dequeue();
                    top_order.Add(u);

                    foreach (int itr in adj[u])
                        if (--in_degree[itr] == 0)
                            q.Enqueue(itr);

                    cnt++;
                }

                if (cnt != V)
                    return true;
                else
                    return false;
            }
        
            public string Third_Task()
            {
                int h = 0;
                string for_ret="";
                for_ret += "List of requirements" + Environment.NewLine;
                for(int i =0;i<V;i++)
                {
                    h = 0;
                    for_ret += i.ToString() ;
                    for(int j = 0;j<V;j++)
                    {
                        if (matrix[i, j] == 1)
                        {
                           if(h==0) for_ret += " before "+ j.ToString();
                           else for_ret += " and " + j.ToString();
                            h++;
                        }
                        if (j == (V - 1) && h == 0) for_ret += " final";
                    }
                    for_ret += Environment.NewLine;
                }



                return for_ret;
            }






    }
        public LR5()
        {
            InitializeComponent();
        }
        Graph g;
        private void button1_Click(object sender, EventArgs e)
        {
            g = new Graph(Int32.Parse(in_1.Text));
        }

      
        private void btn_add_edge_Click(object sender, EventArgs e)
        {
        if(Yes_Or.Checked==true)    g.addEdge(Int32.Parse(edge_1.Text), Int32.Parse(edge_2.Text));
        if(No_or.Checked==true)
            {
                g.addEdge(Int32.Parse(edge_1.Text), Int32.Parse(edge_2.Text));
                g.addEdge(Int32.Parse(edge_2.Text), Int32.Parse(edge_1.Text));
            }
        }

        private void btn_DFS_Click(object sender, EventArgs e)
        {
            out_1.Text = g.DFS(0);
        }

        private void btn_BFS_Click(object sender, EventArgs e)
        {
            out_1.Text = g.BFS(0);

        }

        private void btn_path_Click(object sender, EventArgs e)
        {
             out_1.Text = g.short_path(Int32.Parse(edge_1.Text), Int32.Parse(edge_2.Text));
        }

        private void btn_edges_Click(object sender, EventArgs e)
        {
              out_1.Text = "";
            for (int i = 0; i < g.V; i++)
            {
                g.d[i] = 0;
                g.f[i] = 0;
                g.state[i] = 1;
            }
            out_1.Text += g.Type_Edges(0);

    
            for (int i = 0; i < g.V; i++)
            {
                if (g.state[i] == 1)
                    out_1.Text+=g.Type_Edges(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (g.isCycle() == true) out_1.Text = "Cycle found";
            else out_1.Text = "Cycle not found";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            out_1.Text = g.Third_Task();
        }
    }
}
