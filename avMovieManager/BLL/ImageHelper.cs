using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avMovieManager.BLL
{
    public class ImageHelper
    {
        /// <summary>
        /// 图片水印
        /// </summary>
        /// <param name="imgPath">图片路径</param>
        /// <param name="filename">保存文件名</param>
        /// <param name="watermarkFilename">水印文件路径</param>
        /// <param name="watermarkStatus">图片水印位置 0=不使用 1=左上 2=中上 3=右上 4=左中 9=右下 10=底部</param>
        /// <param name="quality">附加水印图片质量,0-100</param>
        /// <param name="watermarkTransparency">水印的透明度 1--10 10为不透明</param>
        public static void AddImageSignPic(string imgPath, string filename, string watermarkFilename, int watermarkStatus, int quality, int watermarkTransparency)
        {
            if (!File.Exists(imgPath))
                return;
            byte[] _ImageBytes = File.ReadAllBytes(imgPath);
            Image img = Image.FromStream(new MemoryStream(_ImageBytes));

            if (!File.Exists(watermarkFilename))
                return;
            Graphics g = Graphics.FromImage(img);
            //设置高质量插值法
            //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Image watermark = new Bitmap(watermarkFilename);

            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMap colorMap = new ColorMap();

            colorMap.OldColor = Color.FromArgb(255, 0, 255, 0);
            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
            ColorMap[] remapTable = { colorMap };

            imageAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);

            float transparency = 0.5F;

            if (watermarkTransparency >= 1 && watermarkTransparency <= 10)
                transparency = (watermarkTransparency / 10.0F);

            float[][] colorMatrixElements = {
                new float[] {1.0f, 0.0f, 0.0f, 0.0f, 0.0f},
                new float[] {0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
                new float[] {0.0f, 0.0f, 1.0f, 0.0f, 0.0f},
                new float[] {0.0f, 0.0f, 0.0f, transparency, 0.0f},
                new float[] {0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            int xpos = 0;
            int ypos = 0;

            switch (watermarkStatus)
            {
                case 1:
                    xpos = (int)(img.Width * (float).01);
                    ypos = (int)(img.Height * (float).01);
                    break;
                case 2:
                    xpos = (int)((img.Width * (float).50) - (watermark.Width / 2));
                    ypos = (int)(img.Height * (float).01);
                    break;
                case 3:
                    xpos = (int)((img.Width * (float).99) - (watermark.Width));
                    ypos = (int)(img.Height * (float).01);
                    break;
                case 4:
                    xpos = (int)(img.Width * (float).01);
                    ypos = (int)((img.Height * (float).50) - (watermark.Height / 2));
                    break;
                case 5:
                    xpos = (int)((img.Width * (float).50) - (watermark.Width / 2));
                    ypos = (int)((img.Height * (float).50) - (watermark.Height / 2));
                    break;
                case 6:
                    xpos = (int)((img.Width * (float).99) - (watermark.Width));
                    ypos = (int)((img.Height * (float).50) - (watermark.Height / 2));
                    break;
                case 7:
                    xpos = (int)(img.Width * (float).01);
                    ypos = (int)((img.Height * (float).99) - watermark.Height);
                    break;
                case 8:
                    xpos = (int)((img.Width * (float).50) - (watermark.Width / 2));
                    ypos = (int)((img.Height * (float).99) - watermark.Height);
                    break;
                case 9:
                    xpos = (int)((img.Width * (float).99) - (watermark.Width));
                    ypos = (int)((img.Height * (float).99) - watermark.Height);
                    break;
                case 10:
                    ypos = (int)((img.Height * (float).99) - watermark.Height) + 10;
                    break;
            }

            g.DrawImage(watermark, new Rectangle(1, ypos, watermark.Width, watermark.Height), 0, 0, watermark.Width, watermark.Height, GraphicsUnit.Pixel, imageAttributes);

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            ImageCodecInfo ici = null;
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.MimeType.IndexOf("jpeg") > -1)
                    ici = codec;
            }
            EncoderParameters encoderParams = new EncoderParameters();
            long[] qualityParam = new long[1];
            if (quality < 0 || quality > 100)
                quality = 80;

            qualityParam[0] = quality;

            EncoderParameter encoderParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qualityParam);
            encoderParams.Param[0] = encoderParam;

            if (ici != null)
                img.Save(filename, ici, encoderParams);
            else
                img.Save(filename);

            g.Dispose();
            img.Dispose();
            watermark.Dispose();
            imageAttributes.Dispose();
        }


        public static void CropPosterImg(string fromImagePath, string toImagePath)
        {
            //原图片文件
            Image fromImage = Image.FromFile(fromImagePath);

            int width = fromImage.Width/2;
            int height = fromImage.Height;
            //创建新图位图
            Bitmap bitmap = new Bitmap(width, height);
            //创建作图区域
            Graphics graphic = Graphics.FromImage(bitmap);
            //截取原图相应区域写入作图区
            graphic.DrawImage(fromImage, new Rectangle(0, 0, width, height), new Rectangle(width, 0, fromImage.Width/2, fromImage.Height), GraphicsUnit.Pixel);
            //从作图区生成新图
            Image saveImage = Image.FromHbitmap(bitmap.GetHbitmap());
            //保存图片
            saveImage.Save(toImagePath, ImageFormat.Jpeg);
            //释放资源   
            saveImage.Dispose();
            graphic.Dispose();
            bitmap.Dispose();
            fromImage.Dispose();
        }
    }
}
