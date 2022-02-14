using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace LR1
{
    


public partial class LR1 : Form
    {
     
    
        internal class DoubleLinkedList
        {
                private DL_NODE _head;
                private DL_NODE _tail;
                // счетчик списка
                public int Count { get; set; }
               
                private bool IsEmpty
                {
                    get
                    {
                        {
                            return _head == null;
                        }
                    }
                } 
                public void AddFirst(string pidrozdil, string contact, string direktor, int kolvo, int ser)
                {
                    DL_NODE node = new DL_NODE(pidrozdil,contact,direktor,kolvo,ser);   
                    DL_NODE temp = _head;
                    _head = node; // new start of DL
                    _head.Next = node; 
                    _head.Next = temp; 
                    if (Count == 0)
                    {
                        _tail = _head;
                    }
                    else
                    {
                        temp.Previous = _head;
                    }
                    Count++;
                }
            public DL_NODE FindIdByElement(int value) // find by index
            {
                DL_NODE current = _head;
                for (int i = 0; i < Count; i++)
                {
                    current.INDEX = i;
                    current = current.Next;
                }
                current = _head;
                    for (int i = 0; i < Count; i++)
                    {
                        if (current.INDEX.Equals(value)) return current;
                        current = current.Next;
                    }
                    // нету в списке
                    return current;
                }
            public void Add(string pidrozdil, string contact, string direktor, int kolvo, int ser)
            {
                DL_NODE node = new DL_NODE(pidrozdil,contact, direktor,kolvo, ser);//new node with information

                if (_head == null)
                    _head = node;
                else
                {
                    _tail.Next = node;
                    node.Previous = _tail;
                }
                _tail = node;
                Count++;
            }
            public void AddInside(string pidrozdil, string contact, string direktor, int kolvo, int ser, int index) // вставка в середину
            {
                if (index > Count || index < 0)
                    throw new ArgumentOutOfRangeException();
                if (index == 0)
                    AddFirst(pidrozdil, contact, direktor, kolvo, ser);
                else if (index == (Count - 1))
                    Add(pidrozdil, contact, direktor, kolvo, ser);
                else
                {
                    DL_NODE currentNode = _head;
                    for (int i = 0; i < index - 1; i++)
                    {
                        currentNode = currentNode.Next;
                    }
                    DL_NODE node = new DL_NODE(pidrozdil, contact, direktor, kolvo, ser, currentNode.Next);
                    currentNode.Next = node;
                    Count++;
                }
            }
            public string[] INF_OUT(int or)
            {
                string[] information=new string[Count];
                if (or == 1)
                {
                    DL_NODE current = _head;
                    for (int i = 0; i < Count; i++)
                    {
                        information[i] = current.Pidrozdil +" "+ current.Contact +" "+ current.Direktor +" "+ current.Ser_zp.ToString() +" "+ current.Kolvo.ToString()+"\n" ;
                        Console.WriteLine(information[i]);
                        current = current.Next;
                    }
                    return information;
                }
                else
                {
                    DL_NODE current = _head;
                    for (int i = 0; i < Count; i++)
                    {
                        information[i] = current.Pidrozdil + " " + current.Contact + " " + current.Direktor + " " + current.Ser_zp.ToString() + " " + current.Kolvo.ToString() + "\n";
                        Console.WriteLine(information[i]);

                        current = current.Next;
                    }
                    string[] Backinformation = new string[Count];
                    for (int i = 0, j = Count-1; i < Count; i++,j--)
                    {
                        Backinformation[i] = information[j];
                        Console.WriteLine(Backinformation[i]);

                    }
                    return Backinformation;
                }
            }
            public void RemoveFirst()
            {
                int removedData = _head.INDEX;  //index of removed node
                if (Count != 0)
                {
                    _head = _head.Next;
                    if (Count == 0)
                    {
                        _tail = null;
                    }
                    else
                    {
                        _head.Previous = null;
                    }
                }
                Count--;
            }
            public void RemoveLast()
            {
                int removedData = _tail.INDEX;  //index of removed node
                switch (Count)
                {
                   
                    case 1:
                        _head = _tail = null;
                        break;
                    default:
                        _tail.Previous.Next = null;
                        _tail = _tail.Previous;
                        break;
                }
                Count--;
            }
            public void RemoveAt(int index)
            {
                DL_NODE current = _head;
                for (int i = 0; i < Count; i++) current.INDEX = i;  //set index
                if (index > Count || index < 0)
                    throw new ArgumentOutOfRangeException();    //check for error
          
                if (index == 0)
                RemoveFirst();
                else if (index == (Count - 1))
                    RemoveLast();
                else
                {
                    current = _head;
                    for (int i = 0; i < index - 1; i++)
                    {
                        current = current.Next;
                    }
                    current.Next = current.Next.Next;
                    Count--;
                }
            }
            public void Sort()  //sor DL
            {
                int s = Count;
                DL_NODE current = _head;
                DL_NODE[] SortArray = new DL_NODE[Count];

                    for (int i = 0; i < Count; i++)
                    {
                    SortArray[i] = current;
                    current = current.Next;
                    }
                SortArray=PyramidSorting.sorting(SortArray, Count);

                
                for (int i = 0; i < Count; i++)
                {
                    RemoveFirst();
                    
                }
               
                Count = 0;
                for (int i = 0; i < s; i++) AddFirst(SortArray[i].Pidrozdil, SortArray[i].Contact, SortArray[i].Direktor, SortArray[i].Kolvo, SortArray[i].Ser_zp);
            }
        }

    
        class QueueP
        {

            public DL_NODE[] A; // array of element 
            public int[] P; // array of prioritets
            public int count; // kolvo elementov
            
           public QueueP() { count = 0; }

          public  void Clear()      //clear queue
            {
                if (count > 0)
                {
                  
                    Array.Clear(A,0,count);
                    Array.Clear(P, 0, count);
                    count = 0;
                  }
            }
            
            int Count()
            {
                return count;
            }

            public void Push(string pidrozdil, string contact, string direktor, int kolvo, int ser, int priority)
            {
                DL_NODE[] A2;   
                int[] P2;   //array with prioritets


                A2 = new DL_NODE[count + 1];
                P2 = new int[count + 1];
                int pos;

                if (count == 0)
                    pos = 0;
                else
                {
                    pos = 0;
                    while (pos < count)
                    {
                        if (P[pos] < priority) break;
                        pos++;
                    }
                }

                for (int i = 0; i < pos; i++)
                {
                    A2[i] = A[i];
                    P2[i] = P[i];
                }
                A2[pos]= new DL_NODE(pidrozdil,contact,direktor,kolvo,ser);
             
                P2[pos] = priority;

                for (int i = pos + 1; i < count + 1; i++)
                {
                    A2[i] = A[i - 1];
                    P2[i] = P[i - 1];
                }
                if (count > 0)
                {

                    Array.Clear(A, 0, count);
                    Array.Clear(P, 0, count);
                }
        
                A = A2;
                P = P2;

                count++;
            }

            public DL_NODE Pop()    //go out of queue
            {

                DL_NODE[] A2;
                int[] P2;
                A2 = new DL_NODE[count - 1]; // на 1 элемент меньше
                P2 = new int[count - 1];
                DL_NODE item;
                item = A[0];

                for (int i = 0; i < count - 1; i++)
                {
                    A2[i] = A[i + 1];
                    P2[i] = P[i + 1];
                }

                count--;
                A = A2;
                P = P2;
                return item;
            }

            public string[] Show(int a)     //return sring array with information
            {
                string[] for_return;
                for_return = new string[count];
             if(a==0)   for (int i = 0; i < count; i++) for_return[i] = A[i].Pidrozdil + " " + A[i].Contact + " " + A[i].Direktor + " " + A[i].Kolvo + " " + A[i].Ser_zp;
                else for (int i = 0; i < count; i++) for_return[i] = A[i].Pidrozdil + " " + A[i].Contact + " " + A[i].Direktor + " " + A[i].Kolvo + " " + A[i].Ser_zp + " with Prority " + P[i];

                for (int i=0;i<count; i++) Console.WriteLine(for_return[i]);
                return for_return;
            }
            public string[] SortMMM()   //metod for call pyramid sorting
            {
                string[] for_return;
                for_return = new string[count];
                int[] Prior = P;
                A=PyramidSorting.sorting(A,A.Length);
              
                for (int i = 0; i < count; i++) for_return[i] = A[i].Pidrozdil + " " + A[i].Contact + " " + A[i].Direktor + " " + A[i].Kolvo + " " + A[i].Ser_zp;//+ " with Prority " + P[i];
                for (int i = 0; i < count; i++) Console.WriteLine(for_return[i]);

                return for_return;
            }
            public void build(DL_NODE[] buf,int a)  //create queue from array
            {
                Clear();
                for(int i=0;i<a; i++)
                {
                    Push(buf[i].Pidrozdil,buf[i].Contact,buf[i].Direktor,buf[i].Kolvo,buf[i].Ser_zp,i*2);
                }


            }
        }


public LR1()
        {
            InitializeComponent();
        }
        DoubleLinkedList Lis = new DoubleLinkedList();  //create DL
        QueueP KUCHA=new QueueP();                      //create KUCHA
        string[] lines = File.ReadAllLines(@"LR_INF.txt");  //information from file
        private void button2_Click(object sender, EventArgs e)  //find by index from DL
        {
            listView1.Items.Clear();
            int id = Int32.Parse(textBox1.Text);
            DL_NODE TEMP = Lis.FindIdByElement(id);
            string forout = TEMP.Pidrozdil + " " + TEMP.Contact + " " + TEMP.Direktor + " " + TEMP.Kolvo + " " + TEMP.Ser_zp;
            listView1.Items.Add(forout);
        }

        private void button3_Click(object sender, EventArgs e)//show DL information
        {
            listView1.Items.Clear();
            string[] infa = Lis.INF_OUT(1);  //array of DL information
            for(int i = 0;i<Lis.Count; i++)
            {
              
                listView1.Items.Add(infa[i]);
            }
        }

       

        private void SHOW_BACK_Click(object sender, EventArgs e)    //show DL information
        {
            listView1.Items.Clear();
            string[] infa = Lis.INF_OUT(2);  //array of DL information
            for (int i = 0; i < Lis.Count; i++)
            {

                listView1.Items.Add(infa[i]);
            }
        }

        private void REMOVE_Click(object sender, EventArgs e)   //DL.remove by index
        {
            int id = Int16.Parse(textBox1.Text);
            Lis.RemoveAt(id);
        }

        private void F_REM_Click(object sender, EventArgs e)    //DL.remove first 
        {
            Lis.RemoveFirst();
        }

        private void L_REM_Click(object sender, EventArgs e)    //DL.remove last
        {
            Lis.RemoveLast();
        }

        private void K_ADD_Click(object sender, EventArgs e)    //Queue create
        {
          
            listView1.Items.Clear();
            string[] show;
            show = new string[KUCHA.count];
            show=KUCHA.Show(1);
            for (int i = KUCHA.count-1; i >= 0; i--)
            {
                listView1.Items.Add(show[i]);
            }
        }

        private void LOAD_BUTTON_Click(object sender, EventArgs e)  //Load information from file
        {
            KUCHA.count = 0;
            Lis.Count = 0;
            int g = lines.Length;
            int j = 0;
           while(j<g)
            {
                int a, b,d;
                a = Int16.Parse(lines[j + 3]);
                b = Int16.Parse(lines[j + 4]);
               
                Lis.Add(lines[j], lines[j + 1], lines[j + 2], a, b);
                j=j + 6;
            }
            j = 0;
            while (j < g)
            {
                int a, b, d;
                a = Int16.Parse(lines[j + 3]);
                b = Int16.Parse(lines[j + 4]);
                d = Int16.Parse(lines[j + 5]);
                KUCHA.Push(lines[j], lines[j + 1], lines[j + 2], a, b,d);
                j = j + 6;
            }
        }

        private void SORT_Click(object sender, EventArgs e) //DL.Pyramid Sorting
        {
            Lis.Sort();
        }

        private void KUCHA_SORT_Click(object sender, EventArgs e)   //Queue. Pyramid Sorting
        {
            KUCHA.SortMMM();    //call sotring metod



            //////////show information////////
            listView1.Items.Clear();
            string[] show;
            show = new string[KUCHA.count];
            show = KUCHA.Show(0);
            for (int i = KUCHA.count - 1; i >= 0; i--)
            {
                listView1.Items.Add(show[i]);
            }
            //////////show information////////

        }

        private void ADD_FIRST_Click(object sender, EventArgs e)    //DL.Add in start
        {
            Lis.AddFirst(textBox2.Text, textBox3.Text, textBox4.Text, Int16.Parse(textBox6.Text), Int16.Parse(textBox5.Text));
        }

        private void INSIDE_Click(object sender, EventArgs e)   //DL.Add inside
        {
            Lis.AddInside(textBox2.Text, textBox3.Text, textBox4.Text, Int16.Parse(textBox6.Text), Int16.Parse(textBox5.Text), Int16.Parse(textBox1.Text));
        }

        private void BUILDER_Click(object sender, EventArgs e)  //Queue.build from array
        {
            DL_NODE[] temp = new DL_NODE[KUCHA.count];
            for (int i = 0; i < KUCHA.count; i++) temp[i] = new DL_NODE("a","b", "c" , i , i+3);
            KUCHA.build(temp,temp.Length);
            //////////show information////////

            listView1.Items.Clear();
            string[] show;
            show = new string[temp.Length];
            show = KUCHA.Show(0);
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                listView1.Items.Add(show[i]);
            }
            //////////show information////////

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KUCHA.Pop();
        }
    }
}
