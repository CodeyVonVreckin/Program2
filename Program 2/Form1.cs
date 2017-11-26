//Codey Von Vreckin
// CIS 199-01
// Program 2
// March 6th, 2016
// This program asks the user to input their current number of completed credit hours as well as their last name. 
// Once entered the program displays the day and time the user may register their classes for the upcoming  Fall 2016 Semester.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class program2 : Form
    {
        public program2()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double hours; //declares the double variable hours to hold the number of completed credit hours
            char lastName;// declares the char variable to hold the last name of the student
            const double SENIOR = 90;//declares a constant double variable to hold the # of hours required to be a Senior
            const double JUNIOR = 60;//declares a constant double variable to hold the # of hours required to be a Junior
            const double SOPHOMORE = 30;//declares a constant double variable to hold the # of hours required to be a Sophomore
            const string SENIOR_DAY = "Wednesday, March 30th";// declares the constant string variable to hold the day seniors are able to register for classes
            const string JUNIOR_DAY = "Thursday, March 31st";// declares the constant string variable to hold the day juniors are able to register for classes
            const string SOPHOMORE_DAY_1 = "Friday, April 1st";// declares the constant string variable to hold the first day sophomores are able to register for classes
            const string SOPHOMORE_DAY_2 = "Monday, April 4th";// declares the constant string variable to hold the second day sophomores are able to register for classes
            const string FRESHMAN_DAY_1 = "Tuesday, April 5th";// declares the constant string variable to hold the first day freshman are able to register for classes
            const string FRESHMAN_DAY_2 = "Wednesday, April 6th";// declares the constant string variable to hold the second day freshman are able to register for classes
            const string TIME_1 = "8:30 A.M"; //declares the constant string variable to hold the 1st time available to register for classes
            const string TIME_2 = "10:00 A.M";//declares the constant string variable to hold the 2nd time available to register for classes
            const string TIME_3 = "11:30 A.M";//declares the constant string variable to hold the 3rd time available to register for classes
            const string TIME_4 = "2:00 P.M";//declares the constant string variable to hold the 4th time available to register for classes
            const string TIME_5 = "4:00 P.M";//declares the constant string variable to hold the 5th time available to register for classes
            lastName = lastNameTxtBox.Text[0]; //pulls out the first letter of the students last name
           
            if (double.TryParse(hoursTxtBox.Text, out hours) && hours > 0) // if statment that attempts to parse the content inputed into the hours text box

                if (hours >= SENIOR) // if statment that asks if the number of hours are greater than or equal to 90
                {
                    dayLabel.Text = SENIOR_DAY;// displays the day seniors can reigster for classes in the dayLabel
                    if (lastName >= 'E' && lastName <= 'I') //asks if the first letter of the last name is between E and I                   
                        timeLabel.Text = TIME_1;// displays the 1st time available to register in the timeLabel

                    else if (lastName >= 'J' && lastName <= 'O')//asks if the first letter of the last name is between J and O  
                        timeLabel.Text = TIME_2;// displays the 2nd time available to register in the timeLabel

                    else if (lastName >= 'P' && lastName <= 'S')//asks if the first letter of the last name is between P and S  
                        timeLabel.Text = TIME_3;// displays the 3rd time available to register in the timeLabel

                    else if (lastName >= 'T' && lastName <= 'Z')//asks if the first letter of the last name is between T and Z  
                        timeLabel.Text = TIME_4;// displays the 4th time available to register in the timeLabel
                    
                    else
                        timeLabel.Text = TIME_5; // displays the 5th time available to register in the timeLabel               
                }
                else if (hours >= JUNIOR && hours < SENIOR) // if statment that asks if the number of hours are between 60 and 90
                {
                    dayLabel.Text = JUNIOR_DAY;// displays the day juniors can reigster for classes in the dayLabel
                    if (lastName >= 'E' && lastName <= 'I')//asks if the first letter of the last name is between E and I  
                        timeLabel.Text = TIME_1;// displays the 1st time available to register in the timeLabel

                    else if (lastName >= 'J' && lastName <= 'O')//asks if the first letter of the last name is between J and O  
                        timeLabel.Text = TIME_2;// displays the 2nd time available to register in the timeLabel

                    else if (lastName >= 'P' && lastName <= 'S')//asks if the first letter of the last name is between P and S  
                        timeLabel.Text = TIME_3;// displays the 3rd time available to register in the timeLabel

                    else if (lastName >= 'T' && lastName <= 'Z')//asks if the first letter of the last name is between T and Z  
                        timeLabel.Text = TIME_4;// displays the 4th time available to register in the timeLabel
                    
                    else
                        timeLabel.Text = TIME_5;// displays the 5th time available to register in the timeLabel               
                }
                else if (hours >= SOPHOMORE && hours < JUNIOR)// if statment that asks if the number of hours are between 30 and 60
                {
                    if (lastName >= 'E' && lastName <= 'Q')//asks if the first letter of the last name is between E and Q  
                    {
                        dayLabel.Text = SOPHOMORE_DAY_1;// displays the 1st day sophomores can reigster for classes in the dayLabel
                        if (lastName >= 'E' && lastName <= 'F')//asks if the first letter of the last name is between E and F  
                            timeLabel.Text = TIME_1;// displays the 1st time available to register in the timeLabel

                        else if (lastName >= 'G' && lastName <= 'I')//asks if the first letter of the last name is between G and I  
                            timeLabel.Text = TIME_2;// displays the 2nd time available to register in the timeLabel

                        else if (lastName >= 'J' && lastName <= 'L')//asks if the first letter of the last name is between J and L  
                            timeLabel.Text = TIME_3;// displays the 3rd time available to register in the timeLabel

                        else if (lastName >= 'M' && lastName <= 'O')//asks if the first letter of the last name is between M and O  
                            timeLabel.Text = TIME_4;// displays the 4th time available to register in the timeLabel
                        
                        else
                            timeLabel.Text = TIME_5;// displays the 5th time available to register in the timeLabel
                    }
                    else// performs if the first letter of the name was not between E and Q
                    {
                        dayLabel.Text = SOPHOMORE_DAY_2;// displays the 2nd day sophomores can reigster for classes in the dayLabel
                        if (lastName >= 'R' && lastName <= 'S')//asks if the first letter of the last name is between R and S  
                            timeLabel.Text = TIME_1;// displays the 1st time available to register in the timeLabel
                        
                        else if (lastName >= 'T' && lastName <= 'V')//asks if the first letter of the last name is between T and V  
                            timeLabel.Text = TIME_2;// displays the 2nd time available to register in the timeLabel
                        
                        else if (lastName >= 'W' && lastName <= 'Z')//asks if the first letter of the last name is between W and Z  
                            timeLabel.Text = TIME_3;// displays the 3rd time available to register in the timeLabel
                        
                        else if (lastName >= 'A' && lastName <= 'B')//asks if the first letter of the last name is between A and B  
                            timeLabel.Text = TIME_4;// displays the 4th time available to register in the timeLabel
                        else
                            timeLabel.Text = TIME_5;// displays the 5th time available to register in the timeLabel
                    }
                }
                else// performs if the number of hours are less than 30
                {
                    if (lastName >= 'E' && lastName <= 'Q')//asks if the first letter of the last name is between E and Q  
                    {
                        dayLabel.Text = FRESHMAN_DAY_1;// displays the 1st day freshman can reigster for classes in the dayLabel
                        if (lastName >= 'E' && lastName <= 'F')//asks if the first letter of the last name is between E and F  
                            timeLabel.Text = TIME_1;// displays the 1st time available to register in the timeLabel

                        else if (lastName >= 'G' && lastName <= 'I')//asks if the first letter of the last name is between G and I  
                            timeLabel.Text = TIME_2;// displays the 2nd time available to register in the timeLabel

                        else if (lastName >= 'J' && lastName <= 'L')//asks if the first letter of the last name is between J and L  
                            timeLabel.Text = TIME_3;// displays the 3rd time available to register in the timeLabel

                        else if (lastName >= 'M' && lastName <= 'O')//asks if the first letter of the last name is between M and O  
                            timeLabel.Text = TIME_4;// displays the 4th time available to register in the timeLabel

                        else
                            timeLabel.Text = TIME_5;// displays the 5th time available to register in the timeLabel
                    }
                    else// performs if the first letter of the name was not between E and Q
                    {
                        dayLabel.Text = FRESHMAN_DAY_2;// displays the 2nd day freshman can reigster for classes in the dayLabel
                        if (lastName >= 'R' && lastName <= 'S')//asks if the first letter of the last name is between R and S  
                            timeLabel.Text = TIME_1;// displays the 1st time available to register in the timeLabel

                        else if (lastName >= 'T' && lastName <= 'V')//asks if the first letter of the last name is between T and V  
                            timeLabel.Text = TIME_2;// displays the 2nd time available to register in the timeLabel

                        else if (lastName >= 'W' && lastName <= 'Z')//asks if the first letter of the last name is between W and Z  
                            timeLabel.Text = TIME_3;// displays the 3rd time available to register in the timeLabel

                        else if (lastName >= 'A' && lastName <= 'B')//asks if the first letter of the last name is between A and B  
                            timeLabel.Text = TIME_4;// displays the 4th time available to register in the timeLabel
                        else
                            timeLabel.Text = TIME_5;// displays the 5th time available to register in the timeLabel
                    }
                }
            else// performs if there is nothing entered in the hours text box or if the number entered is a negative
                MessageBox.Show("Invaild data was entered");// displays an error message informing the user that there was invaild data entered
        }
    }
}
