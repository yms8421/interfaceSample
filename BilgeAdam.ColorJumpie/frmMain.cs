using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.ColorJumpie
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Colors = new Queue<Color>();
            Colors.Enqueue(Color.Red);//Bir nevi Add, sadece queue nesnesinde var, sadece sona ekler
            Colors.Enqueue(Color.Yellow);
            Colors.Enqueue(Color.Pink);
            Colors.Enqueue(Color.Blue);
            Colors.Enqueue(Color.Green);
            Colors.Enqueue(Color.Purple);
            tmr.Interval = 80;
        }

        public Queue<Color> Colors { get; set; }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ColorizePanels();
        }

        private void ColorizePanels()
        {
            var colorList = Colors.ToList();
            foreach (var control in Controls)
            {
                if (control is Panel)
                {
                    var panel = control as Panel;
                    if (panel.Tag != null && panel.Tag.ToString() == "colorable")
                    {
                        var index = int.Parse(panel.Name.Substring(3, 1));
                        panel.BackColor = colorList[index];
                    }
                }
            }
            tmr.Start();//tmr.Enabled = true;
        }

        private void btnCEE_Click(object sender, EventArgs e)
        {
            ReorganizeColors();
        }

        private void ReorganizeColors()
        {
            var first = Colors.Dequeue(); //kuyruktan çıkar yani en öncekini çağır ve kuyruğu bir azalt
            Colors.Enqueue(first);
            ColorizePanels();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            ReorganizeColors();
        }
    }
}
