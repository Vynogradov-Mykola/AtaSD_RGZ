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
namespace LR2
{

    public partial class LR2 : Form
    {

        public class Item
        {
           
            public string Key { get; private set; }

            public string Value { get; private set; }
            public Item(string key, string value)
            {
             

                // Устанавливаем значения.
                Key = key;
                Value = value;
            }

            public override string ToString()
            {
                return Key;
            }
        }
      
    const int t = 2;
       public string for_out = "";
        class BNode
        {
            public int[] keys;//[2 * t];
            public BNode[] children;//[2 * t + 1];
            public BNode parent;
            public int count; //количество ключей
            public int countSons; //количество сыновей
            public bool leaf;
            public string[] DATA;
            public int[] Temperature;
            public int[] Vologist;
            public string[] Napravlenie;
            public string[] Atmosphere;
            public int[] Tisk;
            public int[] Opadi;
            public bool is_leaf()
            {
                if (this.children[0] == null) return true;
                else return false;
            }
            public BNode()
            {
                keys = new int[2 * t];
                children = new BNode[2 * t + 1];
                DATA = new string[2 * t + 1];
                Temperature = new int[2 * t + 1];
                Vologist = new int[2 * t + 1];
                Napravlenie = new string[2 * t + 1];
                Atmosphere = new string[2 * t + 1];
                Tisk = new int[2 * t + 1];
                Opadi = new int[2 * t + 1];

            }

        };
        class Tree
        {
            public int[] length;
            public Tree(int z)
            {
               length = new int[z];
             for (int i = 0; i < z; i++) length[i] = i;
                root = null;
            }
            public BNode root;
            public void insert_to_node(int key, BNode node, string date, int tp, int volog, string naprav, string atm, int tisk, int opad)
            {
                node.keys[node.count] = key;
                node.DATA[node.count] = date;
                node.Temperature[node.count] = tp;
                node.Vologist[node.count] = volog;
                node.Napravlenie[node.count] = naprav;
                node.Atmosphere[node.count] = atm;
                node.Tisk[node.count] = tisk;
                node.Opadi[node.count] = opad;
                node.count = node.count + 1;
                sort(node);
            }
            public void sort(BNode node)
            {
                int m;
                string m1;
                for (int i = 0; i < (2 * t - 1); i++)
                {
                    for (int j = i + 1; j <= (2 * t - 1); j++)
                    {
                        if ((node.keys[i] != 0) && (node.keys[j] != 0))
                        {
                            if ((node.keys[i]) > (node.keys[j]))
                            {
                                m = node.keys[i];
                                node.keys[i] = node.keys[j];
                                node.keys[j] = m;
                                m1 = node.DATA[i];
                                node.DATA[i] = node.DATA[j];
                                node.DATA[j] = m1;
                                m = node.Temperature[i];
                                node.Temperature[i] = node.Temperature[j];
                                node.Temperature[j] = m;
                                m = node.Vologist[i];
                                node.Vologist[i] = node.Vologist[j];
                                node.Vologist[j] = m;
                                m1 = node.Napravlenie[i];
                                node.Napravlenie[i] = node.Napravlenie[j];
                                node.Napravlenie[j] = m1;
                                m1 = node.Atmosphere[i];
                                node.Atmosphere[i] = node.Atmosphere[j];
                                node.Atmosphere[j] = m1;
                                m = node.Tisk[i];
                                node.Tisk[i] = node.Tisk[j];
                                node.Tisk[j] = m;
                                m = node.Opadi[i];
                                node.Opadi[i] = node.Opadi[j];
                                node.Opadi[j] = m;
                            }
                        }
                        else break;
                    }
                }
            }
            public void restruct(BNode node)
            {
                if (node.count < (2 * t - 1)) return;

                //первый сын
                BNode child1 = new BNode();
                int j;
                for (j = 0; j <= t - 2; j++)
                {
                    child1.keys[j] = node.keys[j];
                    child1.DATA[j] = node.DATA[j];
                    child1.Temperature[j] = node.Temperature[j];
                    child1.Vologist[j] = node.Vologist[j];
                    child1.Napravlenie[j] = node.Napravlenie[j];
                    child1.Atmosphere[j] = node.Atmosphere[j];
                    child1.Tisk[j] = node.Tisk[j];
                    child1.Opadi[j] = node.Opadi[j];

                }
                for (j = t - 1; j <= (2 * t - 1); j++)
                {
                    child1.keys[j] = 0;
                }
                child1.count = t - 1; //количество ключей в узле
                if (node.countSons != 0)
                {
                    for (int i = 0; i <= (t - 1); i++)
                    {
                        child1.children[i] = node.children[i];
                        child1.children[i].parent = child1;
                    }
                    for (int i = t; i <= (2 * t); i++)
                    {
                        child1.children[i] = null;
                    }
                    child1.leaf = false;
                    child1.countSons = t - 1; //количество сыновей
                }
                else
                {
                    child1.leaf = true;
                    child1.countSons = 0;
                    for (int i = 0; i <= (2 * t); i++)
                    {
                        child1.children[i] = null;
                    }
                }

                //второй сын
                BNode child2 = new BNode();
                for (j = 0; j <= (t - 1); j++)
                {
                    child2.keys[j] = node.keys[j + t];
                    child2.DATA[j] = node.DATA[j+t];
                    child2.Temperature[j] = node.Temperature[j+t];
                    child2.Vologist[j] = node.Vologist[j+t];
                    child2.Napravlenie[j] = node.Napravlenie[j+t];
                    child2.Atmosphere[j] = node.Atmosphere[j+t];
                    child2.Tisk[j] = node.Tisk[j+t];
                    child2.Opadi[j] = node.Opadi[j+t];
                }
                for (j = t; j <= (2 * t - 1); j++)
                {
                    child2.keys[j] = 0;
                }
                child2.count = t; //количество ключей в узле
                if (node.countSons != 0)
                {
                    for (int i = 0; i <= (t); i++)
                    {
                        child2.children[i] = node.children[i + t];
                        child2.children[i].parent = child2;
                    }
                    for (int i = t + 1; i <= (2 * t); i++)
                    {
                        child2.children[i] = null;
                    }
                    child2.leaf = false;
                    child2.countSons = t; //количество сыновей
                }
                else
                {
                    child2.leaf = true;
                    child2.countSons = 0;
                    for (int i = 0; i <= (2 * t); i++)
                    {
                        child2.children[i] = null;
                    }
                }

                //родитель
                if (node.parent == null)
                { //если родителя нет, то это корень
                    node.keys[0] = node.keys[t - 1];
                    node.DATA[0] = node.DATA[t - 1];
                    node.Temperature[0] = node.Temperature[t - 1];
                    node.Vologist[0] = node.Vologist[t - 1];
                    node.Napravlenie[0] = node.Napravlenie[t - 1];
                    node.Atmosphere[0] = node.Atmosphere[t - 1];
                    node.Tisk[0] = node.Tisk[t - 1];
                    node.Opadi[0] = node.Opadi[t - 1];
                    for (j = 1; j <= (2 * t - 1); j++)
                    {
                        node.keys[j] = 0;
                    }
                    node.children[0] = child1;
                    node.children[1] = child2;
                    for (int i = 2; i <= (2 * t); i++)
                    {
                        node.children[i] = null;
                    }
                    node.parent = null;
                    node.leaf = false;
                    node.count = 1;
                    node.countSons = 2;
                    child1.parent = node;
                    child2.parent = node;
                }
                else
                {
                    insert_to_node(node.keys[t - 1], node.parent, node.DATA[t - 1], node.Temperature[t - 1], node.Vologist[t - 1], node.Napravlenie[t - 1], node.Atmosphere[t - 1], node.Tisk[t - 1], node.Opadi[t - 1]);
                    for (int i = 0; i <= (2 * t); i++)
                    {
                        if (node.parent.children[i] == node) node.parent.children[i] = null;
                    }
                    for (int i = 0; i <= (2 * t); i++)
                    {
                        if (node.parent.children[i] == null)
                        {
                            for (j = (2 * t); j > (i + 1); j--) node.parent.children[j] = node.parent.children[j - 1];
                            node.parent.children[i + 1] = child2;
                            node.parent.children[i] = child1;
                            break;
                        }
                    }
                    child1.parent = node.parent;
                    child2.parent = node.parent;
                    node.parent.leaf = false;
                }
            }


