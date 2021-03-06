﻿using System;
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
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;

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

        public static Bitmap StretchGray(Bitmap bitmap, int max, int min)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            Dictionary<Color, int> histDic = Utility.HistogramMap(bitmap);

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    if (bitmap.GetPixel(x, y).R >= max)
                    {
                        Color newColor = Color.FromArgb(255, 255, 255);
                        newBitmap.SetPixel(x, y, newColor);
                    }
                    if (bitmap.GetPixel(x, y).R <= min)
                    {
                        Color newColor = Color.FromArgb(0, 0, 0);
                        newBitmap.SetPixel(x, y, newColor);
                    }
                    if ((bitmap.GetPixel(x, y).R > min) && (bitmap.GetPixel(x, y).R < max))
                    {
                        int color = (((bitmap.GetPixel(x, y).R - min) * 255) / (max - min));
                        Color newColor = Color.FromArgb(color, color, color);
                        newBitmap.SetPixel(x, y, newColor);
                    }
                }
            }
            return newBitmap;
        }

        public static Bitmap StretchRGB(Bitmap bitmap, int max, int min)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            Dictionary<Color, int> histDic = Utility.HistogramMap(bitmap);

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    if (bitmap.GetPixel(x, y).R > max)
                    {
                        Color newColor = Color.FromArgb(255, bitmap.GetPixel(x, y).G, bitmap.GetPixel(x, y).B);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    if (bitmap.GetPixel(x, y).G > max)
                    {
                        Color newColor = Color.FromArgb(bitmap.GetPixel(x, y).R, 255, bitmap.GetPixel(x, y).B);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    if (bitmap.GetPixel(x, y).B > max)
                    {
                        Color newColor = Color.FromArgb(bitmap.GetPixel(x, y).R, bitmap.GetPixel(x, y).G, 255);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    // # 
                    // #
                    if (bitmap.GetPixel(x, y).R < min)
                    {
                        Color newColor = Color.FromArgb(0, bitmap.GetPixel(x, y).G, bitmap.GetPixel(x, y).B);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    if (bitmap.GetPixel(x, y).G < min)
                    {
                        Color newColor = Color.FromArgb(bitmap.GetPixel(x, y).R, 0, bitmap.GetPixel(x, y).B);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    if (bitmap.GetPixel(x, y).B < min)
                    {
                        Color newColor = Color.FromArgb(bitmap.GetPixel(x, y).R, bitmap.GetPixel(x, y).G, 0);
                        bitmap.SetPixel(x, y, newColor);
                    }


                    // # 
                    // #
                    if ((bitmap.GetPixel(x, y).R >= min) && (bitmap.GetPixel(x, y).R <= max))
                    {
                        int color = (((bitmap.GetPixel(x, y).R - min) * 255) / (max - min));
                        Color newColor = Color.FromArgb(color, bitmap.GetPixel(x, y).G, bitmap.GetPixel(x, y).B);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    if ((bitmap.GetPixel(x, y).G >= min) && (bitmap.GetPixel(x, y).G <= max))
                    {
                        int color = (((bitmap.GetPixel(x, y).G - min) * 255) / (max - min));
                        Color newColor = Color.FromArgb(bitmap.GetPixel(x, y).R, color, bitmap.GetPixel(x, y).B);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    if ((bitmap.GetPixel(x, y).B >= min) && (bitmap.GetPixel(x, y).B <= max))
                    {
                        int color = (((bitmap.GetPixel(x, y).B - min) * 255) / (max - min));
                        Color newColor = Color.FromArgb(bitmap.GetPixel(x, y).R, bitmap.GetPixel(x, y).G, color);
                        bitmap.SetPixel(x, y, newColor);
                    }

                    // # 
                    // #
                }
            }
            return bitmap;
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

        public static Bitmap Thresholding(Bitmap bitmap, int p)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(Threshold(newBitmap.GetPixel(x, y).R, p),
                                                    Threshold(newBitmap.GetPixel(x, y).R, p),
                                                    Threshold(newBitmap.GetPixel(x, y).R, p));
                    newBitmap.SetPixel(x, y, newColor);
                }
            }
            return newBitmap;
        }

        private static int Threshold(int value, int p)
        {
            if (value <= p) { return 0; }
            else { return 255; }
        }
        private static int Threshold2(int value, int p1, int p2)
        {
            if ((value >= p1) && (value <= p2)) { return value; }
            else { return 0; }
        }

        public static Bitmap ThreshholdGrayValue(Bitmap bm, int threshhold1, int threshhold2)
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

        public static Bitmap Posterize(Bitmap bm, int levels)
        {
            Bitmap newBm = Utility.ConvertToGreyscale(bm);

            int[] tabValues = new int[levels + 1];
            int[] tabColors = new int[levels];

            int b = 256 / (levels - 1);
            for (int i = 0; i < levels - 1; ++i)
            {
                tabColors[i] = b * i;
            }
            tabColors[tabColors.Length - 1] = 255;

            int a = b / 2;
            tabValues[0] = 0;
            tabValues[tabValues.Length - 1] = 255;
            for (int i = 1; i < levels; ++i)
            {
                tabValues[i] = tabColors[i - 1] + a;
            }

            for (int x = 0; x < newBm.Width; x++)
            {
                for (int y = 0; y < newBm.Height; y++)
                {
                    Color c = newBm.GetPixel(x, y);
                    Color newC = new Color();
                    for (int i = 0; i < levels; ++i)
                    {
                        if (c.R > tabValues[i] && c.R <= tabValues[i + 1])
                        {
                            newC = Color.FromArgb(255, tabColors[i], tabColors[i], tabColors[i]);
                            newBm.SetPixel(x, y, newC);
                        }
                    }

                }

            }

            return newBm;
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

        public static string SaveBmpTmp(Bitmap bmp)
        {
            string fileName = Path.GetTempPath() + Guid.NewGuid().ToString() + ".bmp";
            FileStream stream = File.Create(fileName);
            bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
            stream.Close();
            return fileName;
        }

        public static Bitmap BmpFromFile(string path)
        {
            var bytes = File.ReadAllBytes(path);
            var ms = new MemoryStream(bytes);
            var img = (Bitmap)Image.FromStream(ms);
            return img;
        }

        public static Mat GetMatFromSDImage(System.Drawing.Image image)
        {
            int stride = 0;
            Bitmap bmp = new Bitmap(image);

            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);

            System.Drawing.Imaging.PixelFormat pf = bmp.PixelFormat;
            if (pf == System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            {
                stride = bmp.Width * 4;
            }
            else
            {
                stride = bmp.Width * 3;
            }

            Image<Bgra, byte> cvImage = new Image<Bgra, byte>(bmp.Width, bmp.Height, stride, (IntPtr)bmpData.Scan0);

            bmp.UnlockBits(bmpData);

            return cvImage.Mat;
        }

        public static void Histogram(Chart chart, Bitmap bitmap)
        {
            Dictionary<Color, int> map = Utility.HistogramMap(bitmap);
            int[] RedLut = Utility.HistogramLUT(map, "red");
            int[] GreenLut = Utility.HistogramLUT(map, "green");
            int[] BlueLut = Utility.HistogramLUT(map, "blue");

            chart.Series.Clear();
            chart.Series.Add("Red");
            chart.Series.Add("Blue");
            chart.Series.Add("Green");
            chart.Series["Red"].Color = Color.Red;
            chart.Series["Blue"].Color = Color.Blue;
            chart.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                chart.Series["Red"].Points.AddXY(i, RedLut[i]);
                chart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                chart.Series["Blue"].Points.AddXY(i, BlueLut[i]);

            }
        }
        public static Bitmap Filter2D(Bitmap bmp, float[,] mask)
        {
            string file1 = Utility.SaveBmpTmp(bmp);
            Image<Bgr, float> img = new Image<Bgr, float>(file1),
                             dst = new Image<Bgr, float>(img.Size);
            ConvolutionKernelF kernel = new ConvolutionKernelF(mask);
            CvInvoke.Filter2D(img, dst, kernel, new Point(-1, -1));
            dst.Save(file1);
            Bitmap tmpBmp = Utility.BmpFromFile(file1);
            File.Delete(file1);
            return tmpBmp;
        }

        public static Bitmap XOR(Bitmap bmp1, Bitmap bmp2)
        {
            string file1 = SaveBmpTmp(bmp1),
                   file2 = SaveBmpTmp(bmp2);
            Image<Bgr, Byte> img = new Image<Bgr, Byte>(file1),
                             img2 = new Image<Bgr, Byte>(file2);
            img2 = img2.Resize(img.Width, img.Height, Emgu.CV.CvEnum.Inter.Linear);
            img = img.Xor(img2);
            img.Save(file1);
            Bitmap tmpBmp = BmpFromFile(file1);
            File.Delete(file1);
            File.Delete(file2);
            return tmpBmp;
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


            Dictionary<int, int> LUT = new Dictionary<int, int>();

            for (int i = 0; i < D.Length; ++i)
            {
                LUT.Add(i, (int)Math.Ceiling(255 * D[i])); 
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

        public static Bitmap Thresholding2(Bitmap bm, int threshhold1, int threshhold2)
        {
            Bitmap newBm = Utility.ConvertToGreyscale(bm);

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

        public static Bitmap Reduction(Bitmap bitmap, int n) 
        {
            Bitmap newBitmap = new Bitmap(bitmap);
            int p = 256 / n; 
            Dictionary<Color, int> map = HistogramMap(bitmap);                        

            int p0 = 0;
            int p1 = 0;

            for (int i = 0; i < n; ++i)
            {
                p0 = p1;
                p1 = p1 + p;
                for (int x = 0; x < bitmap.Width; ++x)
                {
                    for (int y = 0; y < bitmap.Height; ++y)
                    {
                        Color newColor = Color.FromArgb(0, 0, 0);

                        if ((bitmap.GetPixel(x, y).R >= p0) && (bitmap.GetPixel(x, y).R < p1))
                        {
                            newColor = Color.FromArgb(p0 + (n / 2), newColor.G, newColor.B);
                        }
                        if ((bitmap.GetPixel(x, y).G >= p0) && (bitmap.GetPixel(x, y).G < p1))
                        {
                            newColor = Color.FromArgb(newColor.R, p0 + (n / 2), newColor.B);
                        }
                        if ((bitmap.GetPixel(x, y).B >= p0) && (bitmap.GetPixel(x, y).B < p1))
                        {
                            newColor = Color.FromArgb(newColor.R, newColor.G, p0 + (n / 2));
                        }
                        newBitmap.SetPixel(x, y, newColor);

                    }
                }
            }
            return newBitmap;
        }
    }
}

