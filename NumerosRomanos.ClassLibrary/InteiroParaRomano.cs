
namespace NumerosRomanos.ClassLibrary
{
    public class InteiroParaRomano
    {
        private string[] LetrasMilhares = { "", "M", "MM", "MMM" };
        private string[] LetrasMaiores4mil = { "", "", "", "", "ĪV̄", "V̄", "V̄Ī", "V̄ĪĪ", "V̄ĪĪĪ ", "ĪX̄ ", "X̄" };
        private string[] LetrasCentenas =
            { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private string[] LetrasDezenas =
            { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private string[] LetrasUnidades =
            { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        public string ConverteInteiroParaRomano(int numeroInteiro)
        {

            if (numeroInteiro >= 4000)
                return EhMaior4mil(ref numeroInteiro);

            string resultado = "";

            int num = Milhares(ref numeroInteiro, ref resultado);

            num = Centenas(ref numeroInteiro, ref resultado);

            num = Dezenas(ref numeroInteiro, ref resultado);

            resultado += LetrasUnidades[numeroInteiro];

            return resultado;
        }

        private int Dezenas(ref int numeroInteiro, ref string resultado)
        {
            int num = numeroInteiro / 10;
            resultado += LetrasDezenas[num];
            numeroInteiro %= 10;
            return num;
        }

        private int Centenas(ref int numeroInteiro, ref string resultado)
        {
            int num = numeroInteiro / 100;
            resultado += LetrasCentenas[num];
            numeroInteiro %= 100;
            return num;
        }

        private int Milhares(ref int numeroInteiro, ref string resultado)
        {
            int num = numeroInteiro / 1000;
            resultado += LetrasMilhares[num];
            numeroInteiro %= 1000;
            return num;
        }

        private string EhMaior4mil(ref int numeroInteiro)
        {
            int mil = numeroInteiro / 1000;
            numeroInteiro %= 1000;

            return Tracinho(mil) + ConverteInteiroParaRomano(numeroInteiro);
        }

        private string Tracinho(int numero)
        {
            string resultado = "";
            resultado += LetrasMaiores4mil[numero];
            return resultado;
        }
    }
}
