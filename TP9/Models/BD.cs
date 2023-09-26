using System.Data.SqlCliente;
using Dapper;

public static class BD
{

private static string ConnectionString{get;set;}  = @"Server=localhost,DataBase=Login_Usuarios;Trusted_Connection=True;";                                       


public static void OlvideContraseña(string Nombre)
{
    string sql = "";   
    using(SqlConnection db = new SqlConnection(ConnectionString))
    {
        sql = "UPDATE Usuario SET Contraseña where Nombre = @vNombre";
        us1 = db.Query<Usuario>(sql,new{vNombre = Nombre});
    }
    return us1;
}

public static void CrearUsuario(string Nombre, string Constraseña,int Telefono,string Ciudad, int DNI)
{
    string sql = "";
    using(SqlConnection db = new SqlConnection(ConnectionString))
    {
        sql = "INSERT INTO Usuario (Nombre,Contraseña,Telefono,Ciudad,DNI) values (@vNombre,@vContraseña,@vTelefono,@vCiudad,@vDNI)";
        us1 = db.Query<Usuario>(sql,new{vNombre = Nombre,vConstraseña = Constraseña,vTelefono = Telefono,vCiudad = Ciudad, vDNI = DNI}); 
    }
   
}

public static void IniciarSesion(string Nombre, string Constraseña,int Telefono,string Ciudad, int DNI)
{
    string sql = "";
    using(SqlConnection db = new SqlConnection(ConnectionString))
    {
        sql = "Select from from Usuario where Nombre = @vNombre, Contraseña = @vContraseña ,Telefono = @vTelefono, Ciudad = @vCiudad, DNI = @vDNI";
        us1 = db.Query<Usuario>(sql,new{vNombre = Nombre,vConstraseña = Constraseña,vTelefono = Telefono,vCiudad = Ciudad, vDNI = DNI});
    }
}

}