/*
Enhanced Student Grading System V2
Provides detailed grade reports with separate tracking of exam scores, overall grades,
and extra credit contributions. Shows students exactly how extra credit impacts their
final grades with transparent reporting of point contributions.
*/

/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)

*/

// Define the number of graded exam assignments (first 5 are core exams)
// Define the number of graded exam assignments (first 5 are core exams)
int examAssignments = 5;

// Array of student names to process in the grading system
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// Individual student score arrays (first 5 are exams, remaining are extra credit)
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };      // 5 exams + 2 extra credit
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };            // 5 exams + 1 extra credit
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };      // 5 exams + 3 extra credit
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };              // 5 exams + 1 extra credit

// Temporary array to hold current student's scores during processing
int[] studentScores = new int[10];

// Variable to store the calculated letter grade for current student
string currentStudentLetterGrade = "";

// Display the header row with multiple columns for detailed grade reporting
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
// Outer loop: Process each student in the class roster
foreach (string name in studentNames)
{
    string currentStudent = name;

    // Map current student name to their corresponding score array
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // Separate accumulators for exam scores and extra credit scores
    int sumExamScores = 0;
    int sumExtraCreditScores = 0;

    // Variables to store calculated grade values
    decimal currentStudentGrade = 0;               // Overall grade with extra credit
    decimal currentStudentExamScore = 0;           // Average of exam scores only
    decimal currentStudentExtraCreditScore = 0;    // Average of extra credit scores

    // Counters for tracking assignments processed
    int gradedAssignments = 0;                     // Total assignments processed
    int gradedExtraCreditAssignments = 0;          // Extra credit assignments count

    // Track the point contribution from extra credit to overall grade    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCreditScore = 0;

    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0;

    decimal extraCreditPoints = 0;
// Inner loop: Process each assignment score for the current student
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        // Categorize score as either exam (first 5) or extra credit (beyond first 5)
        if (gradedAssignments <= examAssignments)
        {
            // Add to exam score accumulator
            sumExamScores += score;
        }
        else
        {
            // Count and accumulate extra credit assignments separately
            gradedExtraCreditAssignments += 1;
            sumExtraCreditScores += score;
        }
    }

    // Calculate exam score average (first 5 assignments only)
    // Assign letter grade based on overall grade using if-else chain
    // Grade boundaries: A+ (97+), A (93+), A- (90+), B+ (87+), etc.
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    // Display comprehensive grade report with 5 columns:
    // Student name, exam average, overall grade with letter, and extra credit details
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
Pause program execution to allow user to review the detailed grade report
// R
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({extraCreditPoints} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
