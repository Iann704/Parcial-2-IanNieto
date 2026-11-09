using Negocio;
using Presentacion.interfaces;

namespace Presentacion.presentadores;

public class CambiarContrasenaPresenter
{
    private readonly ICambiarContrasenaView _vista;
    private readonly IAutenticacionService _servicio;
    private readonly string _nombreUsuario;

    public CambiarContrasenaPresenter(
        ICambiarContrasenaView vista, IAutenticacionService servicio, string nombreUsuario)
    {
        _vista = vista;
        _servicio = servicio;
        _nombreUsuario = nombreUsuario;

        _vista.CambiarClick += OnCambiar;
    }

    private void OnCambiar(object? sender, EventArgs e)
    {
        if (_vista.ContrasenaNueva != _vista.ConfirmarNueva)
        {
            _vista.MostrarMensaje("La confirmación no coincide con la nueva contraseña.");
            return;
        }

        try
        {
            _servicio.CambiarContrasena(
                _nombreUsuario, _vista.ContrasenaActual, _vista.ContrasenaNueva);
            _vista.MostrarMensaje("Contraseña actualizada correctamente.");
            _vista.Cerrar();
        }
        catch (ArgumentException ex)
        {
            _vista.MostrarMensaje(ex.Message);
        }
        catch (Exception)
        {
            _vista.MostrarMensaje("No se pudo actualizar la contraseña.");
        }
    }
}