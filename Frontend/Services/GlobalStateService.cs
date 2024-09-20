public class GlobalStateService
{
    public string UserRole { get; private set; }

    // Event to notify when the state changes (role or command)
    public event Action OnChange;

    // Method to update the user role and trigger re-rendering in components
    public void SetUserRole(string role)
    {
        UserRole = role;
        NotifyStateChanged();
    }

    // Method to notify components when the state changes
    private void NotifyStateChanged() => OnChange?.Invoke();
}
