using System;
namespace TestDateFormat;


/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string Input)
    {
    
        if(!StringIsValid(Input)) 
        {
            return string.Empty;
        }
        
        return Input.Substring(6) + "-" + Input.Substring(3, 2) + "-" + Input.Substring(0, 2);
    }

    public static bool StringIsValid(string Input)
    {
        if (string.IsNullOrEmpty(Input))
        {
            return false;
        }
        else
        {
            //char barra = {'/'};
            //string[] Date;
            //List<string> date;

           //date = Input.Split('/');
        
            //date = Convert.ToString(Date);
            int DateNumber = Convert.ToInt32(Input.Substring(0, 2));
            int Month = Convert.ToInt32(Input.Substring(3, 2));
            int Year = Convert.ToInt32(Input.Substring(6));

            return ((DateNumber >= 1 && DateNumber <= 31) && (Month >= 1 && Month <= 12) && (Year >= 1 && Year < 2024));
        }
    }

    

}
