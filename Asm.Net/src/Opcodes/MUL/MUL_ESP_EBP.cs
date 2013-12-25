﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.MUL
{
    public class MUL_ESP_EBP : Instruction, IMul
    {
        public MUL_ESP_EBP()
            : base(2, typeof(IMul))
        {
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.MUL, (byte)MulRegisterOpcodes.MUL_ESP_EBP };
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "MUL ESP, EBP";
        }

        public void Multiply(Registers registers)
        {
            registers.ESP *= registers.EBP;
        }
    }
}