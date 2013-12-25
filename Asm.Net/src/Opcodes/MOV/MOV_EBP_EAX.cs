﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.MOV
{
    public class MOV_EBP_EAX : Instruction, IMov
    {
        public VirtualAddress ModifiyValue { get; set; }
        public MOV_EBP_EAX()
            : base(2, typeof(IMov))
        {
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.MOV_REGISTER, (byte)MovRegisterOpcodes.MOV_EBP_EAX };
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "MOV ESP, EAX";
        }

        public void Execute(Registers registers, Sections.DataSection dataSection)
        {
            registers.EBP = registers.EAX;
        }
    }
}