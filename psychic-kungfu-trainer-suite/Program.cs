using System;
using PsychicKungFuTrainer.Models;
using PsychicKungFuTrainer.Services;

namespace PsychicKungFuTrainer;

class Program
{
    static void Main(string[] args)
    {
        var trainer = new Trainer("Master Li", 7);
        var student = new Student("Alex", 3);

        Console.WriteLine($"Welcome to {trainer.Name}'s Psychic Kung Fu Dojo!");
        Console.WriteLine($"Student: {student.Name} (Current Chi: {student.ChiLevel})");

        var session = new TrainingSession(trainer, student);
        session.RunBasicMeditation();

        Console.WriteLine($"After meditation, {student.Name}'s Chi: {student.ChiLevel}");
    }
}