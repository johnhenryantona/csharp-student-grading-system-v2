# csharp-student-grading-system-v2

An enhanced C# console application that provides detailed student grade reports with separate tracking of exam scores, overall grades, and extra credit contributions.

## Description

This advanced grading system builds upon basic grade calculation by providing:
1. **Separated Score Tracking**: Distinct tracking of exam vs. extra credit scores
2. **Detailed Reporting**: Shows exam score, overall grade, and extra credit impact
3. **Extra Credit Analysis**: Calculates average extra credit score and point contribution
4. **Comprehensive Grading**: Automatic letter grade assignment with plus/minus modifiers
5. **Enhanced Visibility**: Clear breakdown of how extra credit affects final grades

The application demonstrates advanced data processing, multiple accumulator patterns, and detailed reporting used in modern educational management systems.

## Grading System

### Score Components

1. **Exam Score**: Average of the first 5 assignments (100% weight)
2. **Extra Credit Score**: Average of additional assignments (displayed separately)
3. **Overall Grade**: Exam score + (Extra credit total ÷ 10) ÷ Number of exams

### Extra Credit Calculation

```
Extra Credit Points = (Sum of Extra Credit Scores ÷ 10) ÷ Number of Exams
Overall Grade = Exam Score + Extra Credit Points
```

**Example**: 
- Exam Score: 92.2
- Extra Credit: 3 assignments averaging 92
- Extra Credit Points: (92 × 3 ÷ 10) ÷ 5 = 5.52 pts
- Overall Grade: 92.2 + 3.68 = 95.88

### Letter Grade Scale

| Grade | Range | Grade | Range |
|-------|-------|-------|-------|
| A+ | 97-100 | C+ | 77-79 |
| A | 93-96 | C | 73-76 |
| A- | 90-92 | C- | 70-72 |
| B+ | 87-89 | D+ | 67-69 |
| B | 83-86 | D | 63-66 |
| B- | 80-82 | D- | 60-62 |
| F | 0-59 | | |

## Student Data

The system tracks 4 students with varying extra credit completion:
- **Sophia**: 7 assignments (5 exams + 2 extra credit)
- **Andrew**: 6 assignments (5 exams + 1 extra credit)
- **Emma**: 8 assignments (5 exams + 3 extra credit)
- **Logan**: 6 assignments (5 exams + 1 extra credit)

## How to Run

```bash
dotnet run
```

## Example Output

```
Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)
Andrew          89.8            91.6    A-      89 (1.78 pts)
Emma            85.6            90.4    A-      89 (4.80 pts)
Logan           91.2            92.8    A       96 (1.60 pts)

Press the Enter key to continue
```

## Enhanced Features vs. V1

### New in V2:
- **Separate Score Display**: Exam score shown independently from overall grade
- **Extra Credit Details**: Average extra credit score and point contribution
- **Improved Clarity**: Users can see exactly how extra credit impacts grades
- **Better Analytics**: Track extra credit performance separately

### Report Columns:
1. **Student Name**: Student identifier
2. **Exam Score**: Average of core 5 exam assignments
3. **Overall Grade**: Final grade including extra credit impact
4. **Letter Grade**: Automatically assigned grade (A+ through F)
5. **Extra Credit**: Average extra credit score and total points added

## Concepts Demonstrated

### Advanced Data Processing
- **Multiple Accumulators**: Separate tracking for exams and extra credit
- **Separate Calculations**: Individual averages for different score types
- **Point Contribution**: Calculating weighted impact of bonus work

### Enhanced Algorithms
- **Dual Accumulation**: Summing exam scores and extra credit separately
- **Assignment Counting**: Tracking both exam and extra credit assignment counts
- **Weighted Averaging**: Different calculations for display vs. final grade

### Reporting Features
- **Multi-column Output**: Tab-formatted table with 5 columns
- **Formatted Decimals**: Precise grade display with decimal places
- **Calculated Fields**: Showing both raw scores and derived values

## Real-World Applications

This enhanced reporting is used in:
- **Learning Management Systems**: Detailed grade breakdowns
- **Student Progress Reports**: Showing impact of extra work
- **Academic Advising**: Understanding where points come from
- **Parent Portals**: Transparent grade communication
- **Performance Analytics**: Tracking extra credit effectiveness
- **Educational Research**: Studying extra credit impact on outcomes

## Calculation Breakdown

### For Sophia:
```
Exam Scores: [90, 86, 87, 98, 100]
Extra Credit: [94, 90]

Exam Score Average = (90+86+87+98+100) ÷ 5 = 92.2
Extra Credit Average = (94+90) ÷ 2 = 92
Extra Credit Points = (94+90) ÷ 10 ÷ 5 = 18.4 ÷ 5 = 3.68
Overall Grade = 92.2 + 3.68 = 95.88 → A (93-96 range)
```

## Key Improvements

1. **Transparency**: Students see exam performance separate from bonus points
2. **Accountability**: Clear distinction between required and optional work
3. **Motivation**: Visible impact of extra credit encourages participation
4. **Fairness**: Shows both earned grade and enhanced grade
5. **Analytics**: Enables analysis of extra credit effectiveness

## Extensibility

The system can be extended to:
- Add weighted assignment categories (quizzes, projects, finals)
- Support dropped lowest scores
- Include assignment-level details
- Generate trend reports over time
- Calculate class statistics per category
- Export detailed grade reports to CSV
- Implement grade curves or scaling
