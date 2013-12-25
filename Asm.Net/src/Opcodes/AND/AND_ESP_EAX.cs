﻿using System;
using System.Collections.Generic;
using System.Text;
using Asm.Net.src.Interfaces;

namespace Asm.Net.src.Opcodes.XOR
{
    public class AND_ESP_EAX : Instruction, IAnd
    {
        public AND_ESP_EAX()
            : base(2, typeof(IAnd))
        {
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { (byte)OpcodeList.AND_REGISTER, (byte)AndRegisterOpcodes.AND_ESP_EAX };
        }

        public override void Dispose()
        {
        }

        public override string ToString()
        {
            return "AND ESP, EAX";
        }

        public void AndValue(Registers register)
        {
            register.ESP &= register.EAX;
        }
    }
}