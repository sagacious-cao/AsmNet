﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.CMP
{
    public class CMP_ESI_EBP : Instruction, ICmp
    {
        public CMP_ESI_EBP()
            : base(2, typeof(ICmp))
        {
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.CMP_REGISTER, (byte)CmpRegisterOpcodes.CMP_ESI_EBP };
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "CMP ESI, EBP";
        }

        public void Compare(ref Flags flags, Registers registers)
        {
            flags.ZeroFlag = registers.ESI == registers.EBP;
        }
    }
}