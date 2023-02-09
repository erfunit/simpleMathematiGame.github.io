using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //data declaration:
        //متغیر امتیاز
        int score = 0;
        
        //تولید عدد رندوم
        Random mainNumberRandom = new Random();

        //آرایه های ردیف ها
        int[] row1Array=new int[4];
        int[] row2Array=new int[4];
        int[] row3Array=new int[4];
        int[] row4Array=new int[4];

        //lists of labels:
        //list 1:
        Label row1label;
        List<Label> row1List = new List<Label>();
        //list 2:
        Label row2label;
        List<Label> row2List = new List<Label>();
        //list 3:
        Label row3label;
        List<Label> row3List = new List<Label>();
        //list 4:
        Label row4label;
        List<Label> row4List = new List<Label>();

        //آرایه ای که اگر هر 4 خانه ترو باشد میبازد
        bool[] blocks= {false,false,false,false};


        //timer declaration:
        int timer = 10;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            showArrays();
            timerLabel.Text = timer.ToString();
        }


        private void mainNumber_Click(object sender, EventArgs e)
        {
            //در هر 4 کنترل اصلی صفحه یک اتفاق ثابت می افتد که آن ها را در یک ایونت 
            int number = mainNumberRandom.Next(1, 100);
                mainNumber.Text = number.ToString();
                Random r = new Random();
                mainNumber.BackColor = Color.FromArgb(r.Next(200, 256), r.Next(200, 256), 0);
                scoreLbl.Text=score.ToString();
                timer1.Enabled = true;
                timer = 10;
        }

        private void row1_MouseDown(object sender, MouseEventArgs e)
        {
            //اتفاقاتی که در هر یک از کنترل های اصلی صفحه می افتد:
            for (int i = 0; i < row1Array.Length; i++)
            {
                if (row1Array[i] == 0)
                {
                    //generate label:
                    row1label = new Label();
                    generateLables(i,row1List,mainNumber,row1label);
                    //add to array:
                    row1Array[i] = int.Parse(mainNumber.Text);
                    break;
                }
                else
                    continue;
            }


            removeLabel(row1Array, row1List);
            disableIfFIll(row1Array, row1);
            showArrays();
            //چک کردن ترو بودن خانه ی آخر
            if (blocks[3])
            {
                //وقتی خانه ی آخر بلاکس ترو باشد بازنده است
                    failedMessage();
            }
        }

        private void row2_MouseDown(object sender, MouseEventArgs e)
        {
                for (int i = 0; i < row2Array.Length; i++)
                {
                    if (row2Array[i] == 0)
                {
                    row2label = new Label();
                    generateLables(i, row2List, mainNumber, row2label);
                    row2Array[i] = int.Parse(mainNumber.Text);
                    break;
                }
                else
                    continue;
                }
            removeLabel(row2Array, row2List);
            disableIfFIll(row2Array, row2);
            showArrays();

            if (blocks[3])
            {
                failedMessage();
            }

        }

        private void row3_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < row3Array.Length; i++)
            {
                if (row3Array[i] == 0)
                {
                    row3label = new Label();
                    generateLables(i, row3List, mainNumber, row3label);
                    row3Array[i] = int.Parse(mainNumber.Text);
                    break;
                }
                else
                    continue;
            }
            removeLabel(row3Array, row3List);
            disableIfFIll(row3Array, row3);
            showArrays();
            if (blocks[3])
            {
                failedMessage();
            }
        }

        private void row4_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < row4Array.Length; i++)
            {
                if (row4Array[i] == 0)
                {
                    row4label = new Label();
                    generateLables(i, row4List, mainNumber, row4label);
                    row4Array[i] = int.Parse(mainNumber.Text);
                    break;
                }
                else
                    continue;
            }
            removeLabel(row4Array, row4List);
            disableIfFIll(row4Array, row4);
            showArrays();
            if (blocks[3])
            {
                failedMessage();
            }
        }

        private void mainNumber_Click(object sender, MouseEventArgs e)
        {
            int number = mainNumberRandom.Next(1, 100);
            mainNumber.Text = number.ToString();
            Random r = new Random();
            mainNumber.BackColor = Color.FromArgb(r.Next(40, 256), r.Next(40, 256), r.Next(40, 256));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        void disableIfFIll(int[] numbers ,Button btn)
        {
            if (numbers[3] != 0)
            {
                btn.Enabled = false;
                for (int i = 0; i < blocks.Length; i++)
                {
                    if (blocks[i] == false)
                    {
                        blocks[i] = true;
                        break;
                    }
                    else
                        continue;
                }
            }

        }

        //این فانکشن برای نشان دادن 4 آرایه در لیبل ها است
        void showArrays()
        {
            label5.Text = "";
            foreach (int item in row1Array)
            {
                label5.Text += item.ToString()+",";
            }

            label6.Text = "";
            foreach (int item in row2Array)
            {
                label6.Text += item.ToString() + ",";
            }

            label7.Text = "";
            foreach (int item in row3Array)
            {
                label7.Text += item.ToString() + ",";
            }

            label8.Text = "";
            foreach (int item in row4Array)
            {
                label8.Text += item.ToString() + ",";
            }
        }


        //این فانکشن به کمک آرگومان هایی که دریافت میکند لیبلِ مناسب را جنریت میکند
        void generateLables(int index,List<Label> list,Label mainnumber,Label label)
        {
            label.Text = mainnumber.Text.ToString();
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Width = 94;
            label.Height = 94;
            label.BackColor = mainNumber.BackColor;
            if (index == 0)
            {
                label.Top = 9;
            }
            else if (index == 1)
            {
                label.Top = 9 + (mainNumber.Height * 1);
            }
            else if (index == 2)
            {
                label.Top = 9 + (mainNumber.Height * 2);
            }
            else if (index == 3)
            {
                label.Top = 9 + (mainNumber.Height * 3);
            }


            if (label == row1label)
            {
                label.Left = 12;
            }
            else if (label == row2label)
            {
               label.Left= 117;
            }
            else if (label == row3label)
            {
                label.Left = 222;
            }
            else if (label == row4label)
            {
                label.Left = 328;
            }
            this.Controls.Add(label);
            list.Add(label);
        }

        //این فانکشن به کمک آرگومان هایی که دریافت میکند ردیف مورد نظر را حذف میکند
        void removeLabel(int[] labelArray,List<Label>labelList) 
        {
            int sum = 0;
            if(labelArray[1] !=0)
            {
                foreach (int item in labelArray)
                {
                    sum += item;
                }

                //درصورت زوج بودن یا مساوی بودن با توان های عدد 2
                if (sum % 2 == 0 || sum == 2 || sum == 4 || sum == 8 || sum == 16 || sum == 32 || sum == 64 || sum == 128 || sum == 256 || sum == 512 || sum == 1024)
                {
                    for (int i = 0; i < labelArray.Length; i++)
                    {
                        labelArray[i] = 0;
                    }
                    foreach (Label label in labelList)
                    {
                        this.Controls.Remove(label);
                    }
                    for (int i = 0; i < labelList.Count; i++)
                    {
                        labelList.RemoveAt(i);
                    }
                    score++;
                }
            }
            
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timer == 0)
            {
                score--;
                scoreLbl.Text = score.ToString();
                timer = 10;
                timerLabel.Text = timer.ToString();
            }
            if (score < 0)
            {
                scoreLbl.Text = "!";
                timer1.Enabled = false;
                DialogResult d = MessageBox.Show("do you wanna start again?", "you've failed!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    //خالی کردن فرم:
                    this.Controls.Clear();
                    //ایجاد دوباره ی کامپوننت ها:
                    this.InitializeComponent();
                    Array.Clear(row1Array, 0, row1Array.Length);
                    Array.Clear(row2Array, 0, row2Array.Length);
                    Array.Clear(row3Array, 0, row3Array.Length);
                    Array.Clear(row4Array, 0, row4Array.Length);
                    showArrays();
                    timer = 10;
                    timerLabel.Text = timer.ToString();
                    score = 0;
                    scoreLbl.Text = score.ToString();
                }
                else
                {
                    this.Close();
                }
            }
            if (timer < 4) 
            {
                timerLabel.ForeColor= Color.Red;
            }
            else
            {
                timerLabel.ForeColor = Color.Black ;
            }
            timerLabel.Text = timer.ToString();
            timer--;
        }


       //failed message function:
       void failedMessage()
        {
            scoreLbl.Text = "!";
            timer1.Enabled = false;
            DialogResult d = MessageBox.Show("do you wanna start again?", "you've failed!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                //خالی کردن فرم:
                this.Controls.Clear();
                //ایجاد دوباره ی کامپوننت ها:
                this.InitializeComponent();
                Array.Clear(row1Array, 0, row1Array.Length);
                Array.Clear(row2Array, 0, row2Array.Length);
                Array.Clear(row3Array, 0, row3Array.Length);
                Array.Clear(row4Array, 0, row4Array.Length);

                for (int i = 0; i < blocks.Length; i++)
                {
                    blocks[i] = false;
                }
                  
                showArrays();
                timer = 10;
                timerLabel.Text = timer.ToString();
                score = 0;
                scoreLbl.Text = score.ToString();
            }
            else
            {
                this.Close();
            }

            void emptyarrays(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = 0;
                }
            }
        }
    }
}