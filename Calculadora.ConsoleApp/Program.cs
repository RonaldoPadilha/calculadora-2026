//Objetivos / Passo-a-passo

// v1
//1.Nossa calculadora deve ter a possibilidade de somar dois números 
/*2.Nossa calculadora deve ter a possibilidade de subtrair dois números
3.Nossa calculadora deve ter a possibilidade de multiplicar dois números
4.Nossa calculadora deve ter a possibilidade de dividir dois números
5.Nossa calculadora deve permitir que o usuário continue utilizando o sistema até decidir sair*/

// v2
// 1.Nossa calculadora deve dar a possibilidade de produzir a tabuada de um número informado
// 2.Nossa calculadora deve dar a possibilidade de visualizar histórico de operações

// Arrays
string[] historicoOperacoes = new string[100];
int contadorOperacoes = 0;



while (true == true)
{
    Console.Clear();

    Console.WriteLine("--------------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("--------------------------");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - Histórico de Operações");
    Console.WriteLine("S - Saír");
    Console.WriteLine("--------------------------");
    Console.Write("Escolha uma opção válida: ");
    String opcao = Console.ReadLine();

    if (opcao == "S" || opcao == "s")
    {
        break;
    }

    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6")
    {
        Console.WriteLine("-----------------");
        Console.WriteLine("Opção inválida");
        Console.WriteLine("-----------------");

        Console.WriteLine("Digite ENTER para saír...");
        Console.ReadLine();
        continue;
    }

    if (opcao == "5")
    {
        //Console.Clear();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Calculadora 2026");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Digite um número inteiro: ");
        string strNumeroDigitado = Console.ReadLine();

        int numeroDigitado = Convert.ToInt32(strNumeroDigitado);

        Console.WriteLine(numeroDigitado);
        //Console.WriteLine(strNumeroDigitado + " x " + 1 + " = " + numeroDigitado * 1);

        for (int iterador = 1; iterador <= 10; iterador = iterador + 1)
        {
            string linhaTabuada = $"{numeroDigitado} x {iterador} = {numeroDigitado * iterador}";
            Console.WriteLine(strNumeroDigitado + " x " + iterador + " = " + numeroDigitado * iterador);
        }

        Console.WriteLine("--------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
        continue;

    }

    if (opcao == "6")
    {
        Console.Clear();
        Console.WriteLine("---------------");
        Console.WriteLine("HISTÓRICO DE OPERAÇÕES");
        Console.WriteLine("---------------");
        for (int iterador = 0; iterador < historicoOperacoes.Length; iterador++)
        {
            if (historicoOperacoes[iterador] != null)
            {
                Console.WriteLine(historicoOperacoes[iterador]);
            }

        }
    }

    Console.Write("Digite o primeiro número: ");
    String strPrimeiroNumero = Console.ReadLine(); // texto - character String - cadeia de caracteres

    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);

    Console.Write("Digite o segundo número: ");
    String strSegundoNumero = Console.ReadLine();

    int segundoNumero = Convert.ToInt32(strSegundoNumero);

    int resultado = 0;
    string textoOperacao;

    //Estrutura de decisão

    if (opcao == "1")
    {
        resultado = primeiroNumero + segundoNumero;
        textoOperacao = $"{primeiroNumero} + {segundoNumero} = {resultado}";
    }
    else if (opcao == "2")
    {
        resultado = primeiroNumero - segundoNumero;
        textoOperacao = $"{primeiroNumero} - {segundoNumero} = {resultado}";
    }
    else if (opcao == "3")
    {
        resultado = primeiroNumero * segundoNumero;
        textoOperacao = $"{primeiroNumero} * {segundoNumero} = {resultado}";
    }
    else
    {
        resultado = primeiroNumero / segundoNumero;
        textoOperacao = $"{primeiroNumero} / {segundoNumero} = {resultado}";
    }

    if (contadorOperacoes < historicoOperacoes.Length)
    {
        historicoOperacoes[contadorOperacoes] = textoOperacao;

        contadorOperacoes = contadorOperacoes + 1;
    }
    else
    {
        historicoOperacoes = new string[100];
        contadorOperacoes = 0;

        historicoOperacoes[contadorOperacoes] = textoOperacao;
        contadorOperacoes++;
    }

    Console.WriteLine("O resultado é: " + resultado);

    Console.ReadLine();
}

