
//Oggi esercitazione veloce, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe, in particolare nel live-coding di oggi.
//In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe, 
//e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.

public class Address
{
    public string Name { get; }
    public string Surname { get; }
    public string Street { get; }
    public string City { get; }
    public string Province { get; }
    public string Zip { get; }

    public Address (string name, string surname,string street, string city, string province, string zip)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
    }

    public override string ToString()
    {
        string stringa = "------ Indirizzo ------\n";
        stringa += "Nome:\t" + this.Name + "\n";
        stringa += "Cognome:\t" + this.Surname + "\n";
        stringa += "Via:\t" + this.Street + "\n";
        stringa += "Città:\t" + this.City + "\n";
        stringa += "Provincia:\t" + this.Province + "\n";
        stringa += "ZIP:\t" + this.Zip + "\n";
        stringa += "-------------------";

        return stringa;
    }


}
