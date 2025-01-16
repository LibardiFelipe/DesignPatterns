namespace DesignPatterns.Singleton.CredentialsManager
{
    public sealed class LazyCredentialsManager
    {
        private string? _username;
        private string? _password;
        private static readonly Lazy<LazyCredentialsManager> _credentialsManager =
            new(() => new LazyCredentialsManager());

        private LazyCredentialsManager() { }

        public static LazyCredentialsManager Instance => _credentialsManager.Value;

        public void Login(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public (string? Username, string? Password) GetCredentials() =>
            (_username, _password);
    }
}
