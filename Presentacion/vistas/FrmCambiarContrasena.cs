using Presentacion.interfaces;

namespace Presentacion.vistas;

public partial class FrmCambiarContrasena : Form, ICambiarContrasenaView
{
    public FrmCambiarContrasena()
    {
        InitializeComponent();
        btnCambiar.Click += (s, e) => CambiarClick?.Invoke(this, EventArgs.Empty);
    }

    public string ContrasenaActual => txtActual.Text;
    public string ContrasenaNueva => txtNueva.Text;
    public string ConfirmarNueva => txtConfirmar.Text;

    public event EventHandler? CambiarClick;

    public void MostrarMensaje(string mensaje) =>
        MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

    public void Cerrar() => Close();
}