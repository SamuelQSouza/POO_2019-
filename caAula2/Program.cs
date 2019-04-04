using System;
using System.Collections.Generic;

namespace caAula2
{
     class Program
    {
        static Aluno achaAluno(String nome_aluno, List<Aluno> alunos)
        {
            Aluno achei_aluno = null;
            for(int i = 0; i < alunos.Count; i++)
            {
                if(nome_aluno == alunos[i].getNome());
                {
                    achei_aluno = alunos[i];
                    break;
                }
            }
            return achei_aluno;
        }
        
        static Materia achaMateria(String nome_materia, List<Materia> materias)
        {
            Materia achei_materia = null;
            for(int i = 0; i < materias.Count; i++)
            {
                if(nome_materia == materias[i].getNome())
                {
                    achei_materia = materias[i];
                    break;
                }
            }
            return achei_materia;
        }

        static void Main(string[] args)
        {
            //dados para aluno
            String nome_aluno, matricula;
            int periodo;
            
            //dados para materia
            String nome_materia, codigo_materia;

            //dados para associar aluno e materia
            Aluno aL;
            Materia mL;

            //para armazenar os alunos e as materias criadas
            List<Aluno> listaAlunos = new List<Aluno>();
            List<Materia> listaMaterias = new List<Materia>();

            //Aluno a1 = new Aluno("Ze Mane", "11511ECP008", 5);
            //Aluno a2 = new Aluno("Ze Ruela", "11512ECP009", 5);
            //Aluno a3 = new Aluno("Ze Maneta", "11513ECP010", 5);
            //Materia m1 =new Materia("POO","FEELT3131");
            //Materia m2 =new Materia("ED","FEELT3132");
            //a1.associaMateria(m1);
            //a1.associaMateria(m2);
            //a1.imprimeRelatorio();
            //Console.ReadLine();

            int aux = 1;
            while (aux != 0)
            {
                Console.WriteLine("Escolha uma opção do menu:\n");
                Console.WriteLine(" [1] - Cadastrar um aluno");
                Console.WriteLine(" [2] - Cadastrar uma disciplina");
                Console.WriteLine(" [3] - Associar uma disciplina a um aluno");
                Console.WriteLine(" [4] - Imprimir relatório");
                Console.WriteLine(" [5] - Sair");

                string op = Console.ReadLine();

                switch (op){
                    
                    case "1":
                    Console.Write("Cadastrar um aluno\n");
                    Console.Write("Entre com o nome do aluno: ");
                    nome_aluno = Console.ReadLine();
                    Console.Write("Entre com a matricula do aluno: ");
                    matricula = Console.ReadLine();
                    Console.Write("Entre com periodo do aluno: ");
                    periodo = int.Parse(Console.ReadLine());
                    Aluno a = new Aluno(nome_aluno, matricula, periodo);
                    listaAlunos.Add(a);
                    Console.Clear();

                    break;
                    
                    case "2":
                    Console.Write("Cadastrar uma materia\n");
                    Console.Write("Entre com o nome do materia: ");
                    nome_materia = Console.ReadLine();
                    Console.Write("Entre com o codigo do materia: ");
                    codigo_materia = Console.ReadLine();
                    Materia m = new Materia(nome_materia, codigo_materia);
                    listaMaterias.Add(m);
                    Console.Clear();

                    break;
                    
 case "3":
                    Console.Write("Associar uma disciplina a um aluno\n");
                    Console.WriteLine("Escolha um aluno: \n");
                    //Apresentar lista de alunos
                    for(int i = 0; i < listaAlunos.Count; i++)
                    {
                        Aluno temp = (Aluno)listaAlunos[i]; //casting
                        Console.WriteLine("Aluno: " + temp.getNome());
                    }

                    nome_aluno = Console.ReadLine();
                    aL = achaAluno(nome_aluno, listaAlunos);
                    Console.WriteLine("Escolha uma disciplina: \n");
                    //Apresentar lista de disciplinas
                    for(int i = 0; i < listaMaterias.Count; i++)
                    {
                        Materia tempo = (Materia)listaMaterias[i]; //casting
                        Console.WriteLine("Materia: " + tempo.getNome());
                    }
                    nome_materia = Console.ReadLine();
                    mL = achaMateria(nome_materia, listaMaterias);
                    //associa aluno à materia
                    aL.associaMateria(mL);
                    Console.Clear();
                    break;

                    case "4":
                    Console.WriteLine("Imprimir relatório: \n");
                    //Apresentar lista de alunos
                    for(int i = 0; i < listaAlunos.Count; i++)
                    {
                        Aluno temp = (Aluno)listaAlunos[i]; // casting
                        Console.WriteLine("Aluno: " + temp.getNome());
                    }
                    nome_aluno = Console.ReadLine();
                    aL = achaAluno(nome_aluno, listaAlunos);
                    aL.imprimeRelatorio();
                    Console.Clear();
                    break;

                    case "5":
                    aux = 0;
                    Console.Clear();
                    break;

                    default:
                            Console.WriteLine("Favor escolher uma opção válida\n");
                            break;

                }//fim do switch
            }//fim do while
                }
            }
        }
    }
}

