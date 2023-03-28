class Supervisor : Empleados
{
    private Coche coche;
    private Secretario secretario;
    private String despacho;

    public Supervisor(string dni, string apellido, String nombre) : base(dni, apellido, nombre)
    {
        secretario = new Secretario("null", "null", "null");
        coche = new Coche("null", "null", "null");
        despacho = "0";

    }

    public void setSecretario(Secretario secretario)
    {
        this.secretario = secretario;
    }

    public void cambiarCoche(Coche coche)
    {
        this.coche = coche;
    }
    public Coche getCoche()
    {
        return coche;
    }
        public void mostrarSecretario()
    {
        Console.WriteLine("El secretario es "+secretario.getNombre());
    }




}