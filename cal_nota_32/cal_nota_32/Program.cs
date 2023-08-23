using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_nota_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media = 0, nota = 0, notalu = 0, acumnota = 0, medialu, porcalu;
            int contalu = 0, contrecalu = 0, contrec = 0;
            double[] maiores = new double[3];
            char rept = 'S';
            string[] recu = new string[10];
            int etapa = 0;

            Console.WriteLine("|---------------------------------------------|");
                Console.Write("|Informe sua etapa <1/2/3>: ");
            etapa = int.Parse(Console.ReadLine());
            switch (etapa) 
            {

                case 1:

                    while (rept == 'S')
                    {
                        Console.Clear();

                        contalu += 1;
                        notalu = 0;
                        contrecalu = 0;
                        acumnota = 0;
                        medialu = 0;
                        porcalu = 0;


                        Console.WriteLine("|---------------------------------------------|");
                        Console.Write("|Informe sua nota em amb comp: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 18)
                        {
                            recu[0] = "Ambientes Computacionais";
                            contrecalu += 1;
                        }


                        Console.Write("|Informe sua nota em front: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 18)
                        {
                            recu[1] = "Front End";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em banco de dados: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 18)
                        {
                            recu[2] = "Banco de dados";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em física: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 18)
                        {
                            recu[3] = "Física";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em games: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 18)
                        {
                            recu[4] = "Games";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em portugês: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 18)
                        {
                            recu[5] = "portugês";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em lógica: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 18)
                        {
                            recu[6] = "lógica";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em matemática: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 18)
                        {
                            recu[7] = "matemática";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em sociologia: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 18)
                        {
                            recu[8] = "sociologia";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em projeto de vida: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 18)
                        {
                            recu[9] = "projeto de vida";
                            contrecalu += 1;
                        }


                        medialu = notalu / 10;
                        porcalu = (notalu * 100) / 300;

                        if (contrecalu > 0)
                        {
                            contrec += 1;

                            Console.WriteLine("|---------------------------------------------|");
                            Console.WriteLine("O aluno está de recuperação em: " + contrecalu + " matérias");
                            Console.WriteLine("Sendo elas:");
                            for (int i = 0; i < recu.Length; i++)
                            {
                                if (recu[i] != "")
                                {
                                    Console.Write(recu[i] + " ");
                                    Console.WriteLine("");
                                }
                            }
                        }
                        Console.WriteLine("|---------------------------------------------|");
                        Console.WriteLine("|A nota geral do aluno foi: " + notalu);
                        Console.WriteLine("|A média geral do aluno foi: " + medialu.ToString("0.0"));
                        Console.WriteLine("|A porcentagem geral do aluno foi: " + porcalu.ToString("0.0") + "%");

                        nota += notalu;

                        if (notalu >= 240 & contrecalu < 1)
                        {
                            if (notalu > maiores[0])
                            {
                                maiores[2] = maiores[1];
                                maiores[1] = maiores[0];
                                maiores[0] = notalu;

                            }
                            else
                            {
                                if (notalu > maiores[1])
                                {
                                    maiores[2] = maiores[1];
                                    maiores[1] = notalu;

                                }
                                else
                                {
                                    
                                    if (notalu > maiores[2])
                                    {
                                        maiores[2] = notalu;

                                    }

                                }
                            }
                        }

                        media = nota / contalu;
                        Console.WriteLine("|---------------------------------------------|");
                        Console.Write("|Deseja inserir mais notas? <S/N>:  ");
                        rept = char.Parse(Console.ReadLine().ToUpper());
                    }
                    Console.Clear();
                    Console.WriteLine("|---------------------------------------------|");
                    Console.WriteLine("|The best #1: " + maiores[0]);
                    Console.WriteLine("|The best #2: " + maiores[1]);
                    Console.WriteLine("|The best #3: " + maiores[2]);
                    Console.WriteLine("|Alunos contabilizados: " + contalu);
                    Console.WriteLine("|Alunos em recuperação: " + contrec);
                    Console.WriteLine("|Nota geral: " + nota);
                    Console.WriteLine("|Média geral: " + media.ToString("0.0"));
                    Console.WriteLine("|---------------------------------------------|");

                    Console.ReadKey();

                    break;

                case 2:

                case 3:
                    
                    while (rept == 'S')
                    {
                        Console.Clear();

                        contalu += 1;
                        notalu = 0;
                        contrecalu = 0;
                        acumnota = 0;
                        medialu = 0;
                        porcalu = 0;


                        Console.WriteLine("|---------------------------------------------|");
                        Console.Write("|Informe sua nota em amb comp: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 21)
                        {
                            recu[0] = "Ambientes Computacionais";
                            contrecalu += 1;
                        }


                        Console.Write("|Informe sua nota em front: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 21)
                        {
                            recu[1] = "Front End";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em banco de dados: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 21)
                        {
                            recu[2] = "Banco de dados";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em física: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 21)
                        {
                            recu[3] = "Física";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em games: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 21)
                        {
                            recu[4] = "Games";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em portugês: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 21)
                        {
                            recu[5] = "portugês";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em lógica: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 21)
                        {
                            recu[6] = "lógica";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em matemática: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 21)
                        {
                            recu[7] = "matemática";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em sociologia: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 21)
                        {
                            recu[8] = "sociologia";
                            contrecalu += 1;
                        }

                        Console.Write("|Informe sua nota em projeto de vida: ");
                        acumnota = double.Parse(Console.ReadLine());
                        notalu += acumnota;

                        if (acumnota < 21)
                        {
                            recu[9] = "projeto de vida";
                            contrecalu += 1;
                        }


                        medialu = notalu / 10;
                        porcalu = (notalu * 100) / 350;

                        if (contrecalu > 0)
                        {
                            contrec += 1;

                            Console.WriteLine("|---------------------------------------------|");
                            Console.WriteLine("O aluno está de recuperação em: " + contrecalu + " matérias");
                            Console.WriteLine("Sendo elas:");
                            for (int i = 0; i < recu.Length; i++)
                            {
                                if (recu[i] != "")
                                {
                                    Console.Write(recu[i] + " ");
                                    Console.WriteLine("");
                                }
                            }
                        }
                        Console.WriteLine("|---------------------------------------------|");
                        Console.WriteLine("|A nota geral do aluno foi: " + notalu);
                        Console.WriteLine("|A média geral do aluno foi: " + medialu.ToString("0.0"));
                        Console.WriteLine("|A porcentagem geral do aluno foi: " + porcalu.ToString("0.0") + "%");

                        nota += notalu;

                        if (notalu >= 320 & contrecalu < 1)
                        {
                            if (notalu > maiores[0])
                            {
                                maiores[2] = maiores[1];
                                maiores[1] = maiores[0];
                                maiores[0] = notalu;

                            }
                            else
                            {
                                if (notalu > maiores[1])
                                {
                                    maiores[2] = maiores[1];
                                    maiores[1] = notalu;

                                }
                                else
                                {
                                    // algo errado
                                    if (notalu > maiores[2])
                                    {
                                        maiores[2] = notalu;

                                    }

                                }
                            }
                        }

                        media = nota / contalu;
                        Console.WriteLine("|---------------------------------------------|");
                        Console.Write("|Deseja inserir mais notas? <S/N>:  ");
                        rept = char.Parse(Console.ReadLine().ToUpper());
                    }
                    Console.Clear();
                    Console.WriteLine("|---------------------------------------------|");
                    Console.WriteLine("|The best #1: " + maiores[0]);
                    Console.WriteLine("|The best #2: " + maiores[1]);
                    Console.WriteLine("|The best #3: " + maiores[2]);
                    Console.WriteLine("|Alunos contabilizados: " + contalu);
                    Console.WriteLine("|Alunos em recuperação: " + contrec);
                    Console.WriteLine("|Nota geral: " + nota);
                    Console.WriteLine("|Média geral: " + media.ToString("0.0"));
                    Console.WriteLine("|---------------------------------------------|");

                    Console.ReadKey();

                    break;
            
            }
        }
    }
}
