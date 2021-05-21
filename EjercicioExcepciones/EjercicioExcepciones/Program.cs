using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- 1 ------------------");

            Console.WriteLine("Ingrese un numero entero en el denominador ");

            Division uno = new Division(2500);

            uno.Dividir();

            Console.WriteLine("----------- 2 ------------------"); // separador horizontal

            DivisionDos dos = new DivisionDos();

            dos.Dividirr();

            Console.WriteLine("----------- 3 ------------------"); //separador horizontal

            Console.WriteLine("Llamando al metodo LanzarMetodo");

            Logic logic = new Logic();
            Exception ex3 = logic.LanzarMetodo();
            Console.WriteLine("Ha ocurrido una excepcion. " + "Tipo de excepcion: " + ex3.GetType().Name);

            /*/try { logic.LanzarMetodo(); 
           // }catch(Exception ex3)
            {
                
                Console.WriteLine(ex3.Message);
                ;
               

            }*/

            Console.WriteLine("----------- 4 ------------------");

            try
            {
                CustomException nuevaexcep = new CustomException();
                EjemploExceptions.ThrowCustomException();
                
                
            }catch(CustomException ex5)
            {
                Console.WriteLine($"Ha ocurrido una excepcion custom. {ex5.Message}");
                MessageBox.Show(ex5.Message,"CustomException");
            }
            
            Console.ReadLine();
            


        }


    }

    public class Division
    {
        private int numerador;
        private int denominador;


        public Division(int numerador)
        {

            this.numerador = numerador;

        }

        public int Denominador
        {
            get
            {
                return denominador;

            }
        }

        public void Dividir()
        {
            try
            {
                denominador = int.Parse(Console.ReadLine());
                int resultado = numerador / denominador;

                Console.WriteLine("El resultado es " + resultado);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Se ha producido una excepcion: " + ex.Message);
            }
            catch (FormatException ex1)
            {
                Console.WriteLine("Error, formato no valido para este tipo de division.");
            }
            finally
            {
                Console.WriteLine("La operación ha finalizado");

            }


        }
    }

    public class DivisionDos
    {
        private int numerador;
        private int denominador;

        public void Dividirr()


        {

            try
            {
                Console.WriteLine("Ingrese el numerador");
                numerador = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el denominador");
                denominador = int.Parse(Console.ReadLine());
                int resultado = numerador / denominador;

                Console.WriteLine("El resultado es " + resultado);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero!");
                Console.WriteLine(ex.Message);
                    
            }
            catch (FormatException ex1)
            {
                Console.WriteLine("Seguro ingresó una letra o no ingresó nada!");
            }

        }
    }

    public class Logic
    {
        public Exception LanzarMetodo()
        {
            
            return new Exception ();
        }
    }

    }


    public class CustomException : Exception
     {
        public CustomException(): base("Mensaje sobrecargado.")
        {
        
        }

   

}




