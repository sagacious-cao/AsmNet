﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.XOR
{
    public class XOR_EDI_EDI : Instruction, IXor
    {
        public XOR_EDI_EDI()
            : base(2, typeof(IXor))
        {
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.XOR_REGISTER, (byte)XorRegisterOpcodes.XOR_EDI_EDI };
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "XOR EDI, EDI";
        }

        public void XorValue(Registers register)
        {
            register.EDI ^= register.EDI;
        }
    }
}