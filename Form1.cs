using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public int indexLast = -1;
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
            indexLast = -1;
            tbNumber.Text = "";
            g.listPoint.Clear();
            g.n = 0;
            g.pathIndex.Clear();
            pnGraph.Controls.Clear();
            pnGraph.Refresh();
            rtbOutput.Clear();
            MessageBox.Show("Bạn đã reset thành công!","Cảnh báo!");

        }
        public void DrawArrowLine(int a, int b)
        {
            Pen p = new Pen(Color.Black, 2);
            //p.CustomEndCap = new AdjustableArrowCap(5, 5);
            Point point1 = new Point(g.listPoint[a].X + 10, g.listPoint[a].Y + 10);
            Point point2 = new Point(g.listPoint[b].X + 2 , g.listPoint[b].Y + 2);
            graphic.DrawLine(p, point1, point2);
            double angle = Math.Atan2(point2.Y - point1.Y, point2.X - point1.X);
            Point point3 = new Point((int)(point2.X - 10 * Math.Cos(angle - Math.PI / 6)), (int)(point2.Y - 10 * Math.Sin(angle - Math.PI / 6)));
            Point point4 = new Point((int)(point2.X - 10 * Math.Cos(angle + Math.PI / 6)), (int)(point2.Y - 10 * Math.Sin(angle + Math.PI / 6)));
            graphic.DrawLine(p, point2, point3);
            graphic.DrawLine(p, point2, point4);
            graphic.DrawString($"{g.adj[a, b]}", new Font("Fira Code", 12), Brushes.Black, new Point((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2));
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            bool x = Int32.TryParse(tbFrom.Text, out int from);
            bool y = Int32.TryParse(tbTo.Text, out int to);
            bool z = Int32.TryParse(tbWeight.Text, out int weight);
            if (x == true && y == true && z == true && from < number + 1 && to < number+ 1)
            {
                g.InsertEdge($"{from - 1}", $"{to - 1}", weight);
                DrawArrowLine(from - 1, to - 1);
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
                g.FindPaths($"{indexFirst}",$"{indexLast}", rtbOutput);
                for (int i = 0; i < g.pathIndex.Count - 1; i++)
                {
                    DrawPathLine(i);
                }
            }
        }

        private void DrawPathLine(int i)
        {
            Pen p = new Pen(Color.Aqua, 2);
            //p.CustomEndCap = new AdjustableArrowCap(5, 5);
            Point point1 = new Point(g.pathIndex[i].X + 10, g.pathIndex[i].Y + 10);
            Point point2 = new Point(g.pathIndex[i+1].X + 2, g.pathIndex[i+1].Y + 2);
            graphic.DrawLine(p, point1, point2);
            double angle = Math.Atan2(point2.Y - point1.Y, point2.X - point1.X);
            Point point3 = new Point((int)(point2.X - 10 * Math.Cos(angle - Math.PI / 6)), (int)(point2.Y - 10 * Math.Sin(angle - Math.PI / 6)));
            Point point4 = new Point((int)(point2.X - 10 * Math.Cos(angle + Math.PI / 6)), (int)(point2.Y - 10 * Math.Sin(angle + Math.PI / 6)));
            graphic.DrawLine(p, point2, point3);
            graphic.DrawLine(p, point2, point4);
            
        }

        private void lbFirstLast_Click(object sender, EventArgs e)
        {

        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            bool x = Int32.TryParse(tbFirst.Text, out int check1);
            bool y = Int32.TryParse(tbLast.Text, out int check2);
            if (x == true && y == true && check1 < number + 1 && check2 < number +1 )
            {
                indexFirst = check1 - 1;
                indexLast = check2 - 1;
                DrawFirstLast(indexFirst, indexLast);
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void msSource_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/maxrave-dev/Simple-Dijkstra-Winforms");
        }

        private void msListMembers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Nguyễn Đức Tuấn Minh \n2. Nguyễn Thị Phương Thảo\n3. Lê Bá Kha\n4. Thân Trọng Đức", "Danh sách thành viên");
        }

        private void DrawFirstLast(int indexFirst, int indexLast)
        {
            SolidBrush brushFirst = new SolidBrush(Color.LawnGreen);
            SolidBrush brushLast = new SolidBrush(Color.Red);
            Brush pointName = new SolidBrush(Color.White);
            Point firstPoint = g.listPoint[indexFirst];
            Point lastPoint = g.listPoint[indexLast];
            Graphics graph = pnGraph.CreateGraphics();
            graph.FillEllipse(brushFirst, firstPoint.X, firstPoint.Y, 20, 20);
            graph.FillEllipse(brushLast, lastPoint.X, lastPoint.Y, 20, 20);
            graph.DrawString($"{indexFirst + 1}", new Font("Fira Code", 8), pointName, firstPoint.X + 3, firstPoint.Y + 3);
            graph.DrawString($"{indexLast + 1}", new Font("Fira Code", 8), pointName, lastPoint.X + 3, lastPoint.Y + 3);
        }
    }
}
