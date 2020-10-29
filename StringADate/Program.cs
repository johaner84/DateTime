using System;

namespace StringADate
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fechaCadena = "21 oct. 2020 23:12:20 GMT-4";

            //string dia = fechaCadena.Substring(0, 2);
            //string mes = fechaCadena.Substring(3, 3);
            //string year = fechaCadena.Substring(8, 4);


            //int month=0;

            //Console.WriteLine(dia);
            //Console.WriteLine(mes);
            //Console.WriteLine(year);

            //switch (mes)
            //{
            //    case "ene": month = 01; break;
            //    case "feb": month = 02; break;
            //    case "mar": month = 03; break;
            //    case "abr": month = 04; break;
            //    case "may": month = 05; break;
            //    case "jun": month = 06; break;
            //    case "jul": month = 07; break;
            //    case "ago": month = 08; break;
            //    case "sep": month = 09; break;
            //    case "oct": month = 10; break;
            //    case "nov": month = 11; break;
            //    case "dic": month = 12; break;
            //}

            //Console.WriteLine(month);


            //string fechaBien = month +"/"+ dia +"/"+ year;
            //Console.WriteLine(fechaBien);



            //DateTime fechaDefinitiva = DateTime.ParseExact(fechaBien,"MM/dd/yyyy",null);
            //Console.WriteLine(fechaDefinitiva);
            //Console.ReadLine();

            Console.WriteLine(ProcesaFecha(fechaCadena));

        }

        public DateTime ProcesaFecha(string fecha)
        {

            int month = 0;

            string day = fecha.Substring(0, 2);
            string mes = fecha.Substring(3, 3);
            string year = fecha.Substring(8, 4);

            string hora = "";
            string min = "";
            string seg = "";



            if (fecha.Length == 25)
            {
                day = fecha.Substring(0, 1);
                day = "0" + day;
                year = fecha.Substring(7, 4);
                switch (mes)
                {
                    case "ne.": month = 01; break;
                    case "eb.": month = 02; break;
                    case "ar.": month = 03; break;
                    case "br.": month = 04; break;
                    case "ay.": month = 05; break;
                    case "un.": month = 06; break;
                    case "ul.": month = 07; break;
                    case "go.": month = 08; break;
                    case "ep.": month = 09; break;
                    case "ct.": month = 10; break;
                    case "ov.": month = 11; break;
                    case "ic.": month = 12; break;
                }

                hora = fecha.Substring(12, 1);
                min = fecha.Substring(14, 2);
                seg = fecha.Substring(17, 2);
            }
            else if (fecha.Length == 26)
            {
                hora = fecha.Substring(13, 1);
                min = fecha.Substring(15, 2);
                seg = fecha.Substring(18, 2);
            }
            else
            {
                switch (mes)
                {
                    case "ene": month = 01; break;
                    case "feb": month = 02; break;
                    case "mar": month = 03; break;
                    case "abr": month = 04; break;
                    case "may": month = 05; break;
                    case "jun": month = 06; break;
                    case "jul": month = 07; break;
                    case "ago": month = 08; break;
                    case "sep": month = 09; break;
                    case "oct": month = 10; break;
                    case "nov": month = 11; break;
                    case "dic": month = 12; break;
                }
            }

            string fechaCompleta = $"{month},{day},{year},{hora},{min},{seg}";

            DateTime dateFull = DateTime.ParseExact(fechaCompleta, "MM/dd/yyyy hh:mm:ss", null);

            return dateFull;

        }
    }
}
