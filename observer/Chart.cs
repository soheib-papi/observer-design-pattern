namespace observer_design_pattern.observer;
public class Chart : IObserver
{
    public void Update(int value)
    {
        Console.WriteLine("Chart got notified:" + value);
    }
}