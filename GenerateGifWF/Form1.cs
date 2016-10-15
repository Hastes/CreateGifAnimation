using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ImageMagick;

namespace GenerateGifWF
{
    public partial class Form1 : Form
    {
        class DataPicture
        {
            public ContextMenuStrip pictureMenu { get; set; }
        }
        string IMAGE_FULLNAME;  // path to picture
        int KF = 5;  // coefficient of speed
        int INDEX_PICTURE = 0; // update control image
        int SPEED = 0; // timer interval
        int COUNTER = 0; // count of action
        Dictionary<PictureBox, DataPicture> PICTURES_DICT= new Dictionary<PictureBox, DataPicture>();
        IList<PictureBox> PICTURE = new List<PictureBox>();
        IList<ContextMenuStrip> MENU_STRIP = new List<ContextMenuStrip>();
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += UPD_Screen;
        }
        void AddReport(string message)
        {
            COUNTER++;
            Label lab = new Label();
            lab.Text = COUNTER+ ". " + message;
            lab.AutoSize = true;
            lab.Padding = new Padding(0,5,0,0);
            reportPlace.Controls.Add(lab);
            reportPlace.Controls.SetChildIndex(lab, 0);
        }
        private void AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "Images only. | *.jpg; *jpeg; *.png;";
            DialogResult dr = image.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            IMAGE_FULLNAME = image.FileName; // assignment path global variable 
            CreatePictureBox();
            AddReport("Добавлено новое изображение");
        }
        
        private void CreatePictureBox()
        {
            PictureBox pic = new PictureBox();
            ContextMenuStrip dynamic_menu = new ContextMenuStrip();
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image = Image.FromFile(IMAGE_FULLNAME);
            pic.MouseDown += Pic_MouseDown;
            pic.MouseHover += Pic_MouseHover;
            
            ToolStripItem deleteItem = dynamic_menu.Items.Add("Delete");
            ToolStripItem copyItem = dynamic_menu.Items.Add("Copy");
            ToolStripItem moveItem = dynamic_menu.Items.Add("Move");
            dynamic_menu.ItemClicked += (sender, e) =>
            {
                if (e.ClickedItem == deleteItem) DeleteObject(sender);
                if (e.ClickedItem == copyItem) CopyObject(sender);
                if (e.ClickedItem == moveItem) MoveObject(sender);
            };
            // rightClickMenuStrip1.Items.Add("Delete", null, new EventHandler(Pic_Click));
            // rightClickMenuStrip1.Tag = pic;
            // rightClickMenuStrip1.ItemClicked += RightClickMenuStrip1_ItemClicked;
            flowLayoutPanel1.Controls.Add(pic);
            MENU_STRIP.Add(dynamic_menu);
            PICTURE.Add(pic);
        }

        private void Pic_MouseHover(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(pic, "Изображение "+(flowLayoutPanel1.Controls.IndexOf(pic)+1).ToString());
        }

        /* 
MenuStrip:
1) Удалить элемент
2) Передвинуть элемент в указанную позицию
3-4) Сдвинуть влево/вправо
5) Копировать элемент
    */
        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            Form f = new Form();
            PictureBox pic = sender as PictureBox;
            ContextMenuStrip menuStrip = MENU_STRIP[PICTURE.IndexOf(pic)];
            switch (e.Button) {
                case MouseButtons.Right:
                    {
                        menuStrip.Show(this, new Point(pic.Location.X, pic.Location.Y));
                    }
                    break;
            }
        }
        
        private void DeleteObject(object sender)
        {
            ContextMenuStrip menuStrip = sender as ContextMenuStrip;
            int currentIndex = MENU_STRIP.IndexOf(menuStrip);
            PictureBox pic = PICTURE[currentIndex];
            flowLayoutPanel1.Controls.Remove(pic);
            AddReport("Удалено изображение " + (currentIndex+1).ToString());
            PICTURE.Remove(pic);
            MENU_STRIP.Remove(menuStrip);
            INDEX_PICTURE = 0;
            picturesCount.Text = PICTURE.Count.ToString();
        }
        private void CopyObject(object sender)
        {
            ContextMenuStrip menuStrip = sender as ContextMenuStrip;
            int currentIndex = MENU_STRIP.IndexOf(menuStrip);
            PictureBox old_pic = PICTURE[currentIndex];
            AddReport("Скопировано изображение " + (currentIndex + 1).ToString());
            PictureBox pic = new PictureBox();
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image = old_pic.Image;
            pic.MouseDown += Pic_MouseDown;

            MENU_STRIP.Insert(currentIndex, menuStrip);
            PICTURE.Insert(currentIndex, pic);
            flowLayoutPanel1.Controls.Add(pic);
            flowLayoutPanel1.Controls.SetChildIndex(pic, currentIndex);
        }
        private void MoveObject(object sender)
        {
            ContextMenuStrip menuStrip = sender as ContextMenuStrip;
            int currentIndex = MENU_STRIP.IndexOf(menuStrip);
            PictureBox currentPicture = PICTURE[currentIndex];
            string new_position = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите номер позиции, на которую нужно сдвинуть изображение",
                "Сдвиг на заданную позицию",
                "1 ... " + PICTURE.Count,
                MousePosition.X,
                MousePosition.Y
                );
            int new_index = Convert.ToInt32(new_position) - 1;  // postion - 1 = index
            AddReport("Изображение " + (currentIndex + 1).ToString() + " перемещено в позицию " + new_position);
            MENU_STRIP.RemoveAt(currentIndex);
            PICTURE.RemoveAt(currentIndex);
            PICTURE.Insert(new_index, currentPicture);
            MENU_STRIP.Insert(new_index, menuStrip);
            if (new_position == "") return;
            flowLayoutPanel1.Controls.SetChildIndex(currentPicture, new_index); 
        }

        private void UPD_Screen(object sender, EventArgs e)
        {
            if (INDEX_PICTURE == PICTURE.Count) INDEX_PICTURE = 0;
            if (INDEX_PICTURE > PICTURE.Count) return;
            try { 
                MoviePlace.Image = PICTURE[INDEX_PICTURE].Image;
            }
            catch (ArgumentOutOfRangeException)
            {
                MoviePlace.Image = null;
            }
            INDEX_PICTURE += 1;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SPEED = trackBar1.Value;
            if (SPEED == 0)
            {
                timer1.Stop();
                return;
            }
            timer1.Stop();
            timer1.Interval = 1000 / SPEED * KF;
            timer1.Start();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //SaveGif();
            /* MainClass gifClass = new MainClass();
             var bitmapImages = loadImages();
             gifClass.LaunchCreateGif(bitmapImages);
             MessageBox.Show("Gif анимация была успешно собрана");*/
            MainClass gifCreateClass = new MainClass();
            List<Image> imgages = new List<Image>();
            foreach (var obj in PICTURE)
            {
                imgages.Add(obj.Image as Image);
            }
            Image newImage = Image.FromFile(IMAGE_FULLNAME);
            Image newImage2 = Image.FromFile(IMAGE_FULLNAME);

            pictureBox1.Image = gifCreateClass.CreateAnimation(pictureBox1,
            imgages,
            timer1.Interval);
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана при поддержки фонда OOO NIF KEMGU,с бюджетом 1951 рубль в месяц\n BEST OF THE BEST (c) Степанов(седой) ");
        }



        /*     private IEnumerable<Bitmap> loadImages()
{
//var patches = Directory.GetFiles("."));
foreach (var obj in PICTURE)
{
   yield return obj.Image as Bitmap;
}
} */
    }
}

/*private void SaveGif()
{
    MagickImageCollection collection = new MagickImageCollection();
    // Add first image and set the animation delay to 100ms
    int i = 0;
    foreach (PictureBox nameControl in PICTURE)
    {
        collection.Add(nameControl.Name);
        collection[i].AnimationDelay = timer1.Interval;
        i++;
    }
    // Optionally reduce colors
    QuantizeSettings settings = new QuantizeSettings();
    settings.Colors = 256;
    collection.Quantize(settings);

    // Optionally optimize the images (images should have the same size).
    collection.Optimize();

    // Save gif
    collection.Write("Animated.gif");
    MessageBox.Show("Анимация успешно сохранена");
}*/