// initialize variables - graded assignments 
int currentAssignments = 5;

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        // assign Sophia's scores to the studentScores array 
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        // assign Andrew's scores to the studentScores array 
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        // assign Emma's scores to the studentScores array 
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        // assign Logan's scores to the studentScores array 
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        // assign Andrew's scores to the studentScores array 
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        // assign Emma's scores to the studentScores array 
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        // assign Logan's scores to the studentScores array 
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        // assign Logan's scores to the studentScores array 
        studentScores = gregorScores;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    // initialize/reset a counter for the number of assignment
    int gradedAssignments = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments++;

        if (gradedAssignments <= currentAssignments)
        {
            // add the exam score to the sum
            sumAssignmentScores += score;
        }
        else
        {
            /// add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
        }
    }

    currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;


    if (currentStudentGrade <= 59)
    {
        currentStudentLetterGrade = "F";
    }
    else if (currentStudentGrade <= 62)
    {
        currentStudentLetterGrade = "D-";
    }
    else if (currentStudentGrade <= 66)
    {
        currentStudentLetterGrade = "D";
    }
    else if (currentStudentGrade <= 69)
    {
        currentStudentLetterGrade = "D+";
    }
    else if (currentStudentGrade <= 72)
    {
        currentStudentLetterGrade = "C-";
    }
    else if (currentStudentGrade <= 76)
    {
        currentStudentLetterGrade = "C";
    }
    else if (currentStudentGrade <= 79)
    {
        currentStudentLetterGrade = "C+";
    }
    else if (currentStudentGrade <= 82)
    {
        currentStudentLetterGrade = "B-";
    }
    else if (currentStudentGrade <= 86)
    {
        currentStudentLetterGrade = "B";
    }
    else if (currentStudentGrade <= 89)
    {
        currentStudentLetterGrade = "B+";
    }
    else if (currentStudentGrade <= 92)
    {
        currentStudentLetterGrade = "A-";
    }
    else if (currentStudentGrade <= 96)
    {
        currentStudentLetterGrade = "A";
    }
    else if (currentStudentGrade <= 100)
    {
        currentStudentLetterGrade = "A+";
    }

    Console.WriteLine(currentStudent + "\t\t" + currentStudentGrade + "\t" + currentStudentLetterGrade);
}