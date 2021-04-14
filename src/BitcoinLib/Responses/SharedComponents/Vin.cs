// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using System.Collections.Generic;

namespace BitcoinLib.Responses.SharedComponents
{
    public class Vin
    {
        public string TxId { get; set; }
        public int Vout { get; set; }
        public ScriptSig ScriptSig { get; set; }
        public string CoinBase { get; set; }
        public uint Sequence { get; set; }
        public List<string> TXinWitness { get; set; }
    }

    public class ScriptSig
    {
        public string Asm { get; set; }
        public string Hex { get; set; }
    }
}