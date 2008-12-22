﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indy.IL2CPU.Assembler.X86 {
    [OpCode("movs")]
    public class Movs : InstructionWithSize, IInstructionWithPrefix
    {
        public InstructionPrefixes Prefixes
        {
            get;
            set;
        }

        public byte Size
        {
            get;
            set;
        }

        public override string ToString()
        {
            var xPref = "";
            if ((Prefixes & InstructionPrefixes.Repeat) != 0)
            {
                xPref = "rep ";
            }
            switch (Size)
            {
                case 32:
                    return xPref + "movsd";
                case 16:
                    return xPref + "movsw";
                case 8:
                    return xPref + "movsb";
                default: throw new Exception("Size not supported!");
            }
        }
    }
}