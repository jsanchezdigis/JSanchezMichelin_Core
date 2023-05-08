using Microsoft.EntityFrameworkCore;

namespace BL
{
    public class Punto
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.JsanchezMichelinContext context = new DL.JsanchezMichelinContext())
                {
                    var query = context.Puntos.FromSqlRaw($"PuntoGetAll").ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Punto punto = new ML.Punto();

                            punto.IdPunto = obj.IdPunto;
                            punto.Nombre = obj.Nombre;
                            punto.Latitud = obj.Latitud;
                            punto.Longitud = obj.Longitud;
                            punto.FechaHora = obj.FechaHora.ToString();

                            result.Objects.Add(punto);
                        }
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}