using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.EnterpriseServices;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using static System.Net.Mime.MediaTypeNames;


/*   Random rnd = new Random();
           Dictionary<int, string> callDes = new Dictionary<int, string>();
           callDes.Add(0, "People use code to Develop Applications");
           callDes.Add(1, "Study of Truths and pricinles of Knowledge and conduct");
           callDes.Add(2, "People have many beliefs and follow diffrent rules or laws");
           callDes.Add(3, "Fake Science");
           callDes.Add(4, "Many People can Speak it but not all can understand");
           callDes.Add(5, "Devices seem to advance each Year");
           callDes.Add(6, "Issac's newtons was a clever person and discovered the law of gravity");
           callDes.Add(7, "Mona Lisa was Created and is now a very famous picture");
           callDes.Add(8, "Can be considered to be an Art form in drama or friction");
           callDes.Add(9, "Locations and Parts of stories from years ago");*/
namespace PROG7312TASK1WAYNESTEVENS
{
    public partial class IdentifyingAreas : System.Web.UI.Page
    {
        //Declaring out sum here so points can be added
        public static int sum = 0;
        //We are creating a global counter to make sure listboxes break at the given numbers
        public static int counter = 0;
        //Declaring the Dictionary here
        public Dictionary<int, string> callNumbers = new Dictionary<int, string>();
        public List<string> unqiueRandom = new List<string>();

            public int Key { get; set; }
            
            public string Value { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            BtnCheck.Enabled = true;
        }

        protected void BtnStart_Click(object sender, EventArgs e)
        {
            //Calling method into button as it adds better performance 
            getMatches();
        }
       
        public void getMatches()
        {
            //THIS ALLOWS THE LIST TO BE CLEARED AND NEW INFORMATION TO BE ADDED
            List1.Items.Clear();
            List2.Items.Clear();
            //We are going to implement dictionary to store all our values 
            //References --

            Random random = new Random();
           
            callNumbers.Add(000, "Computer Science,information and general works");
            callNumbers.Add(100, "Philosophy and Psycology");
            callNumbers.Add(200, "Religion");
            callNumbers.Add(300, "Social Sciences");
            callNumbers.Add(400, "Language");
            callNumbers.Add(500, "Technology");
            callNumbers.Add(600, "Science");
            callNumbers.Add(700, "Arts and Recreation");
            callNumbers.Add(800, "Literature");
            callNumbers.Add(900, "History and Geography");

         
         /*   for (var i = 0; i < 4; i++)
            {
                foreach (KeyValuePair<int, string> kvp in callNumbers)
            {
                
                    var k = callNumbers.ToList()[random.Next(callNumbers.Count)];
                    callNumbers.ContainsKey(k.Key);
                    List1.Items.Add(kvp.Key.ToString());
                    List1.SelectedIndex = 0;
                    List2.Items.Add(kvp.Value);
                }
           //     List1.Items.Add(kvp.Key.ToString());
               
            }*/
            //THIS LOOP IS USED TO CREATE RANDOM CALL NUMBERS FROM THE DICTIONARY            
           for (var i = 0; i < 4; i++)          
            {                
                var k = callNumbers.ToList()[random.Next(callNumbers.Count)];
                callNumbers.ContainsKey(k.Key);
                List1.Items.Add(k.Key.ToString());
                List1.SelectedIndex = 0;
            }
                                 
                //THIS FOR LOOP IS USED TO MAKE SURE THE PROGRAM GENERATES 7 DIFFTENT DESCRIPTIONS
                for (var i = 0; i < 7; i++)
            {
               
                var k = callNumbers.ToList()[random.Next(callNumbers.Count)];
                //List2.Items.Add(call.Value);
                callNumbers.ContainsValue(k.Value);
                List2.Items.Add(k.Value.ToString());
                List2.SelectedIndex = 0;
           
                     
        } 

    }
        //This button is used to check if the Answers are correct to the given Questions
        //Refrences --
        
