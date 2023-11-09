using System;
using System.Collections;
using System.Globalization;

namespace SamplesComparer {
    public class Program {
    public static void Main(){
        String str1 = "Hello";
        String str2 = "World";

        Console.WriteLine( "Comparing \"{0}\" and \"{1}\" ...", str1, str2 );
        Console.WriteLine("   Invariant Comparer: {0}",Comparer.DefaultInvariant.Compare(str1,str2));

        Comparer mycompIntI = new Comparer(new CultureInfo("es-Es",false));
        Console.WriteLine("International sort:{0}",mycompIntI.Compare(str1,str2));

        Comparer mycompTrad = new Comparer(new CultureInfo("0x040A",false));
        Console.WriteLine("Traditional sort:{0}",mycompTrad.Compare(str1,str2));
    }
}
}