using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos_Brasil
{
	public sealed class AnexosSimpleFactory
	{
		public static AnexosSN CriaAnexo(string numeroAnexo, double receitaBruta, double faturamentoMes)
		{
			AnexosSN anexo;
			switch(numeroAnexo)
			{
				case "1":
					anexo = new Anexo1(receitaBruta);
					break;
				case "2":
					anexo = new Anexo2(receitaBruta);
					break;
				case "3":
					anexo = new Anexo3(receitaBruta);
					break;
				case "4":
					anexo = new Anexo4(receitaBruta);
					break;
				case "5":
					anexo = new Anexo5(receitaBruta);
					break;
				default:
					throw new ApplicationException("O anexo " + numeroAnexo + " não existe!");
			}
			return anexo;
		}
	}
}
