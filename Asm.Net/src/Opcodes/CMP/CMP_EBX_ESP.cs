﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.CMP
{
    public class CMP_EBX_ESP : Instruction, ICmp
    {
        public CMP_EBX_ESP()
            : base(2, typeof(ICmp))
        {
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.CMP_REGISTER, (byte)CmpRegisterOpcodes.CMP_EBX_ESP };
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "CMP EBX, ESP";
        }

        public void Compare(ref Flags flags, Registers registers)
        {
            flags.ZeroFlag = registers.EBX == registers.ESP;
        }
    }
}