            public string SearchKey(int key, BNode node)
            {
                if (node != null)
                {
                    if (node.leaf == false)
                    {
                        int i;
                        for (i = 0; i <= (2 * t - 1); i++)
                        {
                            if (node.keys[i] != 0)
                            {
                                if (key == node.keys[i])
                                {
                                    
                                    string a="";
                                    a += node.DATA[i] + " Temperature:";
                                    a+= node.Temperature[i] + " Vologist:";
                                    a+= node.Vologist[i] + " Napravlenie vetra:";
                                    a+= node.Napravlenie[i] + " Atmosphernoe yavlenie:";
                                    a+= node.Atmosphere[i] + " Tisk:";
                                    a+= node.Tisk[i] + " Opadi:";
                                    a+= node.Opadi[i] + " ";


                                    
                                    return a;
                                }
                                if ((key < node.keys[i]))
                                {
                                    return SearchKey(key, node.children[i]);
                                }
                            }
                            else break;
                        }
                        return SearchKey(key, node.children[i]);
                    }
                    else
                    {
                        for (int j = 0; j <= (2 * t - 1); j++)
                            if (key == node.keys[j])
                            {
                                string a = "";
                                a += node.DATA[j] + " Temperature:";
                                a += node.Temperature[j] + " Vologist:";
                                a += node.Vologist[j] + " Napravlenie vetra:";
                                a += node.Napravlenie[j] + " Atmosphernoe yavlenie:";
                                a += node.Atmosphere[j] + " Tisk:";
                                a += node.Tisk[j] + " Opadi:";
                                a += node.Opadi[j] + " ";
                                return a;
                            }
                        return "a";
                    }
                }
                else return "a";
            }
            public void Remove(int key, BNode node)
            {
                BNode ptr = this.root;
                int position;
                int positionSon;
                int i;
              if (SearchKey(key, ptr) =="a" )
               {
                   return;
                }
                else
                {
                    //ищем узел, в котором находится ключ для удаления
                    for (i = 0; i <= ptr.count - 1; i++)
                    {
                        if (ptr.keys[i] != 0)
                        {
                            if (key == ptr.keys[i])
                            {
                                position = i;
                                break;
                            }
                            else
                            {
                                if ((key < ptr.keys[i]))
                                {
                                    ptr = ptr.children[i];
                                    positionSon = i;
                                    i = -1;
                                }
                                else
                                {
                                    if (i == (ptr.count - 1))
                                    {
                                        ptr = ptr.children[i + 1];
                                        positionSon = i + 1;
                                        i = -1;
                                    }
                                }
                            }
                        }
                        else break;
                    }
                }
                if (ptr.is_leaf() == true)
                {
                    if (ptr.count > (t - 1)) RemoveFromNode(key, ptr);
                    else
                    {
                        RemoveLeaf(key, ptr);
                    }
                }
                else Remove(key, ptr);
            }
            public void RemoveFromNode(int key, BNode node)
            {
                for (int i = 0; i < node.count; i++)
                {
                    if (node.keys[i] == key)
                    {
                        for (int j = i; j < node.count; j++)
                        {
                            node.keys[j] = node.keys[j + 1];
                            node.children[j] = node.children[j + 1];
                        }
                        node.keys[node.count - 1] = 0;
                        node.children[node.count - 1] = node.children[node.count];
                        node.children[node.count] = null;
                        break;
                    }
                }
                node.count--;
            }
            public void RemoveLeaf(int key, BNode node)
            {
                if ((node == root) && (node.count == 1))
                {
                    RemoveFromNode(key, node);
                    root.children[0] = null;

                    root = null;
                    return;
                }
                if (node == root)
                {
                    RemoveFromNode(key, node);
                    return;
                }
                if (node.count > (t - 1))
                {
                    RemoveFromNode(key, node);
                    return;
                }
                BNode ptr = node;
                int k1;
                int k2;
                int position;
                int positionSon = 9999;
                int i;
                for (i = 0; i <= node.count - 1; i++)
                {
                    if (key == node.keys[i])
                    {
                        position = i; //позиция ключа в узле
                        break;
                    }
                }
                BNode parent = ptr.parent;
                for (int j = 0; j <= parent.count; j++)
                {
                    if (parent.children[j] == ptr)
                    {
                        positionSon = j; //позиция узла по отношению к родителю
                        break;
                    }
                }
                //если ptr-первый ребенок (самый левый)
                if (positionSon == 0)
                {
                    if (parent.children[positionSon + 1].count > (t - 1))
                    { //если у правого брата больше, чем t-1 ключей
                        k1 = parent.children[positionSon + 1].keys[0]; //k1 - минимальный ключ правого брата
                        k2 = parent.keys[positionSon]; //k2 - ключ родителя, больше, чем удаляемый, и меньше, чем k1
                        insert_to_node(k2, ptr, node.DATA[positionSon], node.Temperature[positionSon], node.Vologist[positionSon], node.Napravlenie[positionSon], node.Atmosphere[positionSon], node.Tisk[positionSon], node.Opadi[positionSon]);
                        RemoveFromNode(key, ptr);
                        parent.keys[positionSon] = k1; //меняем местами k1 и k2
                        RemoveFromNode(k1, parent.children[positionSon + 1]); //удаляем k1 из правого брата
                    }
                    else
                    { //если у правого <u>единственного</u> брата не больше t-1 ключей		
                        RemoveFromNode(key, ptr);
                        if (ptr.count <= (t - 2)) Repair(ptr);
                    }
                }
                else
                {
                    //если ptr-последний ребенок (самый правый)
                    if (positionSon == parent.count)
                    {
                        //если у левого брата больше, чем t-1 ключей
                        if (parent.children[positionSon - 1].count > (t - 1))
                        {
                            BNode temp = parent.children[positionSon - 1];
                            k1 = temp.keys[temp.count - 1]; //k1 - максимальный ключ левого брата
                            k2 = parent.keys[positionSon - 1]; //k2 - ключ родителя, меньше, чем удаляемый и больше, чем k1
                            insert_to_node(k2, ptr, node.DATA[positionSon - 1], node.Temperature[positionSon - 1], node.Vologist[positionSon - 1], node.Napravlenie[positionSon - 1], node.Atmosphere[positionSon - 1], node.Tisk[positionSon - 1], node.Opadi[positionSon - 1]);
                            RemoveFromNode(key, ptr);
                            parent.keys[positionSon - 1] = k1;
                            RemoveFromNode(k1, temp);
                        }
                        else
                        { //если у <u>единственного</u> левого брата не больше t-1 ключей
                            RemoveFromNode(key, ptr);
                            if (ptr.count <= (t - 2)) Repair(ptr);
                        }
                    }
                    else
                    { //если ptr имеет братьев справа и слева
                      //если у правого брата больше, чем t-1 ключей
                        if (parent.children[positionSon + 1].count > (t - 1))
                        {
                            k1 = parent.children[positionSon + 1].keys[0]; //k1 - минимальный ключ правого брата
                            k2 = parent.keys[positionSon]; //k2 - ключ родителя, больше, чем удаляемый и меньше, чем k1
                            insert_to_node(k2, ptr, node.DATA[positionSon], node.Temperature[positionSon], node.Vologist[positionSon], node.Napravlenie[positionSon], node.Atmosphere[positionSon], node.Tisk[positionSon], node.Opadi[positionSon]);
                            RemoveFromNode(key, ptr);
                            parent.keys[positionSon] = k1; //меняем местами k1 и k2
                            RemoveFromNode(k1, parent.children[positionSon + 1]); //удаляем k1 из правого брата
                        }
                        else
                        {
                            //если у левого брата больше, чем t-1 ключей
                            if (parent.children[positionSon - 1].count > (t - 1))
                            {
                                BNode temp = parent.children[positionSon - 1];
                                k1 = temp.keys[temp.count - 1]; //k1 - максимальный ключ левого брата
                                k2 = parent.keys[positionSon - 1]; //k2 - ключ родителя, меньше, чем удаляемый и больше, чем k1
                                insert_to_node(k2, ptr, node.DATA[positionSon - 1], node.Temperature[positionSon - 1], node.Vologist[positionSon - 1], node.Napravlenie[positionSon - 1], node.Atmosphere[positionSon - 1], node.Tisk[positionSon - 1], node.Opadi[positionSon - 1]);
                                RemoveFromNode(key, ptr);
                                parent.keys[positionSon - 1] = k1;
                                RemoveFromNode(k1, temp);
                            }
                            else
                            { //если у обоих братьев не больше t-1 ключей
                                RemoveFromNode(key, ptr);
                                if (ptr.count <= (t - 2)) Repair(ptr);
                            }
                        }
                    }
                }
            }
            public void Lconnect(BNode node, BNode othernode)
            {

                if (node == null) return;
                for (int i = 0; i <= (othernode.count - 1); i++)
                {
                    node.keys[node.count] = othernode.keys[i];
                    node.children[node.count] = othernode.children[i];
                    node.count = node.count + 1;
                }
                node.children[node.count] = othernode.children[othernode.count];
                for (int j = 0; j <= node.count; j++)
                {
                    if (node.children[j] == null) break;
                    node.children[j].parent = node;
                }

            }
            public void Rconnect(BNode node, BNode othernode)
            {
                if (node == null) return;
                for (int i = 0; i <= (othernode.count - 1); i++)
                {
                    node.keys[node.count] = othernode.keys[i];
                    node.children[node.count + 1] = othernode.children[i + 1];
                    node.count = node.count + 1;
                }
                for (int j = 0; j <= node.count; j++)
                {
                    if (node.children[j] == null) break;
                    node.children[j].parent = node;
                }

            }
            public void Repair(BNode node)
            {
                if ((node == root) && (node.count == 0))
                {
                    if (root.children[0] != null)
                    {
                        root.children[0].parent = null;
                        root = root.children[0];
                    }

                    return;
                }
                BNode ptr = node;
                int k1;
                int k2;
                int positionSon = 9999;
                BNode parent = ptr.parent;
                for (int j = 0; j <= parent.count; j++)
                {
                    if (parent.children[j] == ptr)
                    {
                        positionSon = j; //позиция узла по отношению к родителю
                        break;
                    }
                }
                //если ptr-первый ребенок (самый левый)
                if (positionSon == 0)
                {
                    insert_to_node(parent.keys[positionSon], ptr, parent.DATA[positionSon], parent.Temperature[positionSon], parent.Vologist[positionSon], parent.Napravlenie[positionSon], parent.Atmosphere[positionSon], parent.Tisk[positionSon], parent.Opadi[positionSon]);
                    Lconnect(ptr, parent.children[positionSon + 1]);
                    parent.children[positionSon + 1] = ptr;
                    parent.children[positionSon] = null;
                    RemoveFromNode(parent.keys[positionSon], parent);
                    if (ptr.count == 2 * t)
                    {
                        while (ptr.count == 2 * t)
                        {
                            if (ptr == root)
                            {
                                restruct(ptr);
                                break;
                            }
                            else
                            {
                                restruct(ptr);
                                ptr = ptr.parent;
                            }
                        }
                    }
                    else
                        if (parent.count <= (t - 2)) Repair(parent);
                }
                else
                {
                    //если ptr-последний ребенок (самый правый)
                    if (positionSon == parent.count)
                    {
                        insert_to_node(parent.keys[positionSon - 1], parent.children[positionSon - 1], parent.DATA[positionSon - 1], parent.Temperature[positionSon - 1], parent.Vologist[positionSon - 1], parent.Napravlenie[positionSon - 1], parent.Atmosphere[positionSon - 1], parent.Tisk[positionSon - 1], parent.Opadi[positionSon - 1]);
                        Lconnect(parent.children[positionSon - 1], ptr);
                        parent.children[positionSon] = parent.children[positionSon - 1];
                        parent.children[positionSon - 1] = null;
                        RemoveFromNode(parent.keys[positionSon - 1], parent);
                        BNode temp = parent.children[positionSon];
                        if (ptr.count == 2 * t)
                        {
                            while (temp.count == 2 * t)
                            {
                                if (temp == root)
                                {
                                    restruct(temp);
                                    break;
                                }
                                else
                                {
                                    restruct(temp);
                                    temp = temp.parent;
                                }
                            }
                        }
                        else
                        if (parent.count <= (t - 2)) Repair(parent);
                    }
                    else
                    { //если ptr имеет братьев справа и слева
                        insert_to_node(parent.keys[positionSon], ptr, parent.DATA[positionSon], parent.Temperature[positionSon], parent.Vologist[positionSon], parent.Napravlenie[positionSon], parent.Atmosphere[positionSon], parent.Tisk[positionSon], parent.Opadi[positionSon]);
                        Lconnect(ptr, parent.children[positionSon + 1]);
                        parent.children[positionSon + 1] = ptr;
                        parent.children[positionSon] = null;
                        RemoveFromNode(parent.keys[positionSon], parent);
                        if (ptr.count == 2 * t)
                        {
                            while (ptr.count == 2 * t)
                            {
                                if (ptr == root)
                                {
                                    restruct(ptr);
                                    break;
                                }
                                else
                                {
                                    restruct(ptr);
                                    ptr = ptr.parent;
                                }
                            }
                        }
                        else
                        if (parent.count <= (t - 2)) Repair(parent);
                    }
                }
            }
            public string Search(int key)
            {
                return SearchKey(key, this.root);
            }
            public void Remove(int key)
            {
                BNode ptr = this.root;
                int position;
                int positionSon;
                int i;
                if (SearchKey(key, ptr) == "a")
                {
                    return;
                }
                else
                {
                    //ищем узел, в котором находится ключ для удаления
                    for (i = 0; i <= ptr.count - 1; i++)
                    {
                        if (ptr.keys[i] != 0)
                        {
                            if (key == ptr.keys[i])
                            {
                                position = i;
                                break;
                            }
                            else
                            {
                                if ((key < ptr.keys[i]))
                                {
                                    ptr = ptr.children[i];
                                    positionSon = i;
                                    i = -1;
                                }
                                else
                                {
                                    if (i == (ptr.count - 1))
                                    {
                                        ptr = ptr.children[i + 1];
                                        positionSon = i + 1;
                                        i = -1;
                                    }
                                }
                            }
                        }
                        else break;
                    }
                }
                if (ptr.leaf == true)
                {
                    if (ptr.count > (t - 1)) RemoveFromNode(key, ptr);
                    else RemoveLeaf(key, ptr);
                }
                else Remove(key, ptr);
            }
            public void insert(int key, string date, int tp, int volog, string naprav, string atm, int tisk, int opad)
            {
                if (root == null)
                {
                    BNode newRoot = new BNode();
                    newRoot.keys[0] = key;
                    newRoot.DATA[0] = date;
                    newRoot.Temperature[0] = tp;
                    newRoot.Vologist[0] = volog;
                    newRoot.Napravlenie[0] = naprav;
                    newRoot.Atmosphere[0] = atm;
                    newRoot.Tisk[0] = tisk;
                    newRoot.Opadi[0] = opad;
                    for (int j = 1; j <= (2 * t - 1); j++)
                    {
                        newRoot.keys[j] = 0;
                    }
                    for (int i = 0; i <= (2 * t); i++)
                    {
                        newRoot.children[i] = null;
                    }

                    newRoot.count = 1;
                    newRoot.countSons = 0;
                    newRoot.leaf = true;
                    newRoot.parent = null;
                    root = newRoot;
                }
                else
                {
                    BNode ptr = root;
                    while (ptr.leaf == false)
                    { //выбор ребенка до тех пор, пока узел 
                      //не будет являться листом
                        for (int i = 0; i <= (2 * t - 1); i++)
                        { //перебираем все ключи
                            if (ptr.keys[i] != 0)
                            {
                                if (key < ptr.keys[i])
                                {
                                    ptr = ptr.children[i];
                                    break;
                                }
                                if ((ptr.keys[i + 1] == 0) && (key > ptr.keys[i]))
                                {
                                    ptr = ptr.children[i + 1]; //перенаправляем к самому 
                                                               //последнему ребенку, если цикл не "сломался"
                                    break;
                                }

                            }
                            else break;
                        }
                    }
                    insert_to_node(key, ptr, date, tp, volog, naprav, atm, tisk, opad);

                    while (ptr.count == 2 * t)
                    {
                        if (ptr == root)
                        {
                            restruct(ptr);
                            break;
                        }
                        else
                        {
                            restruct(ptr);
                            ptr = ptr.parent;
                        }
                    }
                }
            }
            public string[] zadanie(int key)
            { 
                string[] s = new string[key];
                for(int i =0;i<key; i++)
                {
                    s[i] = Search(i);
                }
                return s;
            }
        };
        public class HashTable
        {

