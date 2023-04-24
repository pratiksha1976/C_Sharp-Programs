using System;

public class Exhibition : Event {
    private int _stallCount;

    public Exhibition(string name, string detail, string organizer, int stallCount) : base(name, detail, organizer) {
        _stallCount = stallCount;
    }

    public override void TotalCredit() {
        base.TotalCredit();
        int totalCredit = _stallCount * 50;
        Console.WriteLine("Total Credit Gained is {0}", totalCredit);
    }

    public override string ToString() {
        return String.Format("Event Name : {0}\nEvent Detail : {1}\nEvent Organizer : {2}\nStall Count : {3}", _name, _detail, _organizer, _stallCount);
    }
}
