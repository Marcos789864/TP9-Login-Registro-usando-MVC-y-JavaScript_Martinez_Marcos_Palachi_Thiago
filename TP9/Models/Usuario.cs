public static class Usuario
{

    private string Nombre {get;set}

    private string Constraseña {get;set}

    private int Telefono {get;set}

    private string Ciudad {get;set}

    private int DNI{get;set}
}

public Usuario ( string vNombre, string vConstraseña, int vTelefono,string vCiudad, int vDNI)
{
    Nombre = vNombre;
    Constraseña = vConstraseña;
    Telefono = vTelefono;
    Ciudad = vCiudad;
    DNI = vDNI;
}





