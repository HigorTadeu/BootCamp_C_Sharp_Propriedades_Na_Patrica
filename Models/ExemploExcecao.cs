using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCamp_C_Sharp_Propriedades_Na_Patrica.Models
{
    public class ExemploExcecao
{
    public void Metodo1()
    {
        try
        {
            Metodo2();    
        }
        catch (Exception ex)
        {
            
            Console.WriteLine("Exceção tratada. " + ex.Message);
            Console.WriteLine(ex.StackTrace);
        }        
    }

    public void Metodo2()
    {
        Metodo3();
    }

    public void Metodo3()
    {
        Metodo4();
    }

    public void Metodo4()
    {
        throw new Exception("Ocorreu uma exceção");
    }
}
}