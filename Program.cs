namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados emp1 = new Empleados("354355", "fuentes", "pepe");

            Console.WriteLine(emp1.getDni()+emp1.getApellido());

            Supervisor sup1 = new Supervisor("654645", "power", "Max");

            sup1.presentarse();
            sup1.incrementarSalario();

            Console.WriteLine("salario es:"+sup1.getSalario());

            Secretario sec1 = new Secretario("21233", "Diaz", "Marco");

            sup1.setSecretario(sec1);

            sup1.mostrarSecretario();

            Coche c1 = new Coche("FWK289", "Renault", "Clio");

            sup1.cambiarCoche(c1);

            Console.WriteLine("El coche de "+sup1.getNombre()+" es: "+sup1.getCoche().getMarca());  


        }

    }


}

