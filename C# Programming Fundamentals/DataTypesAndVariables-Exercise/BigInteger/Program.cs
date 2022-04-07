using System;
using System.Numerics;

namespace BigIntegerExamle  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Биг Интеджер работи като събира стрингове както се смята на хартия.
            // Вземаш две числа големи и ги събираш едно върху друго ..както на хартия
            // 123234536756545645
            // 1232335476786797897070


            BigInteger biginter1 = 12345678901112212333;
            BigInteger biginter2 = 2342345345345353454;

            BigInteger sum = biginter1 + biginter2;

        }
    }
}
