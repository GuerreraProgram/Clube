using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube
{
    public class Mensalidade
    {
        private double vlr_mensalidade;
        private double vlr_pagamento;
        private double juros;
        private string vlr_pago;
        private string dta_paga;
        private string dta_pagamento;

        public double Vlr_mensalidade { get => vlr_mensalidade; set => vlr_mensalidade = value; }
        public double Vlr_pagamento { get => vlr_pagamento; set => vlr_pagamento = value; }
        public double Juros { get => juros; set => juros = value; }
        public string Vlr_pago { get => vlr_pago; set => vlr_pago = value; }
        public string Dta_paga { get => dta_paga; set => dta_paga = value; }
        public string Dta_pagamento { get => dta_pagamento; set => dta_pagamento = value; }
    }
}
