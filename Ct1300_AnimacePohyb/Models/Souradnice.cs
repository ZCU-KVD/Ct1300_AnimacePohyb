namespace Ct1300_AnimacePohyb.Models
{
	public class Souradnice
	{
		public Souradnice(int pozX, int pozY, int pruhlednost, int velikostObrProcenta)
		{
			PozX = pozX;
			PozY = pozY;
			Pruhlednost = pruhlednost;
			VelikostObrProcenta = velikostObrProcenta;
		}

		public int PozX { get; }
		public int PozY { get; }
		public int Pruhlednost { get; }
		public int VelikostObrProcenta { get; }

		public string Style => $"left: {PozX}px; top: {PozY}px; opacity: {Pruhlednost/100.0}; ";
		
	}
}
