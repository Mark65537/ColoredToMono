using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoredToMono
{
    public partial class Form1 : Form
    {
        //delegate void Mes(); // 1. Объявляем делегат
        //Mes mes = ColoredToBW;            // 2. Создаем переменную делегата
        //mes();                  // 4. Вызываем метод

        string[] fileNames;
        string[] safeFileNames;
        uint fNCount=0;
        public Form1()
        {
            InitializeComponent();
        }        

        private void ToGrayScale(Image img)
        {
            Bitmap Bmono;
            using (Bitmap Bclr = new Bitmap(img))
            {
                Bmono = new Bitmap(Bclr.Width, Bclr.Height);
                for (int y = 0; y < Bclr.Height; y++)
                {
                    for (int x = 0; x < Bclr.Width; x++)
                    {
                        Color p = Bclr.GetPixel(x, y);
                        if (p != null)
                        {
                            int grayScale = (int)((p.R * .3) +
                                 (p.G * .59) + (p.B * .11));

                            //create the color object
                            Color monoColor = Color.FromArgb(grayScale, grayScale, grayScale);
                            Bmono.SetPixel(x, y, monoColor);
                        }
                    }
                }
            }
            pB_mono.Image = Bmono;
        }

        private void ToGrayScale2(Image img)
        {
            Bitmap Bmono;
            using (Bitmap Bclr = new Bitmap(img))
            {
                Bmono = new Bitmap(Bclr.Width, Bclr.Height);
                for (int y = 0; y < Bclr.Height; y++)
                {
                    for (int x = 0; x < Bclr.Width; x++)
                    {
                        int pixel = Bclr.GetPixel(x, y).ToArgb();
                        // получаем компоненты цветов пикселя
                        float R = (pixel & 0x00FF0000) >> 16; // красный
                        float G = (pixel & 0x0000FF00) >> 8; // зеленый
                        float B = pixel & 0x000000FF; // синий
                                                               
                        R = G = B = (R + G + B) / 3.0f;// делаем цвет черно-белым (оттенки серого) - находим среднее арифметическое
                        // собираем новый пиксель по частям (по каналам)
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                        // добавляем его в Bitmap нового изображения
                        Bmono.SetPixel(x, y, Color.FromArgb((int)newPixel));
                    }
                }
            }
            pB_mono.Image = Bmono;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += Assembly.GetExecutingAssembly().GetName().Version;
            MinimumSize = Size;
        }

        private void b_export_Click(object sender, EventArgs e)
        {
            if (pB_mono.Image != null)
            {
                sFD.FileName = l_fileName.Text;
                if (sFD.ShowDialog() == DialogResult.OK)// если в диалоге была нажата кнопка ОК
                {
                    try
                    {
                        pB_mono.Image.Save(sFD.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при сохранении изображения", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                                       
                }
            }
            else
            {
                MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b_openImages_Click(object sender, EventArgs e)
        {
            DialogResult dr=oFD.ShowDialog();           
            if (dr==DialogResult.OK) // если в диалоге была нажата кнопка ОК
            {
                try
                {
                    fileNames=oFD.FileNames;
                    safeFileNames = oFD.SafeFileNames;
                    l_fileName.Text = safeFileNames[0];
                    //pB_mono.ImageLocation = fileNames[0];// загружаем изображение

                    if (fileNames.Length>1)
                    {
                        b_next.Enabled = true;
                    }

                    

                    Stopwatch stopwatch = new Stopwatch();//создаем объект для того что бы засеч время
                    stopwatch.Start();//засекаем время начала операции

                     ColoredToBW(fileNames[0]);

                    stopwatch.Stop();//останавливаем счётчик            
                    TimeSpan ts = stopwatch.Elapsed;

                    string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", // Создаем строку, содержащую время выполнения операции.
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);

                    l_time.Text = elapsedTime;
                }
                catch // в случае ошибки выводим MessageBox
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        void stopWatchFunc(Delegate func)
        {
            Stopwatch stopwatch = new Stopwatch();//создаем объект для того что бы засеч время
            stopwatch.Start();//засекаем время начала операции

            //func(fileNames[0]);

            stopwatch.Stop();//останавливаем счётчик            
            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", // Создаем строку, содержащую время выполнения операции.
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            l_time.Text = elapsedTime;
        }

        private void ColoredToBW(string img)
        {
            Bitmap BWBitmap;
            Color BWColor;
            byte level = (byte)NUpD_lavel.Value;
            bool isBWImage=true;//для определеия что изображение изначально черно белое
            using (Bitmap bmp = new Bitmap(img))//присваивание нужно для того что бы можно было передать стринг
            {
                BWBitmap = new Bitmap(bmp.Width, bmp.Height);                

                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color p = bmp.GetPixel(x, y);
                        if (p.A != 0) {
                            if (p != Color.FromArgb(0, 0, 0) && p != Color.FromArgb(255, 255, 255))
                            {
                                bool isWhite = p.R >= level &&
                                               p.G >= level &&
                                               p.B >= level;

                                BWColor = isWhite ? Color.White : Color.Black;
                                BWBitmap.SetPixel(x, y, BWColor);//можно объединить
                                isBWImage = false;
                            }
                            else
                            {
                                BWBitmap.SetPixel(x, y, p);//можно объединить
                            }
                        }
                    }
                }
            }
            
            pB_mono.Image = new Bitmap(BWBitmap);

            BWBitmap.Dispose();
        }

        private void b_next_Click(object sender, EventArgs e)
        {
            if ((++fNCount) == fileNames.Length - 1)
            {
                b_next.Enabled = false;
                
            }
            else
            {
                b_next.Enabled = true;
            }

            b_prev.Enabled = true;
            //pB_mono.ImageLocation = fileNames[fNCount];
            l_fileName.Text = safeFileNames[fNCount];
            ColoredToBW(fileNames[fNCount]);
        }

        private void b_prev_Click(object sender, EventArgs e)
        {
            if (--fNCount == 0)
            {
                b_prev.Enabled = false;
            }
            else
            {
                b_next.Enabled = true;
                b_prev.Enabled = true;
            }

            //pB_mono.ImageLocation = fileNames[fNCount];
            l_fileName.Text = safeFileNames[fNCount];
            ColoredToBW(fileNames[fNCount]);
        }

        private void cMS_fotPicBox_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == TSMI_normal)
            {
                pB_mono.SizeMode = PictureBoxSizeMode.Normal;
            }
            else if (e.ClickedItem == TSMI_stretchImage)
            {
                pB_mono.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (e.ClickedItem == TSMI_CenterImage)
            {
                pB_mono.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (e.ClickedItem == TSMI_zoom)
            {
                pB_mono.SizeMode = PictureBoxSizeMode.Zoom;
            }
            //else if (e.ClickedItem == TSMI_autoSize)
            //{
            //    pB_colored.SizeMode = PictureBoxSizeMode.AutoSize;
            //    pB_mono.SizeMode = PictureBoxSizeMode.AutoSize;
            //}
        }

        private void pB_mono_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //cMS_fotPicBox.Items.Clear(); // Ну, или сразу в OnLoad заполняешь пункты
                //                contextMenuStrip1.Items.Add("Очистить \"Начислено\"");

                cMS_fotPicBox.Show();
            }
        }

        private void NUpD_lavel_ValueChanged(object sender, EventArgs e)
        {
            ColoredToBW(fileNames[fNCount]);
        }

        private void b_prev_MouseDown(object sender, MouseEventArgs e)
        {
            if (--fNCount == 0)
            {
                b_prev.Enabled = false;
            }
            else
            {
                b_next.Enabled = true;
                b_prev.Enabled = true;
            }

            //pB_mono.ImageLocation = fileNames[fNCount];
            l_fileName.Text = safeFileNames[fNCount];
            ColoredToBW(fileNames[fNCount]);
        }
    }
}
