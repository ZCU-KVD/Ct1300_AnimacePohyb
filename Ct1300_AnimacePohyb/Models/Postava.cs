namespace Ct1300_AnimacePohyb.Models
{
	public class Postava
	{
		public Postava(string jmeno, int width, string obrazek)
		{
			Jmeno = jmeno;
			Width = width;
			Obrazek = obrazek;
		}
		#region Atributy
		public string Jmeno { get; }
		public int Width { get; }
		public string Obrazek { get; }

		private List<Souradnice> SouradniceList { get; set; } = new List<Souradnice>();

		public int AktualniPozice { get; private set; } = -1;

		public string Style {
			get {
				if (AktualniPozice <0)
				{
					return $"width: {Width}px;";
				}
				else
				{
					var pozice = SouradniceList[AktualniPozice];
					return $"{pozice.Style} width: {Width*pozice.VelikostObrProcenta/100}px; ";
				}
			}
		}

		public bool SmerVpred { get; set; } = true;
		#endregion

		#region Metody
		public void PridejPozici(int pozX, int pozY, int pruhlednost, int velikostObrProcenta)
		{
			var souradnice = new Souradnice(pozX, pozY, pruhlednost, velikostObrProcenta);
			SouradniceList.Add(souradnice);
		}

		public void Presun()
		{
			if (SmerVpred)
			{ 
				if(AktualniPozice == SouradniceList.Count - 1)
				{
					SmerVpred = false;
				}
			}
			else
			{
				if (AktualniPozice == 0)
				{
					SmerVpred = true;
				}
			}

			AktualniPozice += SmerVpred? 1 : -1;
		}
		#endregion
	}
}
