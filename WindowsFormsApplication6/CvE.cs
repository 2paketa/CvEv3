using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvEv3
{
    public partial class CvE : Form
    {
        Random Rand = new Random();
        string text = "";
        string field = "";
        string[] domain = { "Legal", "Financial", "Medical" };
        string[] legDoc = { "contracts", "bylaws", "directives" };
        string[] finDoc = { "annual reports", "balance sheets" };
        string[] medDoc = { "SPC's", "PIL's", "clinical trials" };
        public CvE()
        {
            InitializeComponent();
        }
        public string domainRandomizer()
        {
            string randomDomain = domain[Rand.Next(0, domain.Length)];
            return randomDomain;
        }
        public string docRandomizer(string[] docList)
        {
            int i = 0;
            string randomDocList = "";
            while (i < 3)
            {
                i = i + 1;
                string randomDoc = docList[Rand.Next(0, docList.Length)];
                if (randomDocList.Contains(randomDoc))
                {
                    i = i - 1;
                }
                else if (i == 1)
                {
                    randomDocList = randomDocList + " (" + randomDoc;
                }
                else
                {
                    randomDocList = randomDocList + ", " + randomDoc;
                }
            }
            randomDocList = randomDocList + ")";
            return randomDocList;
        }
        public string insDocs() // checks domain and inserts paired documents
        {
            text = domainRandomizer();
            field = text;
            Dictionary<string, string[]> CategorizeDocs = new Dictionary<string, string[]>();
            CategorizeDocs.Add(domain[0], legDoc);
            CategorizeDocs.Add(domain[1], finDoc);
            CategorizeDocs.Add(domain[2], medDoc);
            foreach (KeyValuePair<string, string[]> entry in CategorizeDocs)
            {
                if (text.Contains(entry.Key)){
                    text = (text + docRandomizer(entry.Value));
                }
            }
            return text;
        }
        public string enhanceExp()
        {
            int i = 0;
            string finalText = "";
            while (i < 3)
            {
                i = i + 1;
                string randomText = insDocs();
                if (finalText.Contains(field))
                {
                    i = i - 1;
                }
                else if (i == 1)
                {
                    finalText = finalText + randomText;
                }
                else
                    finalText = finalText + ", " + randomText;
            }
            return finalText;
        }
        public string domainSelector()
        {
            if (legCheckBox.Checked)
            {
                text = domain[0] + docRandomizer(legDoc);
            }
            else
            {
                text = enhanceExp();
            }
            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = domainSelector();
        }
    }
}
