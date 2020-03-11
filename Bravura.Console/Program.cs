using System.Threading.Tasks;

namespace Bravura.Console
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            return await new App(args).Run();
        }
    }
}
