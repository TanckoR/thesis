using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Обучение
{
    public partial class Form : System.Windows.Forms.Form
    {
        List<Bitmap> all_num = new List<Bitmap>();
        List<Bitmap> all_num_info = new List<Bitmap>();
        List<Bitmap> all_num_count = new List<Bitmap>();
        List<Bitmap> simples = new List<Bitmap>();
        List<String> text = new List<String>();

        Bitmap bmp,bmp_simple;
        List<Point> points = new List<Point>();
        bool isClicked = false;

        int X_START = 0, Y_START = 0;
        int X_END = 0, Y_END = 0;

        public Form()
        {
            InitializeComponent();
            bmp = new Bitmap(200, 240);
           // bmp_simple = new Bitmap(200, 240);

            all_num.Add(global::Обучение.Properties.Resources._0);
            all_num.Add(global::Обучение.Properties.Resources._1);
            all_num.Add(global::Обучение.Properties.Resources._2);
            all_num.Add(global::Обучение.Properties.Resources._3);
            all_num.Add(global::Обучение.Properties.Resources._4);
            all_num.Add(global::Обучение.Properties.Resources._5);
            all_num.Add(global::Обучение.Properties.Resources._6);
            all_num.Add(global::Обучение.Properties.Resources._7);
            all_num.Add(global::Обучение.Properties.Resources._8);
            all_num.Add(global::Обучение.Properties.Resources._9);

            all_num_info.Add(global::Обучение.Properties.Resources._0info);
            all_num_info.Add(global::Обучение.Properties.Resources._1info);
            all_num_info.Add(global::Обучение.Properties.Resources._2info);
            all_num_info.Add(global::Обучение.Properties.Resources._3info);
            all_num_info.Add(global::Обучение.Properties.Resources._4info);
            all_num_info.Add(global::Обучение.Properties.Resources._5info);
            all_num_info.Add(global::Обучение.Properties.Resources._6info);
            all_num_info.Add(global::Обучение.Properties.Resources._7info);
            all_num_info.Add(global::Обучение.Properties.Resources._8info);
            all_num_info.Add(global::Обучение.Properties.Resources._9info);

            all_num_count.Add(global::Обучение.Properties.Resources.Blank);
            all_num_count.Add(global::Обучение.Properties.Resources.images);
            all_num_count.Add(global::Обучение.Properties.Resources._2count);
            all_num_count.Add(global::Обучение.Properties.Resources._3count);
            all_num_count.Add(global::Обучение.Properties.Resources._4count);
            all_num_count.Add(global::Обучение.Properties.Resources._5count);
            all_num_count.Add(global::Обучение.Properties.Resources._6count);
            all_num_count.Add(global::Обучение.Properties.Resources._7count);
            all_num_count.Add(global::Обучение.Properties.Resources._8count);
            all_num_count.Add(global::Обучение.Properties.Resources._9count);

           simples.Add(global::Обучение.Properties.Resources.simple0);
            simples.Add(global::Обучение.Properties.Resources.simple1);
            simples.Add(global::Обучение.Properties.Resources.simple2);
            simples.Add(global::Обучение.Properties.Resources.simple3);
            simples.Add(global::Обучение.Properties.Resources.simple4);
            simples.Add(global::Обучение.Properties.Resources.simple5);
            simples.Add(global::Обучение.Properties.Resources.simple6);
            simples.Add(global::Обучение.Properties.Resources.simple7);
            simples.Add(global::Обучение.Properties.Resources.simple8);
            simples.Add(global::Обучение.Properties.Resources.simple9);

            text.Add("\nНоль похож на колобок,\nОн пузат и круглобок.\nНа него похожа Кошка,\nЕсли сложится в клубок.\n ");
            text.Add("\nЭта цифра — единица.\nТонкий носик, будто спица,\nВниз повесила. Грустна,\nВедь она всего одна.\n ");
            text.Add("\nВыгнуть так, как двойка, шею\nЯ, пожалуй, не сумею.\nМожет, сможешь ты? Едва!\nСмогут лебедь с цифрой Два.\n ");
            text.Add("\nТри смешных букашки\nГладили рубашки.\nПо три пуговки на них,\nИ по три кармашка.\n ");
            text.Add("\nУ соседской кошки Капы\nОдин хвост, Четыре лапы,\nИ для кошкиной красы\nОчень длинные усы.\n ");
            text.Add("\nУ колючих у Ежей\nПять ежаток -малышей.\nА у Кошки полосатой\nПять приятелей мышей.\n ");
            text.Add("\nШесть спортсменов,\n шесть парней,\nШайба, клюшки, \nлед, хоккей.\nСчет Шесть:Шесть, и снова:\n «Гол!»\nТренер «наших» очень зол!!\n ");
            text.Add("\nСемь коричневых\n орешков\nБелка осенью в\n листочки закопала.\nА зима все\n снегом завалило -\nДо весны орешки\n белочка искала.\n ");
            text.Add("\nВОСЕМЬ маленьких лягушек\nСобрались покушать мушек.\nУвидали цаплю –\nУх!\nПрыг в болото:\nПлюх!Плюх!Плюх!\nИ ещё:\nПлюх, плюх,\nПлюх, плюх!\nПлюх!\n ");
            text.Add("\nЦифра девять иль девятка-\nЦирковая акробатка:\nЕсли на голову встанет,\nЦифрой шесть девятка станет.\n ");


           ShowMainMenu();

        }
        //удалить все
        void DeleteAll()
        {
            this.Controls.Clear();

        }

        //показать меню
        private void ShowMainMenu()
        {
            DeleteAll();
            PictureBox pct = new PictureBox();
            pct.Height = 250;
            pct.Width = 150;
            pct.Name = "mainLearn";
            pct.Image = global::Обучение.Properties.Resources.main1;
            pct.SizeMode= System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pct.Left = 160;
            pct.Top = 30;
            pct.BackColor = Color.Transparent;
            this.Controls.Add(pct);


            PictureBox pct2 = new PictureBox();
            pct2.Height = 250;
            pct2.Width = 150;
            pct2.Name = "mainExam";
            pct2.Image = global::Обучение.Properties.Resources.main2;
            pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pct2.Left = 380;
            pct2.Top = 30;
            pct2.BackColor = Color.Transparent;
            this.Controls.Add(pct2);

            Button AddBtn = new Button(); //sozdanie knopku
            AddBtn.Name = "btnLearn"; //daesh nazvanie svoie knopki
            AddBtn.Parent = this;
            AddBtn.Text = "Изучаем цифры"; //nadpis' na knopke
            AddBtn.BackColor = SystemColors.Control; //cvet knopki
            AddBtn.Location = new Point(170, 290); //pologenie na forme
            AddBtn.FlatStyle = FlatStyle.Popup; //stil' knopki
            AddBtn.Click += new EventHandler(BtnLearn_Click); //obrabotchik, s pomosh'u kotorogo mogesh zadat' knopke deistvie
            AddBtn.Enabled = true; //knopka aktivna
            AddBtn.Size = new Size(100, 50);
            this.Controls.Add(AddBtn);

            Button AddBtn2 = new Button(); //sozdanie knopku
            AddBtn2.Name = "btnLearn"; //daesh nazvanie svoie knopki
            AddBtn2.Parent = this;
            AddBtn2.Text = "Как пишем цифры"; //nadpis' na knopke
            AddBtn2.BackColor = SystemColors.Control; //cvet knopki
            AddBtn2.Location = new Point(410, 290); //pologenie na forme
            AddBtn2.FlatStyle = FlatStyle.Popup; //stil' knopki
            AddBtn2.Click += new EventHandler(BtnExam_Click); //obrabotchik, s pomosh'u kotorogo mogesh zadat' knopke deistvie
            AddBtn2.Enabled = true; //knopka aktivna
            AddBtn2.Size = new Size(100, 50);
            this.Controls.Add(AddBtn);
        }
        private void ShowExamMenu()
        {
            DeleteAll();
           
            Button AddBtn = new Button(); //sozdanie knopku
            AddBtn.Name = "btnLearn"; //daesh nazvanie svoie knopki
            AddBtn.Parent = this;
            AddBtn.Text = "Назад"; //nadpis' na knopke
            AddBtn.BackColor = SystemColors.Control; //cvet knopki
            AddBtn.Location = new Point(10, 10); //pologenie na forme
            AddBtn.FlatStyle = FlatStyle.Popup; //stil' knopki
            AddBtn.Click += new EventHandler(BtnBackToMain_Click); //obrabotchik, s pomosh'u kotorogo mogesh zadat' knopke deistvie
            AddBtn.Enabled = true; //knopka aktivna
            AddBtn.Size = new Size(100, 50);
            this.Controls.Add(AddBtn);

            for (int i = 0, k = 0; i < 10; i++, k++)
            {
                PictureBox pct = new PictureBox();
                pct.Height = 120;
                pct.Width = 120;
                pct.Name = "pageExamImg" + i;
                pct.Image = all_num[i];
                pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                if (i % 5 == 0) k = 0;
                pct.Left = 80 + k * 120;
                pct.Top = 60 + (i / 5) * 150;
                pct.BackColor = Color.Transparent;
                pct.Click += new EventHandler(imgExamClick);
                this.Controls.Add(pct);

            }


        }
     
        private void ShowLearnMenu()
        {
            DeleteAll();

            Button AddBtn = new Button(); //sozdanie knopku
            AddBtn.Name = "btnLearn"; //daesh nazvanie svoie knopki
            AddBtn.Parent = this;
            AddBtn.Text = "Назад"; //nadpis' na knopke
            AddBtn.BackColor = SystemColors.Control; //cvet knopki
            AddBtn.Location = new Point(10, 10); //pologenie na forme
            AddBtn.FlatStyle = FlatStyle.Popup; //stil' knopki
            AddBtn.Click += new EventHandler(BtnBackToMain_Click); //obrabotchik, s pomosh'u kotorogo mogesh zadat' knopke deistvie
            AddBtn.Enabled = true; //knopka aktivna
            AddBtn.Size = new Size(100, 50);
            this.Controls.Add(AddBtn);


            for (int i = 0, k = 0; i < 10; i++, k++)
            {
                PictureBox pct = new PictureBox();
                pct.Height = 120;
                pct.Width = 120;
                pct.Name = "pageLearnImg" + i;
                pct.Image = all_num[i];
                pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                if (i % 5 == 0) k = 0;
                pct.Left = 80 + k * 120;
                pct.Top = 60 + (i / 5) * 150;
                pct.BackColor = Color.Transparent;
                pct.Click += new EventHandler(imgLearnClick);
                this.Controls.Add(pct);

            }


        }

        private void BtnExam_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Нажата кнопка 2");
            ShowExamMenu();

        }

        private void BtnLearn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Нажата кнопка 1");
            ShowLearnMenu();
        }
        
        //прорисовка элемента изображения
        private void imgLearnClick(object sender, EventArgs e)
        {

            
            String name= (sender as PictureBox).Name;
            int num = Convert.ToInt16(name[name.Length - 1] - 48);

            Console.WriteLine("Нажато = "+ name);
            Console.WriteLine("NUM = " + num);

            DeleteAll();

            Button AddBtn = new Button(); //sozdanie knopku
            AddBtn.Name = "btnLearn"; //daesh nazvanie svoie knopki
            AddBtn.Parent = this;
            AddBtn.Text = "Назад"; //nadpis' na knopke
            AddBtn.BackColor = SystemColors.Control; //cvet knopki
            AddBtn.Location = new Point(10, 10); //pologenie na forme
            AddBtn.FlatStyle = FlatStyle.Popup; //stil' knopki
            AddBtn.Click += new EventHandler(BtnBackToLearn_Click); //obrabotchik, s pomosh'u kotorogo mogesh zadat' knopke deistvie
            AddBtn.Enabled = true; //knopka aktivna
            AddBtn.Size = new Size(100, 50);
            this.Controls.Add(AddBtn);

            PictureBox pct = new PictureBox();
            pct.Height = 250;
            pct.Width = 150;
            pct.Name = "pagePicture";
            pct.Image = all_num_info[num];
            pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;         
            pct.Left = 50 ;
            pct.Top = 80 ;
            pct.BackColor = Color.Transparent;
            this.Controls.Add(pct);


            Label lb = new Label();
            lb.Location = new Point(220, 100);
            lb.AutoSize = true;
            lb.Font = new Font("Tobota", 11, FontStyle.Italic);
            lb.Text = text[num];
            this.Controls.Add(lb);

            PictureBox pct2 = new PictureBox();
            pct2.Height = 220;
            pct2.Width = 220;
            pct2.Name = "pagePicture";
            pct2.Image = all_num_count[num];
            pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pct2.Left = 450;
            pct2.Top = 80;
            pct2.BackColor = Color.Transparent;
            this.Controls.Add(pct2);


        }

        private void BtnBackToLearn_Click(object sender, EventArgs e)
        {
            
            ShowLearnMenu();
        }

        private void BtnBackToMain_Click(object sender, EventArgs e)
        {
            ShowMainMenu();
        }

        private void BtnBackToExam_Click(object sender, EventArgs e)
        {
            points.Clear();
            ShowExamMenu();
        }
        PictureBox pctDraw;
        Label lb;
        //прорисовка форм для рисование и вызов анализа изображений
        private void imgExamClick(object sender, EventArgs e)
        {
            String name = (sender as PictureBox).Name;
            int num = Convert.ToInt16(name[name.Length - 1] - 48);

            Console.WriteLine("Нажато = " + name);
            Console.WriteLine("NUM = " + num);
            exam_num = num;
            DeleteAll();

            Button AddBtn = new Button(); //sozdanie knopku
            AddBtn.Name = "btnExamBack"; //daesh nazvanie svoie knopki
            AddBtn.Parent = this;
            AddBtn.Text = "Назад"; //nadpis' na knopke
            AddBtn.BackColor = SystemColors.Control; //cvet knopki
            AddBtn.Location = new Point(10, 10); //pologenie na forme
            AddBtn.FlatStyle = FlatStyle.Popup; //stil' knopki
            AddBtn.Click += new EventHandler(BtnBackToExam_Click); //obrabotchik, s pomosh'u kotorogo mogesh zadat' knopke deistvie
            AddBtn.Enabled = true; //knopka aktivna
            AddBtn.Size = new Size(100, 50);
            this.Controls.Add(AddBtn);


            //пример изображения - как оно должно выглядеть
            PictureBox pct2 = new PictureBox();
            pct2.Height = 240;
            pct2.Width = 200;
            pct2.Name = "examPic2";
            pct2.Image = simples[num];
            pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pct2.Left = 420;
            pct2.Top = 30;
            pct2.BackColor = Color.Transparent;
            this.Controls.Add(pct2);


            Button AddBtn2 = new Button(); //sozdanie knopku
            AddBtn2.Name = "btnExamAnalis"; //daesh nazvanie svoie knopki
            AddBtn2.Parent = this;
            AddBtn2.Text = "ПРОВЕРИТЬ"; //nadpis' na knopke
            AddBtn2.BackColor = SystemColors.Control; //cvet knopki
            AddBtn2.Location = new Point(195, 290); //pologenie na forme
            AddBtn2.FlatStyle = FlatStyle.Popup; //stil' knopki
            AddBtn2.Click += new EventHandler(BtnExamRes_Click); //obrabotchik, s pomosh'u kotorogo mogesh zadat' knopke deistvie
            AddBtn2.Enabled = true; //knopka aktivna
            AddBtn2.Size = new Size(100, 50);
            this.Controls.Add(AddBtn2);

             lb = new Label();
            lb.Location = new Point(315, 305);
            lb.AutoSize = true;
            lb.Font = new Font("Tobota", 12, FontStyle.Italic);
            lb.Text = "Нарисуй и нажми ПРОВЕРИТЬ";
            this.Controls.Add(lb);

            //поле для рисования
            pctDraw = new PictureBox();
            pctDraw.Height = 240;
            pctDraw.Width = 200;
            pctDraw.Name = "examPic1";       
            pctDraw.SizeMode = PictureBoxSizeMode.StretchImage;
            pctDraw.MouseMove+=new MouseEventHandler(ImgRes_Move);
            pctDraw.Paint += new PaintEventHandler(ImgRes__Paint);
            pctDraw.MouseDown += new MouseEventHandler(ImgRes__MouseDown);
            pctDraw.MouseUp += new MouseEventHandler(ImgRes__MouseUp);
            pctDraw.Left = 160;
            pctDraw.Top = 30;
            pctDraw.BackColor = Color.White;
            this.Controls.Add(pctDraw);
                     

        }

        private void ImgRes__MouseUp(object sender, MouseEventArgs e)
        {
            X_END = e.X;
            Y_END = e.Y;
            
            pctDraw.Invalidate();
            isClicked = false;
        }

       
        private void ImgRes__MouseDown(object sender, MouseEventArgs e)
        {
           
            //рисование кривой
           
            
                points.Clear();
                isClicked = true;
                
                points.Add(new Point(e.X, e.Y));
                X_START = e.X;
                Y_START = e.Y;
            
        }

        private void ImgRes__Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Green);
            pen.Width = 6;
            for (int i = 0; i < points.Count - 1; i++)
                g.DrawLine(pen, points[i], points[i + 1]);
            pctDraw.Image = bmp;
        }

        //рисование на форме
        private void ImgRes_Move(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Move = {0} {1}",e.X, e.Y);
            if (isClicked)
            {
                points.Add(new Point(e.X, e.Y));
                pctDraw.Invalidate();
            }
        }

        int exam_num = -1;
        private void BtnExamRes_Click(object sender, EventArgs e)
        {

            bmp.Save("image.bmp");

            bmp_simple = new Bitmap(simples[exam_num]);
            bmp_simple.Save("simple.bmp");

            int count = 0,count_simple=0,count_this=0;

            int minx = bmp_simple.Width, miny = bmp_simple.Height;
            if (minx > bmp.Width) minx = bmp.Width;
            if (miny > bmp.Width) miny = bmp.Width;

            for (int x = 0; x < minx; x++)
                for (int y = 0; y < miny; y++)
                {
                    if (bmp.GetPixel(x, y).ToArgb() == Color.Green.ToArgb() && bmp_simple.GetPixel(x, y).ToArgb() == Color.Black.ToArgb())
                        count++;

                    if (bmp.GetPixel(x, y).ToArgb() == Color.Green.ToArgb())
                        count_simple++;

                    if (bmp_simple.GetPixel(x, y).ToArgb() == Color.Black.ToArgb())
                        count_this++;                      
                }

            double koef = count * 100.0 / (count_simple + count_this - count);

            if (koef>10)//10% совпадения
            lb.Text = Convert.ToString("Молодец! Это "+exam_num);
            else lb.Text = Convert.ToString("Попробуй ещё раз! У тебя получится!");
            
            //lb.Text = Convert.ToString(count+" "+count_simple + " " + count_this+"  "+koef);
        }
    }
}
