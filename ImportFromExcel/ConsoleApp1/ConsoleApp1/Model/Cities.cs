using System;
using System.Collections.Generic;

namespace ConsoleApp1.Model
{
    public partial class Cities
    {
        public int? CodiceRegione { get; set; }
        public int? CodiceUnita { get; set; }
        public int? CodiceProvincia { get; set; }
        public int? ProgressivoComune { get; set; }
        public string CodiceComune { get; set; }
        public string DenominazioneItalianaStraniera { get; set; }
        public string DenominazioneItaliana { get; set; }
        public string DenominazioneAltraLingua { get; set; }
        public int? CodiceRipartizioneGeografica { get; set; }
        public string RipartizioneGeografica { get; set; }
        public string DenominazioneRegione { get; set; }
        public string DenominazioneUnita { get; set; }
        public int? FlagComuneCapoluogo { get; set; }
        public string SiglaAutomobilistica { get; set; }
        public int? CodiceComuneFormatoNumerico { get; set; }
        public int? CodiceComuneNumericoCon110Province { get; set; }
        public int? CodiceComuneNumericoCon107Province { get; set; }
        public int? CodiceComuneNumericoCon103Province { get; set; }
        public string CodiceCatastale { get; set; }
        public int? PopolazioneLegale2011 { get; set; }
        public string Nuts1 { get; set; }
        public string Nuts2 { get; set; }
        public string Nuts3 { get; set; }
        public long Id { get; set; }
    }
}
