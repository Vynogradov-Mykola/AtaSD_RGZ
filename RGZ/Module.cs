using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LR1
{
    class DL_NODE           //ELEMENT FOR KUCHA AND SPISOK
    {
        public DL_NODE(string pidrozdil, string contact, string direktor, int kolvo, int ser)
        {
            Pidrozdil = pidrozdil;
            Direktor = direktor;
            Contact = contact;
            Ser_zp = ser;
            Kolvo = kolvo;

        }
        public DL_NODE(string pidrozdil, string contact, string direktor, int kolvo, int ser, DL_NODE next)
        {
            Pidrozdil = pidrozdil;
            Direktor = direktor;
            Contact = contact;
            Ser_zp = ser;
            Kolvo = kolvo;
            Next = next;
        }

        public string Pidrozdil;
        public string Direktor;
        public string Contact;
        public int Ser_zp;
        public int Kolvo;
        public int INDEX;
        public DL_NODE Next { get; set; }
        public DL_NODE Previous { get; set; }
    }
    class PyramidSorting    //Pyramidalne sortuvanya
    {
        static int add2pyramid(DL_NODE[] arr, int i, int N) //metod for add element to pyramid
        {
            int imax;
            DL_NODE buf;
            if ((2 * i + 2) < N)    //N-length
            {
                if (arr[2 * i + 1].Ser_zp < arr[2 * i + 2].Ser_zp) imax = 2 * i + 2;
                else imax = 2 * i + 1;
                if (arr[2*i+1].Ser_zp==arr[2*i+2].Ser_zp)
                {
                    if (arr[2 * i + 1].Kolvo < arr[2 * i + 2].Kolvo) imax = 2 * i + 2;
                }
                
            }
            else imax = 2 * i + 1;
            if (imax >= N) return i;
            if (arr[i].Ser_zp < arr[imax].Ser_zp)
            {
                buf = arr[i];
                arr[i] = arr[imax];
                arr[imax] = buf;
                if (imax < N / 2) i = imax;
            }
            if (arr[i].Ser_zp == arr[imax].Ser_zp) 
            {
                if (arr[2 * i + 1].Ser_zp == arr[2 * i + 2].Ser_zp)
                { 
                buf = arr[i];
                arr[i] = arr[imax];
                arr[imax] = buf;
                if (imax < N / 2) i = imax;
                }
            }
           

            return i;
        }
        public static DL_NODE[] sorting(DL_NODE[] arr, int len) //create and sorting Pyramid
        {
            for (int i = 0; i < arr.Length; i++) arr[i].Ser_zp = arr[i].Ser_zp / arr[i].Kolvo;
            for (int i = len / 2 - 1; i >= 0; --i)
            {
                long prev_i = i;
                i = add2pyramid(arr, i, len);
                if (prev_i != i) ++i;
            }

            
            DL_NODE buf;
            for (int k = len - 1; k > 0; --k)
            {
                buf = arr[0];
                arr[0] = arr[k];
                arr[k] = buf;
                int i = 0, prev_i = -1;
                while (i != prev_i)
                {
                    prev_i = i;
                    i = add2pyramid(arr, i, k);
                }
            }
            int iter = 0;
          
            while (iter < arr.Length)    //if Ser_zp ravno, perevaga kolvo rabotnikov
            {
                for (int a = 0; a < arr.Length; a++)
                {
                    
                    if (a + 1 < arr.Length) if (arr[a].Ser_zp == arr[a + 1].Ser_zp)
                        {
                            if (arr[a].Kolvo > arr[a + 1].Kolvo)
                            {
                                DL_NODE temp = arr[a+1];
                                arr[a+1] = arr[a];
                                arr[a] = temp;
                            }
                        }
                }
                iter++;
            }
            return arr;
        }
    }




    
}

