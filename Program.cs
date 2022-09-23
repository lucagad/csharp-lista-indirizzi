
//Oggi esercitazione veloce, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe, in particolare nel live-coding di oggi.
//In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe, 
//e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.

using System.Net;

List<Address> addressesList = new List<Address>();


// LETTURA CSV ES SALVATAGGIO NELLA LISTA

string path = "../../../addresses.csv";
StreamReader addressFile = File.OpenText(path);

addressFile.ReadLine();


while (!addressFile.EndOfStream)
{
    string row = addressFile.ReadLine();
    string[] split = row.Split(',');

    try
    {
        string name = split[0];
        string surname = split[1];
        string street = split[2];
        string city = split[3];
        string province = split[4];
        string zip = split[5];

        Address newAddress = new Address(name, surname, street, city, province, zip);

        addressesList.Add(newAddress);

        Console.WriteLine("Destinatario importato correttamente");

    }

    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Destinatario non valido -->" + row);
    }
  
}

addressFile.Close();


// CREAZIONE FILE
try
{
    StreamWriter addressOutputFile = File.CreateText("addressOutput.txt");


    foreach (Address address in addressesList)
    {
        Console.WriteLine("Salvataggio {0}", address.Name);
        addressOutputFile.WriteLine();
        addressOutputFile.WriteLine(address.ToString());
    }

    addressOutputFile.Close();

}
catch (Exception e)
{
    Console.WriteLine("Qualcosa è andato storto: {0}", e.Message);
}




Console.WriteLine(" --- ", addressesList);
