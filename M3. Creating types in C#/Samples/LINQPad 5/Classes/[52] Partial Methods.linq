<Query Kind="Program" />

// A partial type may contain partial methods. These let an auto-generated partial type
// provide customizable hooks for manual authoring.

partial class PaymentForm    // In auto-generated file
{	
	public PaymentForm (decimal amount)
	{
		ValidatePayment (amount);
		// ...
	}

	partial void ValidatePayment (decimal amount);
}

partial class PaymentForm    // In hand-authored file
{
	partial void ValidatePayment (decimal amount)
	{
		if (amount < 100) 
			throw new ArgumentOutOfRangeException ("amount", "Amount too low!");
	}
}

static void Main()
{
	var paymentForm = new PaymentForm (50);
}