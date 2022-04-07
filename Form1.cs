using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serelization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        [Serializable]
        public class Person
        {
            public string Name;
            public int Age;
            public bool isDead;
            public Person(string name, int age, bool dead)
            {
                this.Name = name;
                this.Age = age;
                this.isDead = dead;
            }
        }
        private void Serelizebtn_Click(object sender, EventArgs e)
        {
            Person p = new Person(NameTxt.Text, int.Parse(AgeTxt.Text), bool.Parse(DeadTxt.Text));
            using(Stream stream = new FileStream("Serelize.txt", FileMode.Create))
            {
                IFormatter content = new BinaryFormatter();
                content.Serialize(stream, p);
            }
            NameTxt.Clear();
            AgeTxt.Clear();
            DeadTxt.Clear();
        }

        private void DeserelizeBtn_Click(object sender, EventArgs e)
        {
            Person p2;
            using (Stream stream = new FileStream("Serelize.txt", FileMode.Open))
            {
                IFormatter content = new BinaryFormatter();
                p2 = content.Deserialize(stream) as Person;
            }
            NameTxt.Text = p2.Name;
            AgeTxt.Text = p2.Age.ToString();
            DeadTxt.Text = p2.isDead.ToString();

        }
    }
}
