using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using Interop = System.Windows.Interop;
using Media = System.Windows.Media;

class MainClass
{
    public void LaunchCreateGif(IEnumerable<Bitmap> imagesBmp)
    {
      //  var images = imagesBmp;

     //   createGif(images, "result.gif");

    }
    //custom
    public Image CreateAnimation(Control ctl, List<Image> frames, int delay)
    {
        var gifEnc = new Media.Imaging.GifBitmapEncoder();
        var ms = new System.IO.MemoryStream();
        var codec = ImageCodecInfo.GetImageEncoders().First(i => i.MimeType == "image/tiff");

        EncoderParameters encoderParameters = new EncoderParameters(2);
        encoderParameters.Param[0] = new EncoderParameter(Encoder.SaveFlag, (long)EncoderValue.MultiFrame);
        encoderParameters.Param[1] = new EncoderParameter(Encoder.Quality, (long)EncoderValue.CompressionLZW);
        frames[0].Save(ms, codec, encoderParameters);

        encoderParameters = new EncoderParameters(1);
        encoderParameters.Param[0] = new EncoderParameter(Encoder.SaveFlag, (long)EncoderValue.FrameDimensionPage);
        for (int i = 1; i < frames.Count; i++)
        {
            frames[0].SaveAdd(frames[i], encoderParameters);
        }
        encoderParameters.Param[0] = new EncoderParameter(Encoder.SaveFlag, (long)EncoderValue.Flush);
        frames[0].SaveAdd(encoderParameters);

        ms.Position = 0;
        var img = Image.FromStream(ms);
        Animate(ctl, img, delay, frames.Count);
        return img;
    }

    private static void Animate(Control ctl, Image img, int delay, int countFrames)
    {
        int frame = 0;
        var tmr = new Timer() { Interval = delay, Enabled = true };
        tmr.Tick += delegate {
            frame++;
            if (frame >= countFrames) frame = 0;
            img.SelectActiveFrame(FrameDimension.Page, frame);
            ctl.Invalidate();
        };
        ctl.Disposed += delegate { tmr.Dispose(); };
    }
    /// custom
    private static void createGif(IEnumerable<Bitmap> bitmaps, string path)
    {
        var gifEnc = new Media.Imaging.GifBitmapEncoder();

        foreach (var bmp in bitmaps)
        {
            var src = Interop.Imaging.CreateBitmapSourceFromHBitmap(
                        bmp.GetHbitmap(),
                        IntPtr.Zero,
                        Int32Rect.Empty,
                        Media.Imaging.BitmapSizeOptions.FromEmptyOptions()
            );
            var emptyBmp = new Bitmap(bmp.Width, bmp.Height);
         /*
            Graphics g = Graphics.FromImage(emptyBmp);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, bmp.Width, bmp.Height);
            g.Dispose();

            var emptyFrame = Interop.Imaging.CreateBitmapSourceFromHBitmap(
                        emptyBmp.GetHbitmap(),
                        IntPtr.Zero,
                        Int32Rect.Empty,
                        Media.Imaging.BitmapSizeOptions.FromEmptyOptions()
                        );
            gifEnc.Frames.Add(Media.Imaging.BitmapFrame.Create(src));
            */

        }
        using (var fs = new FileStream(path, FileMode.Create))
        {
            gifEnc.Save(fs);
        }
    }
}