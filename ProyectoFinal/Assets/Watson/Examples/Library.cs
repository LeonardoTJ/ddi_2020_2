using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Library
{
    public static readonly List<Book> BOOKS = new List<Book>{new Book("Cómo programar en Java",
                                        "H.M. Deitel, P.J. Deitel",
                                        "2004",
                                        "Java",
                                        new Dictionary<string, string>
                                        {
                                            {"introducción", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch01"},
                                            {"entrada salida y operadores", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch02"},
                                            {"clases objetos métodos y cadenas", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch03"},
                                            {"operadores de asignación", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch04"},
                                            {"operadores lógicos", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch05"},
                                            {"métodos", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch06"},
                                            {"arreglos", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch07"},
                                            {"clases y objetos", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch08"},
                                            {"herencia", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch09"},
                                            {"polimorfismo", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch10"},
                                            {"excepciones", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch11"},
                                        }),
                                        new Book("Cómo programar en C/C++",
                                                "H.M. Deitel, P.J. Deitel",
                                                "1994",
                                                "C/C++",
                                                new Dictionary<string, string>
                                                {
                                                    {"introducción a la computación", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch01"},
                                                    {"introducción a la programación", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch02"},
                                                    {"programación estructurada", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch03"},
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
                                                })};

    // public Start()
    // {
    //     Dictionary<string, string> java_l = new Dictionary<string, string>{
    //                                         {"introducción", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch01"},
    //                                         {"entrada salida y operadores", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch02"},
    //                                         {"clases objetos métodos y cadenas", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch03"},
    //                                         {"operadores de asignación", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch04"},
    //                                         {"operadores lógicos", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch05"},
    //                                         {"métodos", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch06"},
    //                                         {"arreglos", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch07"},
    //                                         {"clases y objetos", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch08"},
    //                                         {"herencia", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch09"},
    //                                         {"polimorfismo", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch10"},
    //                                         {"excepciones", "https://github.com/pdeitel/Java9ForProgrammers/tree/master/examples/ch11"},
    //                                     };
    //     Dictionary<string, string> c_l = new Dictionary<string, string>
    //                                     {
    //                                         {"introducción a la computación", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch01"},
    //                                         {"introducción a la programación", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch02"},
    //                                         {"programación estructurada", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch03"},
    //                                         {"control de programa", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch04"},
    //                                         {"funciones", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch05"},
    //                                         {"arreglos", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch06"},
    //                                         {"punteros", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch07"},
    //                                         {"caracteres y cadenas", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch08"},
    //                                         {"entrada y salida con formato", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch09"},
    //                                         {"estructuras y uniones", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch10"},
    //                                         {"procesamiento de archivos", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch11"},
    //                                         {"estructuras de datos", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch12"},
    //                                         {"preprocesador", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch13"},
    //                                         {"temas avanzados", "https://github.com/pdeitel/CHowtoProgram9e/tree/master/examples/ch14"},
    //                                     };
    //     BOOKS = {new Book("Cómo programar en Java",
    //                     "H.M. Deitel, P.J. Deitel",
    //                     "2004",
    //                     "Java", java_l),
    //             new Book("Cómo programar en C/C++",
    //                     "H.M. Deitel, P.J. Deitel",
    //                     "1994",
    //                     "C/C++", c_l)};
    // }
}
