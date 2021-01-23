using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lb_Medium.BackColor = Color.LightBlue;

            tb_Events.ScrollBars = ScrollBars.Both;
        }

        int useId = 2;

        [Serializable]
        class Evnt
        {
            public string Name { get; set; } = "";
            public string Palace { get; set; } = "";
            public DateTime dt { get; set; } = new DateTime();
            public int priority { get; set; } = 0;

            public static int Compare(Evnt ev1, Evnt ev2)
            {
                if (ev1.priority > ev2.priority)
                    return -1;

                if (ev1.priority == ev2.priority)
                    return 0;

                if (ev1.priority < ev2.priority)
                    return 1;

                return 1;
            }
        }

        [Serializable]
        class Evnt_Serializable
        {
            public List<Evnt> Events = new List<Evnt>();
            string fname = "EventsData";

            public void Add(Evnt evnt)
            {
                Events.Add(evnt);
                Events.Sort((x, y) => Evnt.Compare(x, y));
            }
            //public string Print()
            //{
            //    string text = "";
            //    foreach (var el in Events)
            //    {
            //        text += $"Name : {el.Name}\nPalce : {el.Palace}\nDate : {el.dt.ToShortDateString()}\nPrioriti : {el.priority}\n\n";
            //    }
            //    //Console.WriteLine(text);
            //    return text;
            //}
            public void Save()
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate))
                {
                    bf.Serialize(fs, Events);
                }
            }

            public void Load()
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate))
                {
                    Events = (List<Evnt>)bf.Deserialize(fs);
                }
            }
        }

        Evnt evnt = new Evnt();
        Evnt_Serializable ev_sr = new Evnt_Serializable();

        private void tb_NameEv_TextChanged(object sender, EventArgs e)
        {
             evnt.Name = tb_NameEv.Text;
        }

        private void tb_Name_Pl_TextChanged(object sender, EventArgs e)
        {
            evnt.Palace = tb_Name_Pl.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!(dateTimePicker1.Value < DateTime.Now.AddHours(-6))) 
            {
                evnt.dt = dateTimePicker1.Value;
            }
            else
            {
                MessageBox.Show("Error : invalid date", "Error", MessageBoxButtons.OK);
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void lb_High_Click(object sender, EventArgs e)
        {
            if(useId != 3)
            {
                lb_High.BackColor = Color.LightBlue;
                switch(useId)
                {
                    case 1:
                        lb_low.BackColor = Color.Silver;
                        break;
                    case 2:
                        lb_Medium.BackColor = Color.Silver;
                        break;
                }
                useId = 3;
            }
        }

        private void lb_Medium_Click(object sender, EventArgs e)
        {
            if (useId != 2)
            {
                lb_Medium.BackColor = Color.LightBlue;
                switch (useId)
                {
                    case 1:
                        lb_low.BackColor = Color.Silver;
                        break;
                    case 3:
                        lb_High.BackColor = Color.Silver;
                        break;
                }
                useId = 2;
            }
        }

        private void lb_low_Click(object sender, EventArgs e)
        {
            if (useId != 1)
            {
                lb_low.BackColor = Color.LightBlue;
                switch (useId)
                {
                    case 2:
                        lb_Medium.BackColor = Color.Silver;
                        break;
                    case 3:
                        lb_High.BackColor = Color.Silver;
                        break;
                }
                useId = 1;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (evnt.Name != "")
            {
                evnt.priority = useId;
                ev_sr.Add(evnt);

                tb_Events.Clear();
                foreach (var el in ev_sr.Events)
                {
                    tb_Events.Text +=
                        "----------" + Environment.NewLine +
                        $"Name : {el.Name}" + Environment.NewLine +
                        $"Place : {el.Palace}" + Environment.NewLine +
                        $"Date : {el.dt.ToShortDateString()}" + Environment.NewLine +
                        $"Priority : {el.priority}" + Environment.NewLine +
                        "----------" + Environment.NewLine + Environment.NewLine;
                }

                evnt = new Evnt();

                tb_NameEv.Clear();
                tb_Name_Pl.Clear();
                dateTimePicker1.Value = DateTime.Now;

            }
            else
                MessageBox.Show("Error invalid name", "Error", MessageBoxButtons.OK);

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ev_sr.Save();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            ev_sr.Load();

            foreach (var el in ev_sr.Events)
            {
                tb_Events.Text +=
                    "----------" + Environment.NewLine +
                    $"Name : {el.Name}" + Environment.NewLine +
                    $"Place : {el.Palace}" + Environment.NewLine +
                    $"Date : {el.dt.ToShortDateString()}" + Environment.NewLine +
                    $"Priority : {el.priority}" + Environment.NewLine +
                    "----------" + Environment.NewLine + Environment.NewLine;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ev_sr.Events.Clear();
            tb_Events.Clear();
            tb_NameEv.Clear();
            tb_Name_Pl.Clear();
        }
    }
}
