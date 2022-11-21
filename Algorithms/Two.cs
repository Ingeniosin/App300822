using System.Collections;

namespace App300822.Algorithms;

public class Two : Algorithm {

    public Two() : base("Punto 2", "Dados los siguientes datos de n personas: identificación, apellidos, nombres, sexo, edad y peso. Esta información se tiene que registrar en un ArrayList, buscar una persona dado el número de identificación, eliminar una persona, ordenar por apellidos y mostrar todas las personas. Hacer un menú para realizar lo que se pide.") {
    }

    protected override void Execute() {

        var people = new ArrayList();

        var whileLoop = true;
        while(whileLoop) {
            InputUtils.SelectFunction(new Dictionary<string, Action>{

                {"Agregar persona", () => people.Add(GetPerson())},
                {
                    "Ver personas", () => {
                        var index = 1;
                        foreach(var person in people) {
                            Console.WriteLine(index++ +". "+person);
                        }
                        InputUtils.PressToContinue();
                    }
                },
                { "Salir", () => whileLoop = false },
            });
        }


    }

    public Person GetPerson() {
        return new Person(
            InputUtils.GetText("Ingresa el numero de identificacion"),
            InputUtils.GetText("Ingresa el nombre"),
            InputUtils.GetText("Ingresa el apellido"),
            InputUtils.GetText("Ingresa el sexo"),
            InputUtils.GetNumber("Ingresa la edad", x => x > 0 && x < 100),
            InputUtils.GetDouble("Ingresa el peso", x => x > 0 && x < 200)
        );
    }
    
}

public class Person {
    public string Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }

    public Person(string id, string lastName, string firstName, string gender, int age, double weight) {
        Id = id;
        LastName = lastName;
        FirstName = firstName;
        Gender = gender;
        Age = age;
        Weight = weight;
    }

    public override string ToString() => $"Person=[Identificacion={Id}, Apellidos={LastName}, Nombres={FirstName}, Sexo={Gender}, Edad={Age}, Peso={Weight}]";

}