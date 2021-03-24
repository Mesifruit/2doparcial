using System;

namespace Parcial
{
    class pregunta12
    {
        string[] n;
        float[] s;
        public void parcial()
        {
            n = new string[5];
            s = new float[5];
            for (int h = 0; h < n.Length; h++)
            {

                Console.Write("Nombre del empleado: ");
                n[h] = Console.ReadLine();
                Console.Write("Salario del empleado: ");
                string z;
                z = Console.ReadLine();

                s[h] = float.Parse(z);
            }
        }
        public void MayorS()
        {

            float nm; int k = 0; nm = s[0];

            for (int h = 1; h < n.Length; h++)
            {
                if (s[h] > nm)
                {
                    nm = s[h];
                    k = h;
                }
            }
            Console.WriteLine("El empleado que devenga un mayor salario es: " + n[k]);
            Console.WriteLine("Cuyo salario es de: " + nm);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            pregunta12 pv = new pregunta12();
            pv.parcial();
            pv.MayorS();
        }
    }
}

