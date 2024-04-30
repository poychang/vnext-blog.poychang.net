using Statiq.Markdown;

namespace Blog
{
    internal class Program
    {
        static async Task<int> Main(string[] args) =>
            await Bootstrapper
                .Factory
                .CreateWeb(args)
                .AddSetting(MarkdownKeys.MarkdownExtensions, new List<string> { "Bootstrap", "Prism" })
                .RunAsync();
    }
}
