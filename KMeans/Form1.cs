using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMeans
{
    public partial class Form1 : Form
    {
        List<int[]> dataPoints = new List<int[]>();
        List<int[]> centroidList = new List<int[]>();
        List<int> clusters = new List<int>();

        int centroids;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            button_Set.Enabled = false;
        }

        private void DrawPoints(int x,int y) {
            Brush aBrush = (Brush)Brushes.Black;
            Graphics g = panel1.CreateGraphics();
            g.FillEllipse(aBrush, x, y, 10, 10);
            
        }

        private void DrawCentroids(int x, int y)
        {
            Brush aBrush = (Brush)Brushes.Red;
            Graphics g = panel1.CreateGraphics();
            g.FillEllipse(aBrush, x, y, 10, 10);
        }

        private void DisplayInitialPoints()
        {
            foreach (int[] data in dataPoints)
            {
                int x = data[0];
                int y = data[1];
                DrawPoints(x, y);

                if (!validate(x, y))
                {
                    MessageBox.Show("Points exceeds the limits of the panel!", "Panel is not enough!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            GenarateInitialCentroids(int.Parse(textBox_Centroids.Text.Trim()));
        }

        private void Itterate()
        {
            List<int[]> oldCentroids = new List<int[]>();
            foreach(int[] cent in centroidList)
            {
                int x = cent[0];
                int y = cent[1];
                int[] item = { x, y };
                oldCentroids.Add(item);
            }
            ClearPanel();
            Clustering();            
            UpdateCluster();

            foreach (int[] data in dataPoints)
            {
                int x = data[0];
                int y = data[1];
                DrawPoints(x, y);
                
            }
            

           foreach (int[] centroid in centroidList)
            {
                int x = centroid[0];
                int y = centroid[1];
                DrawCentroids(x, y);
         
            }
            if (isFinished(oldCentroids, centroidList))
            {
                MessageBox.Show("No Itterations needed!", "No Itterations needed!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            
        }

        private void Clustering()
        {
            clusters = new List<int>();
            foreach (int[] datapoint in dataPoints)
            {                
                int x1 = datapoint[0];
                int y1 = datapoint[1];
                List<double> temp = new List<double>();

                foreach (int[] centroid in centroidList)
                {
                    int x2 = centroid[0];
                    int y2 = centroid[1];
                    double dst = Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2);
                    temp.Add(dst);
                    
                }
                int minIndex = temp.IndexOf(temp.Min());
                clusters.Add(minIndex);
                
            }
 

        }

        private void UpdateCluster()
        {
            
            int count = 0;
            foreach(int[] centroid in centroidList)
            {
                List<int[]> myDataset = new List<int[]>();
                int i = 0;
                foreach(int c in clusters)
                {
                    if(c == count)
                    {
                        myDataset.Add(dataPoints[i]);
                    }
                   i++;
                }
                if (myDataset.Count != 0)
                {
                    int xsum = 0, ysum = 0;
                    foreach (int[] data in myDataset)
                    {
                        xsum += data[0];
                        ysum += data[1];
                    }

                    int x = xsum / myDataset.Count;
                    int y = ysum / myDataset.Count;
                    centroid[0] = x;
                    centroid[1] = y;
                }
                count++;

            }
            


        }

        private void GenarateInitialCentroids(int num)
        {
            int count = 0;
            if (num >= dataPoints.Count)
            {
                MessageBox.Show("Number of centroids exceeds the number of points!","Out of panel range",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            foreach (int[] data in dataPoints)
            {
                if (count == num)
                {
                    break;
                }
                int xVal = data[0];
                int yVal = data[1];
                int[] centorid = { xVal, yVal };
                centroidList.Add(centorid);
                DrawCentroids(xVal, yVal);        
                count++;
            }
        }

        private void Reset()
        {
            button_Load.Enabled = true;
            button_Manual.Enabled = true;
            panel1.Enabled = false;
            panel1.Invalidate();
            dataPoints = new List<int[]>();
            centroidList = new List<int[]>();
            clusters = new List<int>();
            pictureBox2.Visible = Enabled;
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            Reset();
            if(!(int.TryParse(textBox_Centroids.Text,out centroids)))
            {
                MessageBox.Show("No Centroids Detected!","No Centroids",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            string chosenFile = "";
            openFD.InitialDirectory = "C:";
            openFD.FileName = "";
            openFD.Filter = "Text Files|*.txt";
            if (openFD.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Cancelled", "Operation Cancelled",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                chosenFile = openFD.FileName;
                string line;

                  
                System.IO.StreamReader file =
                    new System.IO.StreamReader(chosenFile);
                while ((line = file.ReadLine()) != null)
                {
                    int temp;
                    try
                    {
                        if(!((int.TryParse(line.Split(',')[0],out temp))&& (int.TryParse(line.Split(',')[1], out temp))))
                        {
                            MessageBox.Show("Invalid Input!", "Invalid Input!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            return;
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Invalid Input!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    int x = int.Parse(line.Split(',')[0]);
                    int y = int.Parse(line.Split(',')[1]);
                    int[] dataPoint = { x, y };
                    dataPoints.Add(dataPoint);
                }

                file.Close();
                pictureBox2.Visible = false;
                DisplayInitialPoints();
                button_Manual.Enabled = false;



            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ClearPanel()
        {
            Brush aBrush = (Brush)Brushes.White;
            Graphics g = panel1.CreateGraphics();

            foreach (int[] centroid in centroidList)
            {
                int x = centroid[0];
                int y = centroid[1];
                g.FillEllipse(aBrush, x, y, 10, 10);
                
            }

            foreach (int[] data in dataPoints)
            {
                int x = data[0];
                int y = data[1];
                g.FillEllipse(aBrush, x, y, 10, 10);
            }

        }

        private void button_Itterate_Click(object sender, EventArgs e)
        {
            if (dataPoints.Count == 0)
            {
                MessageBox.Show("Please insert points!", "No Points!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Itterate();
        }

        private bool validate(int x,int y)
        {
            if (x > panel1.Width){
                return false;
            }
            if (y > panel1.Height)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isFinished(List<int[]> oldCentroids, List<int[]> newCentroids)
        {
            bool equals = false;
            int counter = 0;
            foreach (int[] centOld in oldCentroids)
            {
                equals = false;
                int xOld = centOld[0];
                int yOld = centOld[1];
                
                if(newCentroids[counter][0]==xOld && newCentroids[counter][1] == yOld)
                {
                    equals = true;
                }
                else
                {
                    return false;
                }
                counter++;
            }
            return equals;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            int[] point = { x, y };
            dataPoints.Add(point);
            DrawPoints(x, y);
        }

        private void button_Set_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBox_Centroids.Text, out centroids)))
            {
                MessageBox.Show("No Centroids Detected!", "No Centroids", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            panel1.Enabled = false;
            button_Load.Enabled = false;
            button_Manual.Enabled = false;
            button_Set.Enabled = false;
            DisplayInitialPoints();
        }

        private void button_Manual_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBox_Centroids.Text, out centroids)))
            {
                MessageBox.Show("No Centroids Detected!", "No Centroids", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            button_Load.Enabled = false;
            panel1.Enabled = true;
            button_Set.Enabled = true;
            button_Manual.Enabled = false;
            pictureBox2.Visible = false;


        }
    }
}
