using System.Linq.Expressions;

namespace CapaNegocio
{
    public class Impuesto
    {
        public double valorConIVA5 (int valor)
        {
            return valor + (valor * 0.05);
        }
        public double valorConIVA19(int valor)
        {
            return valor + (valor * 0.19);
        }
        public double valorFinal(string tipo, int valor)
        {
            switch (tipo)
            {
                case "Café":
                    return valorConIVA5(valor);
                case "Harina":
                    return valorConIVA5(valor);
                case "Pastas":
                    return valorConIVA5(valor);
                case "Embutidos":
                    return valorConIVA5(valor);
                case "Licores":
                    return valorConIVA19(valor);
                case "Cereales":
                    return valorConIVA19(valor);
                case "Aceites":
                    return valorConIVA19(valor);
                case "Condimentos":
                    return valorConIVA19(valor);
                case "Carne":
                    return valor;
                case "Pescado":
                    return valor;
                case "Leche":
                    return valor;
                case "Queso":
                    return valor;
                default:
                    Console.WriteLine("something went wrong");
                    break;
            }
            return valor;
        }
    }
}