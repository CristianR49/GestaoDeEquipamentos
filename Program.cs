using System.Collections;

namespace GestaoDeEquipamentos
{
    internal class Program
    {
        static void MensagemDeErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            bool menuInicial = true;
            string opcaoPrimeiroMenu = "5";
            string opcaoMenuEquipamentos = "0";
            string opcaoMenuChamados = "0";

            string[] equipamento = new string[6];
            ArrayList equipamentos = new ArrayList();

            string[] equip1 = new string[] { "Impressora", "15", "2", "20/13/15", "corp.inc", "0" };
            string[] equip2 = new string[] { "cafeteira", "65", "7", "02/9/03", "Casas Bahia", "1" };
            equipamentos.Add(equip1);
            equipamentos.Add(equip2);

            string[] chamado = new string[6];
            ArrayList chamados = new ArrayList();

            string[] chamado1 = new string[] { "Impressora sem tinta", "Ontem a tinta da impressora começou a falhar e então parou", "Impressora", "29/03/2023", "0" };
            string[] chamado2 = new string[] { "cafeteira estragada", "a cafeteira caiu e entrou em defeito, não está dando café", "Cafeteira", "29/03/2023", "1" };
            chamados.Add(chamado1);
            chamados.Add(chamado2);
            while (true)
            {
                if (menuInicial == true)
                {
                    Console.Clear();
                    Console.WriteLine("Escolha uma opção");
                    Console.WriteLine("(1) Registro de equipamentos");
                    Console.WriteLine("(2) Registro de chamados");
                    Console.WriteLine("(3) Sair");
                    opcaoPrimeiroMenu = Console.ReadLine();
                }

                while (opcaoPrimeiroMenu == "1")
                {
                    menuInicial = false;
                    Console.Clear();
                    Console.WriteLine("----------------Registro de Equipamentos----------------");
                    Console.WriteLine("Escolha uma opção");
                    Console.WriteLine("(1) Registrar um equipamento");
                    Console.WriteLine("(2) Visualizar os equipamentos registrados");
                    Console.WriteLine("(3) Editar um equipamento registrado");
                    Console.WriteLine("(4) Excluir um equipamento registrado");
                    Console.WriteLine("(5) Voltar");
                    opcaoMenuEquipamentos = Console.ReadLine();

                    if (opcaoMenuEquipamentos == "1")
                    {

                        Console.Clear();
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Registrar um novo equipamento:");
                            Console.WriteLine("--------------------------------------------------------------");


                            Console.WriteLine("Digite o nome (no mínimo 6 caracteres)");
                            equipamento[0] = Console.ReadLine();
                            if (equipamento[0].Length < 6)
                            {
                                MensagemDeErro("Nome com menos de 6 caracteres, digite novamente!");
                                continue;
                            }
                        } while (equipamento[0].Length < 6);

                        Console.WriteLine("Digite o preço de aquisição");
                        equipamento[1] = Console.ReadLine();

                        Console.WriteLine("Digite o número de série");
                        equipamento[2] = Console.ReadLine();

                        Console.WriteLine("Digite a data de fabricação");
                        equipamento[3] = Console.ReadLine();

                        Console.WriteLine("Digite a fabricante");
                        equipamento[4] = Console.ReadLine();

                        equipamentos.Add(equipamento);

                        equipamento[5] = Convert.ToString(equipamentos.Count - 1);
                        equipamentos[equipamentos.Count - 1] = equipamento;

                        Console.WriteLine("Equipamento registrado!");
                        Console.ReadLine();
                    }

                    if (opcaoMenuEquipamentos == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Equipamentos registrados:");
                        Console.WriteLine("--------------------------------------------------------------\n");
                        if (chamados.Count == 0)
                        {
                            Console.WriteLine("\nNão há equipamentos registrados!");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            foreach (string[] item in equipamentos)
                            {

                                Console.WriteLine("Nome: " + item[0]);
                                Console.WriteLine("Preço de aquisição: " + item[1]);
                                Console.WriteLine("Número de série: " + item[2]);
                                Console.WriteLine("Data de fabricação: " + item[3]);
                                Console.WriteLine("Fabricante: " + item[4]);
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                        }
                    }

                    if (opcaoMenuEquipamentos == "3")
                    {

                        Console.Clear();
                        Console.WriteLine("Editar o registro de um equipamento:");
                        Console.WriteLine("--------------------------------------------------------------\n");
                        Console.WriteLine("Qual o ID do equipamento a ser editado?");
                        if (chamados.Count == 0)
                        {
                            Console.WriteLine("\nNão há equipamentos registrados!");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            foreach (string[] item in equipamentos)
                            {
                                Console.WriteLine("ID: " + item[5]);
                            }
                            int itemASerEditado = Convert.ToInt32(Console.ReadLine());
                            do
                            {
                                Console.WriteLine("Digite o nome (no mínimo 6 caracteres)");
                                equipamento[0] = Console.ReadLine();
                                if (equipamento[0].Length < 6)
                                {
                                    MensagemDeErro("Nome com menos de 6 caracteres, digite novamente!");
                                    continue;
                                }
                            } while (equipamento[0].Length < 6);

                            Console.WriteLine("Digite o preço de aquisição");
                            equipamento[1] = Console.ReadLine();

                            Console.WriteLine("Digite o número de série");
                            equipamento[2] = Console.ReadLine();

                            Console.WriteLine("Digite a data de fabricação");
                            equipamento[3] = Console.ReadLine();

                            Console.WriteLine("Digite a fabricante");
                            equipamento[4] = Console.ReadLine();

                            equipamento[5] = Convert.ToString(itemASerEditado);
                            equipamentos[itemASerEditado] = equipamento;

                            Console.WriteLine("Equipamento editado!");
                            Console.ReadLine();
                        }
                    }

                    if (opcaoMenuEquipamentos == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("Deletar um registro");
                        Console.WriteLine("--------------------------------------------------------------\n");
                        Console.WriteLine("Digite o ID do item a ser removido");
                        if (chamados.Count == 0)
                        {
                            Console.WriteLine("\nNão há equipamentos registrados!");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            foreach (string[] item in equipamentos)
                            {
                                Console.WriteLine("ID: " + item[5]);
                            }

                            int itemASerRemovido = Convert.ToInt32(Console.ReadLine());

                            int indiceDoId = 0;
                            foreach (string[] item in equipamentos)
                            {

                                if (itemASerRemovido == Convert.ToInt32(item[5]))
                                {
                                    equipamentos.RemoveAt(indiceDoId);
                                    break;
                                }
                                else
                                    indiceDoId++;

                            }
                            Console.WriteLine("Registro apagado!");
                            Console.ReadLine();
                        }
                    }

                    if (opcaoMenuEquipamentos == "5")
                    {
                        opcaoPrimeiroMenu = "0";
                        menuInicial = true;
                    }
                }


                while (opcaoPrimeiroMenu == "2")
                {
                    menuInicial = false;
                    Console.Clear();

                    Console.WriteLine("----------------Registro de Chamados----------------");
                    Console.WriteLine("Escolha uma opção");
                    Console.WriteLine("(1) Registrar um chamado");
                    Console.WriteLine("(2) Visualizar os chamados registrados");
                    Console.WriteLine("(3) Editar um chamado registrado");
                    Console.WriteLine("(4) Excluir um chamado registrado");
                    Console.WriteLine("(5) Voltar");
                    opcaoMenuChamados = Console.ReadLine();


                    if (opcaoMenuChamados == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Registrar um novo chamado:");
                        Console.WriteLine("--------------------------------------------------------------");

                        Console.WriteLine("Digite o título do chamado");
                        chamado[0] = Console.ReadLine();

                        Console.WriteLine("Digite a descrição do chamado");
                        chamado[1] = Console.ReadLine();

                        Console.WriteLine("Digite o equipamento");
                        chamado[2] = Console.ReadLine();

                        Console.WriteLine("Digite a data de abertura");
                        chamado[3] = Console.ReadLine();

                        chamados.Add(chamado);

                        chamado[4] = Convert.ToString(chamados.Count - 1);
                        chamados[chamados.Count - 1] = chamado;

                        Console.WriteLine("Chamado registrado!");
                        Console.ReadLine();
                    }

                    if (opcaoMenuChamados == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Chamado registrados:");
                        Console.WriteLine("--------------------------------------------------------------\n");
                        if (chamados.Count == 0)
                        {
                            Console.WriteLine("\nNão há chamados registrados!");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            foreach (string[] item in chamados)
                            {

                                Console.WriteLine("Título: " + item[0]);
                                Console.WriteLine("Descrição: " + item[1]);
                                Console.WriteLine("Equipamento: " + item[2]);
                                Console.WriteLine("Data de abertura: " + item[3]);
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                        }
                    }

                    if (opcaoMenuChamados == "3")
                    {

                        Console.Clear();
                        Console.WriteLine("Editar o registro de um chamado:");
                        Console.WriteLine("--------------------------------------------------------------\n");
                        Console.WriteLine("Qual o ID do chamado a ser editado?");
                        if (chamados.Count == 0)
                        {
                            Console.WriteLine("\nNão há chamados registrados!");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            foreach (string[] item in chamados)
                            {
                                Console.WriteLine("ID: " + item[4]);
                            }
                            int itemASerEditado = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite o título");
                            chamado[0] = Console.ReadLine();

                            Console.WriteLine("Digite a descrição");
                            chamado[1] = Console.ReadLine();

                            Console.WriteLine("Digite o equipamento");
                            chamado[2] = Console.ReadLine();

                            Console.WriteLine("Digite a data de abertura");
                            chamado[3] = Console.ReadLine();

                            chamado[4] = Convert.ToString(itemASerEditado);
                            chamados[itemASerEditado] = chamado;

                            Console.WriteLine("Chamado editado!");
                            Console.ReadLine();
                        }
                    }

                    if (opcaoMenuChamados == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("Deletar um registro");
                        Console.WriteLine("--------------------------------------------------------------\n");
                        Console.WriteLine("Digite o ID do item a ser removido");
                        if (chamados.Count == 0)
                        {
                            Console.WriteLine("\nNão há chamados registrados!");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            foreach (string[] item in chamados)
                            {
                                Console.WriteLine("ID: " + item[4]);
                            }
                            int itemASerRemovido = Convert.ToInt32(Console.ReadLine());

                            int indiceDoId = 0;
                            foreach (string[] item in chamados)
                            {

                                if (itemASerRemovido == Convert.ToInt32(item[4]))
                                {
                                    chamados.RemoveAt(indiceDoId);
                                    break;
                                }
                                else
                                    indiceDoId++;

                            }

                            Console.WriteLine("Registro apagado!");
                            Console.ReadLine();
                        }
                    }

                    if (opcaoMenuChamados == "5")
                    {
                        opcaoPrimeiroMenu = "0";
                        menuInicial = true;
                    }
                }

                if (opcaoPrimeiroMenu == "1")
                {
                    break;
                }

            }
        }
    }
}
