using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;

namespace APO
{

    class Utility
    {
        

        public static Dictionary<Color, int> HistogramMap(Bitmap bitmap)
        {

            Dictionary<Color, int> histDic = new Dictionary<Color, int>();

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color color = bitmap.GetPixel(x, y);
                    if (histDic.ContainsKey(color))
                        histDic[color] = histDic[color] + 1;
                    else
                        histDic.Add(color, 1);
                }
            }
            return histDic;

        }

        public static int[] HistogramLUT(Dictionary<Color, int> histogramMap, string color = "red")
        {
            Dictionary<byte, int> pairs = new Dictionary<byte, int>();
            int[] LUT = new int[256];

            switch (color)
            {
                case "red":
                    foreach (var key in histogramMap.Keys)
                    {
                        if (pairs.ContainsKey(key.R))
                            pairs[key.R] += histogramMap[key];
                        else
                            pairs.Add(key.R, histogramMap[key]);
                    }
                    foreach (var key in pairs.Keys)
                    {
                        LUT[key] = pairs[key];
                    }
                    break;

                case "green":
                    foreach (var key in histogramMap.Keys)
                    {
                        if (pairs.ContainsKey(key.G))
                            pairs[key.G] += histogramMap[key];
                        else
                            pairs.Add(key.G, histogramMap[key]);
                    }
                    foreach (var key in pairs.Keys)
                    {
                        LUT[key] = pairs[key];
                    }
                    break;
                case "blue":
                    foreach (var key in histogramMap.Keys)
                    {
                        if (pairs.ContainsKey(key.B))
                            pairs[key.B] += histogramMap[key];
                        else
                            pairs.Add(key.B, histogramMap[key]);
                    }
                    foreach (var key in pairs.Keys)
                    {
                        LUT[key] = pairs[key];
                    }
                    break;
            }
            return LUT;
        }

        public static Bitmap ConvertToGreyscale(Bitmap src)
        {
            Bitmap d = new Bitmap(src.Width, src.Height);

            for (int i = 0; i < src.Width; i++)
            {
                for (int x = 0; x < src.Height; x++)
                {
                    Color oc = src.GetPixel(i, x);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    d.SetPixel(i, x, nc);
                }
            }
            return d;
        }

        public static Bitmap Threshhold2(Bitmap bm, int threshhold1, int threshhold2)
        {
            Bitmap newBm = ConvertToGreyscale(bm);

            for (int x = 0; x < newBm.Width; x++)
            {
                for (int y = 0; y < newBm.Height; y++)
                {
                    Color c = newBm.GetPixel(x, y);
                    Color newC = new Color();
                    if (c.R < threshhold1 || c.R > threshhold2)
                    {
                        newC = Color.FromArgb(255, 0, 0, 0);
                        newBm.SetPixel(x, y, newC);
                    }

                }

            }

            return newBm;
        }

        public static Size FitSize(Size pictureSize)
        {
            int newHeight, newWidth;

            if ((pictureSize.Height >= APO.ActiveForm.Size.Height) || (pictureSize.Width >= APO.ActiveForm.Size.Width))
            {
                newHeight = (int)(pictureSize.Height * 0.5);
                newWidth = (int)(pictureSize.Width * 0.5);
            }
            else
            {
                newHeight = pictureSize.Height;
                newWidth = pictureSize.Width;
            }

            Size newSize = new Size(newWidth, newHeight);

            return newSize;
        }

        public static Bitmap Negation(Bitmap bitmap)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(255 - (newBitmap.GetPixel(x, y).R),
                                                    255 - (newBitmap.GetPixel(x, y).G),
                                                    255 - (newBitmap.GetPixel(x, y).B));
                    newBitmap.SetPixel(x, y, newColor);
                }
            }
            return newBitmap;
        }

        public static Bitmap EqualGray(Bitmap bitmap)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            Dictionary<Color, int> map = Utility.HistogramMap(bitmap);
            int[] GrayLut = Utility.HistogramLUT(map);
            double[] D = new double[GrayLut.Length];
            int sum = 0;

            foreach (var x in GrayLut) { sum += x; }

            for (int i = 0; i < GrayLut.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    D[i] += GrayLut[j];
                }
                D[i] = D[i] / sum;
            }

            double D0 = 0;
            for (int i = D.Length - 1; i > 0; --i)
            {
                if (D[i] != 0) { D0 = D[i]; }
            }

            // ta tablica to wskażnik przejscia na nowy kolor / wartośc koloru!!! 

            Dictionary<int, int> LUT = new Dictionary<int, int>();

            for (int i = 0; i < D.Length; ++i)
            {
                LUT.Add(i, (int)(((D[i] - D0) / (1 - D0)) * (256 - 1)));
            }

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(LUT[bitmap.GetPixel(x, y).R], LUT[bitmap.GetPixel(x, y).R], LUT[bitmap.GetPixel(x, y).R]);
                    newBitmap.SetPixel(x, y, newColor);
                }
            }
            return newBitmap;
        }

        public static Bitmap EqualRGB(Bitmap bitmap)
        {
            Dictionary<Color, int> map = Utility.HistogramMap(bitmap);
            int[] RedLut = Utility.HistogramLUT(map, "red");
            int[] GreenLut = Utility.HistogramLUT(map, "green");
            int[] BlueLut = Utility.HistogramLUT(map, "blue");
            double[] Dr = new double[RedLut.Length];
            double[] Dg = new double[GreenLut.Length];
            double[] Db = new double[BlueLut.Length];
            int sumR = 0;
            int sumG = 0;
            int sumB = 0;

            foreach (var x in RedLut) { sumR += x; }
            foreach (var x in GreenLut) { sumG += x; }
            foreach (var x in BlueLut) { sumB += x; }

            for (int i = 0; i < RedLut.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Dr[i] += RedLut[j];
                    Dg[i] += GreenLut[j];
                    Db[i] += BlueLut[j];
                }
                Dr[i] = Dr[i] / sumR;
                Dg[i] = Dg[i] / sumG;
                Db[i] = Db[i] / sumB;
            }


            double Dr0 = 0;
            double Dg0 = 0;
            double Db0 = 0;

            for (int i = Dr.Length - 1; i > 0; --i)
            {
                if (Dr[i] != 0) { Dr0 = Dr[i]; }
                if (Dg[i] != 0) { Dg0 = Dg[i]; }
                if (Db[i] != 0) { Db0 = Db[i]; }
            }


            // ta tablica to wskażnik przejscia na nowy kolor / wartośc koloru!!! 

            Dictionary<int, int> LUTr = new Dictionary<int, int>();
            Dictionary<int, int> LUTg = new Dictionary<int, int>();
            Dictionary<int, int> LUTb = new Dictionary<int, int>();

            for (int i = 0; i < Dr.Length; ++i)
            {
                if (((int)(((Dr[i] - Dr0) / (1 - Dr0)) * (256 - 1))) < 0)
                { LUTr.Add(i, 0); }
                else
                {
                    LUTr.Add(i, (int)(((Dr[i] - Dr0) / (1 - Dr0)) * (256 - 1)));
                }
            }
            for (int i = 0; i < Dg.Length; ++i)
            {
                if (((int)(((Dg[i] - Dg0) / (1 - Dg0)) * (256 - 1))) < 0)
                { LUTg.Add(i, 0); }
                else
                {
                    LUTg.Add(i, (int)(((Dg[i] - Dg0) / (1 - Dg0)) * (256 - 1)));
                }
            }
            for (int i = 0; i < Db.Length; ++i)
            {
                if (((int)(((Db[i] - Db0) / (1 - Db0)) * (256 - 1))) < 0)
                { LUTb.Add(i, 0); }
                else
                {
                    LUTb.Add(i, (int)(((Db[i] - Db0) / (1 - Db0)) * (256 - 1)));
                }
            }

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(LUTr[bitmap.GetPixel(x, y).R], LUTg[bitmap.GetPixel(x, y).G], LUTb[bitmap.GetPixel(x, y).B]);
                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;
        }
        // ############################# Selective #########################################################################
        public static Bitmap SelectiveEqualGray(Bitmap bitmap)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            Dictionary<Color, int> map = Utility.HistogramMap(bitmap);
            int[] GrayLut = Utility.HistogramLUT(map);
            double[] D = new double[GrayLut.Length];
            int sum = 0;

            foreach (var x in GrayLut) { sum += x; }

            for (int i = 0; i < GrayLut.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    D[i] += GrayLut[j];
                }
                D[i] = D[i] / sum;
            }

            double D0 = 0;
            for (int i = D.Length - 1; i > 0; --i)
            {
                if (D[i] != 0) { D0 = D[i]; }
            }

            // ta tablica to wskażnik przejscia na nowy kolor / wartośc koloru!!! 

            Dictionary<int, int> LUT = new Dictionary<int, int>();

            for (int i = 0; i < D.Length; ++i)
            {
                LUT.Add(i, (int)Math.Ceiling(255 * D[i])); // ew zamiast 5 - 255
            }

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(LUT[bitmap.GetPixel(x, y).R], LUT[bitmap.GetPixel(x, y).R], LUT[bitmap.GetPixel(x, y).R]);
                    newBitmap.SetPixel(x, y, newColor);
                }
            }
            return newBitmap;
        }


        public static Bitmap SelectiveEqualRGB(Bitmap bitmap)
        {
            Dictionary<Color, int> map = Utility.HistogramMap(bitmap);
            int[] RedLut = Utility.HistogramLUT(map, "red");
            int[] GreenLut = Utility.HistogramLUT(map, "green");
            int[] BlueLut = Utility.HistogramLUT(map, "blue");
            double[] Dr = new double[RedLut.Length];
            double[] Dg = new double[GreenLut.Length];
            double[] Db = new double[BlueLut.Length];
            int sumR = 0;
            int sumG = 0;
            int sumB = 0;

            foreach (var x in RedLut) { sumR += x; }
            foreach (var x in GreenLut) { sumG += x; }
            foreach (var x in BlueLut) { sumB += x; }

            for (int i = 0; i < RedLut.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Dr[i] += RedLut[j];
                    Dg[i] += GreenLut[j];
                    Db[i] += BlueLut[j];
                }
                Dr[i] = Dr[i] / sumR;
                Dg[i] = Dg[i] / sumG;
                Db[i] = Db[i] / sumB;
            }

            double Dr0 = 0;
            double Dg0 = 0;
            double Db0 = 0;

            for (int i = Dr.Length - 1; i > 0; --i)
            {
                if (Dr[i] != 0) { Dr0 = Dr[i]; }
                if (Dg[i] != 0) { Dg0 = Dg[i]; }
                if (Db[i] != 0) { Db0 = Db[i]; }
            }


            // ta tablica to wskażnik przejscia na nowy kolor / wartośc koloru!!! 

            Dictionary<int, int> LUTr = new Dictionary<int, int>();
            Dictionary<int, int> LUTg = new Dictionary<int, int>();
            Dictionary<int, int> LUTb = new Dictionary<int, int>();

            for (int i = 0; i < Dr.Length; ++i)
            {
                LUTr.Add(i, (int)Math.Ceiling(255 * Dr[i]));
                LUTg.Add(i, (int)Math.Ceiling(255 * Dg[i]));
                LUTb.Add(i, (int)Math.Ceiling(255 * Db[i]));
            }


            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(LUTr[bitmap.GetPixel(x, y).R], LUTg[bitmap.GetPixel(x, y).G], LUTb[bitmap.GetPixel(x, y).B]);
                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;

        }
    }
}

