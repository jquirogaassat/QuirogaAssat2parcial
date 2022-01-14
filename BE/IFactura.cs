﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface IFactura<T,M>
    {
        decimal GetTotal(T objdet);
        decimal GetSubtotal(T objSub);
        int CantidadProductos(T objSub);
        List<M> GetDetails(T objDet);
        bool AddLine(T objFac, M objdet);

    }
}
