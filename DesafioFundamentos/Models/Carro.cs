public class Carro
{
    public string Placa { get; set; }

    public Carro(string placa)
    {
        Placa = placa;
    }

    public override string ToString()
    {
        return Placa;
    }
}