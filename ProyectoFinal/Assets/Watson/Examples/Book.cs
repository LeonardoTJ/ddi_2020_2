using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public static readonly int JAVA_DEITEL = 0;
    public static readonly int C_DEITEL = 1;
    public static readonly string[] TITLES = {"Cómo programar en Java",
                                              "Cómo programar en C/C++"};
    public static readonly string[] AUTHORS = {"H.M. Deitel, P.J. Deitel",
                                               "H.M. Deitel, P.J. Deitel"};
    public static readonly string[] DATES = {"2004",
                                             "1994"};
    public static readonly string[] LANGUAGES = {"Java",
                                                 "C/C++"};
    public static readonly Dictionary<string, string> JAVA_MAP = new Dictionary<string, string>
    {
        {"introduccion", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch01"},
        {"entrada salida y operadores", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch02"},
        {"clases objetos metodos y cadenas", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch03"},
        {"operadores de asignacion", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch04"},
        {"operadores logicos", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch05"},
        {"metodos", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch06"},
        {"arreglos", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch07"},
        {"clases y objetos", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch08"},
        {"herencia", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch09"},
        {"polimorfismo", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch10"},
        {"excepciones", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch11"},
    };
    public static readonly Dictionary<string, string> C_MAP = new Dictionary<string, string>
    {
        {"introduccion a la computacion", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch01"},
        {"introduccion a la programacion", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch02"},
        {"programacion estructurada", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch03"},
        {"control de programa", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch04"},
        {"funciones", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch05"},
        {"arreglos", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch06"},
        {"punteros", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch07"},
        {"caracteres y cadenas", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch08"},
        {"entrada y salida con formato", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch09"},
        {"estructuras y uniones", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch10"},
        {"procesamiento de archivos", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch11"},
        {"estructuras de datos", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch12"},
        {"preprocesador", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch13"},
        {"temas avanzados", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch14"},
    };
    public static readonly Dictionary<string, string>[] LINKS = {JAVA_MAP, C_MAP};
}
