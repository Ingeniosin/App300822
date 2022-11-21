namespace App300822.Algorithms; 

public static class AlgorithmManager {
    
    public static void Execute(List<Algorithm> algorithms) {
        Console.WriteLine("¡Bienvenido!");
        Console.WriteLine("¡Se cargaron {0} algoritmos correctamente!", algorithms.Count);
        Thread.Sleep(1500);
        Console.Clear();
        while(true) {
            Console.WriteLine("=============== Menu ===============");
            Console.WriteLine("Seleccione el algoritmo que desea ejecutar:");
            Console.WriteLine();
            for(var i = 1; i <= algorithms.Count; i++) {
                var algorithm = algorithms[i - 1];
                Console.WriteLine("{0}: {1}", i, algorithm.Name);
                Console.WriteLine("\t * {0}", algorithms[i - 1].Description);
            }
            Console.WriteLine($"{algorithms.Count + 1}. Salir.");
            Console.WriteLine();
            var number = InputUtils.GetNumber("Seleccione una opción: ", x => x > 0 && x <= algorithms.Count + 1);
            if(number == algorithms.Count + 1) {
                Console.WriteLine("Adios!");
                Thread.Sleep(800);
                Environment.Exit(0);
            } else {
                Console.Clear();
                algorithms[number - 1].Run();
                Console.Clear();
            }
        }
    }
}