using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lab03
{

    public partial class Form1 : Form
    {
        private Graphics g;
        private int width;
        private int height;
        private Point[] polyg;
        private Matrix funcMatrix;

        public Form1()
        {
            InitializeComponent();

            var data = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            funcMatrix = new Matrix(3, 3);
            funcMatrix.SetData(data);
            width = pictureBox1.Width;
            height = pictureBox1.Height;
            pictureBox1.Image = new Bitmap(width, height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            //g.ScaleTransform(1, -1);
            pictureBox1.Invalidate();
            ResetPoints();
            ResetFlags();
            WuLine(width / 2, 0, width / 2, height - 1, Color.Black);
            WuLine(0, height / 2, width - 1, height / 2, Color.Black);
        }

        private void ResetFlags()
        {
            line = false;
            polygon = false;
            scale = false;
            rotate = false;
            find = false;
            point = false;
            checkSide = false;
            nonConvex = false;
            convex = false;
            //number = true;
        }

        private void ResetPoints()
        {   
            points = new Point[100];
            pointsSet = new bool[100];
            for (int i = 0; i < points.Length; i++)
            {
                pointsSet[i] = false;
                points[i] = new Point(-1, -1);
            }
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            ResetPoints();
            ResetFlags();
            hint.Visible = true;
            if (!point)
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;            
            point = !point;
        }

        private bool line;
        private bool polygon;
        private bool point;
        private Point[] points;
        private bool[] pointsSet;
        private Point[] points1;
        private Point[] points2;
        private bool number = true;
        private void lineButton_Click(object sender, EventArgs e)
        {
            var flag = find;
            ResetPoints();
            ResetFlags();
            hint.Visible = true;
            if (!line)
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
            line = !line;
            if (flag)
                find = flag;           
        }

        private void polygonButton_Click(object sender, EventArgs e)
        {
            ResetPoints();
            ResetFlags();
            hint.Visible = true;
            if (!polygon)
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;            
            polygon = !polygon;            
            drawPolygonButton.Visible = true;
        }

        // НАЖАТИЯ НА ЭКРАН
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = -1;
            for (int i = pointsSet.Length - 1; i > -1; i--)
                if (pointsSet[i])
                {
                    index = i;
                    break;
                }

            if (convex)
            {
                convex = false;
                this.Cursor = Cursors.Default;               
                DrawPoint(e.X, e.Y, 2);
                convexLabel.Text = InsideConvex(e.X, e.Y).ToString();
                pictureBox1.Invalidate();
            }
            else if (nonConvex)
            {
                nonConvex = false;                
                this.Cursor = Cursors.Default;
                DrawPoint(e.X, e.Y, 2);
                nonConvexLabel.Text = InsideNonConvex(e.X, e.Y).ToString();
                pictureBox1.Invalidate();
            }
            else if (checkSide)
            {
                var left = CheckSide(e.X, e.Y);
                if (left)
                    checkSideTextBox.Text = "LEFT";
                else
                    checkSideTextBox.Text = "RIGHT";
                DrawPoint(e.X, e.Y, 2);                
                this.Cursor = Cursors.Default;
                //ResetPoints();
                //ResetFlags();
            }
            else if (scale)
            {
                scale = false;
                this.Cursor = Cursors.Default;
                var kx = 0.0;
                var ky = 0.0;
                pointXTextBox.Text = e.X.ToString();
                pointYTextBox.Text = e.Y.ToString();
                double.TryParse(scaleKXTextBox.Text, out kx);
                double.TryParse(scaleKYTextBox.Text, out ky);
                Scale(e.X, e.Y, kx, ky);
                DrawPolygon();                
            }
            else if (rotate)
            {
                rotate = false;
                this.Cursor = Cursors.Default;
                var phi = 0.0;                
                pointXTextBox.Text = e.X.ToString();
                pointYTextBox.Text = e.Y.ToString();
                double.TryParse(rotatePhiTextBox.Text, out phi);
                Rotate(e.X, e.Y, phi);
                DrawPolygon();                
            }
            else if (index > 1)
            {
                pointsSet[index] = false;
                pointsSet[index + 1] = true;
                points[index + 1] = new Point(e.X, e.Y);
            }
            else if (pointsSet[1])
            {

                pointsSet[1] = false;
                pointsSet[2] = true;
                points[2] = new Point(e.X, e.Y);
               

            }
            else if (pointsSet[0])
            {
                pointsSet[0] = false;
                pointsSet[1] = true;
                points[1] = new Point(e.X, e.Y);
                if (line)
                {
                    WuLine(points[0].X, points[0].Y, points[1].X, points[1].Y, Color.Black);
                    this.Cursor = Cursors.Default;
                    if (!find)
                        p2 = points[1];                    
                    pictureBox1.Invalidate();
                    if (find)
                    {
                        var p = FindIntersection();                        
                        DrawPoint(p.X, p.Y, 3);
                        DrawAdditionalLines(p);                        
                        ResetPoints();
                        ResetFlags();
                    }
                    line = false;                    
                    hint.Visible = false;
                }
            }
            else if (line)
            {
                pointsSet[0] = true;
                points[0] = new Point(e.X, e.Y);               
                if(!find)                
                    p1 = points[0];       
            }
            else if (point)
            {
                pointsSet[0] = true;
                points[0] = new Point(e.X, e.Y);
                DrawPoint(points[0].X, points[0].Y, 3);                
                this.Cursor = Cursors.Default;
                point = false;                
                hint.Visible = false;
            }
            else if (polygon)
            {
                pointsSet[0] = true;
                points[0] = new Point(e.X, e.Y);
   
            }
            pictureBox1.Invalidate();
        }

        //Рисование линии
        private void WuLine(int x0, int y0, int x1, int y1, Color clr)
        {
            polyg = new Point[2];
            polyg[0] = new Point(x0, y0);
            polyg[1] = new Point(x1, y1);

            var steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep)
            {
                var t = x0;
                x0 = y0;
                y0 = t;
                t = x1;
                x1 = y1;
                y1 = t;
            }
            if (x0 > x1)
            {
                var t = x0;
                x0 = x1;
                x1 = t;
                t = y0;
                y0 = y1;
                y1 = t;
            }
            DrawWUPoint(steep, x0, y0, 1, clr);
            DrawWUPoint(steep, x1, y1, 1, clr);
            float dx = x1 - x0;
            float dy = y1 - y0;
            float gradient = dy / dx;
            float y = y0 + gradient;
            for (var x = x0 + 1; x <= x1 - 1; x++)
            {
                DrawWUPoint(steep, x, (int)y, 1 - (y - (int)y), clr);
                DrawWUPoint(steep, x, (int)y + 1, y - (int)y, clr);
                y += gradient;
            }
        }
        private void DrawWUPoint(bool flag, int x, int y, double a, Color clr)
        {
            if (flag)
            {
                var t = x;
                x = y;
                y = t;
            }
            if (x < width-1 && x > 0 && y < height-1 && y > 0)
                (pictureBox1.Image as Bitmap).SetPixel(x, y, Color.FromArgb((int)(a * 255), clr));
        }

        private void DrawPoint(int x, int y, int size)
        {
            polyg = new Point[1];
            polyg[0] = new Point(x, y);
            for (int i = x - size; i <= x + size; i++)
                for (int j = y - size; j <= y + size; j++)
                    if (i >= 0 && i <= pictureBox1.Width)
                        if (j >= 0 && j <= pictureBox1.Height)
                        {
                            (pictureBox1.Image as Bitmap).SetPixel(i, j, Color.Black);
                            pictureBox1.Invalidate();
                        }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            dxTextBox.Text = 0.ToString();
            dyTextBox.Text = 0.ToString();            
            pointXTextBox.Text = 0.ToString();
            pointYTextBox.Text = 0.ToString();
            scaleKXTextBox.Text = 1.ToString();
            scaleKYTextBox.Text = 1.ToString();
            checkSideTextBox.Visible = false;
            WuLine(width / 2, 0, width / 2, height - 1, Color.Black);
            WuLine(0, height / 2, width - 1, height / 2, Color.Black);
            pictureBox1.Invalidate();
            ResetPoints();
            ResetFlags();
        }
        private void drawPolygonButton_Click(object sender, EventArgs e)
        {
            hint.Visible = false;
            polygon = false;
            drawPolygonButton.Visible = false;
            this.Cursor = Cursors.Default;
            polyg = new Point[100];
            DrawPolygon();
            pictureBox1.Invalidate();
            //ResetPoints();
        }

        private void DrawPolygon()
        {
            int i = 0;
            while (!pointsSet[i++])
            {
                WuLine(points[i - 1].X, points[i - 1].Y, points[i].X, points[i].Y, Color.Black);
               
            }
            WuLine(points[i - 1].X, points[i - 1].Y, points[0].X, points[0].Y, Color.Black);

            if (number == false)
            {
                //button1.Text = "" + number + "2q";
                points2 = points;
                for (int j = 0; i < points1.Length - 1; i++)
                {
                    for (int c = 0; c < points2.Length - 1; c++)
                    {
                        IndivFindIntersection(points1[j], points1[j + 1], points2[c], points2[c + 1]);
                       //  button1.Text = "x == " + IndivFindIntersection(points1[j], points1[j + 1], points2[c], points2[c + 1]).X + "y  = " + IndivFindIntersection(points1[j], points1[j + 1], points2[c], points2[c + 1]).Y;
                    }
                }
                
            }
            if (number == true)
            {
                points1 = points;
               // button1.Text = "" + number + "1q";
                number = false;
            }
            

        }

        private void dxdyButton_Click(object sender, EventArgs e)
        {
            double dx = 0;
            double.TryParse(dxTextBox.Text, out dx);
            double dy = 0;
            double.TryParse(dyTextBox.Text, out dy);
            var dxdyMatrix = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { dx,-dy, 1 } };
            funcMatrix.SetData(dxdyMatrix);
            AlgorithWithMatrix();
            DrawPolygon();
            pictureBox1.Invalidate();
        }

        private Point GetPolygonCenter()
        {            
            int i = 0;
            var sumX = 0;
            var sumY = 0;
            var count = 0;
            while (!pointsSet[i++])
            {
                sumX += points[i - 1].X;
                sumY += points[i - 1].Y;
                count++;
            }
            sumX += points[i - 1].X;
            sumY += points[i - 1].Y;
            count++;
            return new Point(sumX/count, sumY/count);
        }

        private bool scale = false;

        private void AlgorithWithMatrix()
        {
            int i = 0;
            while (!pointsSet[i++])
            {
                var pointMatr1 = new Matrix(1, 3);
                var pointMatrData1 = new double[1, 3];
                pointMatrData1[0, 0] = points[i - 1].X;
                pointMatrData1[0, 1] = points[i - 1].Y;
                pointMatrData1[0, 2] = 1;
                pointMatr1.SetData(pointMatrData1);
                var res1 = pointMatr1.Mult(funcMatrix);
                points[i - 1] = new Point((int)res1.GetElem(0, 0), (int)res1.GetElem(0, 1));
            }
            var pointMatr = new Matrix(1, 3);
            var pointMatrData = new double[1, 3];
            pointMatrData[0, 0] = points[i - 1].X;
            pointMatrData[0, 1] = points[i - 1].Y;
            pointMatrData[0, 2] = 1;
            pointMatr.SetData(pointMatrData);
            var res = pointMatr.Mult(funcMatrix);
            points[i - 1] = new Point((int)res.GetElem(0, 0), (int)res.GetElem(0, 1));
        }

        private void Scale(int x, int y, double kx, double ky)
        {
            var dilatationMatrix = new double[3, 3] { { kx, 0, 0 }, { 0, ky, 0 }, { (1-kx)*x, (1-ky)*y, 1 } };
            funcMatrix.SetData(dilatationMatrix);
            AlgorithWithMatrix();
            DrawPolygon();
            pictureBox1.Invalidate();
        }

        private void scaleButton_Click(object sender, EventArgs e)
        {
            if (clickRB.Checked)
            {
                hint.Visible = true;
                if (!scale)
                    this.Cursor = Cursors.Hand;
                else
                    this.Cursor = Cursors.Default;
                scale = !scale;
                line = false;
                rotate = false;
                polygon = false;
                point = false;
            }
            else 
            {
                var p = GetPolygonCenter();
                var kx = 0.0;
                var ky = 0.0;                
                double.TryParse(scaleKXTextBox.Text, out kx);
                double.TryParse(scaleKYTextBox.Text, out ky);
                Scale(p.X, p.Y, kx, ky);
                DrawPolygon();
            }
        }

        private void centerRB_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            pointXTextBox.Visible = false;
            pointYTextBox.Visible = false;                      

            clickRB.Checked = false;
            centerRB.Checked = true;
        }

        private void clickRB_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;            
            pointXTextBox.Visible = true;
            pointYTextBox.Visible = true;

            centerRB.Checked = false;
            clickRB.Checked = true;
        }

        private bool rotate = false;

        private void Rotate(int x, int y, double phi)
        {
            var ang = phi * Math.PI / 180;
            var sin = Math.Sin(ang);
            var cos = Math.Cos(ang);
            var t1 = -x * cos + y * sin + x;
            var t2 = -x * sin - y * cos + y;
            var dilatationMatrix = new double[3, 3] { { cos, sin, 0 }, { -sin, cos, 0 }, { t1, t2, 1 } };
            funcMatrix.SetData(dilatationMatrix);
            AlgorithWithMatrix();
            if (!find)
            {
                DrawPolygon();
                pictureBox1.Invalidate();
            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (clickRB.Checked)
            {
                hint.Visible = true;
                if (!rotate)
                    this.Cursor = Cursors.Hand;
                else
                    this.Cursor = Cursors.Default;
                rotate = !rotate;
                scale = false;
                line = false;
                polygon = false;
                point = false;                             
            }
            else
            {
                var p = GetPolygonCenter();
                var phi = 0.0;                
                double.TryParse(rotatePhiTextBox.Text, out phi);                 
                Rotate(p.X, p.Y, phi);
                DrawPolygon();                
            }
        }

        private void rotateLineButton_Click(object sender, EventArgs e)
        {
            if (pointsSet[1])
            {
                var pi = 180;
                var a = points[0];
                var b = points[1];
                //for (int i = 0; i < 360; i++)                
                Rotate((a.X + b.X)/2, (a.Y+b.Y)/2,pi/2);                
            }
            
        }

       

        // рисует дополнительные линии после нахождения точки пересечения
        private void DrawAdditionalLines(Point p)
        {
            if (p1.X > p2.X)
            {
                var t = p1;
                p1 = p2;
                p2 = t;
            }

            var p3 = points[0];
            var p4 = points[1];

            if (p3.X > p4.X)
            {
                var t = p3;
                p3 = p4;
                p4 = t;
            }            

            if (p.X < p1.X)
                WuLine(p.X, p.Y, p1.X, p1.Y, Color.Red);
            else if (p.X > p2.X)
                WuLine(p.X, p.Y, p2.X, p2.Y, Color.Red);

            if (p.X < p3.X)
                WuLine(p.X, p.Y, p3.X, p3.Y, Color.Red);
            else if (p.X > p4.X)
                WuLine(p.X, p.Y, p4.X, p4.Y, Color.Red);            
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (pointsSet[1])
            {
                find = !find;
                lineButton_Click(sender, e);
                //hint.Text = "!!!!!!!!";
            }
        }

        private bool checkSide = false;

        private bool CheckSide(int x, int y) // left
        {
            var v1 = new Vector(p2, p1);
            var v2 = new Vector(new Point(x,y), p1);
            var res = v2.GetY() * v1.GetX() - v2.GetX() * v1.GetY();
            return res < 0;
        }

        private void checkSideButton_Click(object sender, EventArgs e)
        {
            if (pointsSet[1])
            {
                if (!checkSide)
                    this.Cursor = Cursors.Hand;
                else
                    this.Cursor = Cursors.Default;
                checkSideTextBox.Visible = true;
                checkSide = !checkSide;                             
            }
        }

        private void checkSideTextBox_Click(object sender, EventArgs e)
        {

        }


        private bool convex = false;
        private void convexButton_Click(object sender, EventArgs e)
        {
            ResetFlags();
            if (!convex)
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
            convex = !convex;
            hint.Visible = true;
        }

        private bool InsideConvex(int x, int y)
        {
            int i = 0;
            p1 = points[i];
            p2 = points[i+1];
            var prev = CheckSide(x, y);
            var result = true;
            while (!pointsSet[i++])      
            {
                if (!result)
                    return false;
                p1 = points[i - 1];
                p2 = points[i];
                var cur = CheckSide(x, y);
                result = (prev == cur);
                prev = cur;
            }
            p1 = points[i - 1];
            p2 = points[0];
            result = (prev == CheckSide(x, y));
            return result;            
        }

        private bool InsideNonConvex(int x, int y)
        {
            int count = 0;
            int count1 = 1;
            int i = 0;
            while (!pointsSet[i++])
            {
                p1 = points[i-1];
                p2 = points[i];
                if ((Math.Min(p1.X, p2.X) >= x) || (Math.Min(p1.X, p2.X) <= x && Math.Max(p1.X, p2.X) >= x))
                {
                    if (y >= Math.Min(p1.Y, p2.Y) && y < Math.Max(p1.Y, p2.Y) && !(p1.Y == p2.Y))
                    {
                        if (p1.Y > p2.Y)
                        {
                            var t = p1;
                            p1 = p2;
                            p2 = t;
                        }
                        var left = !CheckSide(x, y);
                        if (left)
                            count++;
                    }
                }                
            }
            p1 = points[i - 1];
            p2 = points[0];
            if ((Math.Min(p1.X, p2.X) >= x) || (Math.Min(p1.X, p2.X) <= x && Math.Max(p1.X, p2.X) >= x))
            {
                if (y >= Math.Min(p1.Y, p2.Y) && y < Math.Max(p1.Y, p2.Y) && !(p1.Y == p2.Y))
                {
                    if (p1.Y > p2.Y)
                    {
                        var t = p1;
                        p1 = p2;
                        p2 = t;
                    }
                    var left = !CheckSide(x, y);
                    if (left)
                        count++;
                }
            }
            count1++;        
            return (count % 2 == 1);
        }

        private bool nonConvex = false;
        private void nonConvexButton_Click(object sender, EventArgs e)
        {
            ResetFlags();
            if (!nonConvex)
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
            nonConvex = !nonConvex;
            hint.Visible = true;
        }

        double rotateAngle = 0;
        double angle = 0;
        string inputString = "";
        string[] rules = new string[6];
        double x1 = 200;
        double y1 = 800;
        int C = 0;
        double tempAngle = 0;
        

        private void Risovat(string seks, double x1, double y1, double angle)
        {
            Console.WriteLine("ВЫЗВАЛАСЬ ФУНКЦИЯ");
            Random rnd = new Random();
            double r = rnd.Next(5);
            g = Graphics.FromImage(pictureBox1.Image);
            Pen pen = new Pen(Color.Black, 1);
            double x2 = 0;
            double y2 = 0;
            Stack<Point> stack = new Stack<Point>();
            Point p1 = new Point((int)x1, (int)y1);
            Point p2 = new Point((int)x2, (int)y2);
            for (int i = 0; i < seks.Length; i++)
            {
                r = rnd.Next(5);
                char x = seks[i];
                x2 = (x1 + Math.Cos(angle * Math.PI / 180) * 50);
                y2 = (y1 + Math.Sin(angle * Math.PI / 180) * 50);
                if (x == 'F')
                {
                    p1 = new Point((int)x1, (int)y1);
                    p2 = new Point((int)x2, (int)y2);

                    g.DrawLine(pen, p1, p2);
                    x1 = x2;
                    y1 = y2;
                }
                if (x == '−')
                {
                    angle -= rotateAngle;
                   
                }
                if (x == '+')
                {
                    angle += rotateAngle;
                    
                }
                if (x == '[')
                {
                    int skob = 0;
                    string sub = seks.Substring(i);
                    Console.Write(sub.Length); Console.WriteLine(sub);
                   
                    for (int f = 0; f < sub.Length; f++)
                    {
                        if(sub[f] == '[')
                        {
                            skob = skob + 1;
                        }
                        if(sub[f] == ']')
                        {
                            skob = skob - 1;
                        }
                        if (skob == 0)
                        {
                            sub = sub.Substring(1,f-1);
                            Console.Write(sub.Length); Console.Write("SuB v risovat"); Console.WriteLine(sub);
                           // Console.Write("f"); Console.WriteLine(f);
                            i = i + f;
                            tempAngle = angle;
                            Risovat(sub, x1, y1, angle);
                            
                            angle = tempAngle;
                            break;
                        }
                        //Console.WriteLine(skob);
                    }
                }
                angle = angle % 360;
            }
        }

       

      

        private void kazel()
        {
            using (StreamReader sr = new StreamReader("koust2.txt"))
            {
                string[] lines = new string[6];
                string line;
                int numb = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (numb >= 1)
                    {
                        rules[numb] = line.Substring(3);
                    }
                    lines[numb] = line;
                    numb++;
                }
                lines = lines[0].Split(' ');
                inputString = lines[0];
                Double.TryParse(lines[1], out angle);
                Double.TryParse(lines[2], out rotateAngle);
            }
        }
        private string seks(int iterations)
        {
            kazel();
            string newStr = "";
            for (int i = 1; i < iterations+1; i++)
            {
                foreach (char x in inputString) 
                {
                    if (x == 'F')
                    {
                        newStr += rules[1];
                    }
                    if (x == 'X')
                    {
                        newStr += rules[2];
                    }
                    if (x == 'Y')
                    {
                        newStr += rules[3];
                    }
                    if((x == '+')||(x == '−')||(x == '[')||(x == ']'))
                    {
                        newStr += x;
                    }
                }
                inputString = newStr;
                //Console.WriteLine(newStr);
                newStr = "";
                //inputString = inputString.Replace("F", rules[1]);
                //inputString = inputString.Replace("X", rules[2]);
                //inputString = inputString.Replace("Y", rules[3]);
            }
            return inputString;
        }

        private bool find = false;
        Point p1;
        Point p2;

        private Vector FindNormalVector(Point p1, Point p2)
        {
            // A * X + B * Y + C = 0;
            // (y2-y1)*x + (x1-x2) * y + C = 0;
            return new Vector(p2.Y - p1.Y, p1.X - p2.X);
        }

        private Point FindIntersection()
        {
            var p3 = points[0];
            var p4 = points[1];
            var n = FindNormalVector(p3, p4);
            var ba = new Vector(p2.X - p1.X, p2.Y - p1.Y);
            var ac = new Vector(p1.X - p3.X, p1.Y - p3.Y);
            var t = -1 * (n * ac / (n * ba));
            return new Point(((int)((1 - t) * p1.X + t * p2.X)), (int)((1 - t) * p1.Y + t * p2.Y));
        }
        double resX;
        double resY;
        bool crossau;
        private void button1_Click(object sender, EventArgs e)
        {
            var p1 = new Point(1, 1);
            var p2 = new Point(4, 1);
            var p3 = new Point(0, 0);
            var p4 = new Point(4, 4);
            IndivFindIntersection(p1,p2,p3,p4);
            button1.Text ="X == " + resX + " Y == " + resY + "cross == " + crossau;

        }
        private Point IndivFindIntersection(Point p1, Point p2, Point p3, Point p4)
        {
          
            crossau = checkIntersectionOfTwoLineSegments(p1, p2, p3, p4);
            button1.Text = "" + crossau;
            if (crossau)
            {
                var n = FindNormalVector(p3, p4);
                var ba = new Vector(p2.X - p1.X, p2.Y - p1.Y);
                var ac = new Vector(p1.X - p3.X, p1.Y - p3.Y);
                var t = -1 * (n * ac / (n * ba));
                Point resultat = new Point(((int)((1 - t) * p1.X + t * p2.X)), (int)((1 - t) * p1.Y + t * p2.Y));
                resX = resultat.X;
                resY = resultat.Y;
                DrawPoint(resultat.X, resultat.Y, 2);
                return resultat;
            }
            else
            {
                //DrawPoint(p1.X, p1.Y, 7);
                return new Point(1000, 1000);
                
            }
        }


        //метод, проверяющий пересекаются ли 2 отрезка [p1, p2] и [p3, p4]

        private bool checkIntersectionOfTwoLineSegments(Point p1, Point p2, Point p3, Point p4)
        {

            //сначала расставим точки по порядку, т.е. чтобы было p1.x <= p2.x

            if (p2.X < p1.X)
            {

                Point tmp = p1;

                p1 = p2;

                p2 = tmp;

            }

            //и p3.x <= p4.x

            if (p4.X < p3.X)
            {

                Point tmp = p3;

                p3 = p4;

                p4 = tmp;

            }

            //проверим существование потенциального интервала для точки пересечения отрезков

            if (p2.X < p3.X)
            {

                return false; //ибо у отрезков нету взаимной абсциссы

            }

            //если оба отрезка вертикальные

            if ((p1.X - p2.X == 0) && (p3.X - p4.X == 0))
            {

                //если они лежат на одном X

                if (p1.X == p3.X)
                {

                    //проверим пересекаются ли они, т.е. есть ли у них общий Y

                    //для этого возьмём отрицание от случая, когда они НЕ пересекаются

                    if (!((Math.Max(p1.Y, p2.Y) < Math.Min(p3.Y, p4.Y)) ||

                    (Math.Min(p1.Y, p2.Y) > Math.Max(p3.Y, p4.Y))))
                    {

                        return true;

                    }

                }

                return false;

            }

            //найдём коэффициенты уравнений, содержащих отрезки

            //f1(x) = A1*x + b1 = y

            //f2(x) = A2*x + b2 = y

            //если первый отрезок вертикальный

            if (p1.X - p2.X == 0)
            {

                //найдём Xa, Ya - точки пересечения двух прямых

                double sXa = p1.X;

                double sA2 = (p3.Y - p4.Y) / (p3.X - p4.X);

                double sb2 = p3.Y - sA2 * p3.X;

                double Ya = sA2 * sXa + sb2;

                if (p3.X <= sXa && p4.X >= sXa && Math.Min(p1.Y, p2.Y) <= Ya &&

                Math.Max(p1.Y, p2.Y) >= Ya)
                {

                    return true;

                }

                return false;

            }

            //если второй отрезок вертикальный

            if (p3.X - p4.X == 0)
            {

                //найдём Xa, Ya - точки пересечения двух прямых

                double sXa = p3.X;

                double sA1 = (p1.Y - p2.Y) / (p1.X - p2.X);

                double sb1 = p1.Y - sA1 * p1.X;

                double Ya = sA1 * sXa + sb1;

                if (p1.X <= sXa && p2.X >= sXa && Math.Min(p3.Y, p4.Y) <= Ya &&

                Math.Max(p3.Y, p4.Y) >= Ya)
                {

                    return true;

                }

                return false;

            }

            //оба отрезка невертикальные

            double A1 = (p1.Y - p2.Y) / (p1.X - p2.X);

            double A2 = (p3.Y - p4.Y) / (p3.X - p4.X);

            double b1 = p1.Y - A1 * p1.X;

            double b2 = p3.Y - A2 * p3.X;

            if (A1 == A2)
            {

                return false; //отрезки параллельны

            }

            //Xa - абсцисса точки пересечения двух прямых

            double Xa = (b2 - b1) / (A1 - A2);

            if ((Xa < Math.Max(p1.X, p3.X)) || (Xa > Math.Min(p2.X, p4.X)))
            {

                return false; //точка Xa находится вне пересечения проекций отрезков на ось X

            }

            else
            {

                return true;

            }

        }



       
    }

  
}
