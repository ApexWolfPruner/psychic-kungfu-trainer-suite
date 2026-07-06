using PsychicKungFuTrainer.Models;
using PsychicKungFuTrainer.Services;

namespace PsychicKungFuTrainer.Tests;

public class TrainingTests
{
    public static void RunAll()
    {
        TestMeditationIncreasesChi();
        TestDepleteChi();
        TestTrainingSession();
        Console.WriteLine("All tests passed!");
    }

    private static void TestMeditationIncreasesChi()
    {
        var student = new Student("Test", 10);
        student.Meditate();
        if (student.ChiLevel != 15)
            throw new Exception("Meditation should increase Chi by 5");
    }

    private static void TestDepleteChi()
    {
        var student = new Student("Test", 10);
        student.DepleteChi(3);
        if (student.ChiLevel != 7)
            throw new Exception("Deplete should reduce Chi correctly");
        student.DepleteChi(100);
        if (student.ChiLevel != 0)
            throw new Exception("Chi should not go below 0");
    }

    private static void TestTrainingSession()
    {
        var trainer = new Trainer("Master", 5);
        var student = new Student("Test", 3);
        var session = new TrainingSession(trainer, student);
        session.RunBasicMeditation();
        if (student.ChiLevel != 8)
            throw new Exception("Session meditation should work");
    }
}