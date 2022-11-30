using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace dijkstra
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900,
                MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200,
                MaterialSkin.TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphic = pnGraph.CreateGraphics();
            rtbOutput.Font = new Font("Fira Code", 12);
        }

        private void tbNumber_Click(object sender, EventArgs e)
        {
            
        }

        private int number = 0; 
        public int indexFirst = -1;
        DirectedWeightedGraph g = new DirectedWeightedGraph();
        private Graphics graphic;
        private void Dijkstra_Core()
        {
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            bool x = Int32.TryParse(tbNumber.Text, out int check1);
            if (number == 0 && tbNumber.Text != "Nhập số điểm" && x == true)
            {
                number = check1;
                for (int i = 0; i < number; i++)
                {
                    g.InsertVertex($"{i}");
                }
                Graphics graph = pnGraph.CreateGraphics();
                g.DrawPoint(graph, pnGraph);
                MessageBox.Show("Bạn đã nhập số điểm và đường thành công!","Cảnh báo!");
            }
            else if (number != 0 && x == true )
            {
                MessageBox.Show($"Số điểm đã set về {number}, mời bạn nhấn nút Reset để đặt lại", "Cảnh báo!");
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai định dạng, mời bạn nhập lại!", "Cảnh báo!");
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            number = 0;
            indexFirst = -1;
            tbNumber.Text = "";
            g.listPoint.Clear();
            g.n = 0;
            pnGraph.Controls.Clear();
            pnGraph.Refresh();
            rtbOutput.Clear();
            MessageBox.Show("Bạn đã reset thành công!","Cảnh báo!");

        }
        public void DrawArrowLine(int a, int b, Graphics graphic)
        {
            Pen p = new Pen(Color.Black, 2);
            //p.CustomEndCap = new AdjustableArrowCap(5, 5);
            Point point1 = new Point(g.listPoint[a].Location.X + 10, g.listPoint[a].Location.Y + 10);
            Point point2 = new Point(g.listPoint[b].Location.X + 2 , g.listPoint[b].Location.Y + 2);
            graphic.DrawLine(p, point1, point2);
            double angle = Math.Atan2(point2.Y - point1.Y, point2.X - point1.X);
            Point point3 = new Point((int)(point2.X - 10 * Math.Cos(angle - Math.PI / 6)), (int)(point2.Y - 10 * Math.Sin(angle - Math.PI / 6)));
            Point point4 = new Point((int)(point2.X - 10 * Math.Cos(angle + Math.PI / 6)), (int)(point2.Y - 10 * Math.Sin(angle + Math.PI / 6)));
            graphic = pnGraph.CreateGraphics();
            graphic.DrawLine(p, point2, point3);
            graphic.DrawLine(p, point2, point4);
            graphic.DrawString($"{g.adj[a, b]}", new Font("Fira Code", 12), Brushes.Black, new Point((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2));
            graphic.Dispose();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            bool x = Int32.TryParse(tbFrom.Text, out int from);
            bool y = Int32.TryParse(tbTo.Text, out int to);
            bool z = Int32.TryParse(tbWeight.Text, out int weight);
            if (x == true && y == true && z == true && from < number + 1 && to < number+ 1)
            {
                g.InsertEdge($"{from - 1}", $"{to - 1}", weight);
                DrawArrowLine(from - 1, to - 1, graphic);
                MessageBox.Show("Bạn đã thêm đường thành công!", "Cảnh báo!");
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai định dạng, mời bạn nhập lại!", "Cảnh báo!");
            }
        }

        private void pnGraph_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btRun_Click(object sender, EventArgs e)
        {
            if (indexFirst == -1)
            {
                MessageBox.Show("Bạn chưa chọn điểm bắt đầu!", "Cảnh báo!");
            }
            else
            {
                g.FindPaths($"{indexFirst}", rtbOutput);
                for (int i = 0; i< g.road.Length; i++)
                {
                    if (i != indexFirst)
                    {
                        rtbOutput.Text += g.road[i];
                        rtbOutput.Text += g.pathCheck[i];
                    }
                }
            }
        }

        private void lbFirstLast_Click(object sender, EventArgs e)
        {

        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            bool x = Int32.TryParse(tbFirst.Text, out int check1);
            if (x == true && check1 < number + 1)
            {
                indexFirst = check1 - 1;
                MessageBox.Show("Bạn đã chọn điểm bắt đầu thành công!", "Cảnh báo!");
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai định dạng, mời bạn nhập lại!", "Cảnh báo!");
            }
        }

        private void rtbOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
