namespace _02.KurtovoKonareBank
{
    public interface IAccount
    {
        decimal CalculateInterestInMonths(int months);
        void MakeDeposit(decimal deposit);
    }
}
