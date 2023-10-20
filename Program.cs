using System;
using System.Reflection;

namespace Demo
{
  class Program
  {
    public static void Main(string[] _)
    {
      //AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;
      var obj = new System.Text.Json.JsonDocumentOptions();
      System.Console.WriteLine(obj);
    }

    public static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
    {
      var assemblyName = new AssemblyName(args.Name).Name + ".dll";
      System.Console.WriteLine(assemblyName);
      return null;
    }
  }
}