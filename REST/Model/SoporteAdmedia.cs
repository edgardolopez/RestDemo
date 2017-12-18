using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SoporteAdmedia
    {
        public string CodigoVehiculo { get; set; }
        public int IdMedio { get; set; }
        public string IdSoporte { get; set; }
        public string IdTipoSoporte{ get; set; }
        public string DescripcionAdmedia { get; set; }

        //o COD_VEHICULO_ADMEDIA: Base ADMEDIA – Tabla Vehículo
        //o ID_MEDIO: Base EVEREST – Tabla Soporte_MMS_ARG
        //o ID_SOPORTE: Base EVEREST – Tabla Soporte_MMS_ARG
        //o ID_TIPO_SOPORTE: Base EVEREST – Tabla Soporte_MMS_ARG
        //o DESCRIPCION_ADMEDIA: Base ADMEDIA – Tabla Vehículo
    }
}
