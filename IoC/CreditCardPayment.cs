namespace IoC;

//Class to send requests to the bank
//Class to logn transaction in the databbase
//Class to send SMS
//Class to send Mail
public class CreditCardPayment
{
    private readonly IMailService _mailService;

    public CreditCardPayment(IMailService mailService)
    {
        _mailService = mailService;
    }
    public void PayAmount(double amount, string card, string cvv)
    {
        _mailService.Send();
    }
}

public interface IMailService
{
    void Send();
}

public class MailService : IMailService
{
    public void Send()
    {
        throw new NotImplementedException();
    }
}