        protected void BtnCheck_Click(object sender, EventArgs e)
        {
            
            if//This Qouted out works but buggy as it doesnt read values from dictionary
             // (List1.SelectedIndex.ToString() == List2.SelectedIndex.ToString())
              (callNumbers[int.Parse(List1.SelectedIndex.ToString())] == List2.SelectedIndex.ToString())
            {
                
                LblQA.ForeColor = Color.Green;
                LblQA.Text = "MATCH IS CORRECT!";
                sum += 5;
                UpdateProgressBar(Convert.ToDouble(sum), 50.0);
               

            }
            else
            {
                   LblQA.ForeColor = Color.Red;
                   LblQA.Text = "INCORRECT MATCH NO POINTS!";
               


            }
            //THIS IF STATEMENTS ADDS 5 TO KEEP THE USER INTRESTED AND TO ACHEIVE HIGHER RANKS           
            //Progress Bar will use the if statement to have a visual side of things
            //References --
            if (sum <= 5)
            {
                LblRankup.Text = " Level 1, Level 2 is 1 Question away: " + sum;
                LblRankup.ForeColor = Color.Blue;
            }
            if (sum == 10)
            {
                LblRankup.Text = "Level 2, Level 3 is 1 Question away : " + sum;
                LblRankup.ForeColor = Color.Brown;
            }
            if (sum ==15 )
            {
                LblRankup.Text = "Level 3, Level 4 is 1 Question away : " + sum;
                LblRankup.ForeColor = Color.DarkViolet;
            }
            if (sum == 20 )
            {
                LblRankup.Text = "Level 4,  All Questions Correctly Answered: " + sum;
                LblRankup.ForeColor = Color.Blue;
            }
            if (sum == 25)
            {
                LblRankup.Text = "Diamond : " + sum;
                LblRankup.ForeColor = Color.Red;
            }
            if (sum == 30)
            {
                LblRankup.Text = "Crystal Highest Level: Carry on Learning " + sum;
                LblRankup.ForeColor = Color.PaleVioletRed;
            }
            

        }

        private void UpdateProgressBar(double score, double maxScore)
        {
            //This Progress bar is used to show how far a user is from completing the game
            var Percentage = ((score / maxScore) * 100.0);

            progressBar.Attributes.Add("style", String.Format("width:{0}%", Percentage));
            progressBar.Attributes.Add("aria-valuenow", Percentage.ToString());
            lblPercentage.InnerText = String.Format("{0}%", Percentage);
        }


      
        protected void BtnNewQ_Click(object sender, EventArgs e)
        {
            //THIS ALLOWS THE LIST TO BE CLEARED AND NEW INFORMATION TO BE ADDED
            //Refrences -- 
            List1.Items.Clear();
            List2.Items.Clear();
                      
        }

        protected void BtnSwop_Click(object sender, EventArgs e)
        {

            //THIS ALLOWS THE LIST TO BE CLEARED AND NEW INFORMATION TO BE ADDED
            List1.Items.Clear();
            List2.Items.Clear();
            //We are going to implement dictionary to store all our values 
            //References --

            Random random = new Random();
            callNumbers.Add(000, "Computer Science,information and general works");
            callNumbers.Add(100, "Philosophy and Psycology");
            callNumbers.Add(200, "Religion");
            callNumbers.Add(300, "Social Sciences");
            callNumbers.Add(400, "Language");
            callNumbers.Add(500, "Technology");
            callNumbers.Add(600, "Science");
            callNumbers.Add(700, "Arts and Recreation");
            callNumbers.Add(800, "Literature");
            callNumbers.Add(900, "History and Geography");

            //THIS FOR LOOP IS FOR THE CALL DESCRIPTIONS WHEN A BUTTON IS PRESSED
            for (var i = 0; i < 4; i++)
            {

                var k = callNumbers.ToList()[random.Next(callNumbers.Count)];
                //List2.Items.Add(call.Value);
                List1.Items.Add(k.Value.ToString());
                List1.SelectedIndex = 0;
            }

            //THIS LOOP IS USED TO CREATE RANDOM CALL NUMBERS FROM THE DICTIONARY 7 Numbers         
            for (var i = 0; i < 7; i++)
            {
                {

                    var k = callNumbers.ToList()[random.Next(callNumbers.Count)];
                    List2.Items.Add(k.Key.ToString());
                    List2.SelectedIndex = 0;
                }
            }

        }
    }
    }
        
    
    