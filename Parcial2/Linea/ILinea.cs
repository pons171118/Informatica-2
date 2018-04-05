﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linea
{
    public interface ILinea<T>
    {

        double Longitud();
        T PuntoMasCercano(T punto);

    }
}
