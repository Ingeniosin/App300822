using System.Collections;

namespace App300822.Algorithms; 

public class One : Algorithm {

    public One() : base("Punto 1", "Realizar un programa que use ArrayList de números reales. El programa debe permitir mostrar un menú donde se pueda agregar un número, buscar un número, modificar un número, eliminar un número e insertar un número en una posición dadaf") {
    }

    protected override void Execute() {
        
        var numbers = new ArrayList();
        
        var whileLoop = true;
        while (whileLoop) {
            InputUtils.SelectFunction(new Dictionary<string, Action>
            {
                {
                    "Agregar un número", () => {
                        numbers.Add(InputUtils.GetNumber("Ingrese un número: "));
                    }
                },
                {
                    "Buscar un número", () => {
                        var number = InputUtils.GetNumber("Ingrese un número: ");
                        Console.WriteLine(numbers.Contains(number) ? "El número {0} se encuentra en la lista" : "El número {0} no se encuentra en la lista", number);
                    }
                },
                {
                    "Modificar un número", () => {
                        var number = InputUtils.GetNumber("Ingrese un número: ");
                        if (numbers.Contains(number)) {
                            var index = numbers.IndexOf(number);
                            numbers[index] = InputUtils.GetNumber("Ingrese el nuevo número");
                        } else {
                            Console.WriteLine("El número {0} no se encuentra en la lista", number);
                        }
                    }
                },
                {
                    "Eliminar un número", () => {
                        var number = InputUtils.GetNumber("Ingrese un número: ");
                        if (numbers.Contains(number)) {
                            numbers.Remove(number);
                        } else {
                            Console.WriteLine("El número {0} no se encuentra en la lista", number);
                        }
                    }
                },
                {
                    "Insertar un número en una posición dada", () => {
                        var number = InputUtils.GetNumber("Ingrese un número: ");
                        var index = InputUtils.GetNumber("Ingrese la posición: ", x => x >= 0 && x <= numbers.Count);
                        numbers.Insert(index, number);
                    }
                },
                {
                    "Salir", () => {
                        whileLoop = false;
                    }
                }
            
            });
        }
        
       
        
        
        
        
    }
}