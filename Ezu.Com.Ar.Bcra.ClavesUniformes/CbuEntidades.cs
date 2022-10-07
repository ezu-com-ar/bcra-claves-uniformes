﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ezu.Com.Ar.Bcra.ClavesUniformes
{
    /// <summary>
    /// Diccionario de entidades. Permite obtener el nombre de la entidad bancaria correspondiente a un CBU.
    /// </summary>
    public class CbuEntidades
    {
        private Dictionary<string, string> entidades = new Dictionary<string, string>()
        {
            ["005"] = "The Royal Bank of Scotland N.V.",
            ["007"] = "Banco de Galicia y Buenos Aires S.A.",
            ["011"] = "Banco de la Nación Argentina",
            ["014"] = "Banco de la Provincia de Buenos Aires",
            ["015"] = "Industrial and Commercial Bank of China S.A.",
            ["016"] = "Citibank N.A.",
            ["017"] = "BBVA Banco Francés S.A.",
            ["018"] = "The Bank of Tokyo-Mitsubishi UFJ, LTD.",
            ["020"] = "Banco de la Provincia de Córdoba S.A.",
            ["027"] = "Banco Supervielle S.A.",
            ["029"] = "Banco de la Ciudad de Buenos Aires",
            ["030"] = "Central de la República Argentina",
            ["034"] = "Banco Patagonia S.A.",
            ["044"] = "Banco Hipotecario S.A.",
            ["045"] = "Banco de San Juan S.A.",
            ["046"] = "Banco do Brasil S.A.",
            ["060"] = "Banco de Tucumán S.A.",
            ["065"] = "Banco Municipal de Rosario",
            ["072"] = "Banco Santander Río S.A.",
            ["083"] = "Banco del Chubut S.A.",
            ["086"] = "Banco de Santa Cruz S.A.",
            ["093"] = "Banco de la Pampa Sociedad de Economía Mixta",
            ["094"] = "Banco de Corrientes S.A.",
            ["097"] = "Banco Provincia del Neuquén S.A.",
            ["143"] = "Brubank S.A.U.",
            ["147"] = "Banco Interfinanzas S.A.",
            ["150"] = "HSBC Bank Argentina S.A.",
            ["158"] = "Openbank",
            ["165"] = "JP Morgan Chase Bank NA (Sucursal Buenos Aires)",
            ["191"] = "Banco Credicoop Cooperativo Limitado",
            ["198"] = "Banco de Valores S.A.",
            ["247"] = "Banco Roela S.A.",
            ["254"] = "Banco Mariva S.A.",
            ["259"] = "Banco Itaú Argentina S.A.",
            ["262"] = "Bank of America National Association",
            ["266"] = "BNP Paribas",
            ["268"] = "Banco Provincia de Tierra del Fuego",
            ["269"] = "Banco de la República Oriental del Uruguay",
            ["277"] = "Banco Sáenz S.A.",
            ["281"] = "Banco Meridian S.A.",
            ["285"] = "Banco Macro S.A.",
            ["295"] = "American Express Bank LTD. S.A.",
            ["299"] = "Banco Comafi S.A.",
            ["300"] = "Banco de Inversión y Comercio Exterior S.A.",
            ["301"] = "Banco Piano S.A.",
            ["305"] = "Banco Julio S.A.",
            ["309"] = "Nuevo Banco de la Rioja S.A.",
            ["310"] = "Banco del Sol S.A.",
            ["311"] = "Nuevo Banco del Chaco S.A.",
            ["312"] = "MBA Lazard Banco de Inversiones S.A.",
            ["315"] = "Banco de Formosa S.A.",
            ["319"] = "Banco CMF S.A.",
            ["321"] = "Banco de Santiago del Estero S.A.",
            ["322"] = "Banco Industrial S.A.",
            ["325"] = "Deutsche Bank S.A.",
            ["330"] = "Nuevo Banco de Santa Fe S.A.",
            ["331"] = "Banco Cetelem Argentina S.A.",
            ["332"] = "Banco de Servicios Financieros S.A.",
            ["336"] = "Banco Bradesco Argentina S.A.",
            ["338"] = "Banco de Servicios y Transacciones S.A.",
            ["339"] = "RCI Banque S.A.",
            ["340"] = "BACS Banco de Crédito y Securitización S.A.",
            ["341"] = "Más Ventas S.A.",
            ["384"] = "Wilobank S.A.",
            ["386"] = "Nuevo Banco de Entre Ríos S.A.",
            ["389"] = "Banco Columbia S.A.",
            ["405"] = "Ford Credit Compañía Financiera S.A.",
            ["406"] = "Metrópolis Compañía Financiera S.A.",
            ["408"] = "Compañía Financiera Argentina S.A.",
            ["413"] = "Montemar Compañía Financiera S.A.",
            ["415"] = "Transatlántica Compañía Financiera S.A.",
            ["428"] = "Caja de Crédito Coop. La Capital del Plata LTDA.",
            ["431"] = "Banco Coinag S.A.",
            ["432"] = "Banco de Comercio S.A.",
            ["434"] = "Caja de Crédito Cuenca Coop. LTDA.",
            ["437"] = "Volkswagen Credit Compañía Financiera S.A.",
            ["438"] = "Cordial Compañía Financiera S.A.",
            ["440"] = "Fiat Crédito Compañía Financiera S.A.",
            ["441"] = "GPAT Compañía Financiera S.A.",
            ["442"] = "Mercedes-Benz Compañía Financiera Argentina S.A.",
            ["443"] = "Rombo Compañía Financiera S.A.",
            ["444"] = "John Deere Credit Compañía Financiera S.A.",
            ["445"] = "PSA Finance Argentina Compañía Financiera S.A.",
            ["446"] = "Toyota Compañía Financiera de Argentina S.A.",
            ["448"] = "Finandino Compañía Financiera S.A.",
            ["453"] = "Naranja X",
            ["992"] = "Provincanje S.A.",
        };

        /// <summary>
        /// Diccionario de entidades predeterminado.
        /// </summary>
        public static CbuEntidades Default { get; } = new CbuEntidades();

        /// <summary>
        /// Nombre de entidad que se devuelve cuando no se la encuentra en el diccionario.
        /// </summary>
        public string NombrePorDefecto { get; set; }

        public CbuEntidades()
        {
        }

        public CbuEntidades(Dictionary<string, string> entidades)
        {
            this.entidades = entidades;
        }

        /// <summary>
        /// Obtiene el nombre de la entidad bancaria correspondiente al CBU.
        /// </summary>
        /// <param name="cbu">El CBU del cual se obtendrá el nombre de la entidad bancaria.</param>
        /// <returns>El nombre de la entidad bancaria. Si no está en el diccionario se devuelve lo especificado en la propiedad NombrePorDefecto.</returns>
        public string GetNombreEntidad(Cbu cbu)
        {
            var exito = entidades.TryGetValue(cbu.NroEntidad, out var nombreEntidad);
            return exito ? nombreEntidad : NombrePorDefecto;
        }

        /// <summary>
        /// Agrega una entidad bancaria al diccionario.
        /// </summary>
        /// <param name="codigo">Código de entidad.</param>
        /// <param name="nombreEntidad">Nombre de entidad.</param>
        public void Agregar(string codigo, string nombreEntidad)
        {
            entidades.Add(codigo, nombreEntidad);
        }

        /// <summary>
        /// Elimina una entidad bancaria del diccionario a partir de su código.
        /// </summary>
        /// <param name="codigo">Código de entidad.</param>
        public void Eliminar(string codigo)
        {
            entidades.Remove(codigo);
        }
    }
}
