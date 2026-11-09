using System;
using System.Collections.Generic;
using System.Text;

namespace Presentacion.interfaces
{
    public interface IPrincipalView
    {
        string UsuarioActual { set; }
        string HoraActual { set; }

        event EventHandler? TickReloj;
        event EventHandler? CerrarSesionClick;

        void CerrarSesion();
    }
}
