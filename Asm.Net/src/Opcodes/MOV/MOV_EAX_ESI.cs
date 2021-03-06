﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.MOV
{
    public class MOV_EAX_ESI : Instruction, IMov
    {
        public VirtualAddress ModifiyValue { get; set; }
        public MOV_EAX_ESI()
            : base(2, typeof(IMov))
        {
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.MOV_REGISTER, (byte)MovRegisterOpcodes.MOV_EAX_ESI };
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "MOV EAX, ESI";
        }

        public void Execute(Registers registers, Sections.DataSection dataSection)
        {
            registers.EAX = registers.ESI;
        }
    }
}