using System.Windows.Forms;

public class Funcionario
{
    private string matricula, nome, cpf, funcao;
    private double salario;
    public Funcionario(string matricula, string nome, string cpf, string funcao, double salario)
    {
        this.matricula = matricula;
        this.nome = nome;
        this.cpf = cpf;
        this.funcao = funcao;
        this.salario = salario;
    }
    public string Funcao
    {
        get { return funcao; }
        set { funcao = value; }
    }
    public double Salario
    {
        get { return salario; }
        set { salario = value; }
    }
    public (double, double) Calcular_salario(double salario, string funcao)
    {
        double IRPF = 0;
        if (funcao.Contains("Medico"))
        {
            salario += (salario * 0.2);
        }
        else if (funcao.Contains("TI"))
        {
            salario += 5600;
        }
        else if (funcao.Contains("ADM"))
        {
            salario += (salario * 0.15) + 200;
        }
        if (salario > 5000)
        {
            IRPF = salario * 0.17;
            salario -= (IRPF);
        }
        return (salario, IRPF);
    }

}