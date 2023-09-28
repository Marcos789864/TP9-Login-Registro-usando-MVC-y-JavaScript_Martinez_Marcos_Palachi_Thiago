let Nombre = document.getElementById('Nombre');










function Contraseña()
{
    let contrasenaUsuario = prompt("Por favor, ingresa tu contraseña:");


    if (validacionDefinitiva(contrasenaUsuario) == false )
    {
        prompt("Por favor reingrese la contraeña:");
    }
    else
    console.log(contrasenaUsuario);
       
    function validarLongitud(contrasenaUsuario) {
        if (contrasenaUsuario.length < 8) {
            return false;
        }
        return true;
    }
        
    function validarMayuscula(contrasenaUsuario){
        for (let i = 0; i < contrasenaUsuario.length; i++) {
            if (contrasenaUsuario[i] === contrasenaUsuario[i].toUpperCase()) {
                return true;  
                }
            }
            return false;
    }

    function validarCaracteresEspeciales(contrasenaUsuario){
        const caracteresEspeciales = "!@#$%^&*";
        for (let i = 0; i < contrasenaUsuario.length; i++) {
            if (caracteresEspeciales.indexOf(contrasenaUsuario[i]) !== -1) {
                return true;  
            }
        }
            return false;
    }
    
    function validacionDefinitiva(contrasenaUsuario){
        if(validarCaracteresEspeciales(contrasenaUsuario) == true && validarLongitud(contrasenaUsuario) == true && validarMayuscula(contrasenaUsuario) == true){
            return true;
        }
        return false;
    }
}