            private readonly byte _maxSize = 255;
            private Dictionary<int, List<Item>> _items = null;
            public IReadOnlyCollection<KeyValuePair<int, List<Item>>> Items => _items?.ToList()?.AsReadOnly();
            public HashTable()
            {
                // Инициализируем коллекцию максимальным количество элементов.
                _items = new Dictionary<int, List<Item>>(_maxSize);
            }
            public void Insert(string key, string value)
            {

                var item = new Item(key, value);
                var hash = GetHash(item.Key);
                List<Item> hashTableItem = null;
                if (_items.ContainsKey(hash))
                {
                    hashTableItem = _items[hash];
                    var oldElementWithKey = hashTableItem.SingleOrDefault(i => i.Key == item.Key);
                    if (oldElementWithKey != null)
                    {
                        throw new ArgumentException($"Хеш-таблица уже содержит элемент с ключом {key}. Ключ должен быть уникален.", nameof(key));
                    }

                    // Добавляем элемент данных в коллекцию элементов хеш таблицы.
                    _items[hash].Add(item);
                }
                else
                {
                    // Создаем новую коллекцию.
                    hashTableItem = new List<Item> { item };

                    // Добавляем данные в таблицу.
                    _items.Add(hash, hashTableItem);
                }
            }
            /// Удалить данные из хеш таблицы по ключу.     
            public void Delete(string key)
            {

                // Получаем хеш ключа.
                var hash = GetHash(key);

                // Если значения с таким хешем нет в таблице, 
                // то завершаем выполнение метода.
                if (!_items.ContainsKey(hash))
                {
                    return;
                }

                // Получаем коллекцию элементов по хешу ключа.
                var hashTableItem = _items[hash];

                // Получаем элемент коллекции по ключу.
                var item = hashTableItem.SingleOrDefault(i => i.Key == key);

                // Если элемент коллекции найден, 
                // то удаляем его из коллекции.
                if (item != null)
                {
                    hashTableItem.Remove(item);
                }
            }

