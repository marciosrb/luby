# 3 Vending Machine

Utilizado o banco de dados do SQLite por ser mais leve e de fácil configuração, basta alterar o caminho do arquivo.

O sistema possui aviso quando o cliente escolher um produto sem estoque.

Interface de fácil entendimento e uso pelo cliente.

# 1 Lógica de Programação

1.1

```c#
	  double i, numero, fatorial;
		 numero = 5;
		 fatorial = numero;
	 
	  for(i=numero-1; i>=1; i--){
	      fatorial =fatorial*i;
	  }
	  Console.Write(fatorial);
	  Console.ReadLine();
```
1.3

          void prime_num(long num) {
                bool isPrime = true;
                for (int i = 0; i <= num; i++) {
                    for (int j = 2; j <= num; j++) {
                        if (i != j && i % j == 0) {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime) {
                        Console.WriteLine("Prime:" + i);
                    }
                    isPrime = true;
                }
            }
            
            static void Main(string[] args) {
    
            Program p = new Program();
            p.prime_num(10L); //Aqui colocar o valor limite do for
            Console.ReadLine();
    
        }
1.4

```
        using System.Linq;
  
        int vogal = 0;
        char[] caracteres = { 'a', 'e', 'i', 'o', 'u', 'A' , 'E' , 'I', 'O', 'U'};
        
        Console.WriteLine("Digite a frase e descubra quantas vogais tem:");

        char[] nome_completo = Console.ReadLine().ToLower().ToCharArray();

        for (int conta = 0; conta < nome_completo.Length; conta++) {
            if (caracteres.Contains(nome_completo[conta])) {
                vogal++;
            }
        }

        Console.WriteLine("Total de " + vogal + " vogais");
        Console.Read();

        Console.ReadKey();
```

1.5

           using System.Globalization; 
      
           string entrada, desconto, saida;
           double calculo, entradaTratada, descontoTratado, calculoFinal;
           string resultadoTratado;
        
           Console.WriteLine("Digite o valor de entrada!");
           entrada = Console.ReadLine();
           entradaTratada = Convert.ToInt32(entrada);
    
           Console.WriteLine("Digite o desconto!");
           desconto = Console.ReadLine();
           descontoTratado = Convert.ToInt32(desconto);
    
           calculo = (entradaTratada * descontoTratado) /100;
           calculoFinal = entradaTratada - calculo;
    
           resultadoTratado = calculoFinal.ToString("C", CultureInfo.CurrentCulture);
    
           Console.WriteLine(resultadoTratado);
    
           Console.Read();
           Console.ReadKey();


1.6


           DateTime data1, data2;
           string data01, data02;
           Console.WriteLine("Digite a primeira data!");
           data01 = Console.ReadLine();
           data1 = Convert.ToDateTime(data01);
    
           Console.WriteLine("Digite a segunda data!");
           data02 = Console.ReadLine();
           data2 = Convert.ToDateTime(data02);
    
           Console.WriteLine("Diferença dias entre a primeira e a segunda data: " + (data2 - data1).Days);
    
           Console.Read();
           Console.ReadKey();
1.7

```
       int[] atividade = new int[6];
       string numeros = "", tipo = "";
                for (int i = 1; i < 6; i++) {
                Console.WriteLine($"Insira o {i}° numero: ");
                atividade[i] = int.Parse(Console.ReadLine());
                tipo += atividade[i] % 2 == 1 ? "impar, " : "par, ";
                numeros += atividade[i] + ", ";
            }
       Console.Clear();
       Console.Write($"Os seguintes numeros foram digitados: \n{numeros}\n{tipo}");
       Console.Read();
       Console.ReadKey();
```



