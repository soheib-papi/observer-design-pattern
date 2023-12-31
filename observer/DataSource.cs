namespace observer_design_pattern.observer;

public class DataSource : Subject
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set
        {
            _value = value;
            //Push style of communication
            NotifyObservers(value);
        }
    }



}