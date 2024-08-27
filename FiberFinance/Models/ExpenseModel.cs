namespace FiberFinance.Models
{
    public class ExpenseModel
    {

        public int ExpenseId { get; set; }
        public string Descripition { get; set; }
        public float Value { get; set; }
        DateTime Date { get; set; }

        public ExpenseModel(int expenseId, string descripition, float value, DateTime date)
        {
            ExpenseId = expenseId;
            Descripition = descripition;
            Value = value;
            Date = date;
        }
    public void AddExpense() { }
    public void RemoveExpense() { }
    public void UpdateExpense() { }
     public void ListExpenses() { }
    public void FindExpense() { }
    }



}
