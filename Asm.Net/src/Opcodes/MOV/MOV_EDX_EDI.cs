﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.MOV
{
    public class MOV_EDX_EDI : Instruction, IMov
    {
        public VirtualAddress ModifiyValue { get; set; }
        public MOV_EDX_EDI()
            : base(2, typeof(IMov))
        {
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.MOV_REGISTER, (byte)MovRegisterOpcodes.MOV_EDX_EDI };
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "MOV EDX, EDI";
        }

        public void Execute(Registers registers, Sections.DataSection dataSection)
        {
            registers.EDX = registers.EDI;
        }
    }
}