namespace Laboratorio2;
class Program
{
    static void Main(string[] args)
    {
        string[] str = new string[3];
        int iStr;
        str[0] = "Um";
        str[1] = "Dois";
        str[2] = "Tres";
        for (iStr = 0; iStr < 3; iStr++)
        {
            Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
        }

        DateTime[] dt = new DateTime[2];
        int iDate = 0;
        dt[0] = new DateTime(2002, 5, 1);
        dt[1] = new DateTime(2002, 6, 1);
        foreach (DateTime data in dt)
        { 
            Console.WriteLine("Indice = " + iDate + " & Data = " + 
            data.ToShortDateString());
            iDate++;
        }

        //Exerc 1
        int[] array1 = new int[100];
        int[] array2 = new int[100];
        int valor = 10;

        for(int i = 0; i < array1.Length; i++){
            array1[i] = valor++;
        }
        Array.Copy(array1,array2,array1.Length);
        for(int i = 0; i < array2.Length; i++){
            Console.WriteLine(array2[i]);
        }

        int [] [] matrizm = new int [5][5];
        //int [][] matrizj = ;
    }
}
