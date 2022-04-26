public class Individuo
{
    public string Nome {get; set;}
    public double Peso {get; set;}  
    public double Altura {get; set;}

    public Individuo()
    {
               Nome = " ";
        Peso = 0;
        Altura = 0;
    }
    
     public double CalculoImc()
    {
         
        double CalculoImc() = Peso / (Altura * Altura);
        return Math.Round (CalculoImc(), 2);
    } 

    public string FaixaAtual()
    {            
         
            if(CalculoImc() <17.00)
            {
                return "Você está muito abaixo do peso!\n";
            }
            else if (CalculoImc() >=17.00 && CalculoImc() <18.50)
            {
                return "Você está abaixo do peso!\n";
            }
            else if(CalculoImc()>=18.50 && CalculoImc() <25.00)
            {
                return "Você está no peso normal!\n";
            }
            else if (CalculoImc() >=25.00 && CalculoImc() <30.00)
            {
                return "Você está acima do peso.\n";
            }
            else if (CalculoImc() >=30.00 && CalculoImc() <35.00)
            {
                return "Você está obeso - Obesidade Grau I\n";
            }
            else if (CalculoImc() >=35.00 && CalculoImc() <40.00)
            {
                return "Você está obeso - Obesidade Grau II (severa)\n";
            }
            else 
            {
                return "Você está obeso - Obesidade Grau III (mórbida)\n";
            }

            return -1;
    }

    public double PesoIdeal()
    {
        
        if(CalculoImc() < 18.50)
        {
            double pesoNecessario = ((18.5*Peso)/CalculoImc()) -Peso;
            Console.WriteLine("Para chegar ao peso ideal, você precisa ganhar:");
            return pesoNecessario;
        }

        else if(CalculoImc() >= 25)
        {
            double pesoNecessario = Peso- ((24.99*Peso)/CalculoImc());
            Console.WriteLine("Para chegar ao peso ideal, você precisa perder:");
            return pesoNecessario;
        }
        
        else
        {
            PesoIdeal = CalculoImc() * (Altura * Altura);
            Console.WriteLine("Você já está no peso ideal!");
        }
        return Math.Round(PesoIdeal, 2);
    }
}