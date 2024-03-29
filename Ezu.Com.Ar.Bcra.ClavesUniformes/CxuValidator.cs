﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ezu.Com.Ar.Bcra.ClavesUniformes
{
    public abstract class CxuValidator
    {
        private readonly CalculadoraDvs _calculadoraDvs = new CalculadoraDvs();

        /// <summary>
        /// Indica si se realizará la validación de dígitos verificadores.
        /// </summary>
        public bool ValidarDvs { get; set; } = true;

        private bool LargoValido(Cxu cxu)
        {
            return cxu.ToString().Length == 22;
        }

        private bool EsNumerico(Cxu cxu)
        {
            return Regex.IsMatch(cxu.ToString(), @"^\d+$");
        }

        private bool DvsSonValidos(Cxu cxu)
        {
            return !ValidarDvs || _calculadoraDvs.DvsSonValidos(cxu);
        }

        /// <summary>
        /// Realiza la validación.
        /// </summary>
        /// <param name="cxu">Objeto a validar.</param>
        /// <returns>True si es válido.</returns>
        public virtual bool EsValido(Cxu cxu)
        {
            return LargoValido(cxu) && EsNumerico(cxu) && DvsSonValidos(cxu);
        }
    }
}
