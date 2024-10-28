namespace arayuzler2;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        Console.WriteLine("************INTERFACE*************");

        Focus focus = new Focus();
        Console.WriteLine(focus.HangiMarkanınAraci().ToString());
        Console.WriteLine(focus.KacTekerlektenOlusur());
        Console.WriteLine(focus.StandartRengiNe().ToString());

        Civic civic = new Civic();
        Console.WriteLine(civic.HangiMarkanınAraci().ToString());
        Console.WriteLine(civic.KacTekerlektenOlusur());
        Console.WriteLine(civic.StandartRengiNe().ToString());
        
        Console.WriteLine("************ABSTRACT*************");
        
        NewFocus newFocus = new NewFocus();
        Console.WriteLine(newFocus.HangiMarkanınAracı().ToString());
        Console.WriteLine(newFocus.KacTekerlektenOlusur());
        Console.WriteLine(newFocus.StandartRengiNe().ToString());

        NewCivic newCivic = new NewCivic();
        Console.WriteLine(newCivic.HangiMarkanınAracı().ToString());
        Console.WriteLine(newCivic.KacTekerlektenOlusur());
        Console.WriteLine(newCivic.StandartRengiNe().ToString());

    }
}
