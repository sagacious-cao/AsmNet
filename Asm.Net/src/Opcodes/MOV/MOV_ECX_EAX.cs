﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.MOV
{
    public class MOV_ECX_EAX : Instruction, IMov
    {
        public VirtualAddress ModifiyValue { get; set; }
        public MOV_ECX_EAX()
            : base(2, typeof(IMov))
        {
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.MOV_REGISTER, (byte)MovRegisterOpcodes.MOV_ECX_EAX };
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "MOV ECX, EAX";
        }

        public void Execute(Registers registers, Sections.DataSection dataSection)
        {
            registers.ECX = registers.EAX;
        }
    }
}