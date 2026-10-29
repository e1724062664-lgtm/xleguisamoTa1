namespace xleguisamoTa1.Views;

public partial class Principal : ContentPage
{
	public Principal()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        guardarTxt();
        string mensaje = "SU REGISTRO FUE GUARDADO CON ÉXITO";
        DisplayAlertAsync("exito", mensaje, "ok");

    }

    private void guardarTxt()
    {
        string rutaProyecto = @"C:\Logs";
        string carpeta = Path.Combine(rutaProyecto, "Archivos");
        string rutaArchivo = Path.Combine(carpeta, "prueba.txt");
        if (!Directory.Exists(carpeta))
        {
            Directory.CreateDirectory(carpeta);
        }
        var identificacion = txtIdentificacion.Text;
        var apellido = txtApellido.Text;
        var nombreCompletos = txtNombreCompletos.Text;
        var telefono = txtTelefono.Text;
        var correo = txtCorreo.Text;
        var carrera = txtCarrera.Text;
        var modalidad = txtModalidad.Text;
        var campus = txtCampus.Text;
        if (!File.Exists(rutaArchivo))
        {
            File.Create(rutaArchivo).Dispose();
        }
        using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
        {
            writer.WriteLine($"Identificación: {identificacion}");
            writer.WriteLine($"Apellido: {apellido}");
            writer.WriteLine($"Nombre Completos: {nombreCompletos}");
            writer.WriteLine($"Teléfono: {telefono}");
            writer.WriteLine($"Correo: {correo}");
            writer.WriteLine($"Carrera: {carrera}");
            writer.WriteLine($"Modalidad: {modalidad}");
            writer.WriteLine($"Campus: {campus}");
            writer.WriteLine("------------------------");
        }
    }
}