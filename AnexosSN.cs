using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos_Brasil
{
    public abstract class AnexosSN
    {
        private double aliquota;
        private double valorADeduzir;

        public double Aliquota
        {
            get { return aliquota; }
            set { aliquota = value; }
        }
        public double ValorADeduzir
        {
            get { return valorADeduzir; }
            set { valorADeduzir = value; }
        }
        public void Calcular(double receitaBruta, double faturamentoMes)
        {
            double aliquotaEfetiva, valorSN;
            aliquotaEfetiva = (receitaBruta * aliquota / 100 - valorADeduzir) / receitaBruta;
            valorSN = faturamentoMes * aliquotaEfetiva;
            MessageBox.Show("R$" + valorSN.ToString("N2"), "Valor do imposto");          
        }
        public abstract void calculoAnexo(double receitaBruta, double faturamentoMes);
    }
       
    public class Anexo1:AnexosSN
    {
        public Anexo1(double receitaBruta)
        {
			if (receitaBruta <= 180000)
			{
				Aliquota = 4.00;
				ValorADeduzir = 0;
			}
			if (receitaBruta > 180000 && receitaBruta <= 360000)
			{
				Aliquota = 7.30;
				ValorADeduzir = 5940;
			}
			if (receitaBruta > 360000 && receitaBruta <= 720000)
			{
				Aliquota = 9.50;
				ValorADeduzir = 13860;
			}
			if (receitaBruta > 720000 && receitaBruta <= 1800000)
			{
				Aliquota = 10.70;
				ValorADeduzir = 22500;
			}
			if (receitaBruta > 1800000 && receitaBruta <= 3600000)
			{
				Aliquota = 14.30;
				ValorADeduzir = 87300;
			}
			if (receitaBruta > 3600000 && receitaBruta <= 4800000)
			{
				Aliquota = 19.00;
				ValorADeduzir = 378000;
			}
		}
        public override void calculoAnexo(double receitaBruta, double faturamentoMes)
        {        
            Calcular(receitaBruta, faturamentoMes);          
        }
    }
    public class Anexo2:AnexosSN
    {
        public Anexo2(double receitaBruta)
        {
			if (receitaBruta <= 180000)
			{
				Aliquota = 4.50;
				ValorADeduzir = 0;
			}
			if (receitaBruta > 180000 && receitaBruta <= 360000)
			{
				Aliquota = 7.80;
				ValorADeduzir = 5940;
			}
			if (receitaBruta > 360000 && receitaBruta <= 720000)
			{
				Aliquota = 10.00;
				ValorADeduzir = 13860;
			}
			if (receitaBruta > 720000 && receitaBruta <= 1800000)
			{
				Aliquota = 11.20;
				ValorADeduzir = 22500;
			}
			if (receitaBruta > 1800000 && receitaBruta <= 3600000)
			{
				Aliquota = 14.70;
				ValorADeduzir = 85500;
			}
			if (receitaBruta > 3600000 && receitaBruta <= 4800000)
			{
				Aliquota = 30.00;
				ValorADeduzir = 720000;
			}
		}
        public override void calculoAnexo(double receitaBruta, double faturamentoMes)
        {
               Calcular(receitaBruta, faturamentoMes);          
        }
    }
    public class Anexo3 : AnexosSN
    {
        public Anexo3(double receitaBruta)
        {
			if (receitaBruta <= 180000)
			{
				Aliquota = 6;
				ValorADeduzir = 0;
			}
			if (receitaBruta > 180000 && receitaBruta <= 360000)
			{
				Aliquota = 11.20;
				ValorADeduzir = 9360;
			}
			if (receitaBruta > 360000 && receitaBruta <= 720000)
			{
				Aliquota = 13.50;
				ValorADeduzir = 17640;
			}
			if (receitaBruta > 720000 && receitaBruta <= 1800000)
			{
				Aliquota = 16.00;
				ValorADeduzir = 35640;
			}
			if (receitaBruta > 1800000 && receitaBruta <= 3600000)
			{
				Aliquota = 21.00;
				ValorADeduzir = 125640;
			}
			if (receitaBruta > 3600000 && receitaBruta <= 4800000)
			{
				Aliquota = 33.00;
				ValorADeduzir = 648000;
			}
		}
        public override void calculoAnexo(double receitaBruta, double faturamentoMes)
        {           
            Calcular(receitaBruta, faturamentoMes);
        }
    }
    public class Anexo4:AnexosSN
    {
        public Anexo4(double receitaBruta)
        {
			if (receitaBruta <= 180000)
			{
				Aliquota = 4.50;
				ValorADeduzir = 0;
			}
			if (receitaBruta > 180000 && receitaBruta <= 360000)
			{
				Aliquota = 9.00;
				ValorADeduzir = 8100;
			}
			if (receitaBruta > 360000 && receitaBruta <= 720000)
			{
				Aliquota = 10.20;
				ValorADeduzir = 12420;
			}
			if (receitaBruta > 720000 && receitaBruta <= 1800000)
			{
				Aliquota = 14.00;
				ValorADeduzir = 39780;
			}
			if (receitaBruta > 1800000 && receitaBruta <= 3600000)
			{
				Aliquota = 22.00;
				ValorADeduzir = 183780;
			}
			if (receitaBruta > 3600000 && receitaBruta <= 4800000)
			{
				Aliquota = 33.00;
				ValorADeduzir = 828000;
			}
		}
        public override void calculoAnexo(double receitaBruta, double faturamentoMes)
        {
            Calcular(receitaBruta, faturamentoMes);           
        }
    }
    public class Anexo5:AnexosSN
    {
		public Anexo5(double receitaBruta)
		{
			if (receitaBruta <= 180000)
			{
				Aliquota = 15.50;
				ValorADeduzir = 0;
			}
			if (receitaBruta > 180000 && receitaBruta <= 360000)
			{
				Aliquota = 18.00;
				ValorADeduzir = 4500;
			}
			if (receitaBruta > 360000 && receitaBruta <= 720000)
			{
				Aliquota = 19.50;
				ValorADeduzir = 9900;
			}
			if (receitaBruta > 720000 && receitaBruta <= 1800000)
			{
				Aliquota = 20.50;
				ValorADeduzir = 17100;
			}
			if (receitaBruta > 1800000 && receitaBruta <= 3600000)
			{
				Aliquota = 23.00;
				ValorADeduzir = 62100;
			}
			if (receitaBruta > 3600000 && receitaBruta <= 4800000)
			{
				Aliquota = 30.50;
				ValorADeduzir = 540000;
			}
		}
        public override void calculoAnexo(double receitaBruta, double faturamentoMes)
        {
            Calcular(receitaBruta, faturamentoMes);           
        }
    }
}
