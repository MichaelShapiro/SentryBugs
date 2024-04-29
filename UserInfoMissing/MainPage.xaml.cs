namespace UserInfoMissing;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked_UserPreserved(object sender, EventArgs e)
    {
        SentrySdk.CaptureException(new Exception("User info is preserved"));
        DisplayAlert("", "Event sent - UserInfo will be preserved", "OK");
    }

    private void Button_Clicked_UserVanishes(object sender, EventArgs e)
    {
        SentrySdk.CaptureException(new Exception("BUG - User info is missing"), scope => scope.Contexts.Add("Payload", new { color = "red", speed = 49 }));
        DisplayAlert("", "Event sent - UserInfo will vanish", "OK");
    }
}
