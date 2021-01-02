using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinoPooUdamy
{
    class Program
    {
        static void Main(string[] args)
        {
            dateiso();
            Console.ReadKey();

        }

        //treino datatime
        public static void dateiso()
        {
            DateTime date = DateTime.Parse("2000-08-15 13:04:58");
            DateTime date2 = DateTime.Parse("2000-08-15T13:04:58Z");

            Console.WriteLine(date2.ToUniversalTime().ToString("yyyy-MM--ddTHH:mm:ssZ"));

            Console.WriteLine(date);
            Console.WriteLine(date2);
        }
        public static void datetimeKind()
        {
            DateTime date = DateTime.Now;

            Console.WriteLine(date.ToUniversalTime());
            Console.WriteLine(date.ToLocalTime());
            Console.WriteLine("---------------");
            DateTime date2 = new DateTime(2000, 5, 7, 1, 5, 7,DateTimeKind.Local);
            DateTime date3 = new DateTime(2000, 5, 7, 1, 5, 7, DateTimeKind.Utc) ;
            Console.WriteLine(date2.ToLocalTime());
            Console.WriteLine(date2.ToUniversalTime());
 
       
        }
        public static void timespawnPropriedade()
        {
            TimeSpan span = TimeSpan.MaxValue;
            TimeSpan span2 = TimeSpan.MinValue;

            TimeSpan ts = new TimeSpan(4, 3, 20, 2, 2);
            TimeSpan ts2 = new TimeSpan(1, 3, 20, 2, 2);

            TimeSpan soma = ts.Add(ts2);
            Console.WriteLine(soma);

   

        }
        public static void gerarBoletoData()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("data de criação:" + date.ToString());

            DateTime date2 = date.AddDays(15);
            date2 = date.AddHours(2);
            Console.WriteLine("data de vencimento:" + date2.ToString());


            TimeSpan tm1 = date.Subtract(date2);
            Console.WriteLine("data de vencimento:" + tm1.ToString());
        }
        public static  void me()
        {
            TimeSpan t1 = new TimeSpan(0, 1, 50);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(1, 30, 12,21);
            TimeSpan t5 = new TimeSpan(1, 30, 12,21,235);
            Console.WriteLine(t4);
            Console.WriteLine(t5);


            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
        }
        public static void dateTime()
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20,45,29);
            DateTime d4 = new DateTime(2018, 11, 25, 20,45,29,500);

            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine("===============");
            DateTime dt1 = DateTime.Parse("15/08/2008");
            Console.WriteLine(dt1);
        }

        //Treino aleatorio
        public static void switch_case()
        {
            Console.WriteLine("Escreva um numero");
            int valor = int.Parse( Console.ReadLine());
            switch (valor)
            {
                case 1 : Console.WriteLine(valor);
                    break;
                case 2:
                    Console.WriteLine("salve: "+valor);
                    break;
                default:
                    Console.WriteLine("defalt");
                    break;

            }
        }
        public static void tenaria()
        {
           Console.WriteLine((1 < 2) ? "sim" : "nao");
           Console.WriteLine((3 < 2) ? "sim" : "nao");
        }

        public static void caractere()
        {
            string original = "  tesgdsf abc Abc replac ABC     ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(5);
            string s5 = original.Substring(5,10);

            string s6 = original.Replace('a','J');
            string s7 = original.Replace("abc","xy");

            bool bl = String.IsNullOrEmpty(original);
            bool bl2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("to Original: -"+original+"-");
            Console.WriteLine("to Upper: -"+s1 + "-");
            Console.WriteLine("to Lower: -"+s2 + "-");
            Console.WriteLine("to Trim: -"+s3 + "-");
            Console.WriteLine("to IndexOF: -"+ n1 + "-");
            Console.WriteLine("to LastIndexOF: -"+ n2 + "-");
            Console.WriteLine("to SubString: -"+ s4 + "-");
            Console.WriteLine("to SubString(5,10): -"+ s5 + "-");

            Console.WriteLine("to Replace: -"+ s6 + "-");
            Console.WriteLine("to Replace StringGrande: -"+ s7 + "-");
            Console.WriteLine("to IsNoOrEmpty: -"+ bl + "-");
            Console.WriteLine("to IsNoOrEmptywhiteSpace: -"+ bl2 + "-");

        }

        //Matriz
        public static void MatrizTreinoUdemy()
        {
            double[,] matrix = new double[5, 7];

            Console.WriteLine(matrix.Length); // retorna o tanto de cada posição da matrix
            
            Console.WriteLine(matrix.Rank);// retorna o tanto de linhas
            Console.WriteLine(matrix.GetLength(0)); // pega o valor da coluna ou o valor das linhas
            Console.WriteLine(matrix.GetLength(1));// pega o valor da coluna ou o valor das linhas


        }

        public static void ExeMatriz1()
        {
            Console.WriteLine("Digite o numero da matriz");
            int numero = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[numero, numero];
            //adicionar valores a matriz
            for (int linha = 0; linha < numero; linha++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int col = 0; col < numero; col++)
                {
                    matriz[linha, col] = int.Parse(values[col]);

                }
            }

            Console.WriteLine("Main Diagonal:");

            for (int pecorrer = 0; pecorrer < numero; pecorrer++)
            {
                Console.WriteLine(matriz.GetValue(pecorrer, pecorrer));
            }

            int count = 0;
            for (int linha = 0; linha < numero; linha++)
            {

                for (int col = 0; col < numero; col++)
                {
                    if(matriz[linha,col] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Numeros negativos:");
            Console.WriteLine( count );
        }
        public static void ExeMatriz2()
        {
            Console.WriteLine("Escreva os 2 numero da matriz exemplo ('3 4')");
            string[] numeroMatriz = Console.ReadLine().Split(' ');
            int[,] matriz = new int[int.Parse(numeroMatriz[0]), int.Parse(numeroMatriz[1])];
            //adiciona os valores na matriz
            for (int linha = 0; linha < int.Parse(numeroMatriz[0]); linha++)
            {
                string[] numeroAdd = Console.ReadLine().Split(' ');
                for (int col = 0; col < int.Parse(numeroMatriz[1]); col++)
                {
                    matriz[linha, col] = int.Parse(numeroAdd[col]);
                }
            }

            Console.WriteLine("Escolha um numero que tenha na matriz");
            int valorEscolhido = int.Parse(Console.ReadLine());
            for (int linha = 0; linha < int.Parse(numeroMatriz[0]); linha++)
            {                
                for (int col = 0; col < int.Parse(numeroMatriz[1]); col++)
                {
                    if (valorEscolhido == matriz[linha, col])
                    {
                        Console.WriteLine(matriz.GetLength(0).ToString()+" , "+ matriz.GetLength(1).ToString());
                        
                        //encima
                        try
                        {
                            if (matriz[linha - 1, col] != null)
                            {
                                Console.WriteLine("Up: " + matriz[linha - 1, col]);
                            }
                        }
                        catch (Exception){}
                        //embaixo
                        try
                        {
                            if (matriz[linha + 1, col] != null)
                            {
                                Console.WriteLine("Down: " + matriz[linha + 1, col]);
                            }
                        }
                        catch (Exception) { }
                        //direita
                        try
                        {
                            if (matriz[linha, col+1] != null)
                            {
                                Console.WriteLine("Right: " + matriz[linha , col+1]);
                            }
                        }
                        catch (Exception) { }

                        //Esquerda
                        try
                        {
                            if (matriz[linha, col - 1] != null)
                            {
                                Console.WriteLine("Left: " + matriz[linha , col-1]);
                            }
                        }
                        catch (Exception) { }
                        Console.WriteLine("========================================");
                    }
                }
            }

        }

        //lista
        public static void ExeFixacaoList()
        {
            List<ListClasseSalary> list = new List<ListClasseSalary>();

            ListClasseSalary emplyoee1 = new ListClasseSalary();
            emplyoee1.id = 32;
            emplyoee1.name = "Thiago";
            emplyoee1.salary = 1300;

            ListClasseSalary emplyoee2 = new ListClasseSalary();
            emplyoee2.id = 12;
            emplyoee2.name = "Juluio";
            emplyoee2.salary = 5300;

            ListClasseSalary emplyoee3 = new ListClasseSalary();
            emplyoee3.id = 45;
            emplyoee3.name = "Jovel";
            emplyoee3.salary = 2300;

            list.Add(emplyoee1);
            list.Add(emplyoee2);
            list.Add(emplyoee3);
            Console.WriteLine("Digite o id da conta");
            int id = Convert.ToInt32( Console.ReadLine());

            ListClasseSalary userElecionado = list.Find(x => x.id == id);

            if (userElecionado != null)
            {
                Console.WriteLine("Porcentagem que sera adicionada ao salario");
                double icrement = Convert.ToDouble(Console.ReadLine());
                userElecionado.increaseSalary(icrement);
                list.Insert(list.FindIndex(x => x.id == id),userElecionado);
            }
            else
            {
                Console.WriteLine("Id nao exite");
            }
            Console.WriteLine("=================");
            foreach(ListClasseSalary obj in list)
            {
                Console.WriteLine(obj.id);  
                Console.WriteLine(obj.name);  
                Console.WriteLine(obj.salary);
                Console.WriteLine("=================");
            }



        }
        public static void ListTreinoUdemyAdd()
        {



            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Joao");
            list.Add("Marcelo");
            list.Add("Ana");
            list.Insert(2,"Marco");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Find(x => x[0] == 'J').ToString());

            Console.WriteLine(list.FindLast(x => x[0] == 'M').ToString());
            Console.WriteLine("---------------------");

            Console.WriteLine( list.FindIndex(x => x[0] == 'M').ToString());

            Console.WriteLine( list.FindLastIndex(x => x[0] == 'M').ToString());
            Console.WriteLine("---------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);


            list.RemoveRange(2,2);
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
        public static void ListTreinoUdemyForeach()
        {



            List<string> list = new List<string>() { "teste" , "teste joao", "teste Thiago"};

            foreach(string l in list)
            {
                Console.WriteLine(l);
            }

        }



        //vetor
        public void produto()
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto");
            Console.WriteLine("Nome");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Preço");
            p.Preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantidade de estoque");
            p.Quant = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(p);

            Console.WriteLine("Digite o numero para ser adicionado ao estoque:");
            p.AdicionarEstoque(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(p);
            Console.WriteLine("Digite o numero para ser remover ao estoque:");
            p.RemoverEstoque(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(p);
        }

        public void exe1()
        {
            Pessoa p = new Pessoa();

            Console.WriteLine("dados da primeira pessoa");
            p.nome = Console.ReadLine();
            p.idade = Convert.ToInt32(Console.ReadLine());
            string texto1 = p.criarTexto();
            Console.WriteLine("dados da segunda pessoa");
            p.nome = Console.ReadLine();
            p.idade = Convert.ToInt32(Console.ReadLine()); string
            texto2 = p.criarTexto();

            Console.WriteLine("Dados da primeira pessoa:\n" + texto1);
            Console.WriteLine("Dados da segunda pessoa:\n" + texto2);

            Console.ReadKey();

        }

        public void chamartriangulo()
        {


            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("digite os valores do triagulo x");
            x.A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("digite os valores do triagulo y");
            y.A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;

            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            p = (y.A + y.B + y.C) / 2.0;

            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));


            Console.WriteLine("valor x:" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("valor y:" + areaY.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }

    }


}