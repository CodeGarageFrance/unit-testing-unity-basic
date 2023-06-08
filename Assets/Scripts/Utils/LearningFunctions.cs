using UnityEngine;
using System.Collections.Generic;

public class LearningFunctions : MonoBehaviour
{
    public static float CalculateAverageScore(List<QuizResult> quizResults)
    {
        if (quizResults.Count == 0)
        {
            return 0f;
        }

        float totalScore = 0f;
        foreach (QuizResult result in quizResults)
        {
            totalScore += result.Score;
        }
        return totalScore / quizResults.Count;
    }

    public static string GetHighestScoringStudent(List<QuizResult> quizResults)
    {
        if (quizResults.Count == 0)
        {
            return null;
        }

        float highestScore = 0f;
        string highestScoringStudent = null;

        foreach (QuizResult result in quizResults)
        {
            if (result.Score > highestScore)
            {
                highestScore = result.Score;
                highestScoringStudent = result.Student;
            }
        }

        return highestScoringStudent;
    }

    public static Dictionary<int, Student> FetchEnrolledStudents(IApiService apiService)
    {
        List<Student> enrolledStudents = apiService.GetEnrolledStudents();
        Dictionary<int, Student> filteredStudents = new Dictionary<int, Student>();

        foreach (Student student in enrolledStudents)
        {
            if (student.Status == "active")
            {
                filteredStudents.Add(student.Id, student);
            }
        }

        return filteredStudents;
    }

    public static List<QuizResult> FilterPassedQuizResults(List<QuizResult> quizResults, float passingScore)
    {
        List<QuizResult> passedResults = new List<QuizResult>();

        foreach (QuizResult result in quizResults)
        {
            if (result.Score >= passingScore)
            {
                passedResults.Add(result);
            }
        }

        return passedResults;
    }
}


public class QuizResult
{
    public string Student { get; set; }
    public float Score { get; set; }
}

public class Student
{
    public int Id { get; set; }
    public string Status { get; set; }
}

public interface IApiService
{
    public List<Student> GetEnrolledStudents();
}