    class Empleados
{
    private String dni;
    private String apellido;
    private String nombre;
    private String direccion;
    private String telefono;
    private String antiguedad;
    private int salario;
    private String supervisor;

    public Empleados(String dni, String apellido, String nombre)
    {
        this.dni = dni;
        this.apellido = apellido; 
        this.nombre = nombre;
        salario = 0;
        antiguedad = "0";
        telefono = "0";
        direccion = "0";
        supervisor = "null";
        
    }


    public String getDni(){

        return dni;
    }
    public String getNombre(){

        return nombre;
    }
    public String getApellido(){

        return apellido;
    }
    public int getSalario(){

        return salario;
    }

    public void presentarse()
    {
        Console.WriteLine("Hola soy "+nombre+" "+apellido);
    }
    public void incrementarSalario()
    {
        salario = salario + 10; 

    }
    public void cambiarSupervisor()
    {
        

    }


}