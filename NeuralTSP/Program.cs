﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralTSP {
    class Program {
        static void Main(string[] args) {
            Controller controller = new Controller(new View(), new Model());
        }
    }
}
