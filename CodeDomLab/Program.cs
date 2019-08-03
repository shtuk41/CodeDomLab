
using System;
using System.IO;
using System.Text;
using System.CodeDom;
using System.Diagnostics;
using System.CodeDom.Compiler;

namespace CodeDomLab
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (System.CodeDom.Compiler.CompilerInfo ci in System.CodeDom.Compiler.CodeDomProvider.GetAllCompilerInfo())
	        {
		        foreach (string language in ci.GetLanguages())
			        System.Console.Write("{0} ", language);
			
		        System.Console.WriteLine();

	        }
            Console.ReadKey();
        }
    }
}

