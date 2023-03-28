class Coche{

    String matricula;
    String marca;
    String modelo;

    public Coche(String matricula, String marca, String modelo)
    {

        this.marca = marca;
        this.modelo = modelo;
        this.matricula = matricula;

    }

    public String getMatricula()
    {
        return matricula;
    }
    public String getModelo()
    {
        return modelo;
    }
    public String getMarca()
    {
        return marca;
    }
    public void setMatricula(String matricula)
    {
        this.matricula = matricula;
    }
    public void setModelo(String modelo)
    {
        this.modelo = modelo;
    }
    public void setMarca(String marca)
    {
        this.marca = marca;
    }



}