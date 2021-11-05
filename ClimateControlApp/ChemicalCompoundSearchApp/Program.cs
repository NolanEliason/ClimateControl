using ChemicalCompoundLibray.Models;
using System;

namespace ChemicalCompoundSearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the Chemical Compound Data search");

            MainMenu();


            Console.ReadLine();
        }

        private static ChemicalCompoundModel AddNewChemical(string chemicalName) 
        {
            ChemicalCompoundModel output = new ChemicalCompoundModel();
            output.ChemicalName = chemicalName;


            Console.WriteLine($"What is the molecular formula of {chemicalName}?: ");
            output.MolecularFormula = Console.ReadLine();

            Console.WriteLine($"What is the Molecular Weight {chemicalName} in (g/mol)?: ");
            output.MolecularWeight = float.Parse(Console.ReadLine());

            Console.WriteLine($"What is the Melting Point of {chemicalName} in (K)?: ");
            output.MeltingPoint = float.Parse(Console.ReadLine());

            Console.WriteLine($"What is the Reference Temperature for normal boiling point in (K)?: ");
            output.ReferenceTemp = float.Parse(Console.ReadLine());

            Console.WriteLine($"What is the Reference Pressure for normal boiling point in (Mpa): ");
            output.ReferencePressure = float.Parse(Console.ReadLine());

            Console.WriteLine($"What is the normal boiling point of {chemicalName} in (K)?: ");
            output.NormalBoilingPoint = float.Parse(Console.ReadLine());

            Console.WriteLine($"What is the normal vapor density of {chemicalName} in (kg/m^3)?: ");
            output.NormalVaporDensity = float.Parse(Console.ReadLine());

            Console.WriteLine($"What is the Critical temperature of {chemicalName} in (K)?: ");
            output.CriticalTemperature = float.Parse(Console.ReadLine());

            Console.WriteLine($"What is the Critical Pressure of {chemicalName} in (MPa)?: ");
            output.CriticalPressure = float.Parse(Console.ReadLine());

            Console.WriteLine($"What is the Critical Desnisty of {chemicalName} in (kg/m^3)?: ");
            output.CriticalDensity = float.Parse(Console.ReadLine());

            return output;
        }

        private static string MainMenu() {
            string output = "";

            int menuSelection;

            Console.WriteLine("What would you like to do? (Type number to select option): ");
            Console.WriteLine("[1] View the current list of Chemical Compounds");
            Console.WriteLine("[2] Add a new Compound");
            Console.WriteLine("[3] Update an exisiting compound");
            Console.WriteLine("[4] Remove a compound from list");
            menuSelection = int.Parse(Console.ReadLine());

            switch (menuSelection)
            {

                case 1:
                    output = "view";
                    break;
                case 2:
                    output = "add";
                    break;
                case 3:
                    output = "update";
                    break;
                case 4:
                    output = "delete";
                    break;
                default:
                    break;
            }

            return output;

        }
    }
}
