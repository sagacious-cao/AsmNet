﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.MUL
{
    public class MUL_EBP_EDI : Instruction, IMul
    {
        public MUL_EBP_EDI()
            : base(2, typeof(IMul))
        {
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.MUL, (byte)MulRegisterOpcodes.MUL_EBP_EDI };
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "MUL ESP, EDI";
        }

        public void Multiply(Registers registers)
        {
            registers.EBP *= registers.EDI;
        }
    }
}