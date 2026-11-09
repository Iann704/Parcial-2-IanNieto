namespace Presentacion.interfaces;

public interface ICambiarContrasenaView
{
    string ContrasenaActual { get; }
    string ContrasenaNueva { get; }
    string ConfirmarNueva { get; }
    event EventHandler? CambiarClick;
    void MostrarMensaje(string mensaje);
    void Cerrar();
}