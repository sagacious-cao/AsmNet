﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.MOV
{
    public class MOV_ESI_ESI : Instruction, IMov
    {
        public VirtualAddress ModifiyValue { get; set; }
        public MOV_ESI_ESI()
            : base(2, typeof(IMov))
        {
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.MOV_REGISTER, (byte)MovRegisterOpcodes.MOV_ESI_ESI };
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "MOV ESI, ESI";
        }

        public void Execute(Registers registers, Sections.DataSection dataSection)
        {
            registers.ESI = registers.ESI;
        }
    }
}