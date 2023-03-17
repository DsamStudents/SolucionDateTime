using System;

namespace AppDateTime.Helper
{
    public static class Utilidad
    {
        public static string ERROR01="Ha ocurrido un error en Utilidad: ";
        public static string ERRORNAMEEMPTY = "El nombre del estudiante no debe estar vacio.";
        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            var fechaActual = DateTime.Now;
            if (fechaNacimiento>fechaActual)
            {
                throw new ArgumentException("La edad de nacimiento no debe ser mayor a la fecha actual.");
            }            
            var edad=fechaActual.Year-fechaNacimiento.Year;
            var cumpleanios = new DateTime(fechaActual.Year, fechaNacimiento.Month, fechaNacimiento.Day);
            //Esta opción es para bobos
            //if (cumpleanios>fechaActual)
            //{
            //    --edad;
            //}   
            //return edad;
            return cumpleanios > fechaActual ? --edad : edad;
          
        }
    }
}
