using Entidades;
using Presentacion.interfaces;

namespace Presentacion.vistas;

public partial class FrmLogin : Form, ILoginView
{
    public FrmLogin()
    {
        InitializeComponent();
        btnIniciar.Click += (s, e) => IniciarSesionClick?.Invoke(this, EventArgs.Empty);
        btnRegistro.Click += (s, e) => AbrirRegistroClick?.Invoke(this, EventArgs.Empty);
        AcceptButton = btnIniciar;
    }

    public string NombreUsuario => txtUsuario.Text;
    public string Contrasena => txtContrasena.Text;

    public event EventHandler? IniciarSesionClick;
    public event EventHandler? AbrirRegistroClick;

    public void MostrarMensaje(string mensaje) =>
        MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

    public Action<Usuario>? AccionAbrirPrincipal { get; set; }

    public void AbrirPrincipal(Usuario usuario) => AccionAbrirPrincipal?.Invoke(usuario);

    public Action? AccionAbrirRegistro { get; set; }

    public void AbrirRegistro() => AccionAbrirRegistro?.Invoke();
}