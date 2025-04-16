namespace HttpClient
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            List<string> urls = new List<string>()
            {
               "https://www.youtube.com",
               "https://www.githup.com",
               "https://www.google.com",
               "https://www.apple.com",
               "https://www.amazon.com"
            };
            HttpClientClass.GetData(urls).Wait();
        }
    }
}
