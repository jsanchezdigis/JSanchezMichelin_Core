namespace ML
{
    public class Punto
    {
        public int IdPunto { get; set; }
        public string Nombre { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int MyProperty { get; set; }
        public string FechaHora { get; set; }
        public List<object> Puntos { get; set; }
    }
}