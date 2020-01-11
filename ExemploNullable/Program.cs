using System;

namespace ExemploNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valores stack não aceitam valores nulos
            //No entanto, para forçar que a variável aceite, há um recuro no qual a variável passa a aceitar valores nulos

            //A forma abaixo faz com que o tipo stack double aceite valores nulos
            Nullable<double> x = null;
            
            //esta é outra forma de fazer a operação
            double? y = null;

            double? z = 10.0;

            //A função GetValueOrDefault() faz com que se o valor for nulo, pegar o valor padrão stack.
            //No caso double, o valor padrão é zero.
            Console.WriteLine(y.GetValueOrDefault());

            //Já o método abaixo, o programa vai considear o 10, pois existe um valor atribuído
            Console.WriteLine(z.GetValueOrDefault());

            //O método HasValue checa se a variável possui valor returnando TRUE ou FALSE
            
            //Quando passamos o Y, o programa imprime False
            Console.WriteLine(y.HasValue);

            //Já no método abaixo, retornará True
            Console.WriteLine(z.HasValue);

            //Quando usamos o método Value direto, se o dado não tiver valor, retornará erro no programa
            //pois o valor stack double exige valores não nulos.
            //Console.WriteLine(y.Value);
            

            //para resolver isso, podemos usar uma condição IF para checar se o dado é não nulo
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("x é nulo");
            }

            //No teste abaixo, como há informação, Z é TRUE e o resultado é impresso.
            if (z.HasValue)
            {
                Console.WriteLine(z.Value);
            }
            else
            {
                Console.WriteLine("z é nulo");
            }


        }
    }
}
