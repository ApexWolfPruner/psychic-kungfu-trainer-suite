using PsychicKungFuTrainer.Models;

namespace PsychicKungFuTrainer.Services;

public class TrainingSession
{
    private readonly Trainer _trainer;
    private readonly Student _student;

    public TrainingSession(Trainer trainer, Student student)
    {
        _trainer = trainer;
        _student = student;
    }

    public void RunBasicMeditation()
    {
        Console.WriteLine(_trainer.GiveInstruction());
        _student.Meditate();
    }
}