interface PaymentProcessor{
    void processPayment();
}

class paymentUPI implements PaymentProcessor{

    @Override
    public void processPayment(){
        System.out.println("Payment by UPI is successfull");
    }
}

class paymentCash implements PaymentProcessor{

    @Override
    public void processPayment(){
        System.out.println("Payment by cash is successfull");
    }
}

class UPIadapter extends paymentUPI{
    private paymentCash Cash;

    public UPIadapter(paymentCash cash) {
        this.Cash = cash;
    }

    @Override
    public void processPayment(){
        Cash.processPayment(); 
        System.out.println("Payment done by UPI");
    }
    
}

class Cashadapter extends paymentCash{
    private paymentUPI UPI;

    public Cashadapter(paymentUPI uPI) {
        this.UPI = uPI;
    }
    
    @Override
    public void processPayment(){
        UPI.processPayment(); 
        System.out.println("Payment done by cash");
    }
    
}

public class AdapterPatternExample {
    public static void main(String[] args) {
        PaymentProcessor user = new UPIadapter(new paymentCash());
        user.processPayment(); 

        PaymentProcessor user2 = new Cashadapter(new paymentUPI());
        user2.processPayment();
    }
    
}
