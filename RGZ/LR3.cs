using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LR3
{
    public partial class LR3 : Form
    {   
        class HuffmanTree
        {
            public static HuffmanTree Root;
            public HuffmanTree LeftBranch;
            public HuffmanTree RightBranch;
            private HuffmanTree _parent;
            public byte Value;
            private int _weight;
            private static HuffmanTree[] _nodes;
            readonly static int[] _byteMap = new int[256];
            // побудова
            public static void CreateHuffmanTree(int[] byteMap)
            {
                var nodes = new List<HuffmanTree>(256);
                for (int i = 0; i < 256; i++)
                    if (byteMap[i] > 0)
                        nodes.Add(new HuffmanTree { Value = (byte)i, _weight = byteMap[i] }); // додаємо всі вузли
                _nodes = nodes.ToArray();

                while (nodes.Count > 1)
                {
                    var firstNode = nodes[0];
                    var index = 0;
                    for (int i = 1; i < nodes.Count; i++)
                    {
                        if (firstNode._weight <= nodes[i]._weight) continue;
                        firstNode = nodes[i];
                        index = i;
                    }
                    nodes.RemoveAt(index);
                    var second = nodes[0];
                    index = 0;
                    for (int i = 1; i < nodes.Count; i++)
                    {
                        if (second._weight <= nodes[i]._weight) continue;
                        second = nodes[i];
                        index = i;
                    } // шукаємо 2 найлегших (вузли)
                    nodes.RemoveAt(index);
                    var newNode = new HuffmanTree { LeftBranch = firstNode, RightBranch = second, _weight = firstNode._weight + second._weight };
                    firstNode._parent = newNode;
                    second._parent = newNode;
                    nodes.Add(newNode);
                    // замінюємо 2 найлегших на один с вагою равної сумі
                }
                Root = nodes[0];

            }
            public static Dictionary<byte, BitArray> GetMap()
            {// отримуємо карту для кодування
                var output = new Dictionary<byte, BitArray>(_nodes.Length);
                var stringb = new StringBuilder();
                foreach (HuffmanTree t in _nodes) // для кожного вузла будуємо код
                {
                    var huffmanTree = t;
                    stringb.Clear();

                    while (huffmanTree._parent != null)
                    {
                        stringb.Append(huffmanTree == huffmanTree._parent.LeftBranch ? "0" : "1"); // якщо вітка ліва - додаємо 0, якщо права, -1
                        huffmanTree = huffmanTree._parent;
                    }
                    var bitArray = new BitArray(stringb.Length);
                    for (int j = 0; j < stringb.Length; j++)
                    {
                        bitArray[j] = stringb[j] - '0' == 1; // збираємо в bitArray и додаяєм у карту
                    }
                    output.Add(t.Value, bitArray);
                }

                return output;
            }
            public static string Decoder()
            {
                var ChooseFile = new OpenFileDialog();
                if (ChooseFile.ShowDialog() == DialogResult.OK)
                {
                    var map = new int[256];
                    using (var stream = new FileStream(ChooseFile.FileName, FileMode.Open))
                    using (var binaryReader = new BinaryReader(stream))
                    {
                        for (int i = 0; i < map.Length; i++)
                        {
                            map[i] = binaryReader.ReadInt32();
                        }
                        HuffmanTree.CreateHuffmanTree(map); // зчитуємо карту байт из файлу й по ній будуємо дерево
                        int additionBits = binaryReader.ReadByte(); // зчитуємо кількість додатоквих 
                        var bytes = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length - map.Length * 4 - 1);
                        // зчитуємо закодоване
                        var bitArray = new BitArray(bytes);
                        HuffmanTree currentNode = HuffmanTree.Root;
                        using (var sw = new FileStream(ChooseFile.FileName.Substring(0, ChooseFile.FileName.Length - 3), FileMode.Create))
                        using (var bw = new BinaryWriter(sw))
                        {
                            for (int i = 0; i < bitArray.Length - additionBits; i++) // розшифрування
                            {
                                var boolean = bitArray[i]; // отримуємо біт
                                currentNode = boolean ? currentNode.RightBranch : currentNode.LeftBranch; // 1 вправо 0 - вліво 
                                if (currentNode.LeftBranch == null) // нема дітей - лист
                                {
                                    bw.Write(currentNode.Value); // пишемо значення листа в файл
                                    currentNode = HuffmanTree.Root; // переходимо к root
                                }
                            }
                        }
                    }
               
                    StringBuilder texter=new StringBuilder();
                    texter.Append("\nФайл успішно розшифровано. Нове ім'я файла: ");
                    texter.Append(ChooseFile.FileName.Substring(0, ChooseFile.FileName.Length - 3) + '\n');
                    string a=texter.ToString();
                    return a;

                }
                return null;
            }
            public static string Cod()
            {

                var ChooseFile = new OpenFileDialog(); // Відкриття вікна для вибору потрібного файлу
                if (ChooseFile.ShowDialog() == DialogResult.OK)// кодуємо
                {
                    FillByteMap(ChooseFile.FileName); // заповнюємо карту байт (частоту появи байт)
                    HuffmanTree.CreateHuffmanTree(_byteMap); // будуємо дерево
                    var huffmapMap = HuffmanTree.GetMap();

                    CodeFile(ChooseFile.FileName, ChooseFile.FileName + "huf", huffmapMap, _byteMap); // кодуємо
                 
                    StringBuilder texter = new StringBuilder();
                    texter.Append("\nФайл успішно зашифровано.Нове ім'я файла: " + ChooseFile.FileName + "huf\n");
                  
                    string a = texter.ToString();
                    return a;


                }
                return null;

            }
            public static void FillByteMap(String fileName)// заповнювач карти байт
            {
                Byte myByte;
                for (int i = 0; i < _byteMap.Length; i++)
                {
                    _byteMap[i] = 0;
                }
                using (var file = new FileStream(fileName, FileMode.Open))
                {
                    for (int i = 0; i < file.Length; i++)
                    {
                        myByte = (Byte)file.ReadByte();
                        _byteMap[myByte]++;
                    }
                }
            }
            public static void CodeFile(string fileName, string newFileName, Dictionary<byte, BitArray> huffmapMap, IEnumerable<int> map)
            {// кодуємо
                Byte myByte;
                var code = new List<BitArray>();
                using (var fs = new FileStream(fileName, FileMode.Open))
                {
                    for (int i = 0; i < fs.Length; i++)
                    {
                        myByte = (Byte)fs.ReadByte();
                        code.Add(huffmapMap[myByte]);
                    }
                }
                var count = code.Sum(bitArray => bitArray.Count);


                var DopBits = (byte)((8 - count % 8) % 8); // кілкість додадткових біт 
                var bitCount = (count + 7) / 8; // кількість байт в закодованому файлі

                var bitarr = new BitArray(count + DopBits, false);
                var add = 0;
                foreach (var t in code)
                {
                    for (var j = 0; j < t.Count; j++)
                    {
                        bitarr[add + j] = t[t.Count - 1 - j];
                    }
                    add += t.Count;//збираємо из массиву потік
                }
                var bytes = new byte[bitCount];
                bitarr.CopyTo(bytes, 0);

                using (var aw = new FileStream(newFileName, FileMode.Create))
                using (var bw = new BinaryWriter(aw))
                {
                    foreach (var b in map)
                    {
                        bw.Write(b);// спочатку запишемо у файл карту баит
                    }
                    bw.Write(DopBits); // кільксть додаткових біт
                    foreach (var b in bytes)
                    {
                        bw.Write(b); // тепер сам код
                    }
                }
            }
        }

        class Greed
        {
            public int for_buy;
            public List<string> name_of_species;
            public List<int> value_species;
            public List<int> Tuzemchi_sale_value;
            public List<string> Tuzemchi_sale_name;
            public List<int> Tuzemchi_sale_vaga;
            public int Trum;
            public Greed(int trum,int chena)
            {
                name_of_species = new List<string>();
                value_species = new List<int>();
                Tuzemchi_sale_value = new List<int>();
                Tuzemchi_sale_name = new List<string>();
                Tuzemchi_sale_vaga = new List<int>();
                Trum = trum;
                for_buy = chena;
            }
            public List<string> greed_algoritm()
            {
                List<string> z = new List<string>();    //список для показу результату 
                Tuzemchi_sale_value = new List<int>();
                for (int i =0;i<Tuzemchi_sale_vaga.Count;i++) //заповнювач масиву цін
                {
                    for(int j=0;j<value_species.Count;j++)
                    {
                        if(name_of_species[j]==Tuzemchi_sale_name[i])
                        {
                            Tuzemchi_sale_value.Add( value_species[j]);
                        }
                    }
                }
                //Lists for sorsts
                List<int> sort_arr = Tuzemchi_sale_value;
                List<string> sort_string = Tuzemchi_sale_name;
                List<int> sort_arr2 = Tuzemchi_sale_vaga;  
                for (int i = 1; i < Tuzemchi_sale_value.Count; ++i) //buble sort
                {
                    for (int r = 0; r < Tuzemchi_sale_value.Count - i; r++)
                    {
                        if (sort_arr[r] < sort_arr[r + 1])
                        {
                            int temp = sort_arr[r];
                            sort_arr[r] = sort_arr[r + 1];
                            sort_arr[r + 1] = temp;
                            temp = sort_arr2[r];
                            sort_arr2[r] = sort_arr2[r + 1];
                            sort_arr2[r + 1] = temp;
                            string temper = sort_string[r];
                            sort_string[r] = sort_string[r + 1];
                            sort_string[r + 1] = temper;
                        }
                    }
                }
                int current_ves = 0;    //Поточна вага вантажу
                int last_value = 0; //Поточна вартість товару
                    for(int i=0;i<Tuzemchi_sale_value.Count;i++)    
                    {
                        if(current_ves+sort_arr2[i]<=Trum)
                        {
                        string output ="Ціна за кг - " +sort_arr[i].ToString() + "; вага - " + sort_arr2[i].ToString()+ "; назва- "+sort_string[i];
                        current_ves += sort_arr2[i];
                        last_value += (sort_arr[i] * sort_arr2[i]);
                        z.Add(output);
                        }
                    }
                z.Add("Вага вантажу: "+current_ves.ToString());
                z.Add("Чистий прибуток: "+(last_value-(for_buy*current_ves)).ToString());
                return z;
            }
            
        }
        public LR3()
        {
            InitializeComponent();
        }
        Greed Greedier=new Greed(500,20);   //максимальна вага і ціна купівлі за замовчуванням
        private void Hufman_C_Click(object sender, EventArgs e)
        {
            string a = HuffmanTree.Cod();
            OutputTextBox.AppendText(a);
         
        }
        private  void button1_Click(object sender, EventArgs e)
        {
            string a = HuffmanTree.Decoder();
            OutputTextBox.AppendText(a);
      
        }

        private void LR3_Load(object sender, EventArgs e)
        {
          
        //    Greedier.Tuzemchi_sale_vaga.Add(1);
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Greedier.Tuzemchi_sale_vaga.Add(Int32.Parse(vaga_sp.Text));
            Greedier.Tuzemchi_sale_name.Add(name_sp.Text);
            string s = name_sp.Text;
            Random rand = new Random();
           
            for(int i =0;i<2;i++)
            {
                int a = 0;
                for(int j=0;j<Greedier.name_of_species.Count;j++)
                {
                    if (s == Greedier.name_of_species[j]) a++;
                }
                if (a == 0)
                {
                    Greedier.name_of_species.Add(s);
                    int z = rand.Next(10, 100);
                    Greedier.value_species.Add(z);
                }

            }
         
        }


        private void Show_containt_Click(object sender, EventArgs e)
        {
            OutputTextBox.Clear();
            for (int i = 0; i < Greedier.Tuzemchi_sale_name.Count; i++) OutputTextBox.Text += Greedier.Tuzemchi_sale_name[i]+" with vaga " + Greedier.Tuzemchi_sale_vaga[i].ToString()   + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OutputTextBox.Clear();
            for(int i=0;i<Greedier.name_of_species.Count;i++) OutputTextBox.Text += Greedier.name_of_species[i]+" with price " +Greedier.value_species[i].ToString() + Environment.NewLine;

        }

        private void find_destiny_Click(object sender, EventArgs e)
        {
            OutputTextBox.Clear();
            List<string> output = new List<string>();
            output = Greedier.greed_algoritm();
            for(int i=0;i<output.Count;i++)
            {
                OutputTextBox.Text += output[i] + Environment.NewLine;
            }
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            Greedier.Tuzemchi_sale_name.RemoveAt(Int32.Parse(index_box.Text));
            Greedier.Tuzemchi_sale_vaga.RemoveAt(Int32.Parse(index_box.Text));
        
        }

        private void remake_button_Click(object sender, EventArgs e)
        {
            Greedier.Tuzemchi_sale_name[Int32.Parse(index_box.Text)] = name_sp.Text;
            Greedier.Tuzemchi_sale_vaga[Int32.Parse(index_box.Text)] = Int32.Parse(vaga_sp.Text);
        }

        private void Trum_new_Click(object sender, EventArgs e)
        {
            Greedier.Trum = Int32.Parse(changer.Text);
        }

        private void trade_change_v_Click(object sender, EventArgs e)
        {
            Greedier.for_buy = Int32.Parse(changer.Text);
        }
    }
}
