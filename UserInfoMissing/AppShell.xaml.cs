namespace UserInfoMissing
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            SentrySdk.ConfigureScope(scope =>
            {
                scope.User = new SentryUser
                {
                    Username = "SentryUserName",
                    Segment = "SentryBug",
                    Other = new Dictionary<string, string>
                    {
                        {"First", "Firstsentry" },
                        {"Last", "Lastsentry" },
                        {"Agency", "Bug Department" },
                    }
                };
            });
        }
    }
}
