namespace arayuzler2 {

    public class NewCivic : Otomobil
    {
        public override Marka HangiMarkanınAracı()
        {
            // throw new NotImplementedException();
            return Marka.Honda;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}