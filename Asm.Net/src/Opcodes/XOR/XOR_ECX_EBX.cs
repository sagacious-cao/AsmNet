﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.XOR
{
    public class XOR_ECX_EBX : Instruction, IXor
    {
        public XOR_ECX_EBX()
            : base(2, typeof(IXor))
        {
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.XOR_REGISTER, (byte)XorRegisterOpcodes.XOR_ECX_EBX };
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "XOR ECX, EBX";
        }

        public void XorValue(Registers register)
        {
            register.ECX ^= register.EBX;
        }
    }
}