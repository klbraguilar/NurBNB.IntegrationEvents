using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NURBNB.IntegrationEvents
{
    public class ReservaRegistrada
    {
        public DateTime fechaLlegada { get; set; }
        public DateTime fechaSalida { get; set; }
        public Guid GuestId { get; set; }
        public Guid reservaId { get; set; }
        public Guid PropiedadId { get; set; }
    }

}
