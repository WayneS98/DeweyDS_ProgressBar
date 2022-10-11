using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace PROG7312TASK1WAYNESTEVENS
{
    public partial class ReplacingBooks : System.Web.UI.Page
    {
        //Declaring Our total here to get the sum of points
        public static int total = 0;
        public int click = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        
        protected void BtnGen_Click(object sender, EventArgs e)

        {
            //Neater Pull from method to button
            GetNumbers();         
        }
        
        public void GetNumbers()
        {
            //This is code used to make a achevement progress bar 
            //References Mark Otto, a., 2022. Components · Bootstrap. [online] Getbootstrap.com. Available at: <https://getbootstrap.com/docs/3.4/components/#progress-stacked> [Accessed 30 August 2022].
            
            //This is used to get random numbers
            Random rnd = new Random();
            int[] numbers = new int[10];
                 
            //This will Create and display random numbers that are between the Ranges of 0 to 999
            //We will need 10 random numbers
            //References Thedeveloperblog.com. 2022. C# Random Number Examples. [online] Available at: <https://thedeveloperblog.com/c-sharp/random#:~:text=C%23%20program%20that%20uses%20modulo%20with%20Random%20using,%3C%2010%3B%20i%2B%2B%29%20%7B%20int%20result%20%3D%20random.> [Accessed 29 August 2022].
            double numb1 = rnd.Next(0, 1000);
            double numb2 = rnd.Next(0, 1000);
            double numb3 = rnd.Next(0, 1000);
            double numb4 = rnd.Next(0, 1000);
            double numb5 = rnd.Next(0, 1000);
            double numb6 = rnd.Next(0, 1000);
            double numb7 = rnd.Next(0, 1000);
            double numb8 = rnd.Next(0, 1000);
            double numb9 = rnd.Next(0, 1000);
            double numb10 = rnd.Next(0, 1000);
            //Reference numbers, S., Hornby, J., Winney, G., Kingen, D. and S., D., 2022. Sort a collection of randomly generated numbers. [online] Stack Overflow. Available at: <https://stackoverflow.com/questions/15484635/sort-a-collection-of-randomly-generated-numbers> [Accessed 29 August 2022]

            //This displays the list in Labels so the user can see the numbers and change them Accordinlgy 
            Lbl1.Text = numb1.ToString();           
            Lbl2.Text = numb2.ToString();
            Lbl3.Text = numb3.ToString();
            Lbl4.Text = numb4.ToString();
            Lbl5.Text = numb5.ToString();
            Lbl6.Text = numb6.ToString();
            Lbl7.Text = numb7.ToString();
            Lbl8.Text = numb8.ToString();
            Lbl9.Text = numb9.ToString();
            Lbl10.Text = numb10.ToString();

            //This is Text Boxes that allow to show numbers and to change numbers around
            //References ---
            Txt1.Text = numb1.ToString();
            Txt2.Text = numb2.ToString();
            Txt3.Text = numb3.ToString();
            Txt4.Text = numb4.ToString();
            Txt5.Text = numb5.ToString();
            Txt6.Text = numb6.ToString();
            Txt7.Text = numb7.ToString();
            Txt8.Text = numb8.ToString();
            Txt9.Text = numb9.ToString();
            Txt10.Text = numb10.ToString();


            //Using a label in order to get a random Letters,WONT REARRANGE USER WILL JUST NEED TO ADD LETTERS 
            //WHEN NUMBERS ARE IN ORDER       
            LblLet1.Text = CreateLetters();
            LblLet2.Text = CreateLetters();
            LblLet3.Text = CreateLetters();
            LblLet4.Text = CreateLetters();
            LblLet5.Text = CreateLetters();
            LblLet6.Text = CreateLetters();
            LblLet7.Text = CreateLetters();
            LblLet8.Text = CreateLetters();
            LblLet9.Text = CreateLetters();
            LblLet10.Text = CreateLetters();  






        }

        protected void BtnInspect_Click(object sender, EventArgs e)
            
        {            
            LblLevelup.Text = (total).ToString();
  
            
      
            //For the Method to check the numbers we adding the Algorithm of the Bubble Sort method 
            //References 
            //This is a method which is used to make sure each text box and the label shown is corrsponding 
            // smallest to highest
            double numb1 = Convert.ToDouble(Lbl1.Text);
            double numb2 = Convert.ToDouble(Lbl2.Text);
            double numb3 = Convert.ToDouble(Lbl3.Text);
            double numb4 = Convert.ToDouble(Lbl4.Text);
            double numb5 = Convert.ToDouble(Lbl5.Text);
            double numb6 = Convert.ToDouble(Lbl6.Text);
            double numb7 = Convert.ToDouble(Lbl7.Text);
            double numb8 = Convert.ToDouble(Lbl8.Text);
            double numb9 = Convert.ToDouble(Lbl9.Text);
            double numb10 = Convert.ToDouble(Lbl10.Text);

            //Algorithm and this we using the Bubble sort Array
            double[] ar = new double[] { numb1, numb2, numb3, numb4, numb5, numb6, numb7, numb8, numb9, numb10 };

            BubbleSort(ar);
            foreach (int n in ar)
            Lbl1.Text = ar[0].ToString();
            Lbl2.Text = ar[1].ToString();
            Lbl3.Text = ar[2].ToString();
            Lbl4.Text = ar[3].ToString();
            Lbl5.Text = ar[4].ToString();
            Lbl6.Text = ar[5].ToString();
            Lbl7.Text = ar[6].ToString();
            Lbl8.Text = ar[7].ToString();
            Lbl9.Text = ar[8].ToString();
            Lbl10.Text = ar[9].ToString();


        

            if (Txt1.Text == Lbl1.Text && Txt2.Text == Lbl2.Text &&
                Txt3.Text == Lbl3.Text && Txt4.Text == Lbl4.Text &&
                Txt5.Text == Lbl5.Text && Txt6.Text == Lbl6.Text &&
                Txt7.Text == Lbl7.Text && Txt8.Text == Lbl8.Text &&
                Txt9.Text == Lbl9.Text && Txt10.Text == Lbl10.Text)
            {               
                LblWR.Text = "WELL DONE YOUR NUMBERS ARE IN THE CORRECT ORDER ! " ;              
                LblWR.ForeColor = Color.DarkGreen;                         
                total += 15;
                UpdateProgressBar(Convert.ToDouble(total), 60.0);
            }
            else
            {
                LblWR.Text = " YOUR NUMBERS ARE INCORRECT PLEASE LOOK AT THE ORDER! ";                
                LblWR.ForeColor = Color.Red;
            }
            //This if statment is used to go through totals if users gets answers correct
            //Gamification method
            //Each time will show on Progress Bar aswell
            if(total <= 15)
            {              
                LblLevelup.Text = " Ranked Up Level 1 : " + total;
                LblLevelup.ForeColor = Color.Yellow;              
            }
            if (total == 30)
            {              
                LblLevelup.Text = "Ranked Up Level 2 : " + total;
                LblLevelup.ForeColor = Color.DeepPink;              
            }
          if (total == 45)
            {             
                LblLevelup.Text = "Ranked Up Level 3 : " + total;
                LblLevelup.ForeColor = Color.Purple;
            } 
          if(total == 60)
            {
                LblLevelup.Text = "LEVEL 4, MAX POINTS REACHED! : " + total;
                LblLevelup.ForeColor = Color.Blue;                    
            }   
          
        }

        //this method will create the random letters next to each number with only 3 letters
        //References C-sharpcorner.com. 2022. Random Password In C#. [online] Available at: <https://www.c-sharpcorner.com/article/how-to-generate-a-random-password-in-c-sharp-and-net-core/> [Accessed 30 August 2022].

        public static string CreateLetters(int length = 3)
        {
            string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rnd = new Random();
            var randomLetters = new string(Enumerable.Repeat(Letters, length)
                                                    .Select(s => s[rnd.Next(s.Length)]).ToArray());
            return randomLetters;
        }
 




        //We are now going to use a Algorithm and this we using the Bubble sort 
        //References --- GeeksforGeeks. 2022. Bubble Sort Algorithm - GeeksforGeeks. [online] Available at: <https://www.geeksforgeeks.org/bubble-sort/> [Accessed 30 August 2022].

        void BubbleSort(double[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = (int)arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }       
        private void UpdateProgressBar(double score, double maxScore)
        {
            //Gets the percentage to show on the progress bar each time it is updated
            var Percentage = ((score / maxScore) * 100.0);

            progressBar.Attributes.Add("style", String.Format("width:{0}%", Percentage));
            progressBar.Attributes.Add("aria-valuenow", Percentage.ToString());
            lblPercentage.InnerText = String.Format("{0}%", Percentage);
        }

    }
    }

    
       
    
 
    

      
    

    

    
