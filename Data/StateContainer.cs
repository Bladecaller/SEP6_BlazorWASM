using System;

public class StateContainer
{
    private string savedString;

    public string Property
    {
        get => savedString;
        set
        {
            savedString = value;
            NotifyStateChanged();
        }
    }

    public event Action OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}