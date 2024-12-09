namespace Framework.Defaults.Tests.Integrations;

public sealed class Test
{
    // Implicit Using is allowed by default -> No using System.Threading.Tasks; is needed
    public static Task MethodName()
    {
        // Nullable reference types are enabled by default -> No #nullable enable; is needed
        string? x = null;

        Console.WriteLine(x);

        return Task.CompletedTask;
    }
}
