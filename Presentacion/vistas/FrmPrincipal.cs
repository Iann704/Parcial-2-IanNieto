using Presentacion.interfaces;
using System.ComponentModel;
using System.Drawing.Text;

namespace Presentacion.vistas;

public partial class FrmPrincipal : Form, IPrincipalView
{
    // 1. Constantes y campos
    private const int AnchoExpandido = 200;
    private const int AnchoColapsado = 60;
    private bool _menuExpandido = true;

    // 2. Constructor
    public FrmPrincipal()
    {
        InitializeComponent();

        ConfigurarBoton(btnMenu, "\uE700");
        ConfigurarBoton(btnUsuarios, "\uE716");
        ConfigurarBoton(btnCambiarClave, "\uE72E");
        ConfigurarBoton(btnSalir, "\uE7E8");

        ttMenu.SetToolTip(btnMenu, "Mostrar u ocultar menú");
        ttMenu.SetToolTip(btnUsuarios, "Usuarios");
        ttMenu.SetToolTip(btnCambiarClave, "Cambiar contraseña");
        ttMenu.SetToolTip(btnSalir, "Cerrar sesión");

        tmrReloj.Tick += (s, e) => TickReloj?.Invoke(this, EventArgs.Empty);
        btnSalir.Click += (s, e) => CerrarSesionClick?.Invoke(this, EventArgs.Empty);
        btnCambiarClave.Click += (s, e) => CambiarContrasenaClick?.Invoke(this, EventArgs.Empty);
        btnMenu.Click += (s, e) => AlternarMenuClick?.Invoke(this, EventArgs.Empty);
        tmrMenu.Tick += (s, e) => AnimarMenu();
    }

    // 3. Propiedades y eventos de la interfaz
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string UsuarioActual { set => lblUsuario.Text = value; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string HoraActual { set => lblHora.Text = value; }

    public event EventHandler? TickReloj;
    public event EventHandler? CerrarSesionClick;
    public event EventHandler? CambiarContrasenaClick;
    public event EventHandler? AlternarMenuClick;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Action? AccionCambiarContrasena { get; set; }

    // 4. Métodos de la interfaz
    public void CerrarSesion() => Close();

    public void AbrirCambioContrasena() => AccionCambiarContrasena?.Invoke();

    public void AlternarMenu()
    {
        _menuExpandido = !_menuExpandido;
        tmrMenu.Start();
    }

    // 5. Métodos de ayuda del menú
    private void AnimarMenu()
    {
        int destino = _menuExpandido ? AnchoExpandido : AnchoColapsado;
        int paso = 20;

        if (pnlMenu.Width < destino)
            pnlMenu.Width = Math.Min(pnlMenu.Width + paso, destino);
        else
            pnlMenu.Width = Math.Max(pnlMenu.Width - paso, destino);

        if (pnlMenu.Width == destino)
        {
            tmrMenu.Stop();
            ActualizarTextos();
        }
    }

    private void ActualizarTextos()
    {
        foreach (var boton in new[] { btnMenu, btnUsuarios, btnCambiarClave, btnSalir })
            boton.Text = _menuExpandido ? (string)boton.Tag! : "";

        lblUsuario.Visible = _menuExpandido;
    }

    private static Bitmap CrearIcono(string simbolo, int tamano = 24)
    {
        var bmp = new Bitmap(tamano, tamano);
        using var g = Graphics.FromImage(bmp);
        g.TextRenderingHint = TextRenderingHint.AntiAlias;
        using var fuente = new Font("Segoe MDL2 Assets", tamano * 0.7f, GraphicsUnit.Pixel);
        using var formato = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        g.DrawString(simbolo, fuente, Brushes.White,
            new RectangleF(0, 0, tamano, tamano), formato);
        return bmp;
    }

    private void ConfigurarBoton(Button boton, string simbolo)
    {
        boton.Tag = boton.Text;
        boton.Image = CrearIcono(simbolo);
        boton.ImageAlign = ContentAlignment.MiddleLeft;
        boton.TextAlign = ContentAlignment.MiddleLeft;
        boton.TextImageRelation = TextImageRelation.ImageBeforeText;
        boton.Padding = new Padding(18, 0, 0, 0);
    }
}