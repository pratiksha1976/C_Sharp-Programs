using System;

public class StageEvent : Event {
    private int _totalShow;
    private int _seatsPerShow;

    public StageEvent(string name, string detail, string organizer, int totalShow, int seatsPerShow) : base(name, detail, organizer) {
        _totalShow = totalShow;
        _seatsPerShow = seatsPerShow;
    }

    public override void TotalCredit() {
        base.TotalCredit();
        int totalCredit = _totalShow * _seatsPerShow * 100;
        Console.WriteLine("Total Credit Gained is {0}", totalCredit);
    }

    public override string ToString() {
        return String.Format("Event Name : {0}\nEvent Detail : {1}\nEvent Organizeer : {2}\nTotal Events : {3}\nTotal Seats : {4}", _name, _detail, _organizer, _totalShow, _seatsPerShow);
    }
}
