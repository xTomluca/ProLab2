using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> pruebaDictionary = new Dictionary<string, int>();
            string[] split = richTextBox1.Text.Split(' ');
            foreach(string s in split)
            {
                if (pruebaDictionary.ContainsKey(s))
                {
                    pruebaDictionary[s]++;
                }
                else
                    pruebaDictionary.Add(s, 1);
            }

            List<KeyValuePair<string, int>> auxSort = pruebaDictionary.ToList();
            auxSort.Sort(sortDictionary);
            pruebaDictionary.Clear();


            foreach(KeyValuePair<string,int> ordenado in auxSort)
            {
                pruebaDictionary.Add(ordenado.Key, ordenado.Value);
            }

            StringBuilder str = new StringBuilder();
            int desdeImprimir;
            if (pruebaDictionary.Count > 3)
                desdeImprimir = pruebaDictionary.Count - 3;
            else
                desdeImprimir = 0;
            for(int index = desdeImprimir; index < pruebaDictionary.Count; index++)
            {
                str.AppendLine(string.Format("Palabra: {0} Cantidad de veces: {1}", pruebaDictionary.ElementAt(index).Key, pruebaDictionary.ElementAt(index).Value));
            }
            MessageBox.Show(str.ToString());
        }
        public int sortDictionary(KeyValuePair<string, int> kvp1, KeyValuePair<string, int> kvp2)
        {
            if (kvp1.Value > kvp2.Value)
                return 1;
            else if (kvp1.Value < kvp2.Value)
                return -1;
            return 0;
        }
    }
}
