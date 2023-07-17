namespace observer_design_pattern.observer;
public class SpreadSheet : IObserver
{
    public void Update(int value)
    {
        Console.WriteLine("SpreadSheet got notified:" + value);
    }
}