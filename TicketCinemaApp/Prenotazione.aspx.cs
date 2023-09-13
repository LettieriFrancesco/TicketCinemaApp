using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketCinemaApp
{
    public partial class Prenotazione : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["CINEMA_COOKIE"] != null)
            {
                string nome = Request.Cookies["CINEMA_COOKIE"]["Username"];
                DatiUtenteUsername.InnerHtml = $"Bentornato {nome}";
            }
            else
            {
                DatiUtenteUsername.InnerHtml = "Nessun dato dell'utente salvato";
                Response.Redirect("Default.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nome = TextBox1.Text;
            string cognome = TextBox2.Text;
            string salaSelezionata = DropDownList1.SelectedValue;
            bool ticketRidotto = CheckBoxList1.Items[0].Selected;
           
            if (salaSelezionata == "Selezione Sala" )
            {
                LabelMessaggio.Text = "Seleziona una sala";
            }
            else
            {
                int postiRimasti = 0;
                List<Sala> salaDaPrenotare = null;

                if(salaSelezionata == "Ticket SalaNord")
                {
                    postiRimasti = MultiSala.PostiRimastiSalaNord;
                    salaDaPrenotare = MultiSala.SalaNord;
                }
                else if(salaSelezionata == "Ticket SalaEst")
                {
                    postiRimasti = MultiSala.PostiRimastiSalaEst;
                    salaDaPrenotare = MultiSala.SalaEst;
                }
                else if(salaSelezionata == "Ticket SalaSud")
                {
                    postiRimasti = MultiSala.PostiRimastiSalaSud;
                    salaDaPrenotare = MultiSala.SalaSud;
                }
                if(postiRimasti > 0)
                {
                    Sala nuovaPrenotazione = new Sala(nome,cognome,ticketRidotto);
                    salaDaPrenotare.Add(nuovaPrenotazione);
                    postiRimasti--;
                    if(salaSelezionata == "Ticket SalaNord")
                    {
                        MultiSala.PostiRimastiSalaNord = postiRimasti;
                    }
                    else if(salaSelezionata == "Ticket SalaEst")
                    {
                        MultiSala.PostiRimastiSalaEst = postiRimasti;
                    }
                    else if(salaSelezionata == "Ticket SalaSud")
                    {
                        MultiSala.PostiRimastiSalaSud = postiRimasti;
                    }
                    LabelMessaggio.Text = "Prenotazione effettuata con successo!";
                }
                else
                {
                    LabelMessaggio.Text = "La sala è piena scegli un altra sala!";
                }
                int bigliettiVendutiInteriNord = MultiSala.SalaNord.Count(s => !s.TicketRidotto);
                int bigliettiVendutiRidottiNord = MultiSala.SalaNord.Count(s => s.TicketRidotto);
                int postiRimanentiNord = 120 - MultiSala.SalaNord.Count;

                int bigliettiVendutiInteriEst = MultiSala.SalaEst.Count(s => !s.TicketRidotto);
                int bigliettiVendutiRidottiEst = MultiSala.SalaEst.Count(s => s.TicketRidotto);
                int postiRimanentiEst = 120 - MultiSala.SalaEst.Count;

                int bigliettiVendutiInteriSud = MultiSala.SalaSud.Count(s => !s.TicketRidotto);
                int bigliettiVendutiRidottiSud = MultiSala.SalaSud.Count(s => s.TicketRidotto);
                int postiRimanentiSud = 120 - MultiSala.SalaSud.Count;

                Riepilogo.InnerHtml = "Riepilogo acquisto biglietti";

                LabelBigliettiVendutiNord.Text = $"Biglietti venduti per Sala Nord: {bigliettiVendutiInteriNord} di cui ridotti: {bigliettiVendutiRidottiNord} </br>";
                LabelBigliettiVendutiEst.Text = $"Biglietti venduti per Sala Est: {bigliettiVendutiInteriEst} di cui ridotti: {bigliettiVendutiRidottiEst} </br>";
                LabelBigliettiVendutiSud.Text = $"Biglietti venduti per Sala Sud: {bigliettiVendutiInteriSud} di cui ridotti: {bigliettiVendutiRidottiSud} </br>";

                LabelPostiRimanentiNord.Text = $"Posti rimanenti per Sala Nord: {postiRimanentiNord} </br>";
                LabelPostiRimanentiEst.Text = $"Posti rimanenti per Sala Est: {postiRimanentiEst} </br>";
                LabelPostiRimanentiSud.Text = $"Posti rimanenti per Sala Sud: {postiRimanentiSud}";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["CINEMA_COOKIE"] != null)
            {
                Response.Cookies["CINEMA_COOKIE"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("Default.aspx");
        }
    }
}