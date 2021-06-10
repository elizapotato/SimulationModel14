using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_9
{
    public partial class Form1 : Form
    {
        float[] Val;
        float emEx;
        float emDx;
        int n;
        readonly float[] chishki = { 7.8145f, 14.057f, 18.307f, 22.362f };
        int exp;

        public Form1()
        {
            InitializeComponent();            
            chart1.Legends.Clear();
            chart1.Series[0]["PointWidth"] = "1";
            labAverage.Text = labVariance.Text = labChi.Text = labChiBool.Text = "";
        }               
        
        private void startB_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            var random = new Random();
            emEx = (float)MeanBox.Value;
            emDx = (float)VarianceBox.Value;

            n = Convert.ToInt32(ExpBox.Text);
            exp = ExpBox.SelectedIndex;
            Console.WriteLine(exp);
            Val = new float[n];
            float Ex = 0;
            float Dx = 0;
            for (int i = 0; i < n; i++)
            {
                double a1 = random.NextDouble();
                double a2 = random.NextDouble();
                double kor = Math.Sqrt(-2 * Math.Log(a1));
                double cos = Math.Cos(2 * Math.PI * a2);
                float x = (float)(kor * cos * Math.Sqrt(emDx) + emEx);
                Val[i] = x;
                Ex += x;
                Dx += (float)Math.Pow(x, 2);
            }
            Ex /= n;
            Dx /= n;
            Dx -= (float)Math.Pow(Ex, 2);
            Stats(n, Ex, Dx);
        }

        void Stats(int numbers, float Ex, float Dx)
        {
            double max;
            var min = max = Val[0];
            foreach (var t in Val)
            {
                if (t < min) min = t;
                if (t > max) max = t;
            }
            double smallKoef = (max - min) * 0.05;
            double interval = (max - min) + smallKoef;

            int k = (int)Math.Round(Math.Log(numbers) / Math.Log(2) + 1);
            double step = interval / k;

            double q = min - smallKoef / 2;
            int[] stat = new int[k];
            float chi = 0;

            for (int i = 0; i < k; i++)
            {
                stat[i] = Check(q, q + step);
                float p = (float)(q + step - q) * Density((float)(q + step + q) / 2);
                chi += (float)Math.Pow(stat[i], 2) / (numbers * p);
                chart1.Series[1].Points.AddXY(q, Density((float)(q + step + q) / 2));
                chart1.Series[0].Points.AddXY(q, (double)stat[i] / numbers);
                q += step;
            }

            chi -= numbers;
            SetStatInfo(chi, Ex, Dx);
        }


        private void SetStatInfo(float chi, float Ex, float Dx)
        {
            labChi.Text = chi < chishki[exp] ? $"{chi} < {chishki[exp]}  is {false}" : $"{chi} > {chishki[exp]}  is {true}";
            labAverage.Text = $@"{Ex} (error = {Math.Round(Math.Abs(Ex - emEx) / Math.Abs(Ex) * 100)}%)";
            labVariance.Text = $@"{Dx} (errors = {Math.Round(Math.Abs(Dx - emDx) / Math.Abs(Dx) * 100, 2)}%)";
        }

        private int Check(double a, double b)
        {
            return Val.Count(t => t >= a && t < b);
        }

        private float Density(float x)
        {
            var value = (float)Math.Pow(Math.E, Math.Pow((x - emEx), 2) / (-2 * Math.Pow(emDx, 2)));
            return value / (float)(emDx * Math.Sqrt(2 * Math.PI));
        }
    }
}
