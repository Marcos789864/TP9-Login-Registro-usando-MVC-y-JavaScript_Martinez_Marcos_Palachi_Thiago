public  class Usuario
{

    public  string Nombre {get;set;}

    public string Contraseña {get;set;}

    public int Telefono {get;set;}

    public string Ciudad {get;set;}

    public int DNI{get;set;}

    public Usuario()
    {

    }
    public Usuario ( string vNombre, string vConstraseña, int vTelefono,string vCiudad, int vDNI)
{
    Nombre = vNombre;
    Contraseña = vConstraseña;
    Telefono = vTelefono;
    Ciudad = vCiudad;
    DNI = vDNI;
}

}







