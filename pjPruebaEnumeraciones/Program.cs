int estatusOperacion = 5;
if(estatusOperacion == (int)EstatusOperacion.Exitoso)
{
    //...
}
else if(estatusOperacion == (int)EstatusOperacion.ClienteNoEncontrado)
{
    //...
}
else if(estatusOperacion == (int)EstatusOperacion.ErrorDeSistema)
{
    //...
}

public enum EstatusOperacion
{
    Exitoso = 1,
    ClienteNoEncontrado = 2,
    ErrorDeSistema = 5
}