﻿using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp.Refactorizacion
{
    internal class Cilindro : IArea
    {
        public double Altura { get; internal set; }
        public double Radio { get; internal set; }

        public double Area()
        {
            return (2 * Math.PI * this.Radio * (this.Radio + this.Altura));
        }
    }
}