namespace PsychicKungFuTrainer.Models;

public class Trainer
{
    public string Name { get; }
    public int MasteryLevel { get; }

    public Trainer(string name, int masteryLevel)
    {
        Name = name;
        MasteryLevel = masteryLevel;
    }

    public string GiveInstruction()
    {
        return $"Channel your inner chi, {Name} guides you!";
    }
}