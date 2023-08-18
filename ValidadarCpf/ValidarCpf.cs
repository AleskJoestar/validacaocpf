
using System;
public class ValidacaoCpf
{

    public static bool ValidarCpf(string cpf)
    {

        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");

        if (cpf.Length != 11)
            {
                Console.WriteLine("Não possui 11 digitos");
                return false;
        }
        else
        {
            int n1 = 10 * Convert.ToInt32(cpf[0].ToString());
            int n2 = 10 * Convert.ToInt32(cpf[1].ToString());
            int n3 = 10 * Convert.ToInt32(cpf[2].ToString());
            int n4 = 10 * Convert.ToInt32(cpf[3].ToString());
            int n5 = 10 * Convert.ToInt32(cpf[4].ToString());
            int n6 = 10 * Convert.ToInt32(cpf[5].ToString());
            int n7 = 10 * Convert.ToInt32(cpf[6].ToString());
            int n8 = 10 * Convert.ToInt32(cpf[7].ToString());
            int n9 = 10 * Convert.ToInt32(cpf[8].ToString());

            int soma = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9;

            if (soma % 11 < 2)
            {
                if (Convert.ToInt32(cpf[9].ToString()) != 0)
                {
                    return false;

                }
                
            }
            else
            {
                int p = 11 - (soma % 11);   
            }
            
        }
           
        return true;

    }
    


















}