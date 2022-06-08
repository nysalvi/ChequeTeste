using System;
using System.Collections.Generic;

namespace ChequeExtenso.ConsoleApp
{
    public class Cheque
    {
        string valor;        
        public Cheque(string valor)
        {
            this.valor = valor;
        }
        public string CalculaValor()
        {
            string resul = "";
            string array = valor;
            //resul += CalculaNumeroMaiorQue4(valorString);
            
            while (array.Length > 0)
            {
                if (array.Length % 3 == 0)
                    resul += CalculaResto0(ref array);
                else if (array.Length % 3 == 1)
                    resul += CalculaResto1(ref array);
                else if (array.Length % 3 == 2)
                    resul += CalculaResto2(ref array);      
            }
            return resul;
        }
        private string CalculaResto0(ref string array)
        {
            if (array[0] == '0')
            {
                array = array.Remove(0, 1);
                return "";
            }
            string num = array.Substring(0, 1);
            array = array.Remove(0, 1);
            return Numeros[0][num];
        }
        private string CalculaResto1(ref string array)
        {
            if (array[0] == '0')
            {
                array = array.Remove(0, 1);
                return "";
            }
            string num = array.Substring(0, 1);
            array = array.Remove(0, 1);
            return Numeros[1][num];            
        }
        private string CalculaResto2(ref string array)
        {
            if (array[0] == '0')
            {
                array = array.Remove(0, 1);
                return "";
            }
            string num;
            if (array[0] == '1')
            {
                num = array.Substring(0, 2);
                array = array.Remove(0, 2);
            }
            else
            {
                num = array.Substring(0, 1);
                array = array.Remove(0, 1);
            }
            return Numeros[2][num];
        }
        private string CalculaNumeroMaiorQue4(string array)
        {
            string resul = "";

            if (array.Length % 3 == 1)
            {
                bool maiorQueUm = array[0] > 1;
                string pluralOuSingular = milharPraCima[array.Length];
                pluralOuSingular += maiorQueUm && array[0] != 4 ? "ões" : "ão";

                if (array[0] != 0)
                    resul += array[0] + pluralOuSingular;
            }
            return resul;
        }
        private string CalculaNumeroMenorQue4(string array)
        {
            string resul = "";

            if (array.Length >= 4 && array.Length % 3 == 1)
            {
                bool maiorQueUm = array[0] > 1;
                string pluralOuSingular = milharPraCima[array.Length];
                pluralOuSingular += maiorQueUm && array[0] != 4 ? "ões" : "ão";

                if (array[0] != 0)
                    resul += array[0] + pluralOuSingular;
            }
            return resul;
        }

        #region NUMEROS:
        static readonly Dictionary<int, string> milharPraCima = new Dictionary<int, string>() {
            {4, "mil"},
            {7, "milh"},
            {10, "bilh"},
            {13, "trilh"}
        };

        public static readonly Dictionary<string, string>[] Numeros = new Dictionary<string, string>[3]
        {
            new Dictionary<string, string>()
        {
            {"1", "cem"},
            {"2", "duzentos"},
            {"3", "trezentos"},
            {"4", "quatrocentos"},
            {"5", "quinhentos"},
            {"6", "seiscentos"},
            {"7", "setecentos"},
            {"8", "oitocentos"},
            {"9", "novecentos" }
        },
            new Dictionary<string, string>()
        {
            {"1", "um"},
            {"2", "dois"},
            {"3", "três"},
            {"4", "quatro"},
            {"5", "cinco"},
            {"6", "seis"},
            {"7", "sete"},
            {"8", "oito"},
            {"9", "nove"},
        },
            new Dictionary<string, string>()
        {
            {"10", "dez"},
            {"11", "onze"},
            {"12", "doze"},
            {"13", "treze"},
            {"14", "catorze"},
            {"15", "quinze"},
            {"16", "dezesseis"},
            {"17", "dezessete"},
            {"18", "dezoito"},
            {"19", "dezenove"} ,
            {"2", "vinte"},
            {"3", "trinta"},
            {"4", "quarenta"},
            {"5", "cinquenta"},
            {"6", "sessenta"},
            {"7", "setenta"},
            {"8", "oitenta"},
            {"9", "noventa"},
        }
    };
    //static readonly Dictionary<string, string> centena = new Dictionary<string, string>()
    //    {
    //        {"1", "cem "},
    //        {"2", "duzentos"},
    //        {"3", "trezentos"},
    //        {"4", "quatrocentos"},
    //        {"5", "quinhentos"},
    //        {"6", "seiscentos "},
    //        {"7", "setecentos "},
    //        {"8", "oitocentos "},
    //        {"9", "novecentos" }
    //    };
    //static readonly Dictionary<string, string> dezena = new Dictionary<string, string>()
    //    {
    //        {"10", "dez"},
    //        {"11", "onze"},
    //        {"12", "doze"},
    //        {"13", "treze"},
    //        {"14", "catorze"},
    //        {"15", "quinze"},
    //        {"16", "dezesseis "},
    //        {"17", "dezessete "},
    //        {"18", "dezoito "},
    //        {"19", "dezenove"} ,
    //        {"2", "vinte "},
    //        {"3", "trinta "},
    //        {"4", "quarenta "},
    //        {"5", "cinquenta"},
    //        {"6", "sessenta "},
    //        {"7", "setenta "},
    //        {"8", "oitenta "},
    //        {"9", "noventa "},
    //    };
    //static readonly Dictionary<string, string> unidade = new Dictionary<string, string>()
    //    {
    //        {"1", "um"},
    //        {"2", "dois"},
    //        {"3", "três"},
    //        {"4", "quatro"},
    //        {"5", "cinco"},
    //        {"6", "seis"},
    //        {"7", "sete"},
    //        {"8", "oito"},
    //        {"9", "nove"},
    //    };
        #endregion
    }
}
