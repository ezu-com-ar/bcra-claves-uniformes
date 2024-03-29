﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ezu.Com.Ar.Bcra.ClavesUniformes
{
    public class CxuBuilder
    {
        public Cxu Crear(string cxuStr)
        {
            return cxuStr.StartsWith("000") ? (Cxu) new Cvu(cxuStr) : new Cbu(cxuStr);
        }

        public object Crear(string bloque1, string bloque2)
        {
            return bloque1.StartsWith("000") ? (Cxu) new Cvu(bloque1, bloque2) : new Cbu(bloque1, bloque2);
        }
    }
}
