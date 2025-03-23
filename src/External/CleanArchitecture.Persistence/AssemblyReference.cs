using System.Reflection;

namespace CleanArchitecture.Persistence;

public class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(Assembly).Assembly;
}