            public string Search(string key)
            {
                // Проверяем входные данные на корректность.
                if (string.IsNullOrEmpty(key))
                {
                    throw new ArgumentNullException(nameof(key));
                }

                if (key.Length > _maxSize)
                {
                    throw new ArgumentException($"Максимальная длинна ключа составляет {_maxSize} символов.", nameof(key));
                }

                // Получаем хеш ключа.
                var hash = GetHash(key);

                // Если таблица не содержит такого хеша,
                // то завершаем выполнения метода вернув null.
                if (!_items.ContainsKey(hash))
                {
                    return null;
                }

                // Если хеш найден, то ищем значение в коллекции по ключу.
                var hashTableItem = _items[hash];

                // Если хеш найден, то ищем значение в коллекции по ключу.
                if (hashTableItem != null)
                {
                    // Получаем элемент коллекции по ключу.
                    var item = hashTableItem.SingleOrDefault(i => i.Key == key);

                    // Если элемент коллекции найден, 
                    // то возвращаем хранимые данные.
                    if (item != null)
                    {
                        return item.Value;
                    }
                }

                // Возвращаем null если ничего найдено.
                return null;
            }

            //Hash function//
            private int GetHash(string value)
            {


                // Получаем длину строки.
                var hash = value.Length;
                return hash;
            }
        }
        void print(BNode node)
        {
            if (node == null) return;
            int i;
            for (i = 0; i <= (2 * t - 1); i++)
            {
                if (i == 0) textBox1.Text += @"\";
                if (node.keys[i] != 0)
                {
                    textBox1.Text += node.keys[i] + "";
                
                    if (i < 2 * t - 1)
                        if (node.keys[i + 1] != 0)
                            textBox1.Text += ":";
                }

                else
                {
                    textBox1.Text += @"\;";
                    break;
                }
            }
            textBox1.Text += Environment.NewLine;
            int j = 0;
            while (node.children[j] != null)
            {
                for (i = 0; i <= (2 * t - 1); i++)
                {
                    if (i == 0) textBox1.Text += @"\";
                    if (node.keys[i] != 0)
                    {
                        textBox1.Text += node.keys[i] + "";
                        
                        if (i < 2 * t - 1)
                            if (node.keys[i + 1] != 0)
                                textBox1.Text += ":";
                    }
                    else
                    {
                        textBox1.Text += "\" -> ";
                        break;
                    }
                }
                print(node.children[j]);
                j++;
            }
        }
        void pout()
            {
            textBox1.Text = "";
            textBox1.Text += for_out;
        }
        public LR2()
        {
            InitializeComponent();
        }
       
