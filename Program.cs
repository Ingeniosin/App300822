
using App300822.Algorithms;

namespace App300822; 

public class Program {
    public static void Main(string[] args) {

        AlgorithmManager.Execute(new List<Algorithm>{
            new One(),
            new Two()
        });
    }
}