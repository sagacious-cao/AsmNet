﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.MOV
{
    public class MOV_EBP : Instruction, IMov
    {
        public VirtualAddress ModifiyValue { get; set; }
        public MOV_EBP(VirtualAddress virtualAddress)
            : base(5, typeof(IMov))
        {
            this.ModifiyValue = virtualAddress;
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.MOV_EBP,
                                BitConverter.GetBytes(ModifiyValue.Address)[0],
                                BitConverter.GetBytes(ModifiyValue.Address)[1],
                                BitConverter.GetBytes(ModifiyValue.Address)[2],
                                BitConverter.GetBytes(ModifiyValue.Address)[3]
                              };
        }

        public void Execute(Registers registers, Sections.DataSection dataSection)
        {
            registers.ECX = ModifiyValue.Address;
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "MOV EBP, 0x" + ModifiyValue.Address.ToString("X6");
        }
    }
}
