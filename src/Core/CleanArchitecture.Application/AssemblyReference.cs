using System.Reflection;

namespace CleanArchitecture.Application;

public class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(Assembly).Assembly;
}