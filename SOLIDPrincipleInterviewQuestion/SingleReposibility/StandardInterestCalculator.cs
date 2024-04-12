namespace SOLIDPrincipleInterviewQuestion
{
    public class StandardInterestCalculator : IInterestCalculator
    {
        public decimal CalculateInterest(BankAccount bankAccount)
        {
            //Standard interest calculation logic
            return bankAccount.AccountBalance;
        }
    }
}
