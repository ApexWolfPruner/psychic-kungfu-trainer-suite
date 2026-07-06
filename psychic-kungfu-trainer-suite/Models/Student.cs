namespace PsychicKungFuTrainer.Models;

public class Student
{
    public string Name { get; }
    public int ChiLevel { get; private set; }

    public Student(string name, int initialChi)
    {
        Name = name;
        ChiLevel = initialChi;
    }

    public void Meditate()
    {
        ChiLevel += 5;
    }

    public void DepleteChi(int amount)
    {
        ChiLevel = Math.Max(0, ChiLevel - amount);
    }
}