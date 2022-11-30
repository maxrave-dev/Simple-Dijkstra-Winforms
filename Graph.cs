using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dijkstra
{
    public class Vertex
    {
        public String name;
        public int status;
        public int predecessor;
        public int pathLength;
        public Vertex(String name)
        {
            this.name = name;
        }
    }

    class DirectedWeightedGraph
    {
        public readonly int MAX_VERTICES = 30;

        public int n =0;
        int e;
        public int[,] adj;
        public Vertex[] vertexList;
        private readonly int INFINITY = 9999999;
        private readonly int PERMANENT = 2;
        private readonly int TEMPORARY = 1;
        private readonly int NIL = -1;
        public List<PictureBox> listPoint = new List<PictureBox>();

        public DirectedWeightedGraph()
        {
            adj = new int[MAX_VERTICES, MAX_VERTICES];
            vertexList = new Vertex[MAX_VERTICES];
        }

        private void Dijkstra(int s)
        {
            int v, c;
            for (v = 0; v < n; v++)
            {
                vertexList[v].status = TEMPORARY;
                vertexList[v].pathLength = INFINITY;
                vertexList[v].predecessor = NIL;
            }
            vertexList[s].pathLength = 0;
            while (true)
            {
                c = TempVertexWithMinPL();
                if (c == NIL)
                    return;
                vertexList[c].status = PERMANENT;
                for (v = 0; v < n; v++)
                {
                    if (IsAdjacent(c, v) && vertexList[v].status == TEMPORARY)
                    {
                        if (vertexList[c].pathLength + adj[c, v] < vertexList[v].pathLength)
                        {
                            vertexList[v].predecessor = c;
                            vertexList[v].pathLength = vertexList[c].pathLength + adj[c, v];
                        }
                    }
                }
            }

        }

        public void FindPaths(string source, RichTextBox rtbOutput)
        {
            int s = GetIndex(source);
            Dijkstra(s);
            rtbOutput.Text = "Đỉnh nguồn : " + (Convert.ToInt32(source) + 1)  + "\r\n\n";

            for (int v = 0; v < n; v++)
            {
                if (v != s)
                {
                    rtbOutput.Text += "Đỉnh đích: " + (Convert.ToInt32(vertexList[v].name) + 1) + "\r\n";
                    if (vertexList[v].pathLength == INFINITY)
                    {
                        rtbOutput.Text += "\tKhông có đường đi \n";
                    }
                    else
                    {
                        FindPath(s, v, rtbOutput);
                    }
                }
            }
        }

        public void FindPath(int s, int v, RichTextBox rtbOutput)
        {
            int i, u;
            int[] path = new int[n];
            int sd = 0;
            int count = 0;
            while (v != s)
            {
                count++;
                path[count] = v;
                u = vertexList[v].predecessor;
                sd += adj[u, v];
                v = u;
            }

            count++;
            if (count >= n)
            {
                MessageBox.Show("Số lượng đường phải nhỏ số điểm", "Cảnh báo!");
                
            }
            path[count] = s;
            rtbOutput.Text += "\t Đường đi ngắn nhất: ";
            for (i = count; i >= 1; i--)
            {
                rtbOutput.Text += " => "+(path[i] + 1);
            }
            rtbOutput.Text += "\n\t Khoảng cách ngắn nhất: " + sd + "\n";
        }

        private int GetIndex(string s)
        {
            for (int i = 0; i < n; i++)
            {
                if (s.Equals(vertexList[i].name))
                    return i;
            }
            throw new System.InvalidOperationException("Invalid Vertex");
        }

        public void InsertVertex(string name)
        {
            vertexList[n++] = new Vertex(name);
        }
        private bool IsAdjacent(int u, int v)
        {
            return adj[u, v] != 0;
        }

        private int TempVertexWithMinPL()
        {
            int min = INFINITY;
            int x = NIL;
            for (int v = 0; v < n; v++)
            {
                if (vertexList[v].status == TEMPORARY && vertexList[v].pathLength < min)
                {
                    min = vertexList[v].pathLength;
                    x = v;
                }
            }
            return x;
        }

        public void InsertEdge(string v1, string v2, int v3)
        {
            int i = GetIndex(v1);
            int j = GetIndex(v2);
            adj[i, j] = v3;
        }



        public void DrawPoint(Graphics graph, Panel pnGraph)
        {
            int[] x = new int[n];
            int[] y = new int[n];
            Random ran = new Random();
            int j = 0;
            while (j < n)
            {
                int a = ran.Next(0, 500);
                int b = ran.Next(0, 500);
                if (x.Contains(a) && y.Contains(b))
                {
                    continue;
                }
                else
                {
                    x[j] = a;
                    y[j] = b;
                    j++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                var location = new Point(x[i], y[i]);
                PictureBox point = new PictureBox();
                point.Image = Image.FromFile(Application.StartupPath + @"\Resources\Point.png");
                point.Size = new Size(20, 20);
                point.SizeMode = PictureBoxSizeMode.StretchImage;
                point.BackColor = Color.Transparent;
                point.Location = location;
                pnGraph.Controls.Add(point);
                listPoint.Add(point);
                ToolTip toolTipPoint = new ToolTip();
                toolTipPoint.SetToolTip(point, $"Điểm thứ {Convert.ToInt32(vertexList[i].name) + 1}");
            }
        }
    }
}
