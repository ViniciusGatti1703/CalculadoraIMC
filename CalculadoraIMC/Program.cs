//declarar as variáveis
string nome;
decimal peso;
decimal altura;
decimal imc;
string classificacao;

// Entrada dos valores
Console.Write("Digite seu nome: ");
nome = Console.ReadLine();
Console.Write("Digite seu peso: ");
peso = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite sua altura: ");
altura = Convert.ToDecimal(Console.ReadLine());

// Calcular o IMC
imc = peso / (altura * altura);

// Verificar a classificação

if (imc <= 18.5m)
{
    classificacao = "Abaixo do peso";
}
else if (imc <= 24.9m)
{
    classificacao = "Peso normal";
}
else if (imc <= 29.9m)
{
    classificacao = "Sobrepeso";
}
else if (imc <= 34.9m)
{
    classificacao = "Obesidade Grau 1";
}
else if (imc <= 39.9m)
{
    classificacao = "Obesidade Grau 2";
}
else
{
    classificacao = "Obesidade Grau 3";
}
//Mostrar o resultado na tela
Console.Clear();
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Peso: " + peso);
Console.WriteLine("Altura: " + altura);
Console.WriteLine("IMC: " + imc);
Console.WriteLine("Classificação: " + classificacao);