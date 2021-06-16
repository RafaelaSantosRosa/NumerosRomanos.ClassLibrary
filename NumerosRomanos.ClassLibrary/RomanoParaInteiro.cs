
using System.Collections.Generic;


namespace NumerosRomanos.ClassLibrary
{
    public class RomanoParaInteiro
    {
        
        private Dictionary<string, int> valor = null;

        public int ConverteRomanoParaInteiroraInteiro(string romano)
        {

            if (valor == null)
            {
                romano = romano.Replace("ĪV̄", "(IV)");
                romano = romano.Replace("V̄", "(V)");
                romano = romano.Replace("V̄Ī", "(VI)");
                romano = romano.Replace("V̄ĪĪ", "(VII)");
                romano = romano.Replace("V̄ĪĪĪ", "(VIII)");
                romano = romano.Replace("ĪX̄", "(IX)");
                romano = romano.Replace("X̄", "(X)");

                valor = new Dictionary<string, int>();
                valor.Add("I", 1);
                valor.Add("V", 5);
                valor.Add("X", 10);
                valor.Add("L", 50);
                valor.Add("C", 100);
                valor.Add("D", 500);
                valor.Add("M", 1000);

            }

            if (romano.Length == 0) return 0;

            romano = romano.ToUpper();

            if (romano[0] == '(') return VerificaTraco(romano);
           
            int total = ConverteLetraParaNumero(romano);

            return total;
        }

        private int ConverteLetraParaNumero(string romano)
        {
            int total = 0;
            int last_value = 0;
            for (int i = romano.Length - 1; i >= 0; i--)
            {
                int new_value = valor[romano.Substring(i, 1)];
                SomaOuSubtrai(ref total, ref last_value, new_value);
            }

            return total;
        }

        private static void SomaOuSubtrai(ref int total, ref int last_value, int new_value)
        {
            if (new_value < last_value)
                total -= new_value;
            else
            {
                total += new_value;
                last_value = new_value;
            }
        }

        private int VerificaTraco(string romano)
        {
            int pos = romano.IndexOf(')');

            string part1 = romano.Substring(1, pos - 1);
            string part2 = romano.Substring(pos + 1);
            return 1000 * ConverteRomanoParaInteiroraInteiro(part1) + ConverteRomanoParaInteiroraInteiro(part2);
        }
    }
}
