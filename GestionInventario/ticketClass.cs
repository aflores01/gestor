using LibPrintTicket;
using System;

namespace GestionInventario
{
    class ticketClass
    {
        public void PrintTicket(string cliente, string telefono, string equipo, string falla, string cost, string coment)
        {
            Ticket recibo = new Ticket();
            recibo.AddHeaderLine("DK LABORATORIO CELULAR");
            recibo.AddSubHeaderLine("");
            recibo.AddHeaderLine("LUN - SAB 9:30 - 19:00");
            recibo.AddHeaderLine("AV MEXICO 111, DOS RIOS");
            recibo.AddHeaderLine("HUIXQUILUCAN MÉXICO 52790");
            recibo.AddHeaderLine(Properties.Settings.Default.contact_number.ToString());
            recibo.AddSubHeaderLine("");
            recibo.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString());
            recibo.AddHeaderLine("");
            recibo.AddHeaderLine("Cliente: " + cliente);
            recibo.AddHeaderLine("Contacto: " + telefono);
            recibo.AddItem("1", equipo, "");
            recibo.AddItem("", falla, cost);
            recibo.AddTotal("$", cost);
            recibo.AddFooterLine("Comentarios: " + coment);
            recibo.AddFooterLine("");
            recibo.AddFooterLine("DESPUÉS DE 30 DÍAS NO NOS");
            recibo.AddFooterLine("HACEMOS RESPONSABLES POR");
            recibo.AddFooterLine("NINGÚN EQUIPO O ANTICIPO");
            recibo.AddFooterLine("");
            recibo.AddFooterLine("EQUIPOS MOJADOS NO HAY");
            recibo.AddFooterLine("      GARANTÍA");
            recibo.AddFooterLine("");
            recibo.AddFooterLine("DISPLAY/TOUCH 15 DÍAS DE");
            recibo.AddFooterLine("      GARANTÍA");
            recibo.AddFooterLine("");
            recibo.AddFooterLine("MICRÓFONOS CENTROS DE CARGA");
            recibo.AddFooterLine("ALTAVOZ 30 DÍAS DE GARANTÍA");
            recibo.AddFooterLine("");
            recibo.AddFooterLine("SÓLO SE ENTREGA EQUIPO");
            recibo.AddFooterLine("   CON ESTE TICKET");
            if (Properties.Settings.Default.printer == "null")
            {

            }
            else 
            {
                recibo.PrintTicket(Properties.Settings.Default.printer);
            }
        }

        public void PrintCopyTicket(string cliente, string telefono, string equipo, string falla, string cost, string coment, string fecha)
        {
            Ticket recibo = new Ticket();
            recibo.AddHeaderLine("DK LABORATORIO CELULAR");
            recibo.AddSubHeaderLine("");
            recibo.AddHeaderLine("LUN - SAB 9:30 - 19:00");
            recibo.AddHeaderLine("AV MEXICO 111, DOS RIOS");
            recibo.AddHeaderLine("HUOXQUIUCAN MÉXICO 52790");
            recibo.AddHeaderLine("55 8284 2550");
            recibo.AddSubHeaderLine("");
            recibo.AddSubHeaderLine(fecha);
            recibo.AddHeaderLine("");
            recibo.AddHeaderLine("Cliente: " + cliente);
            recibo.AddHeaderLine("Contacto: " + telefono);
            recibo.AddItem("1", equipo, "");
            recibo.AddItem("", falla, cost);
            recibo.AddTotal("$", cost);
            recibo.AddFooterLine("Comentarios: " + coment);
            recibo.AddFooterLine("");
            recibo.AddFooterLine("DESPUÉS DE 30 DÍAS NO NOS");
            recibo.AddFooterLine("HACEMOS RESPONSABLES POR");
            recibo.AddFooterLine("NINGÚN EQUIPO O ANTICIPO");
            recibo.AddFooterLine("");
            recibo.AddFooterLine("EQUIPOS MOJADOS NO HAY");
            recibo.AddFooterLine("      GARANTÍA");
            recibo.AddFooterLine("");
            recibo.AddFooterLine("DISPLAY/TOUCH 15 DÍAS DE");
            recibo.AddFooterLine("      GARANTÍA");
            recibo.AddFooterLine("");
            recibo.AddFooterLine("MICRÓFONOS CENTROS DE CARGA");
            recibo.AddFooterLine("ALTAVOZ 30 DÍAS DE GARANTÍA");
            recibo.AddFooterLine("");
            recibo.AddFooterLine("SÓLO SE ENTREGA EQUIPO");
            recibo.AddFooterLine("   CON ESTE TICKET");
            if (Properties.Settings.Default.printer == "null")
            {

            }
            else
            {
                recibo.PrintTicket(Properties.Settings.Default.printer);
            }
        }
    }
}
