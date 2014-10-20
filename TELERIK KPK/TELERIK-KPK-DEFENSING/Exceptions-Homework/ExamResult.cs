using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }
        private set
        {
            if (value < 0 || value < this.MinGrade || value > this.MaxGrade)
            {
                throw new ArgumentOutOfRangeException("Grade must be positive number, bigger than MinGrade and smaller than MaxGrade");
            }
            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        { 
            return this.minGrade;
        }
        private set
        {
            if (value < 0 || value >= this.MaxGrade)
            {
                throw new ArgumentOutOfRangeException("MinGrade must be positive number and smaller than MaxGrade");
            }
            value = this.minGrade;
        }
    }

    public int MaxGrade
    {
        get
        { 
            return this.maxGrade;
        }
        private set
        {
            if (value < 0 || value <= this.MinGrade)
            {
                throw new ArgumentOutOfRangeException("MaxGrade must be positive number and bigger than MaxGrade");
            }
            value = this.minGrade;
        }
    }

    public string Comments
    {
        get 
        {
            return this.comments;
        }
        set 
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("Comment cannot be empty");
            }
            this.comments = value;
        }
    }
}
