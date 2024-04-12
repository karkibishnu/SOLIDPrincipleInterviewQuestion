namespace SOLIDPrincipleInterviewQuestion
{
    public class SpecialInterestCalculator : IInterestCalculator
    {
        public decimal CalculateInterest(BankAccount bankAccount)
        {
            //Special interest calculation logic
            return bankAccount.AccountBalance;
        }
    }
}
