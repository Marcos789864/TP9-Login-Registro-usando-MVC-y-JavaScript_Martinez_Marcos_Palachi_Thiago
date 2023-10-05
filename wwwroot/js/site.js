



function contraseña()
{
    let contrasenaUsuario = document.getElementById('Contraseña')
    let bool;


    if (validacionDefinitiva(contrasenaUsuario) == false )
    {
        alert("Por favor reingrese la contraeña:");
        return false;
    }
    else
    console.log(contrasenaUsuario);
       
    function validarLongitud(contrasenaUsuario) {
        
        if (contrasenaUsuario.length < 8) {
            return bool = false;
        }
        alert("1");
        return true;
    }
        
    function validarMayuscula(contrasenaUsuario){
        for (let i = 0; i < contrasenaUsuario.length; i++) {
            if (contrasenaUsuario[i] === contrasenaUsuario[i].toUpperCase()) {
                return bool = true;  
                }
            }
            alert("2")
            return false;
    }

    function validarCaracteresEspeciales(contrasenaUsuario){
        const caracteresEspeciales = "!@#$%^&*";
        for (let i = 0; i < contrasenaUsuario.length; i++) {
            if (caracteresEspeciales.indexOf(contrasenaUsuario[i]) !== -1) {
                return bool = true;  
            }
        }
        alert("3");
            return false;
    }
    
    function validacionDefinitiva(contrasenaUsuario){
        if(validarCaracteresEspeciales(contrasenaUsuario) == true && validarLongitud(contrasenaUsuario) == true && validarMayuscula(contrasenaUsuario) == true){
            return true;
        }
        return false;
    }
}
    


