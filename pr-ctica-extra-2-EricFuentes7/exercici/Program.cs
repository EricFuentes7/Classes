using System;
using System.Collections.Generic;
using System.IO;

namespace exercici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            Console.WriteLine("Introdueix la llista de regals que porta el Pare Noel, separats per comes:");
            string regalsInput = Console.ReadLine();

            // El HashSet fa que funcioni, no se perquè si no, no va
            var regalsPareNoel = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var regal in regalsInput.Split(','))
            {
                regalsPareNoel.Add(regal.Trim().ToLower());
            }

            Console.Write("Introdueix el camí de l'arxiu de peticions: ");
            string path = Console.ReadLine();

            if (!File.Exists(path))
            {
                Console.WriteLine("L'arxiu no existeix.");
                return;
            }

            string[] lineas = File.ReadAllLines(path);

            var persones = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

            foreach (var linea in lineas)
            {
                var partsLine = linea.Split(new[] { ": " }, StringSplitOptions.None);
                if (partsLine.Length == 2)
                {
                    string nomPersona = partsLine[0].Trim();
                    string[] regals = partsLine[1].Split(',');
                    var regalsLlista = new List<string>();
                    foreach (var regal in regals)
                    {
                        regalsLlista.Add(regal.Trim().ToLower());
                    }
                    persones[nomPersona] = regalsLlista;
                }
            }

            Console.WriteLine("Persones a les quals entregarà regals en aquest viatge:");
            bool haEntratAlguna = false;

            foreach (var persona in persones)
            {
                bool teTots = true;
                foreach (var regal in persona.Value)
                {
                    if (!regalsPareNoel.Contains(regal))
                    {
                        teTots = false;
                        break;
                    }
                }

                if (teTots)
                {
                    Console.WriteLine(persona.Key);
                    haEntratAlguna = true;
                }
            }

            if (!haEntratAlguna)
            {
                Console.WriteLine("Cap persona té tots els regals que porta el Pare Noel.");
            }
        }
    }
}