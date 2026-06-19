import java.util.*;

interface CustomerRepository {
    void findCustomerById(String Id);
}

class CustomerRepositoryImpl implements CustomerRepository{
    @Override
    public void findCustomerById(String Id){
        HashSet<String> set = new HashSet<>();
        set.add("32ABCK");
        set.add("4RTYGH");
        set.add("L23HJ8");
        if(set.contains(Id)) System.out.println("Found");
        else System.out.println("Not found");
    }

}
class CustomerService{
    private CustomerRepository Customer;
    public CustomerService(CustomerRepository Customer){
        this.Customer = Customer; 
    }
    public void check(String Id){
        Customer.findCustomerById(Id);
    }
}
public class DependencyInjectionExample {
    public static void main(String[] args) {
        CustomerRepository Customer = new CustomerRepositoryImpl();
        CustomerService service = new CustomerService(Customer); 
        service.check("32ABCK");
        service.check("GGGGGG"); 
    }
}
