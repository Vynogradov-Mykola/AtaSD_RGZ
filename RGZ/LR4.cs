using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4
{
    public partial class LR4 : Form
    {
        public LR4()
        {
            InitializeComponent();
        }
        class Best_polindrom
        {
        public static string poli(string input)
        {
            string[,] bests;   //array for polindroms

            string output = ""; //string for show
            char[] stroka1 = input.ToCharArray(), stroka2 = input.ToCharArray();    //input text to char array
            int i, j;


            int input_length = stroka1.Length + 1;       // length ryada

            Array.Reverse(stroka2); //reverse array
                bests = new string[input_length, input_length];
            for (int itterator = 0; itterator < input_length; itterator++)
            {
                for (int itterator2 = 0; itterator2 < input_length; itterator2++) bests[itterator, itterator2] = "";
            }
            for (i = 1; i < input_length; i++)
            {
                for (j = 1; j < input_length; j++)
                {
                    if (stroka1[i - 1] == stroka2[j - 1]) bests[i, j] = bests[i - 1, j - 1] + stroka2[j - 1].ToString();
                    else
                    {
                        int z = 0;
                        z = bests[i - 1, j].Length;
                        int x = 0;
                        x = bests[i, j - 1].Length;
                        if (z > x) bests[i, j] = bests[i - 1, j];
                        else bests[i, j] = bests[i, j - 1];
                    }

                }
            }
            output = bests[input_length - 1, input_length - 1] + " With length: " + bests[input_length - 1, input_length - 1].Length; //output text
            return output;
        }
        }
        class zadacha
        {
            public int N;  //кількість заявок
            public int[,] begins;   
            public int price; //ціна за годину аренди
            public zadacha(int count,int pr)    //конструктор
            {
                begins = new int[count,2];
                N = count;
                price = pr;
            }
            public string Best(List<int> b, List<int> e)    //повертає рядок з інформацію про максимальний прибуток
            {
               
                int[] indx = new int[N];
                int[] ends = new int[N];
                for (int i = 0; i < N; i++)
                {
                    begins[i, 0] = b[i];
                    begins[i, 1] = i+1;
                    ends[i] = e[i];
                }
                for(int i=0;i<N;i++)
                {
                    indx[i] = i;
                }
                int[] end_for_price = new int[N];
                end_for_price = ends;
                Array.Sort(ends, indx);
                string z = "";
                int last = 0;
                int value = 0;
                for(int i=0;i<N;i++)
                {
                    if(begins[indx[i],0]>=last)
                    {
                        z += begins[indx[i], 1] + " ";
                        value += (end_for_price[indx[i]]- begins[indx[i],0])*price;
                        last = ends[i];
                    }
                }
                string h = "Для максимального прибутку:"+z+" З прибутком у: "+ value;
                    return h;
            }
        }
        private void pol_make_Click(object sender, EventArgs e)
        {
            string output = Best_polindrom.poli(in_text.Text);
            out_text.Text = output;
        }
        List<int> start = new List<int>();
        List<int> end = new List<int>();
        private void Add_button_Click(object sender, EventArgs e)
        {          
            start.Add(Int32.Parse(start_.Text));
            end.Add(Int32.Parse(end_.Text));         
        }

        private void Show_b_Click(object sender, EventArgs e)
        {
            outtext.Text = "";
            for(int i=0;i<start.Count;i++)
            {
                outtext.Text += (i+1) + " begin in " + start[i] + " and end in " + end[i]+Environment.NewLine;
  
            }
        }

        private void Show_best_b_Click(object sender, EventArgs e)
        {
            outtext.Text = "";
            zadacha test = new zadacha(start.Count,Int32.Parse(pricer.Text));
            outtext.Text = test.Best(start, end);
        }

        private void Rem_but_Click(object sender, EventArgs e)
        {
            start.RemoveAt(Int32.Parse(indexer.Text)-1);
            end.RemoveAt(Int32.Parse(indexer.Text)-1);
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            start[Int32.Parse(indexer.Text)-1]= Int32.Parse(start_.Text);
            end[Int32.Parse(indexer.Text)-1]= Int32.Parse(end_.Text);
        }
    }
}
