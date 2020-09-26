using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgrammingTest : MonoBehaviour
{
    void Start()
    {
        int[] arregloNums = {8,1,2,2,3};
        foreach(var num in comparaNums(arregloNums))
            Debug.Log(num.ToString());
    }

    public static int[] comparaNums(int[] nums)
    {
        int[] arregloCont = new int[nums.Length]; // arreglo auxiliar
        int cont;   // contador

        for(int i = 0; i<nums.Length; i++)      // iterar el arreglo de numeros
        {
            cont = 0;
            for(int j = 0; j<nums.Length; j++)  // comparar cada numero con los demas
            {
                if(nums[j] < nums[i])
                    cont++;     // contar cada numero menor
            }
            arregloCont[i] = cont;
        }
        return arregloCont;     // retornar arreglo auxiliar
    }
    // Complejidad de O(n^2); Se accede a todos los elementos del arreglo dos veces
}
