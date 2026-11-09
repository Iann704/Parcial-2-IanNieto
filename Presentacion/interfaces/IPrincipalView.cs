namespace Presentacion.interfaces;

public interface IPrincipalView
{
    string UsuarioActual { set; }
    string HoraActual { set; }

    event EventHandler? TickReloj;
    event EventHandler? CerrarSesionClick;
    event EventHandler? CambiarContrasenaClick;
    event EventHandler? AlternarMenuClick;

    void CerrarSesion();
    void AbrirCambioContrasena();
    void AlternarMenu();
}