        string[] lines = File.ReadAllLines(@"LR_BINF.txt");
        HashTable Hash=new HashTable();
       
        Tree Btree;
        string[] Hash_lines = File.ReadAllLines(@"LR_HSHINF.txt");
        private void ADD_B_Click(object sender, EventArgs e)
        { string[] l_out =new string[lines.Length/7];
           l_out= Btree.zadanie(lines.Length/7);
            string[] l2_out = new string[lines.Length/7];
            for (int i = 0; i < lines.Length/7; i++)
            {
                if (l_out.Length > 2)
                {
                    char[] ot = l_out[i].ToCharArray(0, 10);
                    l2_out[i] = ot[0].ToString() + ot[1].ToString() + ot[2].ToString() + ot[3].ToString() + ot[4].ToString() + ot[5].ToString()+ot[6].ToString()+ ot[7].ToString()+ ot[8].ToString()+ ot[9].ToString();
                    for (int j =0;j<l_out.Length;j++)
                    {
                        string a = textBox1.Text;
                        if (a == l2_out[j])
                        {
                            string g = Btree.Search(j);
                            textBox1.Text = "";
                            textBox1.Text += g;
                        }
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Btree = new Tree(lines.Length / 7);
            int a = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                string data = lines[i];
                i++;
                int temper = Int32.Parse(lines[i]);
                i++;
                int volog = Int32.Parse(lines[i]);
                i++;
                string napr = lines[i];
                i++;
                string atmos = lines[i];
                i++;
                int tisk = Int32.Parse(lines[i]);
                i++;
                int opad = Int32.Parse(lines[i]);


                Btree.insert(a, data, temper, volog, napr, atmos, tisk, opad);
                a++;
            }
            for (int i = 0; i < Hash_lines.Length; i++)
            {
                int key = Int32.Parse(Hash_lines[i]);
                i++;
                string data = Hash_lines[i];
                Hash.Insert(key.ToString(), data);
            }
           
           
        }

        private void BPRINT_Click(object sender, EventArgs e)
        {
            if (Btree.root != null)
                print(Btree.root);
        }
        private void serch_Click(object sender, EventArgs e)
        {
            string g = Btree.Search(Int32.Parse(textBox1.Text));
            textBox1.Text = g;
        }
        private void zadanie_2_Click(object sender, EventArgs e)
        {
            string b="";
            int counter = 0;
            string[] l_out = new string[lines.Length / 7];
            l_out = Btree.zadanie(lines.Length / 7);
            string[] l_day_out = new string[lines.Length / 7];
            string[] l2_out = new string[lines.Length / 7];
            for (int i = 0; i < lines.Length / 7; i++)
            {
                char[] ot = l_out[i].ToCharArray(0, 10);
                l2_out[i] = ot[3].ToString() + ot[4].ToString();
                l_day_out[i] = ot[0].ToString() + ot[1].ToString();
                for (int j = 0; j < l_out.Length; j++)
                {
                    string a = textBox1.Text;
                    int c = 0;
                         if (a == l2_out[j])
                            {
                 
                    string lastWord = l_out[j].Substring(l_out[j].LastIndexOf(':') + 1);
                        int x = Int32.Parse(lastWord);
                        if (x > counter)
                        {
                            counter = x;
                            b = l_day_out[j];
                        }
                    }
                   
                }
            }
            textBox1.Text = "";
            textBox1.Text += counter.ToString()+" Is the highest Opadi in "+b+ " Day";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowHashTable(Hash, "HashTable:");
        }
        private void ShowHashTable(HashTable hashTable, string title)
        {
            textBox1.Text = "";
           

            // Выводим все имеющие пары хеш-значение
            textBox1.Text+=title+Environment.NewLine;
            foreach (var item in hashTable.Items)
            {
               
                foreach (var value in item.Value)
                {
                    textBox1.Text+=($"{value.Key} - {value.Value}");
                    textBox1.Text += Environment.NewLine;
                }
            }
            textBox1.Text+=Environment.NewLine;
        }

        private void Hsearch_Click(object sender, EventArgs e)
        {
            if (Hash.Search(textBox1.Text) != null) textBox1.Text += " FIO platnika:" + Hash.Search(textBox1.Text);
            else textBox1.Text = "NOT FOUND";
        }

        private void KRemove_Click(object sender, EventArgs e)
        {
            Btree.Remove(Int32.Parse(textBox1.Text));
        }

        private void RELH_Click(object sender, EventArgs e)
        {
            Hash.Delete(textBox1.Text);
        }

        private void aller_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            for(int i=0;i<Btree.length.Length;i++)
          {
             if(Btree.Search(Btree.length[i])!="a"&& Btree.Search(Btree.length[i]) != "0")  textBox1.Text += Btree.Search(Btree.length[i]) + Environment.NewLine ;
                
          }
        }
    }
}
